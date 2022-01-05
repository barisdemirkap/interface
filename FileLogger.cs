using System;

namespace _interface
{
    public class FileLogger : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Dosyaya log yazar");
        }
    }
}