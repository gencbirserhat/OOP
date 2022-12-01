namespace OOP.aExam
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Employee> Employees { get; set; }

        private string? fullName;
        

        public Employee(int ıd, string firstName, string lastName, int salary) 
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            fullName = firstName + " " + lastName;
            Console.WriteLine(fullName+" "+ salary);
            
        }
        public Employee()
        {

        }

        public int Salary { get; set; }

    }
}