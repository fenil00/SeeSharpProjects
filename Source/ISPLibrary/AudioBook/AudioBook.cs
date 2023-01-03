using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPLibrary
{
    public class AudioBook : IBorrowableAudioBook
    {
        public string LibraryId { get; set; }

        public string Title { get; set; }

        public int RuntimeInMinutes { get; set; }

        public DateTime BorrowDate { get; set; }

        public string Borrower { get; set; }

        public int CheckOutDurationInDays { get; set; }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut(string borrower)
        {
            throw new NotImplementedException();
        }

        public DateTime GetDueDate()
        {
            throw new NotImplementedException();
        }
    }
}
