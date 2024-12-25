using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_session_2_demo.inheritance
{
    internal class Vechial
    {
        public string Type { get; set; }
        public int Id {  get; set; }

        public Vechial(string type, int id)
        {
            Type = type;
            Id = id;
        }

        public override string ToString()
        {
            return $"Vechial type is : {Type} \n Vechial id is : {Id}";
        }
    }
}
