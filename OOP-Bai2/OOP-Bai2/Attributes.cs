using System;
using System.Collections.Generic;
using System.Text;

namespace OOPBai2
{
    public class Attributes
    {
        private int studentCode;
        private string name;
        private double theoreticalPoint;
        private double practicePoint;
        private double mediumPoint;

        public Attributes()
        {
        }

        public Attributes(int studentCode, string name, double theoreticalPoint, double praticePoint, double mediumPoint)
        {
            setStudentCode(studentCode);
            setName(name);
            setTheoreticalPoint(theoreticalPoint);
            setPraticePoint(praticePoint);
            getMedium();
        }

        //setter
        public void setStudentCode(int studentCode)
        {
            this.studentCode = studentCode;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setTheoreticalPoint(double theoreticalPoint)
        {
            this.theoreticalPoint = theoreticalPoint;
        }

        public void setPraticePoint(double practicePoint)
        {
            this.practicePoint = practicePoint;
        }

        //getter
        public double getMedium()
        {
            return mediumPoint =  ((theoreticalPoint + practicePoint) / 2);
        }

        public int getStudentCode()
        {
            return studentCode;
        }

        public string getName()
        {
            return name;
        }

        public double getTheoreticalPoint()
        {
            return theoreticalPoint;
        }

        public double getPraticePoint()
        {
            return practicePoint;
        }

        //ToString
        public override string ToString()
        {
            return $"{this.studentCode} {this.name} {this.theoreticalPoint} {this.practicePoint} {this.mediumPoint}"; 
        }

        public void outPut()// xuat thong tin
        {
            String st = String.Format(" {0} ", centeredString($"{studentCode}", 20))
          + String.Format("{0}", centeredString($"{name}", 20))
          + String.Format("{0}", centeredString($"{theoreticalPoint}", 20))
          + String.Format("{0}", centeredString($"{practicePoint}", 20))
          + String.Format("{0}", centeredString($"{mediumPoint}", 20));

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
        }// ham cach deu
    }
}