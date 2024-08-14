namespace Try_Catch_BROCODE
{
    //bu kodu brocode youtbe sayfasından öğrendim solution explorer den ekleme yaptım
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exception=errors that occur during execution

            //try     = try some code that is considered "Dangerous"
            //catch   =catches and handles exceptions when they occur
            //finally = always executes regardless if exception is caught or not


            //Exception=yürütme sırasında oluşan hatalar

            //dene = "Tehlikeli" olarak kabul edilen bazı kodları deneyin
            //catch = istisnaları ortaya çıktıklarında yakalar ve işler
            //finally = istisnanın yakalanıp yakalanmamasına bakılmaksızın her zaman yürütülür


            double x;
            double y;
            double result;

            try
            {
                Console.Write("Enter number 1: ");
                x=Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y=Convert.ToDouble(Console.ReadLine());

                result = x / y;
                Console.WriteLine("Result: "+result);
            }


            // Bu blok, kullanıcının girdiği metinleri sayıya dönüştürmeye çalışırken bir hata oluştuğunda çalışır.Örneğin, 
             //kullanıcı metin girişi yaparsa ve bu metin sayıya dönüştürülemezse, bir FormatException fırlatılır.Bu blok,
             //bu hatayı yakalar ve ekrana "Enter only numbers Please!" mesajını yazdırır.
            catch (FormatException ex)
            {
                Console.WriteLine("Enter only numbers Please!");
            }
           
           // Bu blok, kullanıcının ikinci sayıyı sıfıra bölmeye çalıştığında çalışır. Bir sayıyı sıfıra bölmek matematiksel olarak tanımsız olduğundan, 
            // bu işlem yapılırsa bir DivideByZeroException fırlatılır.Bu blok, bu hatayı yakalar ve ekrana "You can't divide by zero!" mesajını yazdırır.
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide by zero!");
            }

            //Bu blok, yukarıdaki iki catch bloğundan farklı olarak, genel bir hata durumu oluştuğunda çalışır. Yani, FormatException veya DivideByZeroException dışında bir hata oluşursa bu blok çalışır. 
           // Bu blok, herhangi bir hata durumunu yakalar ve ekrana "Something went wrong!" mesajını yazdırır.
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!");
            }

           // Bu blok, try bloğu içindeki işlemler tamamlandıktan sonra, hata olsa da olmasa da her zaman çalışır. 
           //bu  blok, programın sonunda çalıştırılacak işlemleri içerir. 
           //Burada "Thanks for visiting!" mesajı yazdırılır.
            finally
            {
                Console.WriteLine("Thanks for visiting!");
            }

            Console.ReadKey();


            //CATCH formmatları

            //IOException: Dosya giriş/çıkış işlemleri sırasında oluşabilecek hataları ele almak için:

            //ArgumentNullException: Bir metodun null olarak geçilen bir parametresini ele almak için:

            //WebException: Web isteği sırasında oluşabilecek hataları ele almak için:

            //SqlException: Veritabanı işlemleri sırasında oluşabilecek hataları ele almak için:






        }

    }
}
