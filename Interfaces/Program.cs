using System.Runtime.CompilerServices;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // IntarfacesIntro();
            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlServerCustomerDal()
            };
            
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
            Console.ReadKey();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new OracleCustomerDal());
        }


        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "ahmet",
                LastName = "kızkaban",
                Adress = "Trabzon",
            };
            Student student = new Student
            {
                Id = 2,
                FirstName = "Zahid",
                LastName = "Büyükzengin",
                Departmant = "Computer Sciences",

            };
            //çıktı alabilmek için yazıyoruz
            manager.Add(customer);
            manager.Add(student);
        }

        interface IPerson
        {
             int Id { get; set; }
             string FirstName { get; set; }
             string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }

        class Student :IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }
        }
        class PersonManager
        {
            public void Add(IPerson person)
            {
                //çıktısını almak istediğimiz nesneyi yazarak onun çıktısını alabilriz.firsstname yazdığımız içn first name çıktı olur
                Console.WriteLine(person.FirstName);
                
            }
        }
    }
}
