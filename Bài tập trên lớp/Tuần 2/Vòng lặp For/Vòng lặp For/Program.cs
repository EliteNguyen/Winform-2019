using System;

namespace Vòng_lặp_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vong lap for trong C#");
            Console.WriteLine("------------------------------------");

            // Sự thực thi vòng lặp for
            for(int a = 10; a < 20; a = a + 1)
            {
                Console.WriteLine("Gia tri cua a la: {0}", a);
            }
            Console.ReadLine();

            Console.ReadKey();
            
        }
    }
}
