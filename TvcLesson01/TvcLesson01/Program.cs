namespace TvcLesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AspNetCore MVC - UTC.K65CNT2.LTW");
            string choise;
            List<Student> students = new List<Student>()
            {
                new Student{masv="SV001",hoTen="Chung Trinh",email="chungtrinhj@gmail.com",soDienThoai="0978611889"},
                new Student{masv="SV002",hoTen="Chach Van Doanh",email="doanh@gmail.com",soDienThoai="0978611889"},
            };
            do
            {
                menu();
                Console.Write("Ban chon chuc nang:");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        // Them sinnh vien
                        ThemMoiSinhVien(students);  
                        break;
                    case "2":
                        // Hien thi
                        HienThiThongTin(students);
                        break;

                    case "14":
                        Console.WriteLine("Ban da ket thuc chuc nang");
                        break;
                    default:
                        Console.WriteLine("Ban chon sai chuc nang");
                        break;
                }

            } while (choise != "14");

        }

        static void menu()
        {
            Console.WriteLine("===========CHUC NANG===========");
            Console.WriteLine("1.\tThêm sinh viên.\r" +
                "\n2.\tHiển thị danh sách.\r" +
                "\n3.\tTìm sinh viên theo mã.\r" +
                "\n4.\tTìm gần đúng theo họ tên.\r" +
                "\n5.\tCập nhật sinh viên.\r" +
                "\n6.\tXóa sinh viên.\r" +
                "\n7.\tSắp xếp theo họ tên.\r" +
                "\n8.\tSắp xếp theo điểm trung bình.\r" +
                "\n9.\tHiển thị sinh viên có điểm từ 8 trở lên.\r" +
                "\n10.\tHiển thị sinh viên có điểm cao nhất.\r" +
                "\n11.\tTính điểm trung bình toàn bộ sinh viên.\r" +
                "\n12.\tThống kê sinh viên theo ngành.\r" +
                "\n13.\tThống kê sinh viên theo trạng thái.\r");

            Console.WriteLine("14.\tThoat ");
        }
        static void HienThiThongTin(List<Student> students)
        {
            Console.WriteLine("Danh sach sinh vien");
            foreach (var item in students)
            {
                Console.WriteLine("Mã sinh viên:" + item.masv);
                Console.WriteLine("Họ và tên:" + item.hoTen);
                Console.WriteLine("--------------------------");
            }
        }
        static void ThemMoiSinhVien(List<Student> students)
        {
            Console.WriteLine("Nhap thong tin sinh vien");
            Student student = new Student();
            Console.Write("Ma sv:");
            student.masv = Console.ReadLine();
            Console.Write("Tên sv:");
            student.hoTen = Console.ReadLine();

            /// ....
            /// 

            students.Add(student);

        }
    }
}
