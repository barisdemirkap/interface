using System;

namespace _interface
{
    class program
    {
        static void Main(string[] args)
        {
            FileLogger filelogger = new FileLogger () ;
            filelogger.WriteLog ();

            DataBase database = new DataBase () ;
            database.WriteLog() ;

            SmsLogger smsLogger = new SmsLogger ();
            smsLogger.WriteLog() ;

            LogManager logmanager = new LogManager (new FileLogger ()) ;
            logmanager.WriteLog();



        }
    }
}