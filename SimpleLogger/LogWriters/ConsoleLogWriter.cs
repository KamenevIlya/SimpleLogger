using SimpleLogger.Logger;

namespace SimpleLogger.LogWriters
{
    /// <summary>
    /// Логирование в консоль.
    /// </summary>
    public class ConsoleLogWriter : BaseLogWriter, ILogWriter
    {
        /// <summary>
        /// Конструктор с параметром.
        /// </summary>
        /// <param name="logger"> Логировщик. </param>
        public ConsoleLogWriter(ILogger logger) : base(logger)
        {
        }

        /// <summary>
        /// Записать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        public override void WriteLog(string message)
        {
            var log = Logger.MakeLog(message);
            Console.WriteLine($"{log.CreatedAt}\t{log.Message}\t{log.LogType}");
        }
    }
}
