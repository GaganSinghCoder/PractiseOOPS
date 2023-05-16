namespace Classes
{
    public class A
    {
        public virtual void DoWork()
        {
            Console.WriteLine("I'm in A");
        }
    }
    public class B : A
    {
        public virtual void DoWork()
        {
            Console.WriteLine("I'm in B");
        }

    }
    public class B2 : A
    {
        public override void DoWork()
        {
            Console.WriteLine("I'm in B2");
        }

    }

    public class C : B
    {
        public sealed override void DoWork()
        {
            Console.WriteLine("I'm in C");
        }
    }

    public class D : B2
    {
        public sealed override void DoWork()
        {
            Console.WriteLine("I'm in D but can call base.DoWork()");
            base.DoWork();
        }
    }

    public class E : B2
    {
        public void DoWork()
        {
            Console.WriteLine("I'm in E");
        }
    }

    public class F : B2
    {
        public virtual void DoWork()
        {
            Console.WriteLine("I'm in F");
        }
    }

    public class G : B2
    {
        public new void DoWork()
        {
            Console.WriteLine("I'm in G");
        }
    }

}
