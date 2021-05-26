using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadingBasics
{

    [System.Runtime.Remoting.Contexts.Synchronization]
    public class DAO:System.ContextBoundObject
    {
        public readonly static DAO Instance = new DAO();
        private DAO() { }
        public void Create() { 
        
        for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Create Action.......");
                Thread.Sleep(1000);
            }
        }
        public void Delete() {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Delete Action.......");
                Thread.Sleep(500);
            }
        }

        public void Update() {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Update Action.......");
                Thread.Sleep(800);
            }
        }
        public void Select()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Select Action.......");
                Thread.Sleep(800);
            }
        }
    }
    class SynchronizationDemo
    {
    
        static void Main()
        {
            DAO singleton = DAO.Instance;
            new Thread(singleton.Create).Start();
            new Thread(singleton.Delete).Start();
            new Thread(singleton.Update).Start();
            new Thread(singleton.Select).Start();

        }
    }
}
