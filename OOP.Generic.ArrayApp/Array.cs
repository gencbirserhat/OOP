using System.Collections;


namespace OOP.Generics.ArrayApp
{
    public class Array<T> : IEnumerable
    {
        private T[] InnerList;
        private int InnerIndex;

        public Array(int size = 32)
        {
            InnerList = new T[size];
            InnerIndex = 0;
        }

        public Array(params T[] collection)
        {
            InnerList = new T[collection.Length];
            InnerIndex=0;

            foreach (var item in collection)
            {
                InnerList[InnerIndex] = item;
                InnerIndex++;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return InnerList.Take(InnerIndex).GetEnumerator();
        }
    }
}