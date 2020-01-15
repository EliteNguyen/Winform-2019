using System;

namespace Lồng_lệnh_If
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Long lenh if trong C#");
            Console.WriteLine("---------------------------------------");

            /* Định nghĩa biến cục bộ */
            int a = 100;
            int b = 200;

            /*Kiểm tra điều kiện */
            if(a == 100)
            {
                /* Nếu điều kiện là True thì in ra dòng sau */
                if (b == 200)
                {
                    /* Nếu điều kiện là True thì in ra dòng sau: */
                    Console.WriteLine("Gia tri cua a la 100 va b la 200");
                }
            }

            Console.WriteLine("Gia tri cua a la: {0}", a);
            Console.WriteLine("Gia tri cua a la: {0}", b);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
