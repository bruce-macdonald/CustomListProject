using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CustomListUnitTestStarter
{
    public class CustomList<T> /*: IEnumerable*/
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
                if (index < 0 || index > count || count == 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
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
            items[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            bool doItOnce = true;
            for (int i = 0, j = 0; i < Count; i++, j++)
            {
                items[j] = items[i];
                if (items[i].Equals(item) && doItOnce)
                {
                    doItOnce = false;
                    j--;
                }
            }
            if (!doItOnce)
            {
                count--;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(items[i].ToString());
            }
            return sb.ToString();
        }

        //public IEnumerable GetEnumerator()
        //{
        //    for (int i = 0; i < items.Count; i++)
        //    {
        //        yield return items[i];
        //    }
        //    yield return items;

        //}


        public static CustomList<T> operator +(CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                result.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                result.Add(list2[i]);
            }
            return result;
        }

        public static CustomList<T> operator- (CustomList<T> list1, CustomList<T> list2)
        {
            CustomList<T> result = new CustomList<T>();
            for (int i = 0; i < list1.count; i++)
            {
                result.Add(list1[i]);
            }
            for (int i = 0; i < list2.count; i++)
            {
                if (list2.DoesContain(list1[i]))
                {
                    result.Remove(list2[i]); 
                }
            }
            return result;
        }
        



        public bool DoesContain(T item)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[index].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }


}   }

   


    

