using Classes;
using System.Net.WebSockets;
using System.Runtime;
using System.Runtime.CompilerServices;

internal class Program
{
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Uptate();

            Customer customer=new Customer();
        customer.City = "Ankara";
        customer.Id = 1;
        customer.FirstName = "Zahid";
        customer.LastName = "Büyükzengin";


        Customer customer2 =new Customer
        {
            //üstteki ile farkı yok daha kısa hali
            Id = 2,City ="konya", LastName="Kızkaban",FirstName="Ahmet"
        };
        Console.WriteLine(customer2.FirstName);

        Console.ReadLine();
    }    
}

    //clasıma ekleme için add,güncellemek için updated içine yazdık
    class ProductManager
    {
        public void Add()
        {
            Console.WriteLine("Product Added!");

        }
        public void Uptate()
        {
            Console.WriteLine("Product Updated!");
        }

    }

//solutiondan classes üstüne sağtık add>class klasımızın adını yazıp clasımızı taşıyabilriiz

    class CustomerManager
    {
        public void Add()
        {
            Console.WriteLine("Customer Added");
        }

        public void update()
        {
            Console.WriteLine("customer Updated");
        }

    }


