using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesLibrary
{
    public interface IDataAccess
    {
        string LoadConnectionString(string name);

        void LoadData(string sql);

        void SaveData(string sql);
    }
}
