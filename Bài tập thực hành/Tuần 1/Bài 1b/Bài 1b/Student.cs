using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Bài_1b
{
    public class Student : IComparable
    {
        //Tạo thuộc tính
        private string studentID;       //Mã sinh viên
        private string name;            //Tên
        private float mark;             //Điểm trung bình
        private string faculty;         //Khoa

        //Tạo property
        public string StudentID
        {
            get
            {
                return studentID;
            }

            set
            {
                studentID = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public float Mark
        {
            get
            {
                return mark;
            }

            set
            {
                mark = value;
            }
        }

        public string Falcuty
        {
            get
            {
                return faculty;
            }

            set
            {
                faculty = value;
            }
        }

        //Tạo constructor mặc định
        public Student()
        {

        }

        //Constructor tham số
        public Student(string id, string ten, string khoa, float dtb)
        {
            studentID = id;
            name = ten;
            faculty = khoa;
            mark = dtb;
        }

        //Nhập thông tin sinh viên
        public void NhapSv()
        {
            Console.Write("\nNhap MSSV: ");
            studentID = Console.ReadLine();
            Console.Write("ho ten sv: ");
            name = Console.ReadLine();
            Console.Write("Nhap khoa: ");
            faculty = Console.ReadLine();
            Console.Write("Nhap diem tb: ");
            mark = float.Parse(Console.ReadLine());
        }

        //Phương thức hiển thị dữ liệu
        public void show()
        {
            Console.WriteLine("\nMSSV {0}", this.studentID);
            Console.WriteLine("Ten sv: {0}", this.name);
            Console.WriteLine("Khoa: {0}", this.faculty);
            Console.WriteLine("Diem tb: {0}", this.mark);
        }

        //So sánh
        public int CompareTo(Object obj)
        {
            int iCompare = Convert.ToInt32(this.mark - (obj as Student).mark);
            return iCompare;
        }

    }
}
