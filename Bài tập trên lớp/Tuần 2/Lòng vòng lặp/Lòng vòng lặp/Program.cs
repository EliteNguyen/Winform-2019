using System;

namespace Lòng_vòng_lặp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("long vong lap trong C#");
            Console.WriteLine("Tim so nguyen to trong C#"); ;
            Console.WriteLine("---------------------------------------");

            // Định nghĩa biến cục bộ
            int i, j;
            for (i = 2; i < 100; i++)
            {
                for (j = 2; j <= (i/j); j++)
                    if ((i % j) == 0) break; // Nếu tìm thấy ước số thì không phải là sớ nguyên tố 
                if (j > (i / j))
                    Console.WriteLine("{0} la so nguyen to", i);

            }

            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
