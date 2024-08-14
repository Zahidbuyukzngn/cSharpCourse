namespace VirtualMethods
{
   internal class Program
    {
        static void Main(string[] args)
        {
          SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();

            Console.ReadLine();
        }
        class DataBase
        {
            public virtual void Add()
            {
                Console.WriteLine("added by default");
            }
            public virtual void Delete() 
            {
                Console.WriteLine("deleted by default");
            }
        }
        class SqlServer:DataBase
        {
            public override void Add()
            {
                Console.WriteLine("added by sql code");
                //base.Add();
            }
        }
        class MySql:DataBase
        {

        }

    }
}
