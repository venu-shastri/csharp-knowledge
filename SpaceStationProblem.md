```C#
public interface INASASpaceDockable
    {
        void Connect();
        void Disconnect();
    }
    public class NASASpaceStation
    {

        public void Dock(INASASpaceDockable spaceCraft)
        {
            spaceCraft.Connect();
        }
    }
    public interface IUSSRSpacDockable
    {
        void Connect();
        void Disconnect();
    }
    public class USSRSpaceStation
    {
        public void Dock(IUSSRSpacDockable spaceCraft)
        {
            spaceCraft.Connect();
        }
    }

    public class ISROSpaceCraft
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            ISROSpaceCraft _spaceCraft = new ISROSpaceCraft();
            NASASpaceStation _nasaSpaceStation = new NASASpaceStation();
            _nasaSpaceStation.Dock(_spaceCraft);

            USSRSpaceStation _ussrSpaceStation = new USSRSpaceStation();
            _ussrSpaceStation.Dock(_spaceCraft);
        }
    }
```

