using System.Runtime.Serialization;

namespace Strings
{
    internal class Program
    {
        //Stringler
        static void Main(string[] args)
        {
            //      string city = "ANKARA";

            ////ankarayı harf harf aşağı doğru yazdırdık
            //      foreach (var item in city)
            //      {
            //          Console.WriteLine(item);
            //      }
            // //ankara ve istanbulu birleştirip tek satırda yazdık     
            //      string city2 = "İSTANBUL";
            //      Console.WriteLine(string.Format("{0} {1}",city,city2));

            //      Console.ReadKey();



            //STRİNG METODLARIYLA ÇALIŞMA

            string sentence = "My name is Zahid Büyükzengin";

            //boşluk dahil kaç karakter olduğunu söyler
            var result = sentence.Length;
           //clone ile kopya oluşturuyoruz 
            var result2= sentence.Clone();
            result2 = "selam";

            // n ile biten kelime varmı yokmu onu söyler
            bool result3 = sentence.EndsWith("n");

            //my name cümle içinde varmı diye sorduk.mesela sadece m yazsaydık true döndürecekti
            bool result4=sentence.StartsWith("my name");
           
            // name kaçıncı karakterden başladığını bize söyler (sadece ilk name söyler).bulamazsa -1 döndürür
            var result5=sentence.IndexOf("name");
            //aynı şekilde ilk boşluğun kaçıncı karakterden başladığını söyler
            var result6 = sentence.IndexOf(" ");
            //aramaya sodnan başlar
            var result7=sentence.LastIndexOf(" ");

            //0.karakterden itibaren hello yazdırdık
            var result8 = sentence.Insert(0, "Hello, ");
           
            //cümlenin 3.karakterden itibaren başlamasını sağladık.4 yazarak da sadece başlattığımız yerden sonra 4 karakter almasını sağladık
            var result9=sentence.Substring(3,4);
            
            //to lower ile tüm harfleri küçülttük,toupper ile hepsini büyülttük
            var result10=sentence.ToLower();
            var result11=sentence.ToUpper();

            // boşluk yerine çizgi kullandık
            var result12 = sentence.Replace(" ", "-");

            //2den sonrasını kaldır dedik,4 tanesini kaldrı dedik 2.karakterden sonra
            var result13 = sentence.Remove(2,4);
            Console.WriteLine(result12);
            Console.ReadLine();

        }
    }
}
