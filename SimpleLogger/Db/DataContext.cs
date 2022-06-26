using Microsoft.EntityFrameworkCore;
using SimpleLogger.Models;

namespace SimpleLogger.Db
{
    /// <summary>
    /// Контекст бд.
    /// </summary>
    public class DataContext : DbContext
    {
        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public DataContext()
        {
        }

        /// <summary>
        /// Конструктор с конфигурацией.
        /// </summary>
        /// <param name="options"> Конфигурация. </param>
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source=(localdb)\\MSSQLLocalDB; Initial Catalog=Logs; Integrated Security=True;");
            }
        }

        /// <summary>
        /// Логи в бд.
        /// </summary>
        public DbSet<Log>Logs { get; set; } = null!;
    }
}
