using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Tester
    {
        static void Main(string[] args)
        {
            Student[] DSSV;             //Mảng sinh viên
            int n;                      //Số lượng sinh viên
            Console.Write("Nhap so luong SV:");
            n = int.Parse(Console.ReadLine());

            //Tạo mảng n phần tử
            DSSV = new Student[n];

            Console.WriteLine("\n============ Nhap DSSV ==================");
            for(int i=0; i<n; i++)
            {
                DSSV[i] = new Student();
                Console.Write("\nNhap MSSV {0}: ", i + 1);
                DSSV[i].StudentID = Console.ReadLine();
                Console.Write("ho ten sv: ");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap khoa:");
                DSSV[i].Falcuty = Console.ReadLine();
                Console.Write("Nhap diem tb: ");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }

            //Xuất danh sách sinh viên
            Console.WriteLine("\n =========== Xuat danh sach sinh vien ===========");
            foreach (Student sv in DSSV)
                sv.show();
            Console.ReadLine();
        }
    }
}
