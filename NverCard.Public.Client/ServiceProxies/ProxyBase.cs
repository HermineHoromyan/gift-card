using System.Text.Json;
using System.Threading.Tasks;

namespace NverCard.Public.Client.ServiceProxies
{
    /// <summary>
    /// Базовый класс для проксиков команд и запросов с входящей информацией и возвращаемым значением
    /// </summary>
    public abstract class ProxyBase<TInput, TResult>
    {
        #region Fields

        private readonly Executor executor;

        #endregion Fields

        #region Constructor

        protected ProxyBase(Executor executor)
        {
            this.executor = executor;
        }

        #endregion Constructor

        /// <summary>
        /// Исполняет команду/запрос
        /// </summary>
        /// <param name="input">Входные данные команды/запроса</param>
        /// <returns>Возвращаемый результат команды/запроса</returns>
        public Task<TResult> Execute(TInput input)
        {
            ExecuteInput executeInput = new ExecuteInput
            {
                CommandOrQueryName = GetType().Name.Replace("Proxy", string.Empty),
                Input = JsonSerializer.Serialize(input)
            };
            return executor.Execute<TResult>(executeInput);
        }
    }

    /// <summary>
    /// Базовый класс для проксиков команд и запросов без входящей информации
    /// </summary>
    public abstract class ProxyBaseNoInput<TResult>
    {
        #region Fields

        private readonly Executor executor;

        #endregion Fields

        #region Constructor

        protected ProxyBaseNoInput(Executor executor)
        {
            this.executor = executor;
        }

        #endregion Constructor

        /// <summary>
        /// Исполняет команду/запрос
        /// </summary>
        /// <returns>Возвращаемый результат команды/запроса</returns>
        public Task<TResult> Execute()
        {
            ExecuteInput executeInput = new ExecuteInput
            {
                CommandOrQueryName = GetType().Name.Replace("Proxy", string.Empty)
            };
            return executor.Execute<TResult>(executeInput);
        }
    }

    /// <summary>
    /// Базовый класс для проксиков команд и запросов без возвращаемого значения
    /// </summary>
    public abstract class ProxyBaseNoResult<TInput>
    {
        #region Fields

        private readonly Executor executor;

        #endregion Fields

        #region Constructor

        protected ProxyBaseNoResult(Executor executor)
        {
            this.executor = executor;
        }

        #endregion Constructor

        /// <summary>
        /// Исполняет команду/запрос
        /// </summary>
        /// <param name="input">Входные данные команды/запроса</param>
        public Task Execute(TInput input)
        {
            ExecuteInput executeInput = new ExecuteInput
            {
                CommandOrQueryName = GetType().Name.Replace("Proxy", string.Empty),
                Input = JsonSerializer.Serialize(input)
            };
            return executor.Execute(executeInput);
        }
    }

    /// <summary>
    /// Базовый класс для проксиков команд и запросов без входящей информации и возвращаемого значения
    /// </summary>
    public abstract class ProxyBaseNoInputNoResult
    {
        #region Fields

        private readonly Executor executor;

        #endregion Fields

        #region Constructor

        protected ProxyBaseNoInputNoResult(Executor executor)
        {
            this.executor = executor;
        }

        #endregion Constructor

        /// <summary>
        /// Исполняет команду/запрос
        /// </summary>
        public Task Execute()
        {
            ExecuteInput executeInput = new ExecuteInput
            {
                CommandOrQueryName = GetType().Name.Replace("Proxy", string.Empty)
            };
            return executor.Execute(executeInput);
        }
    }
}