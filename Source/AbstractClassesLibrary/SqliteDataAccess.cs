using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesLibrary
{
    public class SqliteDataAccess : DataAccess
    {

        public override string LoadConnectionString(string name)
        {
            Console.WriteLine(base.LoadConnectionString(name) + " from SQLite");
            return "testConnectionString frin child class";
        }

        public override void LoadData(string sql)
        {
            Console.WriteLine("Loading SQLite Data");
        }

        public override void SaveData(string sql)
        {
            Console.WriteLine("Saving data to SQLite");
        }
    }
}
