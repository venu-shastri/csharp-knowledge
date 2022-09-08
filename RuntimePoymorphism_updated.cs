using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Codes
{
    public class TataCar
    {
        //Dendends On Abstraction Of Engines
        IEngineType _engineType;
        

        //Constructor Injection
        // Dependency is Must
        // Dependency Will Not Change for the lifetime of the Dependent Object
        public TataCar(IEngineType engine)
        {
            this._engineType = engine;
        }

        public void Ignite()
        {
            _engineType.Start();
        }
        public void Halt()
        {
            _engineType.Stop();
        }
    }

    public interface IEngineType
    {
         void Start();// default methods are public 
         void Stop();// default methods are public

    }
    public class RevtronEngine : IEngineType
    {
        public  void Start()
        {
            Console.WriteLine("Revtron...Ignited");
        }
        public  void Stop() { }
    }
    public class VericoreEngine : IEngineType
    {
        public  void Start()
        {
            Console.WriteLine("Vericore...Ignited");
        }
        public  void Stop() { }

    }
    public class KrytoechEngine : IEngineType
    {
        public  void Start()
        {
            Console.WriteLine("Kryotech...Ignited");
        }
        public  void Stop() { }

    }

    public class Program
    {

        public static void Main()
        {

            IEngineType _engine = new RevtronEngine();
            TataCar _nexon = new TataCar(_engine);
            _nexon.Ignite();

             _engine = new KrytoechEngine();
            TataCar _harrier = new TataCar(_engine);
            _harrier.Ignite();


            _engine = new VericoreEngine();
            TataCar _hexa = new TataCar(_engine);
            _hexa.Ignite();



        }
    }


}
