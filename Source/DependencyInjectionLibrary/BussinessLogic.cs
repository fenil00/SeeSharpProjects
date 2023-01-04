using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLibrary
{
    using DependencyInjectionLibrary.Utilities;

    public class BussinessLogic : IBussinessLogic
    {
        private ILogger _logger;

        private IDataAccess _dataAccess;

        public BussinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            this._logger = logger;
            this._dataAccess = dataAccess;
        }

        public void ProcessData()
        {
            // don not need this anymore
            // Logger logger = new Logger();
            // DataAccess dataAccess = new DataAccess();

            _logger.Log("Starting the processing of data.");
            Console.WriteLine("Processing the data");
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed Info");
            _logger.Log("Finished processing of the data.");

        }
    }
}
