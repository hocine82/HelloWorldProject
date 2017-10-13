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

    public abstract class IWrite
    {
        public virtual bool Output() { return true; }
    }

    public class WriteToConsole : IWrite
    {
        public override bool Output() 
        {
            Console.WriteLine("Hellow world");
            Console.Read();
            return true;
        }
    }

    public class WriteToDatabase : IWrite
    {
        public override bool Output()
        {
            Console.WriteLine("You have chosen to write to database");
            Console.Read();
            return true;
        }       
    }














}
