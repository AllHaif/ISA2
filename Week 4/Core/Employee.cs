using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Cache;
using System.Threading.Tasks;

namespace Core
{
    public class Employee
    {
        private const string requiredField = "Required field!";
        private const string lengthIsTooBig = "Length should be less than 20 characters!";
        public Employee()
        {
        }

        public Employee(string firstName, string lastname = null, int salary = 0)
        {
            FirstName = firstName?? string.Empty;
            LastName = lastname?? string.Empty;
            Salary = salary;
        }
        public int EmployeeID { get; set; }
        [NameValidation]
        public string FirstName { get; set; }
        [NameValidation]
        public string LastName { get; set; }
        [SalaryValidation]
        public int Salary { get; set; }
    }
}
