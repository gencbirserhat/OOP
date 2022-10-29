using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Interfaces.IComparablesT
{
    public class Employee: IComparable<Employee>
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public decimal Salary { get; set; }

        public int CompareTo(Employee? other)
        {
            //return this.Salary.CompareTo(other?.Salary);
            if (this.Salary < other?.Salary)
            {
                return 1;
                
            }
            else if (this.Salary.Equals(other?.Salary))
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"{Id,-5}{FullName,-25}{Salary,-7}";
        }
    }

}
