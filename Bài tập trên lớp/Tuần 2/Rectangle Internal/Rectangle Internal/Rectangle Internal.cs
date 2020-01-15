using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle_Internal
{
    class Rectangle_Internal
    {
        //Các biến thành viên
        internal double length;
        internal double width;

        //Các phương thức
        public void AcceptDetails()
        {
            Console.WriteLine("Nhap chieu dai: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            width = Convert.ToDouble(Console.ReadLine());

        }

        public double GetArea()
        {
            return length * width;
        }

        public void Display()
        {
            Console.WriteLine("Chieu dai: {0}, chieu rong: {1}", length, width);
            Console.WriteLine("Dien tich: {0}", GetArea());
        }
    }
}
