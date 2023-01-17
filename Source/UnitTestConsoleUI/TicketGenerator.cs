using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestConsoleUI
{
    public class TicketGenerator
    {
        IPersonNameCleaner _cleaner;

        public TicketGenerator(IPersonNameCleaner cleaner)
        {
            _cleaner = cleaner;
        }

        public Ticket GenerateTicket(Person person)
        {
            _cleaner.Clean(person);
            return new Ticket
                       {
                           Name = string.Format("{0} {1}", person.FirstName, person.LastName)
                       };
        }
    }
}
