using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added");
        }
        public void Update()
        {
            Console.WriteLine("Sql Updated");

        }
        public void Delete()
        {
            Console.WriteLine("Sql Deleted");

        }
    } class MySqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("MySql added");
        }
        public void Update()
        {
            Console.WriteLine("MySql Updated");

        }
        public void Delete()
        {
            Console.WriteLine("MySql Deleted");

        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal) 
        
        {
           customerDal.Add();
        }
    }
}
