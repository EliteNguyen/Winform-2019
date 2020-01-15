using System;

namespace Lệnh_If_ELse
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lệnh if else trong C#");
            Console.WriteLine("---------------------------------------");

            /* Phần định nghĩa biến cục bộ */
            int a = 1;

            /* Kiểm tra điều kiện */
            if(a > 20)
            {
                /* Nếu điều kiện là True thì in dòng sau: */
                Console.WriteLine("a lon hon 20");
            }
            else
            {
                /* Nếu điều kiện là False thì in dòng sau: */
                Console.WriteLine("a nho hon 20");
            }

            Console.WriteLine("Gia tri cua a la: {0}", a);
            Console.ReadLine();

            Console.ReadKey();
       
        }
    }
}
