using System;
namespace OOPBai8
{
    public class CD
    {
        private int maCD;
        private string tenCD;
        private int soBaiHat;
        private double gia;

        public CD()
        {
        }

        public CD(int maCD, string tenCD, int soBaiHat, double gia)
        {
            this.maCD = maCD;
            this.tenCD = tenCD;
            this.soBaiHat = soBaiHat;
            this.gia = gia;
        }

        //setter
        public void setMaCD(int maCD)
        {
            this.maCD = maCD;
        }

        public void setTenCD(string tenCD)
        {
            this.tenCD = tenCD;
        }

        public void setSoBaiHat(int soBaiHat)
        {
            this.soBaiHat = soBaiHat;
        }

        public void setGia(double gia)
        {
            this.gia = gia;
        }

        //getter
        public int getMaCD()
        {
            return maCD;
        }

        public string getTenCD()
        {
            return tenCD;
        }

        public int getSoBaiHat()
        {
            return soBaiHat;
        }

        public double getGia()
        {
            return gia;
        }

        public override string ToString()
        {
            return $"{this.maCD} {this.tenCD} {this.soBaiHat} {this.gia}";
        }
    }
}
