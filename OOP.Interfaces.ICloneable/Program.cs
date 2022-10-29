namespace OOP.Interfaces.ICloneables
{
    class Program
    {
        static void Main()
        {
            var book1 = new Book()
            {
                Id = 1,
                Title= "Suç ve Ceza",
                Price = 25.5
            };
            var book2 = (Book)book1.Clone();
            book2.Id = 2;
            book2.Title = "Sefiller";
            book2.Price = 30;
            Console.WriteLine(book1.Id + " " + book1.Title);
            Console.WriteLine(book2.Id + " " + book2.Title);

            Console.ReadKey();
        }
    }
}