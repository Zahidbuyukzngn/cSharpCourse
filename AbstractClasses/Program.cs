namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database2=new SqlServer();
            database2.Add();
            database2.Delete();

            Console.ReadLine();
        }
    }
    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void Delete();
    }
    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("deleted by sql");
        }
    }
    class Oracle:Database
    {
        public override void Delete()
        {
            Console.WriteLine("deleted by Oracle");
        }
    }
}
