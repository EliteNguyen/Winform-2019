using System;

namespace Câu_lệnh_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lenh Switch trong C#");
            Console.WriteLine("---------------------------------------");

            /* Phần định nghĩa biến cục bộ */
            char grade = 'a';

            switch(grade)
            {
                case 'a':
                    Console.WriteLine("Xuat sac");
                    break;

                case 'b':
                    Console.WriteLine("Gioi");
                    break;

                case 'c':
                    Console.WriteLine("Kha");
                    break;

                case 'd':
                    Console.WriteLine("Trung binh");
                    break;

                case 'e':
                    Console.WriteLine("Yeu");
                    break;

                default:
                    Console.WriteLine("Gia tri khong hop le");
                    break;
            }
            
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
