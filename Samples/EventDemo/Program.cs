using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    //One who has state / EventSource
    public class Subject
    {
        string state;
        public void ChangeState(string newState)
        {
            this.state = newState;

        }
    }
    class ObserverOne { 

        public void Notify() {
            Console.WriteLine("Oserver One Notified");
        }
    }
    class ObserverTwo
    {
        public void Notify()
        {
            Console.WriteLine("Observer Two Notified");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Subject _subjectRef = new Subject();
            _subjectRef.ChangeState("State1");
            _subjectRef.ChangeState("State2");
        }
    }
}
