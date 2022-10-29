namespace OOP.Interfaces.IEnumerables
{
	class Program
	{
		static void Main()
		{
			// Define an custom array
			var customArr = new Array(1,3,5,7,9);
			var arr = new int[] {1, 3, 5, 7 };

			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("-----");
            foreach (var item in customArr)
            {
                Console.WriteLine(item);
            }
        }
	}
}