using System.Globalization;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //eğer parantez içine bir sayı girmezsek ve consturteri yoruma alırsak 15i döndürür
            CustomerManager customerManager = new CustomerManager(23);
            customerManager.List();

            Product product = new Product { ıd = 1, name = "LAPTOP" };
            Product product1 = new Product (2,"Computer");
            Console.ReadLine();
        }
    }
    class CustomerManager
    {
        private int _count = 15;

        //ctor +tab yaparak bir constructer ifade oluşturabiliyoruz
    
        //burayı yoruma almamız lazım eğeri 15i yazdırmak istiyorsak
        //eğer 23ü yazdıracaksak 15i yoruma almaya gerek yok direkt parantez içine istediğini girebilirsin
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void List()
        {
            Console.WriteLine("Listed {0} items", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!");
        }

    }
    class Product
    {
        public Product()
        {
            
        }
        private int _id;
        private string _name;
        public Product(int id,string name)
        {
            _id = id;
            _name = name;   
        }
        public int ıd { get; set; }
        public string name { get; set; }
    }


}
