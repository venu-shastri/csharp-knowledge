### Event Demo

```C#
 public class SPO2Monitor
    {
        Random _randomRef = new Random();
        public event Action Critical;
        public event Action<string> ValueChanged;
     
        

        public void Monitor()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                int value = _randomRef.Next(90, 99);
        		if(ValueChanged!=null){
                    ValueChanged.Invoke(value.ToString());
                }
                if (value < 95)
                {
                    //Critical
                    if(Critical!=null){
                        Critical.Invoke();
                    }
        
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
           Beeper _beeper = new Beeper();
            Display _display = new Display();

            Action _beeperAddress = new Action(_beeper.Beep);
            Action<string> _displayAddress = new Action<string>(_display.RefreshDisplay);
            SPO2Monitor _monitor = new SPO2Monitor();
            _monitor.ValueChanged += _displayAddress;
            _monitor.Critical += _beeperAddress;

            _monitor.Monitor();
        }
    }
```

```C#
 public class Button
    {
        public event Action Click;
     
        public void OnClick()
        {
            Console.WriteLine("Button Clicked");
            if(Click!=null){
                Click.Invoke();
            }

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
            Action _observerAddress=new Action (this.btn_Click);
            this._btn.Click+=_observerAddress;
            this._textBox = new TextBox();
        }
        public void SimulateButtonClick()
        {
            this._btn.OnClick();
        }
        void btn_Click(){
            
            this._textBox.Clear();
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
		public event Action<string> OnSwipe;
     
        public void Swipe() {
        
            if(OnSwipe!=null){
                
                OnSwipe.Invoke("Transaction Details");
            }
        }
        
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

### Observer using "event" keyword

```C#
    public enum SubjectState
    {
        OPEN,CLOSE
    }
         

    public class Subject
    {
        SubjectState state;

        #region Event 
         public event Action<SubjectState> StateChanged = null;
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
            _subjectRef.StateChanged+=observerOneAddress;
            _subjectRef.StateChanged+=observerTwoAddress;

            _subjectRef.SetState(SubjectState.OPEN);
            System.Threading.Thread.Sleep(5000);
            _subjectRef.SetState(SubjectState.CLOSE);

            _subjectRef.StateChanged -= observerTwoAddress;
            _subjectRef.SetState(SubjectState.OPEN);
            System.Threading.Thread.Sleep(5000);
            _subjectRef.SetState(SubjectState.CLOSE);

        }
    }
```

