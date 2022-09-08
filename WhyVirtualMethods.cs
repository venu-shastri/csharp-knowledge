namespace ConsoleApp16.WhyVirtualMethods
{

    //inheritance - use?-> complete code reuse
    //virtual method -> Must have implemenation ,Method Open for change, subclass can /maybe reuse base class implementation or override base class implentation

    public class A
    {
        public virtual void M1() { Console.Write("A.M1"); }
        public virtual void M2() { Console.Write("A.M2"); }
    }

    public class B : A
    {
        //shadowing
        public new void M1() { Console.Write("B.M1"); }
        //override M2
        public override void M2(){Console.Write("B.M2");}
    }

    public class Program
    {
        static void Main()
        {
            A obj = new A();
            obj.M1();//A.M1
            obj.M2();//A.M2
            

            B b_obj = new B();
            b_obj.M1();//B.M1
            b_obj.M2();//B.M2

            //Substitution /object Slice
            obj = b_obj;
            obj.M1();//A.M1
            obj.M2();//B.M2
        }
    }
}
