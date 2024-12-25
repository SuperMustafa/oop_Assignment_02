using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_2_demo.inheritance
{
    internal class Type_B:Type_A

    {
        public int B { set; get; }  // this is property

        public Type_B(int _A,int _B):base(_A){
            B = _B;
        }

        public  void print_1()
        {
            Console.WriteLine("iam child");
            
        }
        public void print_2()
        {
            Console.WriteLine($"type B is :{B}");

        }


    }
}
