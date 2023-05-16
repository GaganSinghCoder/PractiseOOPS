using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string someName, decimal bal) : base(someName, bal)
        { }

        

        public override void OpenAccount(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
