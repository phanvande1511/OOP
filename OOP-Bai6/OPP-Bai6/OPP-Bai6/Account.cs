using System;
using System.Globalization;

namespace OPPBai6
{
    public class Account
    {
        private long accountNumber;
        private string accountName;
        private double balance;
        private double rate = 0.035;

        public Account()
        {
            if (accountNumber <= 0 || accountName.Equals("") || balance < 50000)
            {
                accountNumber = 999999;
                accountName = "Error";
                balance = 50000;
            }
        }

        public Account(string accountName, long accountNumber, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
            this.balance = balance;
        }

        public Account(long accountNumber, string accountName)
        {
            this.accountNumber = accountNumber;
            this.accountName = accountName;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }

        public long getAccountNumber()
        {
            return accountNumber;
        }

        public string getAccountName()
        {
            return accountName;
        }

        public double getBalance()
        {
            return balance;
        }

        public double deposit(double amount)
        {
            return this.balance = this.balance + amount;
        }

        public double withdraw(double amount, double fee)
        {
            return balance = balance - amount - fee;
        }

        public double addInterest()
        {
            return balance = balance + (balance * rate);
        }

        public void transfer(Account acc2, double amount)
        {
            setBalance(balance + amount);
            acc2.setBalance(this.balance - amount);
            Console.WriteLine(toString());
            Console.WriteLine(acc2.toString());
        }

        public String toString()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.NumberFormat.CurrencySymbol = "VND";
            culture.NumberFormat.CurrencyPositivePattern = 2;

            return string.Format(culture, "{0} = {1:C2}", getAccountName(), getBalance());
        }
    }
}
