using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsLibrary
{
    using System.CodeDom;

    public class OverdraftEventArgs : EventArgs
    {
        public decimal AmountOverfrafted { get; private set; }

        public string MoreInfo { get; private set; }

        public bool CancelTransaction { get; set; }

        public OverdraftEventArgs(decimal amountOverfrafted, string moreInfo)
        {
            this.AmountOverfrafted = amountOverfrafted;
            this.MoreInfo = moreInfo;
        }
    }
}
