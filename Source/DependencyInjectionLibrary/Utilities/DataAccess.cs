using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLibrary.Utilities
{
    using System.CodeDom;

    public class DataAccess : IDataAccess
    {
        private ILogger _logger;

        public DataAccess(ILogger logger)
        {
            this._logger = logger;
        }

        public void LoadData()
        {
            Console.WriteLine("Loading Data");
            this._logger.Log("Loading Data");
        }

        public void SaveData(string name)
        {
            Console.WriteLine($"Saving {name}");
            this._logger.Log("Saving Data");
        }
    }
}
