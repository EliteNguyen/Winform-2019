using System;

namespace Rectangle_Private
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tinh dong goi trong C#");
            Console.WriteLine("---------------------------------");
            
            //Tạo đối tượng Rectangle
            Rectangle_with_Private r = new Rectangle_with_Private();

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
