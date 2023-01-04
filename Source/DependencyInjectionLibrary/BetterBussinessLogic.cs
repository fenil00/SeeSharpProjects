using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionLibrary
{
    using DependencyInjectionLibrary.Utilities;

    public class BetterBussinessLogic : IBussinessLogic
    {
        private ILogger _logger;

        private IDataAccess _dataAccess;

        //Constructor injection
        public BetterBussinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            this._logger = logger;
            this._dataAccess = dataAccess;
        }

        public void ProcessData()
        {

            _logger.Log("Starting the processing of data.");
            Console.WriteLine();
            Console.WriteLine("Processing the data");
            Console.WriteLine();
            _dataAccess.LoadData();
            _dataAccess.SaveData("Processed Info");
            Console.WriteLine();
            _logger.Log("Finished processing of the data.");

        }
    }
}
