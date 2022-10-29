using System.Collections;
using System.Linq;

namespace OOP.Interfaces.IEnumerables
{
    public class Array : IEnumerable
	{
		public int[] InnerList { get; set; }
		public int index = 0;

		public Array(int size = 16)
		{
			InnerList = new int[size];
		}
		public Array(params int[] initial)
		{
			InnerList=new int[initial.Length];

			foreach (var item in initial)
			{
				InnerList[index] = item;
				index++;	
			}
		}

		public IEnumerator GetEnumerator()
		{
			return new ArrayEnumerator(InnerList);
		}
	}
}