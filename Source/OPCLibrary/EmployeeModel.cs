using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLibrary
{
    public class EmployeeModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public bool IsManager { get; set; }

        public bool IsExecutive { get; set; }
    }
}
