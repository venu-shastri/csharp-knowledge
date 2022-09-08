namespace ConsoleApp16.WhyInterface
{
    /*
     * 
     * interface : public view of an object
     * 
     * class A{
     * 
     *  public void M1(){}
     *  public void M2(){}
     *  private void M3(){}
     *  protected void M4(){}
     * }
     *  Default Interface Of A : {M1,M2}
     *  
     *  To define Contract b/w two objects communication
     *  Contract : Expectation and Committment
     */

    
    public interface INasaSpecSpaceShip
    {
        void Dock();
    }
    public class NasaSpaceStation
    {

        public void Connect(INasaSpecSpaceShip spaceship)
        {
            spaceship.Dock();
        }
       

    }

    public interface IUSSRSpecSpaceCraft
    {
        void Embark();
    }
    class USSRSpaceStation
    {
        public void Connect(USSRSpaceCraft spaceship)
        {
            spaceship.Embark();
        }
    }
    class ChinaSpaceStation
    {
        public void Connect(ChinaSpaceCraft spaceship)
        {
            spaceship.Land();
        }
    }

    class USASpaceCraft:INasaSpecSpaceShip
    {
        public void Dock() { }

        public void UnDock() { }
    }

    public class ISROSpaceCraft:INasaSpecSpaceShip,IUSSRSpecSpaceCraft
    {
        public void Dock()
        {
            Console.WriteLine("Connected to NASA-SpaceStation");
        }
        public void Embark() {
            Console.WriteLine("Connected to USSR-SpaceStation");
        }

    }

   public class USSRSpaceCraft:IUSSRSpecSpaceCraft
    {
        public void Embark() { }
    }
    public class ChinaSpaceCraft
    {
        public void Land() {  }
    }

    public class Program
    {
        public static void Main()
        {
            ISROSpaceCraft isroSpceShip = new ISROSpaceCraft();
            USASpaceCraft usaSpaceCraft = new USASpaceCraft();
            USSRSpaceCraft ussrSpaceCraft = new USSRSpaceCraft();

            NasaSpaceStation _nasaSpaceStation = new NasaSpaceStation();

            _nasaSpaceStation.Connect(isroSpceShip);
            _nasaSpaceStation.Connect(usaSpaceCraft);

            _nasaSpaceStation.Connect(ussrSpaceCraft);
            



        }
    }

}
