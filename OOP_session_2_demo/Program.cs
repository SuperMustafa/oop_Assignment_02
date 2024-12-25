using System.Security.AccessControl;
using OOP_session_2_demo.inheritance;

namespace OOP_session_2_demo
{
    internal class Program
    {
        static void sum(double x, int y)

        {
            Console.WriteLine(x + y);
        }
        static void sum(int x,double y)

        {
            Console.WriteLine(y + x );
        }
        static void Main(string[] args)
        {

            #region Encapsulation
            //Encapsulation is seperate attribute defenition from where we use it 
            //Encapsulation ways:
            //1- Getter / Setter
            //2- Property
            //3- indexer

            //Employee Emp = new Employee(01, "Mustafa", 15000);
            //Console.WriteLine(Emp);

            //Emp.FName = "hany";
            //Console.WriteLine(Emp);
            #region Getter/Setter
            //Employee Emp = new Employee(01, "Mustafa", 15000);
            //Console.WriteLine(Emp.GetName()); 
            //Emp.SetName("Rewan");
            //Console.WriteLine(Emp.GetName());



            #endregion

            #region Poperty
            //Employee Emp = new Employee(01, "Mustafa", 15000);
            //Console.WriteLine(Emp.salary);
            //Emp.salary = 1000;
            ////Console.WriteLine(Emp.salary);
            //Console.WriteLine(Emp.salary); 

            #endregion
            #region indexer
            //Contacts C1 = new Contacts(3);
            //C1.AddContact("Mustafa", 01019540969, 0);
            //C1.AddContact("Rewan", 010195330969, 1);
            //C1.AddContact("Noha", 010133330969, 2);

            //C1["Mustafa"] = 111;  // indexer use it here as set function
            //Console.WriteLine(C1["Mustafa"]); // indexer her is a get function 


            #endregion


            #endregion
            #region class
            //Car bmw = new Car();
            //string info = bmw.ToString();
            //Console.WriteLine(info);
            #endregion
            #region inheritance [relation called is a]
            //Vechial v1 = new Vechial("car",01);
            //Console.WriteLine(v1.ToString());
            //Plane p = new Plane("Fly emerats",02,1000);
            //Console.WriteLine(p.ToString());

            #endregion
            #region Association [composition/agregiation]{relation called has a}
            #endregion
            #region Access modifiers
            // 1-  protected
            //Accessible within the class and by derived classes.
            //Cannot be accessed from outside the class or derived classes.

            // protected internal
            //A combination of protected and internal.
            //Accessible within the same assembly and from derived classes in other assemblies.

            //private protected (C# 7.2 and later)
            //A combination of private and protected.
            //Accessible within the same class and by derived classes, but only if they are in the same assembly.
            #endregion
            #region Polymorphism
            #region overLoading

            //case 1
            //=================overloading by change number of parameters===============
            //static void sum(int x, int y)

            //{
            //    Console.WriteLine(x + y);
            //}
            //static void sum(int x, int y, int z)

            //{
            //    Console.WriteLine(x + y + z);
            //}
            //Program.sum(1, 2);

            //case 2
            //=================overloading by change data type of parameters===============
            //static void sum(int x, int y)

            //{
            //    Console.WriteLine(x + y);
            //}
            //static void sum(double x, int y, int z)

            //{
            //    Console.WriteLine(x + y + z);
            //}


            //case 2
            //=================overloading by change order of parameters===============
            //static void sum(int x, double y)

            //{
            //    Console.WriteLine(x + y);
            //}
            //static void sum( double y,int x)

            //{
            //    Console.WriteLine(x + y);
            //}
            #endregion
            #region overriding
            // only happens with inheritance cases like we override method like to string

            //Type_A obj = new Type_A(2);
            //obj.print_2();
            //obj.A = 10;
            //obj.print_2();
            Type_B type_b = new Type_B(2,3);
            type_b.print_1();
            type_b.B = 22;
            type_b.print_2();


            #endregion
            #endregion
        }
    }
}
