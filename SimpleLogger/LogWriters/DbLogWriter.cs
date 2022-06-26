using SimpleLogger.Db;
using SimpleLogger.Logger;

namespace SimpleLogger.LogWriters
{
    /// <summary>
    /// Логирование в бд.
    /// </summary>
    public class DbLogWriter : BaseLogWriter, ILogWriter
    {
        private readonly LoggerDataProvider _dataProvider;

        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="logger"> Логировщик. </param>
        public DbLogWriter(LoggerDataProvider dataProvider, ILogger logger) : base(logger)
        {
            _dataProvider = dataProvider;
        }

        /// <summary>
        /// Записать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        public override void WriteLog(string message)
        {
            var log = Logger.MakeLog(message);
            log.Id = Guid.NewGuid();
            _dataProvider.WriteLog(log.Message, log.LogType);
        }

    }
}
