namespace OOP.Interfaces.IEnumerators
{
    class Program
    {
        static void Main()
        {
            var collection = new List<Product>()
            {
                new Product() { ProductId = 1 , ProductName="Buz Dolabı", ProductPrice=8500},
                new Product() { ProductId = 2 , ProductName="Televizyon", ProductPrice=5500},
                new Product() { ProductId = 3 , ProductName="Çamaşır Makinesi", ProductPrice=4500},
                new Product() { ProductId = 4 , ProductName="Bulaşık Makinesi", ProductPrice=6000},
            };

            foreach (var product in collection)
            {
                Console.WriteLine(product);
            }

            Console.WriteLine(new string('-',25));

            IEnumerator<Product> enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(
                    $"{enumerator.Current.ProductId} " +
                    $"{enumerator.Current.ProductName} " + 
                    $"{enumerator.Current.ProductPrice}");
            }
        }
    }
}