namespace ConsoleApp.Logger
{
    public class CommonLogger : WriterLogger
    {
        private readonly ILogger[] loggers;

        public CommonLogger(ILogger[] loggers)
        {
            this.loggers = loggers;
        }

        override public void Log(params string[] messages)
        {
            foreach (ILogger logger in loggers)
            {
                logger.Log(messages);
            }
        }

        override public void Dispose()
        {
            foreach (ILogger logger in loggers)
            {
                logger.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}
