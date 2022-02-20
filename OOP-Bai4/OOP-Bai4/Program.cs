using System;

namespace OOPBai4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Vehicle vehicle1 = new Vehicle();
            vehicle1.setName("Nguyen Thu Loan");
            vehicle1.setVehicleType("Future Neo");
            vehicle1.setCapacity(100);
            vehicle1.setMoneyPrice(35000000);
            vehicle1.getTax();

            Vehicle vehicle2 = new Vehicle();
            vehicle2.setName("Le Minh Tinh");
            vehicle2.setVehicleType("Ford Ranger");
            vehicle2.setCapacity(3000);
            vehicle2.setMoneyPrice(250000000);
            vehicle2.getTax();

            Vehicle vehicle3 = new Vehicle();
            vehicle3.setName("Nguyen Minh Triet");
            vehicle3.setVehicleType("Landscape");
            vehicle3.setCapacity(1500);
            vehicle3.setMoneyPrice(1000000000);
            vehicle3.getTax();

            menu();
            Console.WriteLine();
            vehicle1.outPut();
            vehicle2.outPut();
            vehicle3.outPut();
        }

        static void menu()// in bang thong tin
        {
            String st = String.Format("{0}", centeredString("Name", 20))
              + String.Format("{0}", centeredString("Vehicle Type", 20))
              + String.Format("{0}", centeredString("Capacity", 20))
              + String.Format("{0}", centeredString("Money Price", 20))
              + String.Format("{0}", centeredString("Tax", 20));

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
