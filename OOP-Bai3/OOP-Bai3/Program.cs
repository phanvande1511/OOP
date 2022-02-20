using System;

namespace OOPBai3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Triangle triangle1 = new Triangle();
            triangle1.setA(0);
            triangle1.setB(3);
            triangle1.setC(3);
            triangle1.Temp();
            triangle1.perimeterOfTriangle();
            triangle1.triangleOfAcreage();

            Triangle triangle2 = new Triangle();
            triangle2.setA(1);
            triangle2.setB(-9);
            triangle2.setC(3);
            triangle2.Temp();
            triangle2.perimeterOfTriangle();
            triangle2.triangleOfAcreage();

            Triangle triangle3 = new Triangle();
            triangle3.setA(3);
            triangle3.setB(4);
            triangle3.setC(6);
            triangle3.Temp();
            triangle3.perimeterOfTriangle();
            triangle3.triangleOfAcreage();

            Triangle triangle4 = new Triangle();
            triangle4.setA(4);
            triangle4.setB(4);
            triangle4.setC(6);
            triangle4.Temp();
            triangle4.perimeterOfTriangle();
            triangle4.triangleOfAcreage();

            Triangle triangle5 = new Triangle();
            triangle5.setA(7);
            triangle5.setB(7);
            triangle5.setC(7);
            triangle5.Temp();
            triangle5.perimeterOfTriangle();
            triangle5.triangleOfAcreage();

            menu();
            Console.WriteLine();
            triangle1.outPut();
            triangle2.outPut();
            triangle3.outPut();
            triangle4.outPut();
            triangle5.outPut();
        }

        // in bang thong tin
        static void menu()
        {
            String st = String.Format(" {0} ", centeredString(" A ", 5))
              + String.Format("{0}", centeredString(" B ", 5))
              + String.Format("{0}", centeredString(" C ", 5))
              + String.Format("{0}", centeredString(" Triangle ", 40))
              + String.Format("{0}", centeredString(" Perimeter ", 10))
              + String.Format("{0}", centeredString(" Acreage ", 10));

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
