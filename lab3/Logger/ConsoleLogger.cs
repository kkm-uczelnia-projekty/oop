namespace ConsoleApp.Logger
{
    public class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            this.writer = Console.Out;
        }

        override public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
