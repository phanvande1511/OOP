using System;
using System.Collections;

namespace OOPBai8
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            CDList cD = new CDList();

            cD.taoDS();

            Console.WriteLine();

            cD.add();
        }
    }
}
