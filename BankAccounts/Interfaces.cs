namespace Interfaces
{

    public interface Ai
    {
        public void DoWork()
        {
            Console.WriteLine("I'm in Interface  Ai");
        }
    }
    public interface Bi : Ai
    {
        public virtual void DoWork()
        {
            Console.WriteLine("I'm in interface Bi");
        }

    }
    public interface Ci : Ai
    {
        public void DoWork(Ci derivedInterface)
        {
            Console.WriteLine("1st I'm in interface Ci");
            
            Ai baseInterface = derivedInterface;
            baseInterface.DoWork();
        }

        public void NoDefaultImplementation();

    }

    public class C : Ci
    {
        public void NoDefaultImplementation()
        {
            Console.WriteLine("I'm in Class C");
        }
    }


}


