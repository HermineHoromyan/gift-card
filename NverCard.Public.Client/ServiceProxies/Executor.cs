using Grpc.Core;
using System.Text.Json;
using System.Threading.Tasks;

namespace NverCard.Public.Client.ServiceProxies
{
    public class Executor
    {
        private readonly Public.Executor.ExecutorClient executorClient;
        private readonly UserSession userSession;

        internal Executor(Public.Executor.ExecutorClient executorClient, UserSession userSession)
        {
            this.executorClient = executorClient;
            this.userSession = userSession;
        }

        internal async Task<TResult> Execute<TResult>(ExecuteInput input)
        {
            Metadata headers = new Metadata();

            // проверяем чтобы сессия была загружена
            await userSession.EnsureLoaded();

            if (userSession.Token != null)
                headers.Add("Authorization", $"Bearer {userSession.Token}");
            else
            {
                if (userSession.AnonymousUserId != null)
                    headers.Add("AnonymousUserId", userSession.AnonymousUserId.ToString());
            }
            var executionResult = await executorClient.ExecuteAsync(input, headers);

            return JsonSerializer.Deserialize<TResult>(executionResult.Result);
        }

        internal async Task Execute(ExecuteInput input)
        {
            var headers = new Metadata();

            // проверяем чтобы сессия была загружена
            await userSession.EnsureLoaded();

            if (userSession.Token != null)
                headers.Add("Authorization", $"Bearer {userSession.Token}");
            else if (userSession.AnonymousUserId != null)
                headers.Add("AnonymousUserId", userSession.AnonymousUserId.ToString());

            await executorClient.ExecuteAsync(input, headers);
        }
    }
}