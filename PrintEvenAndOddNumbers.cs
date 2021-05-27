using  System;
using System.Threading.Tasks;
    namespace ConsoleApplication1
    {
        class Program
        {
            static void Main(string[] args)
            {
 
                var t1 = Task.Factory.StartNew(() => PrintOddNumbers());
                var t2 = Task.Factory.StartNew(() => PrintEvenNumbers());
 
                Task.WaitAny(t1, t2);
 
                Console.WriteLine("End");
                Console.ReadLine();
            }
 
            static void PrintOddNumbers()
            {
                int[] arr = new int[] { 1, 3, 5, 7, 9, 11, 13, 15 };
 
                foreach (var item in arr)
                {
                    Console.WriteLine(item);
 
                }
            }
 
            static void PrintEvenNumbers()
            {
                int[] arr = new int[] { 2, 4, 6, 8, 10, 12, 14 };
 
                foreach (var item in arr)
                {
 
                    Console.WriteLine(item);
 
                }
 
            }
        
 
          
        }
    }
