using System.Collections;

namespace OOP.Interfaces.IEnumerables
{
    public class ArrayEnumerator : IEnumerator
    {
        private int[] InnerList;
        private int InnerIndex;
        public object Current => InnerList[InnerIndex];

        public ArrayEnumerator(int[] arr)
        {
            InnerList = arr;
            //InnerIndex = -1;
            InnerIndex = InnerList.Length;    
        }

        public bool MoveNext()
        {
            if (InnerIndex == InnerList.Length)
            {
                InnerIndex--;
                return true;
            } 
            if (InnerIndex > 0 )
            {
                InnerIndex--;
                return true;
            }
            else
            {
                InnerIndex = InnerList.Length;
                return false;
            }
        }

        public void Reset()
        {
            //InnerIndex = -1;
            InnerIndex = InnerList.Length;
        }
    }
}