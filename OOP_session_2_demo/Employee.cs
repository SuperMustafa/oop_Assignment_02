using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_2_demo
{
    internal class Employee
    {
        public int Id;
        public string FName;
        public decimal salary { get; set; }

        public Employee(int _Id, string _FName, decimal _Salary)
        {
            Id = _Id;
            FName = _FName;
            salary = _Salary;

        }

        public string GetName()
        {
            return FName;
        }

        public void SetName(string value)
        {
          FName = value;
        }


        //this is Full property
        //public decimal Salary
        //{
        //    get
        //    {
        //        return salary;
        //    }
        //    set
        //    {
        //        salary = value;
        //    }
        //}

        //this is automatic property


        public override string ToString()
        {
            return $"Employee Id is :{Id}\n Employee Name is:{FName}\n Employee Salary is:{salary}";
        }
    }


}
