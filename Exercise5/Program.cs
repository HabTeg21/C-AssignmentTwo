using System;

namespace Exercise5
{
    class Box
    {
        double length, breadth, height;
        public double getVolume()
        {
            return length * breadth * height;
        }
        public void setLength(double len)
        {
            length = len;
        }

        public void setBreadth(double bre)
        {
            breadth = bre;
        }

        public void setHeight(double hei)
        {
            height = hei;
        }
       
    }
    class Program
    {

        static void Main(string[] args)
        {
            Box Box1 = new Box();
            Box1.setBreadth(4);
            Box1.setHeight(5);
            Box1.setLength(6);
            Console.WriteLine("Volume of Box1 : " +Box1.getVolume());
            Box Box2 = new Box();
            Box2.setBreadth(7);
            Box2.setHeight(8);
            Box2.setLength(9);
            Console.WriteLine("Volume of Box2 : " + Box2.getVolume());
            Box Box3 = new Box();
            Box3.setBreadth(5);
            Box3.setHeight(11);
            Box3.setLength(3.5);
            Console.WriteLine("Volume of Box3 : " + Box3.getVolume());

        }
    }
}
