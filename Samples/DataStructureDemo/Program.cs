using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    //Dynamic Array
    //Dynamic Array
    /*
    public class List
    {
        #region Private Data Members
        private int[] buffer;
        private int count;
        #endregion

        #region Constructor
        public List(int capacity)
        {
            if (capacity == 0)
            {
                capacity = 5;
            }
            buffer = new int[capacity];
            count = 0;
        }
        #endregion

        #region indexer
        public int this[int index]
        {
            get
            {
                return buffer[index];
            }
            set
            {
                if (index >= buffer.Length)
                {
                    Console.WriteLine("Invoke ResizeBuffer");
                    ReSizeBuffer();
                }
                buffer[index] = value;

                if ((index + 1) >= count)
                {
                    count = (index + 1);
                }
            }
        }
        #endregion

        #region Properties
        public int ItemCount
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return buffer.Length;
            }
        }

        #endregion
        #region Methods
        private void ReSizeBuffer()
        {
            int[] temp = new int[buffer.Length + 10];
            for (int i = 0; i < buffer.Length; i++)
            {
                temp[i] = buffer[i];
            }
            buffer = temp;
        }
        #endregion

    }
    */

    /*
    public class List
    {
        #region Private Data Members
        private object[] buffer;
        private int count;
        #endregion

        #region Constructor
        public List(int capacity)
        {
            if (capacity == 0)
            {
                capacity = 5;
            }
            buffer = new object[capacity];
            count = 0;
        }
        #endregion

        #region indexer
        public object this[int index]
        {
            get
            {
                return buffer[index];
            }
            set
            {
                if (index >= buffer.Length)
                {
                    Console.WriteLine("Invoke ResizeBuffer");
                    ReSizeBuffer();
                }
                buffer[index] = value;

                if ((index + 1) >= count)
                {
                    count = (index + 1);
                }
            }
        }
        #endregion

        #region Properties
        public int ItemCount
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return buffer.Length;
            }
        }

        #endregion
        #region Methods
        private void ReSizeBuffer()
        {
            object[] temp = new object[buffer.Length + 10];
            for (int i = 0; i < buffer.Length; i++)
            {
                temp[i] = buffer[i];
            }
            buffer = temp;
        }
        #endregion

    }
    */

    public class List<T>
    {
        #region Private Data Members
        private T[] buffer;
        private int count;
        #endregion

        #region Constructor
        public List(int capacity)
        {
            if (capacity == 0)
            {
                capacity = 5;
            }
            buffer = new T[capacity];
            count = 0;
        }
        #endregion

        #region indexer
        public T this[int index]
        {
            get
            {
                return buffer[index];
            }
            set
            {
                if (index >= buffer.Length)
                {
                    Console.WriteLine("Invoke ResizeBuffer");
                    ReSizeBuffer();
                }
                buffer[index] = value;

                if ((index + 1) >= count)
                {
                    count = (index + 1);
                }
            }
        }
        #endregion

        #region Properties
        public int ItemCount
        {
            get
            {
                return count;
            }
        }

        public int Capacity
        {
            get
            {
                return buffer.Length;
            }
        }

        #endregion
        #region Methods
        private void ReSizeBuffer()
        {
            T[] temp = new T[buffer.Length + 10];
            for (int i = 0; i < buffer.Length; i++)
            {
                temp[i] = buffer[i];
            }
            buffer = temp;
        }
        #endregion

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> _list = new List<int>(0);
            _list[0] = 10;
            _list[1] = 20;
            _list[2] = 30;
            _list[3] = 40;
            _list[4] = 50;
            _list[5] = 60;
            int value = (int)_list[6];
            Console.WriteLine(value);
            Console.WriteLine("Total Number of  Elements in the List " + _list.ItemCount);
            Console.WriteLine("List Capacity " + _list.Capacity);

            List<string> _stringList = new List<string>(10);
            _stringList[0] = "One";

            List<double> _doubleList = new List<double>(20);
            _doubleList[0] = 12.34;


            System.Collections.ArrayList list = new System.Collections.ArrayList();
            list.Add(10);//Boxing
            object _value=list[0];//indexer access
            

            System.Collections.Generic.List<int> _genList = new System.Collections.Generic.List<int>();
            _genList.Add(10);



        }
    }
}
