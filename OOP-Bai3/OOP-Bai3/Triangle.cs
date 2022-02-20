using System;
using System.IO;

namespace OOPBai3
{
    public class Triangle
    {
        private double a;//Canh A    
        private double b;//Canh B
        private double c;//Canh C
        private double perimeter;//Chu vi tam giac
        private double temp;//Bien tam
        private double acreage;//Dien tich tam giac
        

        public Triangle()
        {
        }

        public Triangle(double a, double b, double c, double perimeter, double acreage)
        {
            setA(a);
            setB(b);
            setC(c);
            check();
            perimeterOfTriangle();
            triangleOfAcreage();
        }

        //setter
        public void setA(double a)
        {
            this.a = a;
        }

        public void setB(double b)
        {
            this.b = b;
        }

        public void setC(double c)
        {
            this.c = c;
        }

        //getter
        public double getA()
        {
            return a;
        }

        public double getB()
        {
            return b;
        }

        public double getC()
        {
            return c;
        }

        //Bien tam
        public double Temp()
        {
            return temp = ((perimeter / 2) * ((perimeter / 2) - a) * ((perimeter / 2) - b) * ((perimeter / 2) - c));
        }

        //Chu vi tam giac
        public double perimeterOfTriangle()
        {
            return perimeter = (a + b + c);
        }

        //Dien tich tam giac
        public double triangleOfAcreage()
        {
            return acreage = Math.Sqrt(Temp());
        }

        //Xet tam giac
        public string check()
        {
            string st;
            if(a <= 0 || b <= 0 || c <= 0)
            {
                st = "This is not a triangle";
                perimeter = 0;
                acreage = 0;
            } else if((a == b && a != c) || (a == c && a != b) || (c == b && a != c))
            {
                st = "This is an isosceles triangle";
            } else if(a == b && b == c)
            {
                st = "This is an equilateral triangle";
            } else if((b < c + a))
            {
                st = "This is an ordinary triangle";
            } else
            {
                st = "This is not a triangle";
                perimeter = 0;
                acreage = 0;
            }
            return st;
        }

        //ToString
        public override string ToString()
        {
            return $"{this.a} {this.b} {this.c} {check()} {this.perimeter} {this.acreage, 0:0.00}";
        }

        // in bang thong tin
        public void outPut()
        {
            String st = String.Format(" {0} ", centeredString($"{a}", 5))
          + String.Format("{0}", centeredString($"{b}", 5))
          + String.Format("{0}", centeredString($"{c}", 5))
          + String.Format("{0}", centeredString($"{check()}", 40))
          + String.Format("{0}", centeredString($"{perimeter}", 10))
          + String.Format("{0}", centeredString($"{acreage, 0:0.00}", 10));

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
