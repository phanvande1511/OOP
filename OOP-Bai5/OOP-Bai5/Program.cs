using System;

namespace OOPBai5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            DateTime riceDateOfManufacture = new DateTime(2003, 1, 1);
            DateTime riceExpirationDate = new DateTime(2023, 1, 1);

            FoodGoods rice = new FoodGoods();
            rice.setItemCode("001");
            rice.setNameItems("Rice");
            rice.setMoney(100000);
            rice.setDateOfManufacture(riceDateOfManufacture);
            rice.setExpirationDate(riceExpirationDate);
            rice.check();

            DateTime noodleDateOfManufacture = new DateTime(2012, 1, 1);
            DateTime noodleExpirationDate = new DateTime(2023, 4, 6);

            FoodGoods noodle = new FoodGoods();
            noodle.setItemCode("002");
            noodle.setNameItems("Noodle");
            noodle.setMoney(5000);
            noodle.setDateOfManufacture(riceDateOfManufacture);
            noodle.setExpirationDate(riceExpirationDate);
            noodle.check();

            DateTime waterDateOfManufacture = new DateTime(2012, 1, 1);
            DateTime waterExpirationDate = new DateTime(2023, 4, 6);

            FoodGoods water = new FoodGoods();
            water.setItemCode("003");
            water.setNameItems("Water");
            water.setMoney(10000);
            water.setDateOfManufacture(riceDateOfManufacture);
            water.setExpirationDate(riceExpirationDate);
            water.check();

            menu();
            Console.WriteLine();
            rice.outPut();
            noodle.outPut();
            water.outPut();
        }

        // in bang thong tin
        static void menu()
        {
            String st = String.Format("{0}", centeredString(" Item Code ", 20))
              + String.Format("{0}", centeredString(" Name ", 20))
              + String.Format("{0}", centeredString(" Money ", 20))
              + String.Format("{0}", centeredString(" Date Of Manufacture ", 30))
              + String.Format("{0}", centeredString(" Expiration Date ", 30))
              + String.Format("{0}", centeredString(" Note ", 20));

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
