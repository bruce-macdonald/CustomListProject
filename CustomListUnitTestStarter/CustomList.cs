using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestStarter
{
    public class CustomList<T>
    {
        public int index;
        private T[] items;
        protected int count;
        public int Capacity { get; set; }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
            }
        }


        public CustomList()
        {
            Capacity = 4;
            items = new T[Capacity];
        }

        public void Add(T item)
        {
            items[count] = item;
            count++;
            if (count == Capacity)
            {
                Capacity = Capacity * 2;
                T[] tempArray = new T[Capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    tempArray[i] = items[i];
                }                              
                items = new T[Capacity];
                for (int i = 0; i < items.Length; i++)
                {
                    items[i] = tempArray[i];
                } 
            }
        }


        //add item that's passed in to the array, double the array Cap when it gets maxed out
    }


}
