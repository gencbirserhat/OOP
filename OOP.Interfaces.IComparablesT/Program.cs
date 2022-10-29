namespace OOP.Interfaces.IComparablesT
{
    class Program
    {
        static void Main()
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id = 1,
                    FullName = "Hünkar Acar",
                    Salary= 1000000
                },
                new Employee()
                {
                    Id= 2,
                    FullName = "Serhat Genç",
                    Salary = 500

                },
                new Employee()
                {
                    Id= 3,
                    FullName = "Merve Dağ",
                    Salary = 30000

                },
                new Employee()
                {
                    Id= 4,
                    FullName = "Yağız İpek",
                    Salary = 7000

                },
                new Employee()
                {
                    Id= 5,
                    FullName = "Azna Taşçı",
                    Salary = 5500

                },
                new Employee()
                {
                    Id= 6,
                    FullName = "Mehmet Taşçı",
                    Salary = 15500

                }

            };
            employees.Sort();

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}