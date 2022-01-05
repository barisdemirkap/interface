using System;

namespace _interface
{
    public class DataBase : ILogger
    {
        public void WriteLog()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Database'e log yazar");
        }
    }
}