using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11_CodeRefactoring.RefactoredCode
{
    internal class ConcertBooking
    {
        internal void BookConcert(string concert, TicketType ticketType)
        {
            if (ticketType == TicketType.Seated)
            {
                // Issue seated ticket.
            }
            else
            {
                // Issue standing ticket.
            }
        }
    }
}
