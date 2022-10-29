using static OOP.AbstractClassAndMethods.Heap;

namespace OOP.AbstractClassAndMethods
{
	class Program
	{
		static void Main(string[] args)
		{
			var Array = new int[] { 1, 2, 3, 4, 5 };
			var minheap = new MinHeap();
			var maxheap = new MaxHeap();

			foreach (var item in Array)
			{
				minheap.Insert(item);
				maxheap.Insert(item);
			}

			Console.WriteLine(minheap.Extract());
			Console.WriteLine(maxheap.Extract());
		}
	}
}	