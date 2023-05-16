using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class SimpleAccount:BankAccount
    {
        public SimpleAccount(string name):base(name)
        { }

        public override void OpenAccount(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
