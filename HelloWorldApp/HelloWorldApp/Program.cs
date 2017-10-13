using Microsoft.Practices.Unity;
using System;


namespace HelloWorldApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnityContainer container = new UnityContainer();
            container.RegisterType<LogData>();
            container.RegisterType<IWrite, WriteToDatabase>();
            container.RegisterType<IWrite, WriteToConsole>();
            LogData ld = container.Resolve<LogData>();
            ld.insert();
        }
    }

    public class LogData
    {
        private IWrite log;
        public LogData(IWrite write)
        {
            log = write;
        }
        public bool insert()
        {          
            return log.Output();
        }
    }

    public interface IWrite
    {
        bool Output();
    }

    public class WriteToConsole : IWrite
    {
        public bool Output()
        {
            Console.WriteLine("You have chosen to write to console");
            Console.Read();
            return true;
        }
    }

    public class WriteToDatabase : IWrite
    {
        public bool Output()
        {
            Console.WriteLine("You have chosen to write to database");
            Console.Read();
            return true;
        }
    }














}
