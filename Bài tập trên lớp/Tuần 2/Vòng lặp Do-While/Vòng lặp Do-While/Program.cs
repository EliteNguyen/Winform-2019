using System;

namespace Vòng_lặp_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vong lap do while");
            Console.WriteLine("----------------------------------");

            // Định nghĩa biến cục bộ
            int a = 10;

            // Thực thi vòng lặp Do-While
            do
            {
                Console.WriteLine("Gia tri cua a la: {0}", a);
                a = a + 1;
            }
            while (a < 20);
            Console.ReadLine();

            Console.ReadKey(); 
        }
    }
}
