using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class GiftCardAccount : BankAccount
    {
        string storeName;
        public GiftCardAccount(string someName, decimal bal) : base(someName, bal)
        { }
        public override void OpenAccount(DateTime dateTime)
        {
            storeName = "abc";
        }

    }
    
}
