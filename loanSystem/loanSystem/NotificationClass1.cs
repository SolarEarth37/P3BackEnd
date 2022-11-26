using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loanSystem
{
    public class NotificationClass1
    {
        public int LoanId;
        public string Description;

        public NotificationClass1(int LoanId, string Description)
        {
            this.LoanId = LoanId;
            this.Description = Description;
        }
    }
}
