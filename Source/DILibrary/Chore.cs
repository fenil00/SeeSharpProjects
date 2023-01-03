using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DILibrary
{
    using System.Diagnostics.Eventing.Reader;

    public class Chore : IChore
    {
        private ILogger _logger;

        private IMessageSender _messageSender;

        public string ChoreName { get; set; }

        public IPerson Owner { get; set; }

        public double HoursWorked { get; private set; }

        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            this._logger = logger;
            this._messageSender = messageSender;
        }

        public void PerformedWork(double hours)
        {
            HoursWorked += hours;
            this._logger.Log($"Performed Work on {ChoreName}");
        }

        public void CompleteChore()
        {
            IsComplete = true;

            this._logger.Log($"Completed {ChoreName}");

            
            this._messageSender.SendMessage(Owner, $"The chore {ChoreName} is complete.");
        }
    }
}
