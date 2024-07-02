using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace NverCard.Public.Client
{
    /// <summary>
    /// Сессия пользователя
    /// </summary>
    public class UserSession : AuthenticationStateProvider
    {
        #region Consts

        private const string NameKey = "nc.customer.name";
        private const string UserIdKey = "nc.customer.id";
        private const string TokenKey = "nc.customer.token";
        private const string SessionStartedKey = "nc.customer.issessionstarted";
        private const string AnonymousUserIdKey = "nc.customer.anonymoususerid";

        #endregion Consts

        #region Fields

        private readonly ILocalStorageService localStorage;
        public event Action OnChange;
        private readonly Task loadTask;

        // private readonly IAppUserInfoSetter appUserInfoSetter;
        // private readonly Cookies cookies;

        #endregion Fields

        #region Constructor

        public UserSession(ILocalStorageService localStorage)
        {
            this.localStorage = localStorage;
            loadTask = LoadSession();
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Имя пользователя
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Id
        /// </summary>
        public Guid? UserId { get; private set; }

        /// <summary>
        /// Токен
        /// </summary>
        public string Token { get; private set; }

        /// <summary>
        /// Сессия начата?
        /// </summary>
        public bool IsSessionStarted { get; private set; }

        /// <summary>
        /// Сессия загружена
        /// </summary>
        public bool IsSessionLoaded { get; set; }

        /// <summary>
        /// Id анонимного пользователя
        /// </summary>
        public Guid? AnonymousUserId { get; set; }


        #endregion Properties

        #region Methods

        #region Private methods

        private void SetUserInfo()
        {
            // if (Token != null)
            // {
            //     var tokenValidationParameters = new TokenValidationParameters
            //     {
            //         ValidateIssuer = true, // указывает, будет ли валидироваться издатель при валидации токена
            //         ValidIssuer = AdminAuthOptions.Issuer, // строка, представляющая издателя
            //
            //         ValidateAudience = false, // будет ли валидироваться потребитель токена
            //         ValidAudience = AdminAuthOptions.Audience,// установка потребителя токена
            //
            //         ValidateLifetime = false,  // будет ли валидироваться время существования
            //
            //         IssuerSigningKey = AdminAuthOptions.GetSymmetricSecurityKey(), // установка ключа безопасности
            //         ValidateIssuerSigningKey = true // валидация ключа безопасности
            //     };
            //
            //     JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            //     var user = handler.ValidateToken(Token, tokenValidationParameters, out SecurityToken validatedToken);
            //
            //     appUserInfoSetter.UserName = user.Identity.Name;
            //     appUserInfoSetter.UserType = UserType.Authenticated;
            //     appUserInfoSetter.UserRole = UserRole.Admin;
            //     string userTokenIdStr = user.Claims.SingleOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
            //     if (!string.IsNullOrWhiteSpace(userTokenIdStr))
            //         appUserInfoSetter.UserTokenId = Guid.Parse(userTokenIdStr);
            // }
            // else
            // {
            //     appUserInfoSetter.UserName = null;
            //     appUserInfoSetter.UserType = UserType.Anonymous;
            //     appUserInfoSetter.UserTokenId = Guid.Empty;
            // }
        }

        #endregion Private methods

        #region Public methods

        /// <summary>
        /// Если сессия находится в загрузке то ждет до завершения загрузки
        /// </summary>
        public async Task EnsureLoaded()
        {
            if (!IsSessionLoaded && !loadTask.IsCompleted)
                await loadTask;
        }

        /// <summary>
        /// Устанавоивает значение Id не авторизованного пользователя
        /// </summary>
        /// <param name="anonymousUserId">Id не авторизованного пользователя</param>
        public async Task SetUserId(Guid anonymousUserId)
        {
            await localStorage.SetItemAsync(AnonymousUserIdKey, anonymousUserId);

            AnonymousUserId = anonymousUserId;
        }

        /// <summary>
        /// Загружает сессию пользователя
        /// </summary>
        public async Task LoadSession()
        {
            Name = await localStorage.GetItemAsync<string>(NameKey);
            Token = await localStorage.GetItemAsync<string>(TokenKey);
            IsSessionStarted = await localStorage.GetItemAsync<bool>(SessionStartedKey);
            AnonymousUserId = await localStorage.GetItemAsync<Guid?>(AnonymousUserIdKey);
            UserId = await localStorage.GetItemAsync<Guid>(UserIdKey);

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
            IsSessionLoaded = true;

            //await cookies.SetCookies(AdminTokenValidator.TokenCookiesKey, Token);

            SetUserInfo();
        }

        /// <summary>
        /// Начинает сессию пользователя
        /// </summary>
        /// <param name="name">имя пользователя</param>
        /// <param name="token">токен пользователя</param>
        public async Task StartSession(string name, string token, Guid userId)
        {
            await localStorage.SetItemAsync(NameKey, name);
            await localStorage.SetItemAsync(TokenKey, token);
            await localStorage.SetItemAsync(SessionStartedKey, true);
            await localStorage.SetItemAsync(AnonymousUserIdKey, Guid.Empty);
            await localStorage.SetItemAsync(UserIdKey, userId);

            Name = name;
            Token = token;
            IsSessionStarted = true;
            AnonymousUserId = null;
            UserId = userId;

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());

            //await cookies.SetCookies(AdminTokenValidator.TokenCookiesKey, Token);

            SetUserInfo();
        }

        /// <summary>
        /// Завершает сессию пользователя
        /// </summary>
        public async Task FinishSession()
        {
            await localStorage.RemoveItemAsync(NameKey);
            await localStorage.RemoveItemAsync(TokenKey);
            await localStorage.RemoveItemAsync(UserIdKey);
            await localStorage.SetItemAsync(SessionStartedKey, false);
            await localStorage.SetItemAsync(AnonymousUserIdKey, Guid.NewGuid());

            Name = null;
            Token = null;
            IsSessionStarted = false;
            AnonymousUserId = null;
            UserId = null;

            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());

            //await cookies.RemoveCookies(AdminTokenValidator.TokenCookiesKey);

            SetUserInfo();
            OnChange?.Invoke();
        }

        #endregion Public methods

        #endregion Methods

        #region AuthenticationStateProvider

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            if (!IsSessionLoaded)
                await LoadSession();

            if (!IsSessionStarted)
            {
                ClaimsIdentity anonymous = new ClaimsIdentity();
                return new AuthenticationState(new ClaimsPrincipal(anonymous));
            }

            ClaimsIdentity identity = new ClaimsIdentity("Authorize");
            identity.AddClaim(new Claim(ClaimTypes.Name, Name));
            return new AuthenticationState(new ClaimsPrincipal(identity));
        }

        #endregion AuthenticationStateProvider
    }
}