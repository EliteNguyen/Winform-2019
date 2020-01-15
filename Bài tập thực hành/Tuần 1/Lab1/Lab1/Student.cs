using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Student
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
            studentID = "1711061918";
            name = "Nguyen Le Hoang Dinh";
            faculty = "Information Technology";
            mark = 10;
        }

        //Constructor tham số
        public Student(string id, string ten, string khoa, float dtb)
        {
            studentID = id;
            name = ten;
            faculty = khoa;
            mark = dtb;
        }

        //Phương thức hiển thị dữ liệu
        public void show()
        {
            Console.WriteLine("\nMSSV {0}", this.studentID);
            Console.WriteLine("Ten sv: {0}", this.name);
            Console.WriteLine("Khoa: {0}", this.faculty);
            Console.WriteLine("Diem tb: {0}", this.mark);
        }
    }
}
