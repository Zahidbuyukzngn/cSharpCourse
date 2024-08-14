using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var sayi = 20;

            //    if (sayi == 11)
            //    {
            //        Console.WriteLine("sayi is 11");
            //    }
            //    else if (sayi == 10)
            //    {
            //        Console.WriteLine("sayi is 10");
            //    }
            //    else
            //    {
            //        Console.WriteLine("sayi isn't 11");
            //    }



            //Console.ReadKey();

            ////YUKARDAKİ GİBİ YAPMAK YERİNE SİNGLE LİNE İF YAPABİLİRİZ(else if hariç)

            //var sayi2 = 10;
            //Console.WriteLine(sayi2 ==10 ? "Sayi is 10" : "Sayi isn't 10");

            ////yani burada if kısmı soru işaretine kadar,sayi is 10 if kısmı,isnt ise else kısmı


            //ctrl+k yapıp elimizi çekip tekrar ctrl+d yaparak kodu düzene sokabilriiz
          //ctrl+k,ctrl c yaparak yorum yapabilriiz.ctrl+k,ctrl+u ile de yorumdan çıkartabiliriz
            
            //switch (sayi)
            //{
            //    case 10:
            //        Console.WriteLine("sayi is 10");
            //        break;
            //    case 20:
            //        Console.WriteLine("sayi is 20");
            //        break;
            //    default:
            //        Console.WriteLine("sayi isn't 10 or 20");
            //        break;
            //}

            //Console.ReadLine(); 

            if (sayi >= 0 && sayi <=100)
            {
                Console.WriteLine("sayi is between 0-100");
            }
            else if (sayi >= 100 && sayi <= 200)
            {
                Console.WriteLine("sayi is between 101-200");
            }
            else if (sayi >200 || sayi < 0)
            {
                Console.WriteLine("sayi is less than 0 or greater than 200");
            }
           
            Console.ReadKey();



        }
    }
}
