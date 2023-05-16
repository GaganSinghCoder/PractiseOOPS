using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string someName, decimal bal) : base(someName, bal)
        { }

        public virtual string OpenAccount(DateTime dateTime, string address)
        {
            throw new NotImplementedException();
        }

        public override void OpenAccount(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
