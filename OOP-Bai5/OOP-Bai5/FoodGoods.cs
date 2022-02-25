using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBai5
{
    public class FoodGoods
    {
        private string itemCode;//ma hang
        private string nameItems;//ten mat hang
        private double money;//gia tien
        private DateTime dateOfManufacture;//ngay san xuat
        private DateTime expirationDate;//ngay het han
        private DateTime timeNow = DateTime.Now;

        public FoodGoods()
        {
        }

        public FoodGoods(string itemCode, string nameItems, double money, DateTime dateOfManufacture, DateTime exprirationDate)
        {
            if (itemCode.Equals("")) throw new Exception("Fail Required!");
            else
            {
                this.itemCode = itemCode;
                setNameItems(nameItems);
                setMoney(money);
                setDateOfManufacture(dateOfManufacture);
                setExpirationDate(exprirationDate);
            }
        }

        //setter
        public void setItemCode(string itemCode)
        {
            this.itemCode = itemCode;
        }

        public void setNameItems(string nameItems)
        {
            this.nameItems = nameItems;
        }

        public void setMoney(double money)
        {
            this.money = money;
        }

        public void setDateOfManufacture(DateTime dateOfManufacture)
        {
            int result = DateTime.Compare(this.dateOfManufacture, DateTime.Now);
            if (result < 0)
                this.dateOfManufacture = dateOfManufacture;
            else this.dateOfManufacture = dateOfManufacture;
        }

        public void setExpirationDate(DateTime expirationDate)
        {
            int result = DateTime.Compare(this.expirationDate, this.expirationDate);
            if (result < 0)
                this.expirationDate = expirationDate;
            else this.expirationDate = expirationDate;
        }

        

        //getter
        public string getItemCode()
        {
            return itemCode;
        }

        public string getNameItems()
        {
            return nameItems;
        }

        public double getMoney()
        {
            return money;
        }

        public DateTime getDateOfManufacture()
        {
            return this.dateOfManufacture;
        }

        public DateTime getExpirationDate()
        {
            return this.expirationDate;
        }

        //kiem tra han su dung
        public string check()
        {
            string temp;
            int compare = DateTime.Compare(timeNow, expirationDate);

            if (compare < 0)
            {
                temp = "Unexpired";
            }
            else
            {
                temp = "Expired";
            }
            return temp;
        }

        //ToString
        public override string ToString()
        {
            return $"{this.itemCode} {this.nameItems} {this.money, 0:0.00 VND} {dateOfManufacture} {expirationDate} {check()}";
        }

        // in bang thong tin
        public void outPut()
        {
            String st = String.Format("{0}", centeredString($"{itemCode}", 20))
          + String.Format("{0}", centeredString($"{nameItems}", 20))
          + String.Format("{0}", centeredString($"{money, 0:0.00 VND}", 20))
          + String.Format("{0}", centeredString($"{dateOfManufacture}", 30))
          + String.Format("{0}", centeredString($"{expirationDate}", 30))
          + String.Format("{0}", centeredString($"{check()}", 20));

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
