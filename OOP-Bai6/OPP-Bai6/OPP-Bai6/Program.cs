using System;

namespace OPPBai6
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Account acc1 = new Account("Ted Murphy", 72354, 102.56);
            Account acc2 = new Account("Jane Smith", 69713, 40.00);
            Account acc3 = new Account("Edward Demsey", 93757, 75932);

            acc1.deposit(25.85);
            acc2.deposit(500.00);
            acc2.withdraw(430.75, 1.50);
            acc3.addInterest();

            Console.WriteLine("{0}", acc1.toString());
            Console.WriteLine("{0}", acc2.toString());
            Console.WriteLine("{0}", acc3.toString());

            Console.WriteLine();

            Console.WriteLine("Jane Smith transferred to Ted Murphy: ");

            Console.WriteLine();

            acc2.transfer(acc1, 100.00);
        }
    }
}
