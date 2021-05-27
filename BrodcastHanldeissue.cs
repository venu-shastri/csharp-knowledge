 public class EventsDemo
    {
        //Forground Task
        static ManualResetEvent task1Handle = new ManualResetEvent(false);//wait state(red)
        static ManualResetEvent task2Handle = new ManualResetEvent(false);//wait state(red)
        static ManualResetEvent task3Handle = new ManualResetEvent(false);//wait state(red)
        static ManualResetEvent task4Handle = new ManualResetEvent(false);//wait state(red)
        static AutoResetEvent broadCastHandle = new AutoResetEvent(false);//wait state(red)
        static void Main()
        {
            ThreadPool.QueueUserWorkItem(AsyncTask1);
            ThreadPool.QueueUserWorkItem(AsyncTask2);
            ThreadPool.QueueUserWorkItem(AsyncTask3);
            ThreadPool.QueueUserWorkItem(AsyncTask4);
            Thread.Sleep(2000);
            broadCastHandle.Set();
            WaitHandle.WaitAll(new WaitHandle[] { task1Handle,task2Handle,task3Handle,task4Handle });
            Console.WriteLine("End Of Main");
            WaitHandle.WaitAll(new WaitHandle[] { task1Handle, task2Handle, task3Handle, task4Handle });
            Console.WriteLine("Main End");
        }

        //BG Tasks
        static void AsyncTask1(object args) {
            Console.WriteLine("AsyncTask 1 Awaiting for Broadcast Signal");
            broadCastHandle.WaitOne();
        for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"AsyncTask1 -> {i}");
                System.Threading.Thread.Sleep(1000);
            }
            task1Handle.Set();
        }
        static void AsyncTask2(object args) {
            
            Console.WriteLine("AsyncTask 2 Awaiting for Broadcast Signal");
            broadCastHandle.WaitOne();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"AsyncTask2 -> {i}");
                System.Threading.Thread.Sleep(2000);
            }
            task2Handle.Set();
        }

    
        static void AsyncTask3(object args) {
          
            Console.WriteLine("AsyncTask 3 Awaiting for Broadcast Signal");
            broadCastHandle.WaitOne();
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"AsyncTask3 -> {i}");
                System.Threading.Thread.Sleep(1000);
            }
            task3Handle.Set();
        }
        static void AsyncTask4(object args) {
            
            Console.WriteLine("AsyncTask 4 Awaiting for Broadcast Signal");
            broadCastHandle.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"AsyncTask4 -> {i}");
                System.Threading.Thread.Sleep(2000);
            }
            task4Handle.Set();
        }
    }
