using System;

namespace Lab01
{
    class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;
        
        public Student () //Constructor mặc định 
        {
            SID = 1;
            TenSV = "Nguyen Van Nam";
            Khoa = "CNTT";
            DiemTB = 7;
        }

        public Student (Student stu) //Constructor sao chép
        {
            SID = stu.SID;
            TenSV = stu.TenSV;
            Khoa = stu.Khoa;
            DiemTB = stu.DiemTB;
        }

        public Student (int id, string ten, string kh, float dtb)
        {
            SID = id;
            TenSV = ten;
            Khoa = kh;
            DiemTB = dtb;
        }

        public int StudentID
        {
            get { return SID; }
            set { SID = value; }
        }

       public String Name
        {
            get { return TenSV; }
            set { TenSV = value; }
        }


       public String Falcuty
        {
            get { return Khoa; }
            set { Khoa = value; }
        }

        public float Mark
        {
            get { return DiemTB; }
            set { DiemTB = value; }
        }

        //Hiển thị dữ liệu
        public void Show ()
        {
            Console.WriteLine("MSSV: {0}", this.SID);
            Console.WriteLine("Ten sv: {0}", this.TenSV);
            Console.WriteLine("Khoa: {0}", this.Khoa);
            Console.WriteLine("Diem TB: {0}", this.DiemTB);
        }
    }

  

    //Lớp Tester
    class Tester
    {
        public static void Main()
        {
            Student[] DSSV;
            int n;
            Console.Write("Nhap so luong sv:");
            n = int.Parse(Console.ReadLine());

            //Tạo mảng n phần tử
            DSSV = new Student[n];

            Console.WriteLine("\n ====== Nhap DS Sinh Vien ========");
            for (int i = 0; i < n; i++) //Lập n lần thông tin sinh viên
            {
                DSSV[i] = new Student();
                Console.Write("Nhap MaSV {0}: ", i + 1);
                DSSV[i].StudentID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten sv:");
                DSSV[i].Name = Console.ReadLine();
                Console.Write("Nhap khoa:");
                DSSV[i].Falcuty = Console.ReadLine();
                Console.Write("Nhap diem tb:");
                DSSV[i].Mark = float.Parse(Console.ReadLine());
            }

            //Xuất danh sách nhân viên
            Console.WriteLine("\n ==== Xuat DS Sinh Vien ======");
            foreach (Student sv in DSSV)
                sv.Show();

            Console.ReadLine();
        }
    }
}
