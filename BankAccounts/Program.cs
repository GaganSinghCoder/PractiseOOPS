namespace Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            A a = new C();
            a.DoWork();


            B b = new C();
            b.DoWork();

            A a1 = new D();
            a1.DoWork();


            A a2 = new E();
            a2.DoWork();


            A a3 = new F();
            a3.DoWork();

            A a4 = new G();
            a4.DoWork();

            SpecialDerived sd = new SpecialDerived();
            sd.Say();

            InterfaceTesting();
        }

        static void InterfaceTesting()
        {
            Interfaces.Ci myAi= new Interfaces.C();
            myAi.DoWork();
        }
    }
}