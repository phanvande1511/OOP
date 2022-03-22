using System;

namespace OOPBai7
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            HinhTron hinhTron = new HinhTron();
            hinhTron.setName("O");
            hinhTron.setX(6);
            hinhTron.setY(5);
            hinhTron.setBanKinh(10.5);

            Console.WriteLine("Tam Hinh Tron: {0}", hinhTron);
            Console.WriteLine("Ban Kinh: {0}", hinhTron.getBanKinh());
            Console.WriteLine("Dien Tich: {0}", hinhTron.dienTich());
            Console.WriteLine("Chu Vi: {0}", hinhTron.chuVi());
        }
    }

    public class ToaDo
    {
        private string ten;
        private float x;
        private float y;

        public float getX()
        {
            return x;
        }

        public float getY()
        {
            return y;
        }

        public void setName(string ten)
        {
            this.ten = ten;
        }

        public void setX(float x)
        {
            this.x = x;
        }

        public void setY(float y)
        {
            this.y = y;
        }

        public ToaDo() { }

        public ToaDo(float x, float y)
        {
            setX(x);
            setY(y);
        }

        public override string ToString()
        {
            return $"{this.ten} ({this.x}, {this.y})";
        }
    }

    public class HinhTron : ToaDo
    {
        private ToaDo tam;
        private double banKinh;

        public double chuVi()
        {
            return ((banKinh * 2) * 3.14);
        }

        public double dienTich()
        {
            return ((banKinh * banKinh) * 3.14);
        }

        public ToaDo getTam()
        {
            return (ToaDo)tam;
        }

        public double getBanKinh()
        {
            return banKinh;
        }

        public void setTam(ToaDo tam)
        {
            this.tam = (ToaDo)tam;
        }

        public void setBanKinh(double banKinh)
        {
            this.banKinh = banKinh;
        }

        public HinhTron() { }

        public HinhTron(ToaDo tam, double banKinh)
        {
            this.tam = tam;
            this.banKinh = banKinh;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
