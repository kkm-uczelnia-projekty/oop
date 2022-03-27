namespace ConsoleApp.Logger
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            foreach (string message in messages)
            {
                writer.WriteLine(message);
            }
        }

        public abstract void Dispose();
    }
}
