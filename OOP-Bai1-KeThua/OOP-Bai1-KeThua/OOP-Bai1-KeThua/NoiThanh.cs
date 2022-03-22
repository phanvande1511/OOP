using System;
namespace OOPBai1KeThua
{
    public class NoiThanh
    {
        private string maSo;
        private string ten;
        private int soXe;
        private int soTuyen;
        private double soKm;
        private double doanhThu;

        public NoiThanh()
        {
        }

        public NoiThanh(string maSo, string ten, int soXe, int soTuyen, double soKm, double doanhThu)
        {
            this.maSo = maSo;
            this.ten = ten;
            this.soXe = soXe;
            this.soTuyen = soTuyen;
            this.soKm = soKm;
            this.doanhThu = doanhThu;
        }

        //setter
        public void setMaSo(string maSo)
        {
            this.maSo = maSo;
        }

        public void setTen(string ten)
        {
            this.ten = ten;
        }

        public void setSoXe(int soXe)
        {
            this.soXe = soXe;
        }

        public void setSoTuyen(int soTuyen)
        {
            this.soTuyen = soTuyen;
        }

        public void setSoKm(double soKm)
        {
            this.soKm = soKm;
        }

        public void setDoanhThu(double doanhThu)
        {
            this.doanhThu = doanhThu;
        }

        //getter
        public string getMaSo()
        {
            return maSo;
        }

        public string getTen()
        {
            return ten;
        }

        public int getSoXe()
        {
            return soXe;
        }

        public int getSoTuyen()
        {
            return soTuyen;
        }

        public double getSoKm()
        {
            return soKm;
        }

        public double getDoanhThu()
        {
            return doanhThu;
        }

        public override string ToString()
        {
            return $"{this.maSo} {this.ten} {this.soXe} {this.soTuyen} {this.soKm} {this.doanhThu}";
        }
    }
}
