using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Bài_1b
{
    class Tester
    {
        static void Main(string[] args)
        {
            // Student[] DSSV;             //Mảng sinh viên
            int n;                      //Số lượng sinh viên
            Console.Write("Nhap so luong SV: ");
            n = int.Parse(Console.ReadLine());
           
            //Khởi tạo list
            List<Student> DSSV = new List<Student>();

            //Nhập danh sách
            for(int i = 0; i < n; i++)
            {
                Console.Write("\nNhap thong tin sinh vien thu {0}", i+1);
                Student st = new Student(); //Khởi tạo đối tượng sinh viên
                st.NhapSv();
                DSSV.Add(st);
            }

            //Xuất danh sách sinh viên
            Console.WriteLine("\n ===================== Danh sach sinh vien vua nhap: ================================");
            foreach(Student st in DSSV)
            {
                st.show();
            }

            //Console.ReadLine();
            //Xuất danh sách sinh viên có theo DTB thứ tự tăng dần
            Console.WriteLine("\n Danh sach sinh vien khoa co DTB tang dan: ");
            foreach (Student st in DSSV)
            {              
                st.CompareTo(st);
                st.show();
            }
            //Xuất xinh viên khoa CNTT
            Console.WriteLine("\n Danh sach sinh vien khoa CNTT: ");
            foreach (Student st in DSSV)
            {
                if (st.Falcuty == "CNTT")
                {
                    st.show();
                }
            }

            Console.ReadLine();

            //Tạo mảng n phần tử
            // DSSV = new Student[n];

            //Nhập từng sinh viên
            /*Console.WriteLine("\n============ Nhap DSSV ==================");
            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNhap thong tin sinh vien thu {0} ", i + 1);
                DSSV[i] = new Student();
                DSSV[i].NhapSv();
            }

            //Xuất danh sách sinh viên
            Console.WriteLine("\n================= Xuat danh sach ==============");
            foreach (Student sv in DSSV)
                sv.show();
            Console.ReadLine();

            Console.ReadKey();
            Console.ReadLine(); */
        }
    }
}
