using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Polymorphism
{
    class ShapeTester
    {
        static void Main(string[] args)
        {
            Shape S1 = new Shape(4);
            Console.WriteLine(S1.Area());

            Triangle T1 = new Triangle(23, 4);
            Console.WriteLine(T1.Area());

            Rectangle R1 = new Rectangle(10, 12);
            Console.WriteLine(R1.Area());


            S1 = (Triangle)T1;//cheching type campatabality

            Console.WriteLine(S1.Area());

         
        }
    }
}
