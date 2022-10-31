namespace OOP.AddAClass
{
    class Employee
    {

        private List<Employee> _list;

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }

        public List<Employee> Employees => _list;

        public Employee()
        {
            _list = new List<Employee>();   
        }

        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            _list = new List<Employee>();
        }

        public override string? ToString()
        {
            return $"{FirstName, -20} {LastName,-15} {Age,5}";
        }

        public void Add(Employee item)
        {
            _list.Add(item);
        }

        public void AddRange(params Employee[] employees)
        {
            _list.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _list;
    }
}