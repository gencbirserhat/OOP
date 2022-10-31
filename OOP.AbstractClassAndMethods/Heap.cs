using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.AbstractClassAndMethods
{
    public abstract class Heap
    {
        //field
        private SortedSet<int> _list;
        public Heap()
        {
            _list = new SortedSet<int>();
        }

        public void Insert(int item)
        {
            _list.Add(item);
            
            
        }

        //abstract method
        public abstract int Extract();

        public class MinHeap : Heap
        {
            public override int Extract()
            {
                var item = _list.Min;
                _list.Remove(item);
                return item;
            }
        }
        public class MaxHeap : Heap
        {
            public override int Extract()
            {
                var item = _list.Max;
                _list.Remove(item);
                return item;
            }
        }
    }
}
