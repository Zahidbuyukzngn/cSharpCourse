
//DİZİLER  ARRAY

class Program()
{
    static void Main(string[] args)
    {
        //DİZİLER 1.DERS
        //string[] students = new string[3] { "engin", "mehmet", "ahmet" };

        //string[] students2 = { "engin", "mehmet", "salih" };
        //students2[3] = "Ahmet";
    
    
        //foreach (var student in students2) 
        //{
        //    Console.WriteLine(student);
        //}
        //Console.WriteLine();
       //Console.ReadLine();

        
        //ÇOK BOYUTLU DİZİLER
        
        // 5,3 İLE 3 SÜTUN 5 SATIR OLUŞTURDUK,5 BÖLGE VE 3 ŞEHİR EKLEDİK
         
        string[,] regions = new string[5, 3]
        {
            {"istanbul","izmit","bursa"},
            {"ankara" ,"kayseri","konya"},
            {"antalya" ,"mersin","adana"},
            {"rize","samsun","trabzon"},
            {"izmir","muğla","manisa"}
            
        };
        //GetUpperBound ile 0 yazarak 5i aldık
        for (int i = 0; i <= regions.GetUpperBound(0); i++)
        {
            //parantez içine 1 yazarak da her 3 sütünü aldık
            for (int j = 0; j <= regions.GetUpperBound(1); j++)
            {
                Console.WriteLine(regions[i, j]);
            }
            Console.WriteLine("*******");
        }

    }
}