

//loops döngüler
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {

        ////WHİLE
        ////100den 0 a kadar yazdırdık
        //int Number=100;
        //while(Number>0)
        //{
        //    Console.WriteLine(Number);
        //    Number--;

        //}
        //Console.WriteLine("now number is {0}",Number);

        ////DO WHİLE

        //int number1 = 10;
        //do 
        //{   
        //    Console.WriteLine(number1);
        //    number1--;
        //}

        //while (number1 >= 0);
        //{ Console.WriteLine("finish"); }

        //Console.ReadLine();


        //    //FOREACH   
        //    string[] students = new string[3]
        //    {
        //        "engin","derin","veli"
        //    };
        //    foreach (var student in students)
        //    {
        //        Console.WriteLine(student);
        //    }
        //Console.ReadLine();


        //ASAL SAYIMI UYGULAMASI
      
        //asal sayımı demek ısprimenumber
       
        //asal olup olmadığını sormak için parantez içine istediğimiz numarayı yazıyoruz
        if(IsPrimeNumber(7))
        {
            Console.WriteLine("this is a prime number");
        }
        else
        {
            Console.WriteLine("this is not a prime number");
        }
        
        Console.ReadLine();
    
    
    }

    static bool IsPrimeNumber(int number)
    {
        bool result = true;
        for (int i = 2; i < number - 1; i++)
        {
            if (number % i == 0)
            {
                result = false;
                i = number;
            }

        }
        return result;
    }



}