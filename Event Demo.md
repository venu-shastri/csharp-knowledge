### Event Demo

```C#
 public class SPO2Monitor
    {
        Random _randomRef = new Random();
        Display _displayRef = new Display();
        Beeper _beeper = new Beeper();

        public void Monitor()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                int value = _randomRef.Next(90, 99);
                _displayRef.RefreshDisplay($"Current SpO2 {value}");
                if (value < 95)
                {
                    //Critical
                    _beeper.Beep();
                }
               
            }
            
        }
    }

    class Display
    {
        public void RefreshDisplay(string message)
        {

            Console.WriteLine(message);
        }
    }
    class Beeper
    {
        public void Beep()
        {
            Console.WriteLine("Beep......................");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SPO2Monitor _monitor = new SPO2Monitor();
            _monitor.Monitor();
        }
    }
```

