using System;

namespace Lồng_lệnh_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Long lenh Switch");

            /* Khai báo biến cục bộ */
            int a = 100;
            int b = 200;

            switch (a)
            {
                case 100:
                    Console.WriteLine("Dong nay thuoc lenh Switch ben ngoai");
                    switch(b)
                    {
                        case 200:
                            Console.WriteLine("Dong nay thuoc lenh Switch ben trong");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Gia tri cua a la: {0}", a);
            Console.WriteLine("Gia tri cua a la: {0}", b);
            Console.ReadLine();

            Console.ReadKey();

        }
    }
}
