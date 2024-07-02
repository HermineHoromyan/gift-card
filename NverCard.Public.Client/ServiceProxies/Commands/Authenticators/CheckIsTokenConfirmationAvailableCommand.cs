//Proxy

using System;

namespace NverCard.Public.Client.ServiceProxies.Commands.Authenticators
{
    /// <summary>
    /// Проверяет доступен ли повторный запрос на получение токена
    /// </summary>
    public partial class CheckIsTokenConfirmationAvailableCommand : ProxyBase<Guid, Guid>
    {
        public CheckIsTokenConfirmationAvailableCommand(Executor executor) : base(executor)
        {
        }
    }
}
