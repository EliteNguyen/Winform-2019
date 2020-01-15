using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Lệnh xuất ra màn hình console */
            Console.WriteLine("Lenh if trong C#");
            Console.WriteLine("--------------------------------------------");

            /* Phần định nghĩa biến cục bộ */
            int a = 10;

            /* Kiểm tra điều kiện biểu thức trong lệnh if */
            if(a < 20)
            {
                /* Nếu điều kiện là true thì sẽ in ra dòng sau: */
                Console.WriteLine("a nho hon 20");
            }

            Console.WriteLine("Gia tri cua a la: {0}", a);
            Console.ReadLine(); /* Y chang */

            Console.ReadKey(); /* Giữ nguyên màn hình console để xem, mất lệnh này console tự tắt */
        }
    }
}
