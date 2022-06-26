namespace SimpleLogger.Models
{
    /// <summary>
    /// Лог.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Дата и время создания лога.
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Сообщение.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Тип лога.
        /// </summary>
        public LogType LogType { get; set; }
    }
}
