using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    //One who has state / EventSource

    /*
    public class Subject
    {
        string state;
        List<IObserver> observers = new List<IObserver>();

        
        public void ChangeState(string newState)
        {
            this.state = newState;
           for(int i = 0; i < observers.Count; i++)
            {
                observers[i].Notify();
            }

        }

        public void Subscribe(IObserver observer)
        {
            this.observers.Add(observer);
        }
        public void UnSubScribe(IObserver observer)
        {
            this.observers.Remove(observer);
        }
    }


    public interface IObserver
    {
        void Notify();
    }
    class ObserverOne :IObserver{ 

        public void Notify() {
            Console.WriteLine("Oserver One Notified");
        }
    }

    
    class ObserverTwo:IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Observer Two Notified");
        }
    }
    class ObserverThree:IObserver
    {
        public void Notify()
        {
            Console.WriteLine("Observer Three Notified");
        }
    }
    */

    //CommandSource
    public class Subject
    {
        string state;
        Distributor _distributor;
        public void ChangeState(string newState)
        {
            this.state = newState;
            this._distributor.Invoke();
        
        }
        public void Register(Distributor _distributor)
        {
            this._distributor = _distributor;
        }
        public void UnRegister(Distributor distributor)
        {
            this._distributor = null;
        }


    }

    //Command
    public class Distributor
    {
        Observer _observer;
        public Distributor(Observer observer)
        {
            this._observer = observer;
        }
        public void Invoke()
        {
            this._observer.Notify();
        }
            
    }

    //CommandTarget
    public class Observer
    {
        public void Notify()
        {

            Console.WriteLine("Obsevrer Notify");
        }
    }
    public class NewObserver
    {
        public void Update(string state)
        {
            Console.WriteLine("Obsevrer Notify");
        }
    }
    class Program
    {
        static void Main_old(string[] args)
        {
            //Subject _subjectRef = new Subject();
            //ObserverOne _one = new ObserverOne();
            //ObserverThree _three = new ObserverThree();

            //_subjectRef.Subscribe(_one);
            //_subjectRef.Subscribe(_three);
            
            //_subjectRef.ChangeState("State1");
            //_subjectRef.ChangeState("State2");
        }

        static void Main()
        {
            Observer _target = new Observer();
            Distributor _command = new Distributor(_target);
            Subject _subject = new Subject();
            _subject.Register(_command);

            _subject.ChangeState("State1");
            _subject.ChangeState("State2");

        }
    }
}
