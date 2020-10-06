using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
    //Dynamic Array
    public class List
    {
        private int[] buffer;

        public List(int capacity)
        {
            if (capacity == 0)
            {
                capacity = 5;
            }
            buffer = new int[capacity];

        }

        private void ReSizeBuffer()
        {
            int[] temp = new int[buffer.Length + 10];
            for(int i = 0; i < buffer.Length; i++)
            {
                temp[i] = buffer[i];
            }
            buffer = temp;

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List _list = new List(0);
            _list[0] = 10;
            _list[1] = 20;
            _list[2] = 30;
            _list[3] = 40;
            _list[4] = 50;
            _list[5] = 60;

            int value = _list[5];//60
            Console.WriteLine(value);
            Console.WriteLine("Total Number of  Elements in the List " + _list.ItemCount);
            Console.WriteLine("List Capacity " + _list.Capacity);



        }
    }
}
