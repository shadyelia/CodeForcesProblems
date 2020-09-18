using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            super s1 = new child1();
            super s2 = new child2();

            s1.Do("");
            s2.Do("");
        }

        
    }

    class super
    {
        public virtual void Do(string message)
        {
            Console.WriteLine("Hello World Super!");
        }
    }

    class child1 : super
    {
        public override void Do(string message)
        {
            Console.WriteLine("Hello World c1!");
            base.Do("Hello World c1!");
        }
    }

    class child2 : super
    {
        public void Do()
        {
            Console.WriteLine("Hello World c2!");
        }
    }
}
