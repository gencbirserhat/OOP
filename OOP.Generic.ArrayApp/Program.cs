using System.Collections;

namespace OOP.Generics.ArrayApp
{
    class Program
    {
        static void Main()
        {
            // Array<T> kullanarak yaptığımız liste;
            var arr = new Array<string>("S", "O", "L", "I", "D", "KEY");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(new string('-', 25));

            // ArrayList kullanarak yaptığımız liste;
            var arrayList = new List<int>();
            arrayList.Add('s');
            arrayList.Add(2);
            //arrayList.Add(true);
            //arrayList.Add(DateTime.Now.ToString("dddd"));

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(arrayList[0] * 10);
        }
        // LinkedList kullanarak yaptığımız liste => yukarıda fonksiyon çağırılabilir.
        private static void LinkedListMethod()
        {
            var list = new LinkedList<Book>();
            list.AddLast(new Book(1, "Sefiller", 30));
            list.AddLast(new Book(2, "Çalıkuşu", 25));
            list.AddLast(new Book(3, "Mai ve Siyah", 50));
            list.AddLast(new Book(4, "Açlık Oyunları", 40));


            foreach (var arr in list)
            {

                Console.WriteLine(arr);


            }
        }
    }
}