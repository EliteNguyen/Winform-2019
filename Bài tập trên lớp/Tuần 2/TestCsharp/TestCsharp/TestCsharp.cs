using System;
using System.Collections.Generic;
using System.Text;

namespace TestCsharp
{
    class TestCsharp
    {
        public int FindMax(int num1, int num2)
        {
            //Khai báo biến cục bộ
            int result;

            if (num1 > num2)
                result = num1;
            else
                result = num2;
            return result;
        }

        //Hàm chính
        static void Main(string[] args)
        {
            Console.WriteLine("Goi phuong thuc trong C#");
            Console.WriteLine("--------------------------------");

            //Định nghĩa biến cục bộ
            int a = 400;
            int b = 200;
            int ret;
            TestCsharp n = new TestCsharp();

            //Gọi phương thức FindMax
            ret = n.FindMax(a, b);
            Console.WriteLine("Gia tri max: {0}", ret);
            Console.ReadLine();
            
            Console.ReadKey();
        }

    }
}
