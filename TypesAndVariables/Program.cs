using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
   class Program
    {
        static void Main(string[] args)
        {
            //ondalık sayılar virgülden itibaren 10 sayı kapasite
            double number5 = 10.4;
            //double nin 2  katı özelliğinde sonuna m harfi koymazsak olmaz
            decimal number6 = 10.4m;
            
            char character ='A';

          //bool true false
          bool condition=false;

            byte number4 = 255;
            short number3 = 32767;
            int number1 = 1234567891;
            //19 tane sayı kapasitesi
            long number2 = 1111111111111111111;
            //var karşısındakinin int mı string mi olduğunuu bilir
            var number7 = "A";
            var number8 = 31;

            Console.WriteLine("number1 is {0}",number1);
            Console.WriteLine("number2 is {0}", number2);
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine("number4 is {0}", number4);
            Console.WriteLine("number5 is {0}", number5);
            Console.WriteLine("character is : {0}",character);
            Console.WriteLine("number 7 is :{0}",number7);
            Console.WriteLine(days.friday);
            Console.WriteLine((int)days.sunday);
            Console.WriteLine("number8 is : {0}",number8);
            Console.ReadLine();
        }
    //enum dışarıda tanımlanır içerde kullanılır bir nevi fonksyiona benziyor,if koşullarında faydası olabilir
        enum days
        {
            monday,tuesday,wednesday,thursday,friday,saturday,sunday
        }
    }
}
