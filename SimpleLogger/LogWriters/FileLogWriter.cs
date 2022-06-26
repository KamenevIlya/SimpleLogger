using SimpleLogger.Logger;

namespace SimpleLogger.LogWriters
{
    /// <summary>
    /// Логирование в файл.
    /// </summary>
    public class FileLogWriter : BaseLogWriter, ILogWriter
    {
        private readonly string _fileName;

        /// <summary>
        /// Конструктор с параметрами.
        /// </summary>
        /// <param name="fileName"> Имя файла. </param>
        /// <param name="logger"> Логировщик. </param>
        public FileLogWriter(string fileName, ILogger logger) : base(logger)
        {
            _fileName = fileName;
        }

        /// <summary>
        /// Записать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        public override void WriteLog(string message)
        {
            if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
            }

            var lastRecord = File.ReadLines(_fileName).Last();
            var lastRecordNum = lastRecord?.Split('\t')[0];
            var lastNum = 1;
            if (int.TryParse(lastRecordNum?[1..], out var result))
            {
                lastNum += result;
            }
            var log = Logger.MakeLog(message);
            var record = $"#{lastNum}\t{log.CreatedAt}\t{log.Message}\t{log.LogType}";

            using var streamWriter = new StreamWriter(_fileName, true);
            streamWriter.WriteLine(record);
        }
    }
}
