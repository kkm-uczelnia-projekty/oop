namespace ConsoleApp.Logger
{
    public class FileLogger : WriterLogger
    {
        public FileLogger(string filename)
        {
            this.writer = GetWriter(filename);
        }

        override public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        private TextWriter GetWriter(string path)
        {
            var fileExists = File.Exists(path);
            if (!fileExists)
            {
                return File.CreateText(path);
            }

            return File.AppendText(path);
        }
    }
}
