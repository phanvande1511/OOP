using System;

namespace OOPBai2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter Student Code For Student 3: ");
            int studentCode = int.Parse(Console.ReadLine());
            Console.Write("Enter Name For Student 3: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter Theoretical Point For Student 3: ");
            double theoreticalPoint = double.Parse(Console.ReadLine());
            Console.Write("Enter Pratice Point For Student 3: ");
            double praticePoint = double.Parse(Console.ReadLine());

            //Thong tin sinh vien 1
            Attributes student1 = new Attributes();
            student1.setStudentCode(1);
            student1.setName("Phan Van De");
            student1.setTheoreticalPoint(6);
            student1.setPraticePoint(7);
            student1.getMedium();

            //Thong tin sinh vien 2
            Attributes student2 = new Attributes();
            student2.setStudentCode(2);
            student2.setName("Nguyen Van B");
            student2.setTheoreticalPoint(7);
            student2.setPraticePoint(8);
            student2.getMedium();

            Attributes student3 = new Attributes();

            student3.setStudentCode(studentCode);
            student3.setName(studentName);
            student3.setTheoreticalPoint(theoreticalPoint);
            student3.setPraticePoint(praticePoint);
            student3.getMedium();

            Console.WriteLine();
            Console.WriteLine();

            menu();
            student1.outPut();
            student2.outPut();
            student3.outPut();


        }

        static void menu()// in bang thong tin
        {
            String st = String.Format("{0}", centeredString(" Student Code ", 20))
              + String.Format("{0}", centeredString(" Name ", 20))
              + String.Format("{0}", centeredString(" Theoretical Score ", 20))
              + String.Format("{0}", centeredString(" Practice Score ", 20))
              + String.Format("{0}", centeredString(" Medium Score ", 20));

            Console.WriteLine(st);
        }

        static string centeredString(string s, int width)
        {
            if (s.Length >= width)
            {
                return s;
            }

            int leftPadding = (width - s.Length) / 2;
            int rightPadding = width - s.Length - leftPadding;

            return new string(' ', leftPadding) + s + new string(' ', rightPadding);
        }
    }
}
