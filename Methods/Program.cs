using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

//fonksiyonlar,metotlar
namespace Methods
{
    public class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(add4(1, 2, 3));

           
        }

        //params ve Sum ile yukarda yazdığımız tüm sayıları toplatabiliriz
        static int add4(params int[] numbers)
        {
            return numbers.Sum();
        }



    }




}
