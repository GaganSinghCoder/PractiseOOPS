using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    /// <summary>
    /// see Problem question in StackOverFlow https://stackoverflow.com/questions/2323401/how-to-call-base-base-method
    /// </summary>
    // Cannot change source code
    class Base
    {
        public virtual void Say()
        {
            Console.WriteLine("Called from Base.");
        }
    }

    // Cannot change source code
    class Derived : Base
    {
        public override void Say()
        {
            Console.WriteLine("Called from Derived.");
            base.Say();
        }
    }

    class SpecialDerived : Derived
    {
        public override void Say()
        {
            Console.WriteLine("Called from Special Derived.");
            base.Say();
        }
    }

}
