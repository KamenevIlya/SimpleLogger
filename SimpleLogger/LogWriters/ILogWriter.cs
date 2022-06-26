namespace SimpleLogger.LogWriters
{
    /// <summary>
    /// Записывание логов.
    /// </summary>
    public interface ILogWriter
    {
        /// <summary>
        /// Записать лог.
        /// </summary>
        /// <param name="message"> Сообщение. </param>
        void WriteLog(string message);
    }
}
