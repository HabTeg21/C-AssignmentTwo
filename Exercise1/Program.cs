using System;

namespace Exercise1
{
    class Rectangle
    {
        double length = 1;
        double width = 1;
        public void GetData()
        {
            again:
            Console.WriteLine("Enter length:");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter width:");
            width = Convert.ToInt32(Console.ReadLine());
            if (length < 0 || length > 20 || width < 0 || width > 20)
            {
                Console.WriteLine("Please enter length and width between 0 and 20");
                goto again;
            }
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetPerimeter()
        {
            return 2 * (length + width);
        }
        public void Display()
        {
            Console.WriteLine("The area of the rectangle is " + GetArea());
            Console.WriteLine("The perimeter of the rectangle is " + GetPerimeter());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.GetData();
            rect.Display();
            //Console.ReadLine();
           
        }
    }
}
