namespace ConsoleApp16
{

    class TataCar
    {
        //Dependency
        RevtronEngine _engine=new RevtronEngine(); //composition
        public void Ignite() {
        _engine.Start();
        }
        public void Halt() {
            _engine.Stop();
        }
    }
    class RevtronEngine
    {
        public void Start() { }
        public void Stop() { }
    }
    class VericoreEngine
    {

    }
    class KrytoechEngine
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TataCar _nexon = new TataCar();
            _nexon.Ignite();

            TataCar _harrier = new TataCar(); //Kryotech engine

            TataCar _hexa = new TataCar();//vericore engine

            FamilyOccassion _family = new FamilyOccassion();
            Parent _parentInstance = new Parent();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_One(); //Runtime Polymorphism
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Two();
            _family.Visit(_parentInstance);

            _parentInstance = new Child_Three();
            _family.Visit(_parentInstance);

        }
    }


    public class FamilyOccassion
    {

        public void Visit(Parent  familyMember)
        {
            familyMember.Participate(); //Runtime Polymorphism
            
        }
        
    }

    public class Parent {
    
        public virtual void Participate()
        {
            Console.WriteLine("Parent ...Participate ");
        }
    }
    public class Child_One:Parent {

        public override void Participate()
        {
            Console.WriteLine("ChildOne...Participate");
        }
        public void Smoke()
        {

        }
    }
    public class Child_Two:Parent {

        public override void Participate()
        {
            Console.WriteLine("ChildTwo...Participate");
        }

    }
    public class Child_Three : Parent {
        public override void Participate()
        {
            Console.WriteLine("ChildThree...Participate");
        }

    }



}
