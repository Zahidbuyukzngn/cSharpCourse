namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()

            };

            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[2]
            {
                new Worker(),
                new Manager(),
            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }
            ISalary[] salary = new ISalary[2]
            {
                new Manager(),
                new Worker(),
            };
            foreach (var salary1 in salary)
            {
                salary1.GetSalary();

            }
         
        }
    }

    interface IWorker
    {
        void Work();
    }
    //SOLID,Interface segregation
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
    void GetSalary();
    }

    class Manager : IWorker,IEat, ISalary
    {
        public void GetSalary()
        {
           
        }

        public void Eat()
        {
          
        }

        public void Work()
        {
          
        }
    }
    //ınterface yi bu şekilde yazdıktan sonra ı eat ı salary ıworkerın altı kırmızı olur 
    //üstüne gelip implement interface diyerek public void şeklinde otomatik tanınlar
    class Worker : IEat, ISalary, IWorker
    {
        public void GetSalary()
        {
            
        }

        public void Eat()
        {
            
        }

        public void Work()
        {
           
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
           
        }
    }
}
