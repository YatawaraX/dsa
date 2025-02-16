using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace dynamic2
{
    public class dynamic_2
    {
        public int capacity;
        public string[] array;
        public int counter;

        public dynamic_2()
        {
            capacity = 1;
            array = new string[capacity];
            counter = 0;
        }
        public void add (string item)
        {
            if(counter < capacity)
            {
                array[counter] = item;
                counter++;
            }
            else
            {
                capacity = capacity * 2;
                string[] temp = new string[capacity];
                for (int i = 0; i < counter; i++)
                {
                    temp[i] = array[i];
                }
                temp[counter] = item;
                array = temp;
                counter++;
            }
        }
    }
}
