using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    public interface IFriend
    {

        void Anger();
        void JoyOrLaughter();

        void Sorrow();

    }

    public interface IFamilyMember
    {
        void JoyOrLaughter();

        void Sorrow();


    }

    public interface IProfessionalWorker {

        void JoyOrLaughter();
        void Sorrow();
        void Professional();
    }
    public class Person:IFriend,IFamilyMember,IProfessionalWorker
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
        static void Hangout_friends(IFriend pObj) {

            pObj.Anger();
            pObj.JoyOrLaughter();
            pObj.Sorrow();
        }
        static void Family(IFamilyMember pobj) {
            
            pobj.Sorrow();
            pobj.JoyOrLaughter();
        }

        static void Office_Work(IProfessionalWorker pObj)
        {
            
            pObj.JoyOrLaughter();
            pObj.Professional();
            pObj.Sorrow();
        }
    }
}
