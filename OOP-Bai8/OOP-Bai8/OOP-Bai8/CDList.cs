using System;
using System.Collections;
using System.Text;

namespace OOPBai8
{
    public class CDList : CD
    {
        private int temp;
        private int kichThuoc;
        private int ma;
        private string ten;
        private int soBh;
        private double gia;

        public CD[] cDs = null;

        public void taoDS()
        {
            Console.Write("Nhap so luong CD : ");
            temp = int.Parse(Console.ReadLine());

            cDs = new CD[temp];
            for (int i = 0; i < temp; i++)
            {
                Console.WriteLine("CD thu " + (i + 1) + ": ");
                cDs[i] = new CD();
                menu(cDs[i]);
                print(cDs[i]);
            }
        }

        //add
        public void add()
        {
            print(cDs[0]);
        }

        //setter
        public void setMa(int ma)
        {
            this.ma = ma;   
        }

        public void setTen(string ten)
        {
            this.ten = ten;
        }

        public void setSoBh(int soBh)
        {
            this.soBh = soBh;
        }

        public void setGiaCD(int gia)
        {
            this.gia = gia;
        }

        public void setKichThuoc(int kichThuoc)
        {
            this.kichThuoc = kichThuoc;
        }

        //getter
        public int getMa()
        {
            return ma;
        }

        public string getTen()
        {
            return ten;
        }

        public int getSoBh()
        {
            return soBh;
        }

        public double getGiaCD()
        {
            return gia;
        }

        public int getTemp(int temp)
        {
            return temp;
        }

        public int getKichThuoc()
        {
            return kichThuoc;
        }

        //menu
        public void menu(CD cD)
        {
            Console.Write("Nhap Ma CD: ");
            ma = int.Parse(Console.ReadLine());
            Console.Write("Nhap Ten CD: ");
            ten = Console.ReadLine();
            Console.Write("Nhap So Bai Hat: ");
            soBh = int.Parse(Console.ReadLine());
            Console.Write("Nhap gia: ");
            gia = double.Parse(Console.ReadLine());

            this.setMaCD(ma);
            this.setTenCD(ten);
            this.setSoBaiHat(soBh);
            this.setGia(gia);
        }

        //in
        public void print(CD cD)
        {
            

            Console.Write("Ma CD: {0}", this.getMaCD());
            Console.Write("Ten CD: {0}", this.getTenCD());
            Console.Write("So Bai Hat: {0}", this.getSoBaiHat());
            Console.Write("Gia: {0}", this.getGia());
        }
    }
}
