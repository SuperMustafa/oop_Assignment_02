using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_02
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        private char gender;
        public char Gender //property
        {
            get => gender;
            private set
            {
                if (value != 'M' && value != 'F')
                    throw new ArgumentException("Gender must be 'M' or 'F'.");
                gender = value;
            }
        }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public SecurityLevel SecurityLevel { get;  set; }

        public Employee(int id, string name, char gender, decimal salary, HireDate hireDate, SecurityLevel securityLevel)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name cannot be empty.");
            if (salary < 0)
                throw new ArgumentOutOfRangeException(nameof(salary), "Salary cannot be negative.");

            ID = id;
            Name = name;
            Gender = gender;
            Salary = salary;
            HireDate = hireDate ?? throw new ArgumentNullException(nameof(hireDate));
            SecurityLevel = securityLevel;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}, Hire Date: {HireDate}, Security Level: {SecurityLevel}";
        }
    }

}

