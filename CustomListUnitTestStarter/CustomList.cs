using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestStarter
{
    public class CustomList<T>
    {
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

        

        public CustomList()
        {
            Capacity = 4;
            items = new T[Capacity];
        }

        public void Add(T item)
        {
            //add item that's passed in to the array

        }



    }


}
