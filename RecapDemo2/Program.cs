namespace RecapDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        CustomerManager customerManager = new CustomerManager();
        
            //neyi loglamak istiyorsak onu smslogger yerine yazmamız gerekiyor
        customerManager.Logger =new SmsLogger();
        customerManager.Add();
        Console.ReadLine();
        }
        class CustomerManager
        {
            public ILogger Logger { get; set; }
            public void Add()
            {
                Logger.Log();
                Console.WriteLine("Customer added!");
            }
        }

        class DatabaseLogger:ILogger
        {
            public  void Log()
            {
                Console.WriteLine("logged to Database!");
            }

        }  
        class FileLogger:ILogger
        {
            public  void Log()
            {
                Console.WriteLine("logged to File!");
            }

        }
        class SmsLogger :ILogger
        {
            public void Log()
            {
                Console.WriteLine("logged to sms!");
            }
        }








        interface ILogger
        {
            void Log();
        }
    }
}
