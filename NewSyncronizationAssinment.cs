 
    //public class DAO
    //{
    //    public readonly static DAO Instance = new DAO();
    //    Object _syncUpdaters = new Object();
    //    Object _syncReaders = new Object();
    //    private DAO() { }

    //   // [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
    //    public void Create() {
            
    //        Monitor.Enter(_syncUpdaters);
    //        try
    //        {
    //           for (int i = 0; i < 10; i++)
    //            {
    //                Console.WriteLine("Create Action.......");
    //                Thread.Sleep(1000);
    //                if (i == 5) { return; }
    //            }
    //        }
    //        finally
    //        {
    //            Monitor.Exit(_syncUpdaters);
    //        }
    //    }
    //    //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
    //    public void Delete() {

    //        lock (_syncUpdaters)
    //        {
    //            for (int i = 0; i < 10; i++)
    //            {
    //                Console.WriteLine("Delete Action.......");
    //                Thread.Sleep(500);
    //            }
    //        }
    //    }

    //    //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
    //    public void Update() {
    //        Monitor.Enter(_syncUpdaters);
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("Update Action.......");
    //            Thread.Sleep(800);
    //        }
    //        Monitor.Exit(_syncUpdaters);
    //    }
    //    //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
    //    public void Select()
    //    {
    //        Monitor.Enter(_syncReaders);
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("Select Action.......");
    //            Thread.Sleep(800);
    //        }
    //        Monitor.Exit(_syncReaders);
    //    }
    //   // [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
    //    public void SelectByKey()
    //    {
    //        Monitor.Enter(_syncReaders);
    //        for (int i = 0; i < 10; i++)
    //        {
    //            Console.WriteLine("SelectKey Action.......");
    //            Thread.Sleep(800);
    //        }
    //        Monitor.Exit(_syncReaders);
    //    }
    //}

    public static class MutexWaitHanldes
    {
        public static Mutex _handleOne = new Mutex(true);
        public static Mutex _handleTwo = new Mutex(false);
    }
    public class DAO
    {
        public readonly static DAO Instance = new DAO();
        public Mutex _handleOne = new Mutex(true);
        private DAO() { }

        // [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void Create()
        {

            Console.WriteLine("Create Action Awaiting For Signal");
           this._handleOne.WaitOne();
                
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Create Action.......");
                    Thread.Sleep(1000);
                    if (i == 5) { return; }
                }
            }
            finally
            {
                this._handleOne.ReleaseMutex();
            }
        }
        //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void Delete()
        {

            Console.WriteLine("Delete Action Awaiting For Signal");
            this._handleOne.WaitOne();
            for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Delete Action.......");
                    Thread.Sleep(500);
                }
            this._handleOne.ReleaseMutex();
        }

        //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void Update()
        {
            Console.WriteLine("Update Action Awaiting For Signal");
            this._handleOne.WaitOne();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Update Action.......");
                Thread.Sleep(800);
            }
            this._handleOne.ReleaseMutex();
        }
        //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void Select()
        { 
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Select Action.......");
                Thread.Sleep(800);
            }
            
        }
        // [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public void SelectByKey()
        {
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("SelectKey Action.......");
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

            Console.WriteLine("Click Here To Start Thread Actions");
            Console.ReadKey();
            singleton._handleOne.ReleaseMutex();

             new Thread(singleton.Select).Start();
             new Thread(singleton.SelectByKey).Start();

            Console.WriteLine("End OF Main");


        }
    }
