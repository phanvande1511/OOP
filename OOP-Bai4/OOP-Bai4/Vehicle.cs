using System;
namespace OOPBai4
{
    public class Vehicle
    {
        private string name;//ten chu xe
        private string vehicleType;//loai xe
        private int capacity;//dung tich xi lanh
        private double moneyPrice;//gia tien
        private double tax;//thue phai nop

        public Vehicle()
        {
        }

        public Vehicle(string name, string vehicleType, int capacity, double moneyPrice)
        {
            setName(name);
            setVehicleType(vehicleType);
            setCapacity(capacity);
            setMoneyPrice(moneyPrice);
            getTax();
        }

        //setter
        public void setName(string name)
        {
            this.name = name;
        }

        public void setVehicleType(string vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public void setCapacity(int capacity)
        {
            this.capacity = capacity;
        }

        public void setMoneyPrice(double moneyPrice)
        {
            this.moneyPrice = moneyPrice;
        }

        //public void setTax(double tax)
        //{
        //    this.tax = tax;
        //}

        //getter
        public string getName()
        {
            return name;
        }

        public string getVehicleType()
        {
            return vehicleType;
        }

        public int getCapacity()
        {
            return capacity;
        }

        public double getMoneyPrice()
        {
            return moneyPrice;
        }

        //tinh thue
        public double getTax()
        {
            if (capacity < 100)
            {
                tax = moneyPrice * 0.01;
            } else if (capacity >= 100 && capacity <= 200)
            {
                tax = moneyPrice * 0.03;
            } else if(capacity > 200)
            {
                tax = moneyPrice * 0.05;
            }

            return tax;
        }

        //ToString
        public override string ToString()
        {
            return $"{this.name} {this.vehicleType} {this.capacity} {this.moneyPrice, 0:0,0.00} {getTax(), 0:0,0.00}";
        }

        // xuat thong tin
        public void outPut()
        {
            String st = String.Format("{0}", centeredString($"{name}", 20))
          + String.Format("{0}", centeredString($"{vehicleType}", 20))
          + String.Format("{0}", centeredString($"{capacity}", 20))
          + String.Format("{0}", centeredString($"{moneyPrice,0:0,0.00}", 20))
          + String.Format("{0}", centeredString($"{tax,0:0,0.00}", 20));

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
