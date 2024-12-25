using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_2_demo.inheritance
{
    internal class Plane:Vechial
    {
        public float Speed { get; set; }

        public Plane(string type, int id, float speed):base(type,id )
        {
            Speed = speed;
        }




    }
}
