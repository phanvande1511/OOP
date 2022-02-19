using System;

namespace OOPBai1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Coodinator coodinator = new Coodinator();
            coodinator.setX(1);
            coodinator.setY(4);
            coodinator.setName("X");

            //Lấy các giá trị từ đối tượng coodinator
            Console.WriteLine(coodinator.getName());
            Console.WriteLine(coodinator.getX());
            Console.WriteLine(coodinator.getY());

            //Gán giá trị cho đối tượng lúc new
            Coodinator coodinator1 = new Coodinator();
            Coodinator coodinator2 = new Coodinator(2, 2, "Y");

            Console.WriteLine(coodinator2);



            Console.WriteLine();
        }
    }
}
