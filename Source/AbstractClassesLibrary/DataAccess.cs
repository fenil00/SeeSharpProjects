using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesLibrary
{
    /// <summary>
    /// Abstract class can not be instantiate directly. 
    /// </summary>
    public abstract class DataAccess
    {
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load Connection String");
            return "testConnectionString";
        }

        /// <summary>
        /// Abstract methods must be implemented  in child class with "override" keyword
        /// </summary>
        /// <param name="sql"></param>
        public abstract void LoadData(string sql);

        public abstract void SaveData(string sql);
    }
}
