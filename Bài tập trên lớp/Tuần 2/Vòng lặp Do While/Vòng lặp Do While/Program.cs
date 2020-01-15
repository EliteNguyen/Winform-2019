using System;

namespace Vòng_lặp_Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vong lap While trong C#");
            Console.WriteLine("-------------------------------------");

            /* Định nghĩa biến cục bộ */
            int a = 10;

            /* Sự thực thi của vòng lặp While */
            while (a < 20)
            {
                Console.WriteLine("Gia tri cua a la: {0}", a);
                a++;
            }

            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
