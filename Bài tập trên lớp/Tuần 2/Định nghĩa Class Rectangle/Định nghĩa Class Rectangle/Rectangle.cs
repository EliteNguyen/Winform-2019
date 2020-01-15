using System;
using System.Collections.Generic;
using System.Text;

namespace Định_nghĩa_Class_Rectangle
{
    using System;
    using System.Collections.Generic;
    using System.Text;

        class Rectangle
        {
            //Các biến thành viên
            public double length;
            public double width;

            //Các phương thức
            public double GetArea()
            {
                return length * width;
            }

            public void Display()
            {
                Console.WriteLine("Chieu dai: {0}", length);
                Console.WriteLine("Chieu rong: {0}", width);
                Console.WriteLine("Dien tich: {0}", GetArea());
            }
        }
    

}
