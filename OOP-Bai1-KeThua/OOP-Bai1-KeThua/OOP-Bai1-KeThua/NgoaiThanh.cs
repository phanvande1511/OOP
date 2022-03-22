using System;
namespace OOPBai1KeThua
{
    public class NgoaiThanh : NoiThanh
    {
        private string maSo;
        private string ten;
        private int soXe;
        private string noiDen;
        private int soNgayDi;
        private double doanhThu;

        public NgoaiThanh()
        {
        }

        public NgoaiThanh(string maSo, string ten, int soXe, int soTuyen, double soKm, double doanhThu) : base(maSo, ten, soXe, soTuyen, soKm, doanhThu)
        {
        }
    }
}
