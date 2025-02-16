using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace _dynamic_arr
{
    internal class dynamic
    {
        public int capacity;
        public int[] arr;
        public int counter;

        public dynamic() 
        {
            capacity = 1;
            arr = new int[capacity];
            counter = 0;
        }
        public void add(int item)
        {
            if (capacity > counter)
            {
                arr[counter] = item;
                counter++;
            }
            else
            {               
                    capacity = capacity*2;
                int[] temp = new int[capacity];
                for (int i = 0; i < counter; i++)
                {
                    temp[i] = arr[i];
                }
                temp[counter] = item;
                arr = temp;
                counter++;

            }
        }

    }
}
