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

```C#
 public class Button
    {
        public void OnClick()
        {
            Console.WriteLine("Button Clicked");

        }
    }

    public class TextBox
    {
        public void Clear() { Console.WriteLine("TextBox Content Cleared"); }
    }

    public class Window
    {
        Button _btn;
        TextBox _textBox;
        public Window()
        {
            this._btn = new Button();
            this._textBox = new TextBox();
        }
        public void SimulateButtonClick()
        {
            this._btn.OnClick();
        }
    }
    class Program
    {
      

        static void Main()
        {
            Window _window = new Window();
            while (true)
            {
                Console.WriteLine("Press Any Key To Click Button");
                Console.ReadKey();
                _window.SimulateButtonClick();
            }
        }
    }
```

```C#
 public class CreditCard
    {

        public void Swipe() { }
        
    }

    public class SMSManager
    {
        public void SendSMS(string msg)
        {
            
        }
    }
    public class EmailNotifier
    {
        public void SendMail(string msg)
        {

        }
    }
```



### Observer Pattern Using Delegate

```C#
 public enum SubjectState
    {
        OPEN,CLOSE
    }
         

    public class Subject
    {
        SubjectState state;

        #region Event 
        private Action<SubjectState> StateChanged = null;
        #endregion

        #region EventMutators (Subscribe/UnSubScribe)
        public void Add_StateChanged(Action<SubjectState> observer)
        {
            StateChanged += observer;
        }
        public void Remove_StateChanged(Action<SubjectState> observer)
        {
            this.StateChanged -= observer;

        }
        #endregion
        public void SetState(SubjectState value)
        {
            state = value;
            //Notify Observers
            if (this.StateChanged != null)
            {
                this.StateChanged.Invoke(this.state);
            }

        }
    }

   public  class ObserverOne
    {
        public void Update(SubjectState state)
        {
            Console.WriteLine($"Observer One Notified: Subject State  {state}");
        } 

    }
    public class ObserverTwo
    {
        public void Notify(SubjectState state)
        {
            Console.WriteLine($"Observer Two Notified: Subject State  {state}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ObserverOne _observerOne = new ObserverOne();
            ObserverTwo _observerTwo = new ObserverTwo();

            Action<SubjectState> observerOneAddress = new Action<SubjectState>(_observerOne.Update);
            Action<SubjectState> observerTwoAddress = new Action<SubjectState>(_observerTwo.Notify);

            Subject _subjectRef = new Subject();
            
            _subjectRef.Add_StateChanged(observerOneAddress);
            _subjectRef.Add_StateChanged(observerTwoAddress);

            _subjectRef.SetState(SubjectState.OPEN);
            System.Threading.Thread.Sleep(5000);
            _subjectRef.SetState(SubjectState.CLOSE);

            _subjectRef.Remove_StateChanged(observerTwoAddress);
            _subjectRef.SetState(SubjectState.OPEN);
            System.Threading.Thread.Sleep(5000);
            _subjectRef.SetState(SubjectState.CLOSE);

        }
    }
```

