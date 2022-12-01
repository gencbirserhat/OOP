using Exam;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Exam
{
    public class InMemoryDB : Employee
    {
        public InMemoryDB(int ıd, string firstName, string lastName, int salary) : base(ıd, firstName, lastName, salary)
        {
            var employees = new List<Employee>()
            {
                new Employee()
                {
                    Id=1,
                    FirstName= "Ahmet",
                    LastName = "Can",
                    Salary = 8000

                },
                new Employee()
                {
                    Id=1,
                    FirstName= "Ali",
                    LastName = "Dağ",
                    Salary = 2000
                },
                new Employee()
                {
                    Id=1,
                    FirstName= "Oya",
                    LastName = "Dere",
                    Salary = 12000
                },
                new Employee()
                {
                    Id=1,
                    FirstName= "Can",
                    LastName = "Tepe",
                    Salary = 16000
                },
                new Employee()
                {
                    Id=1,
                    FirstName= "Efe",
                    LastName = "Güneş",
                    Salary = 8000
                },
                new Employee()
                {
                    Id=1,
                    FirstName= "Alp",
                    LastName = "Ay",
                    Salary = 22000
                }
            };
        }
    }
}
