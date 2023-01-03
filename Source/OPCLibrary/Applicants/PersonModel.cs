using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPCLibrary
{
    public class PersonModel : IApplicantModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IAccounts AccountProcessor { get; set; } = new Accounts();
    } 
}
