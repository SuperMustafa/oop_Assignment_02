using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_2_demo.inheritance
{
    internal class Type_A
    {
        public int A { get; set; }

        public Type_A(int _A) {

            A = _A;
        }

        public void print_1()
        {
            Console.WriteLine("parent print");
        }

        public void print_2()
        {
            Console.WriteLine($"Type a is : {A}");
        }



    }
}
