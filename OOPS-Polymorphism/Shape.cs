using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_Polymorphism
{
    class Shape
    {
      protected int Radius { set; get; }

      
      public Shape(int v)
        {
            Radius = v;
        }

      public virtual double Area()
        {
            return (3.14 * Radius * Radius);
        }
    }

    class Rectangle : Shape
    {
        int breadth;
        public int Breadth{
            get{return breadth;}
            set { breadth = value; }
        }
        public Rectangle(int l, int b) : base(l)
        {
            Breadth = b ;
        }
        public override double Area()
        {
            return (breadth * Radius);
        }
    }

    class Triangle : Shape
    {
        int height;
        public int Height
        {
            set { height = value; }
            get { return height;  }
        }
        public Triangle(int Base,int height):base(Base)
        {
            Height = height;
        }
        public override double Area()
        {
            return (.5 * Height * Radius);
        }
    }
}
