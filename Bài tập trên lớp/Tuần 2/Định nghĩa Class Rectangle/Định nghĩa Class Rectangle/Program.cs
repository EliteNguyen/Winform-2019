using System;

namespace Định_nghĩa_Class_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dong goi trong C#");
            Console.WriteLine("---------------------------------");

            //Tạo đối tượng Rectangle
            Rectangle r = new Rectangle();

            //Thiết lập các thuộc tính
            r.length = 4.5;
            r.width = 3.5;

            //Gọi phương thức
            r.Display();
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
