using SimpleLogger.Db;
using SimpleLogger.Logger;
using SimpleLogger.LogWriters;

namespace SimpleLogger.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestConsoleLogger();
            TestFileLogger();
            TestDbLogger();
        }

        private static void TestConsoleLogger()
        {
            var consoleLogWriter = new ConsoleLogWriter(new DebugLogger());
            consoleLogWriter.WriteLog("Hi, there!");
        }

        private static void TestFileLogger()
        {
            var fileLogWriter = new FileLogWriter("errors.txt" ,new ErrorLogger());
            fileLogWriter.WriteLog("Here is error!");
        }

        private static void TestDbLogger()
        {
            var dbLogWriter = new DbLogWriter(new LoggerDataProvider(new DataContext()), new WarnLogger());
            dbLogWriter.WriteLog("Here is warn!");
        }
    }
}