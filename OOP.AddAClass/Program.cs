namespace OOP.AddAClass
{
    class Program
    {
        static void Main()
        {
            var employee= new Employee();
            var _record = new Employee( "Ahmet", "Yılmaz",  43 );
            employee.Add(_record);
            
            employee.AddRange(
                new Employee("Merve", "Aslan", 22),
                new Employee("Sero", "Aslan", 25),
                new Employee("Muhittim", "Aslan", 52),
                new Employee("Bejo", "Aslan", 32));
            var list = employee.GetEmployees();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}