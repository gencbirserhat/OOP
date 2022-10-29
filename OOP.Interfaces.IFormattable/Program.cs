namespace OOP.Interfaces.IFormattables
{
    class Program
    {
        static void Main()
        {
            var list = new List<Employee>()
    {
        new Employee()

        {
            Id = 1,
            Title = "Prof. Dr.",
            FirstName = "Zafer",
            LastName = "Cömert"
        },
        new Employee()
        {
            Id = 2,
            Title = "Prof. Dr.",
            FirstName = "Engin",
            LastName = "Demiroğ"
        },
        new Employee()
        {
            Id = 3,
            Title = "Doç. Dr.",
            FirstName = "Murat",
            LastName = "Yücedağ"
        },
        new Employee()
        {
            Id = 4,
            Title = "Dr.",
            FirstName = "Serhat",
            LastName = "Genç"
        },
    };

            foreach (var emp in list)
            {
                Console.WriteLine(emp.ToString("F"));
            }
            Console.ReadKey();
            Console.WriteLine("It's Worked...");

        }

    }
}



