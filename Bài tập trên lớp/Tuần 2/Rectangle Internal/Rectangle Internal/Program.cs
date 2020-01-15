using System;

namespace Rectangle_Internal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dong goi trong C#");
            Console.WriteLine("--------------------------------");

            //Tạo đối tượng Rectangle
            Rectangle_Internal r = new Rectangle_Internal();


            //Thiết lập các thuộc tính
            r.length = 4.5;
            r.width = 3.5;

            //Gọi phương thức
            r.AcceptDetails();
            r.Display();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
