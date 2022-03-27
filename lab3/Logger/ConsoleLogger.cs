namespace ConsoleApp.Logger
{
    public class ConsoleLogger : WriterLogger
    {
        public ConsoleLogger()
        {
            this.writer = Console.Out;
        }
    }
}
