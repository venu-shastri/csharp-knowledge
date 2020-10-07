using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public class Person
    {
        public void Professional() { }
        public void Anger() { }
        public void JoyOrLaughter() { }

        public void Sorrow() { }

}
    class Program
    {
        static void Main(string[] args)
        {
            Person _personInstance = new Person();
            Hangout_friends(_personInstance);
            Family(_personInstance);
            Office_Work(_personInstance);
        }
        static void Hangout_friends(Person pObj) {

            pObj.Anger();
            pObj.JoyOrLaughter();
            pObj.Professional();// Not-Valid
            pObj.Sorrow();
        }
        static void Family(Person pobj) {
            pobj.Anger();//not-valid
            pobj.Professional();//not -valid
            pobj.Sorrow();
            pobj.JoyOrLaughter();
        }

        static void Office_Work(Person pObj)
        {
            pObj.Anger();//Not-valid
            pObj.JoyOrLaughter();
            pObj.Professional();
            pObj.Sorrow();
        }
    }
}
