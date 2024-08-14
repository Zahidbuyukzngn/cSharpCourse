

//ERİŞİM BİLDİRGEÇLERİ

    internal class Program
    {
        static void Main(string[] args)
        {
        
        }

    }
    class Customer
    {
        protected int Id { get; set; }
        
        public void Save()
        {

        }
        public void Delete()
        {

        }
    //protected erişiminindeki bir şeye inheritance ederek yanı Student:Customer yaparak
    //normalde alamadığımız ıd yi alabilioruz
    //protected private ye çok benzer tek fark budur
        class Student:Customer
        {
        public void Save2()
        {
            Id = 1;
           
        }

        }
    //internal kullanıldığı zaman proje içinde heryerden erişilebilir proje dışından erişim mümkün DEĞİL
        
}
