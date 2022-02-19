using System;
namespace OOPBai1
{
    public class Coodinator
    {
        private int x;
        private int y;
        private string name;


        public Coodinator(int x, int y, string name)
        {
            setX(x);
            setY(y);
            setName(name);
        }

        public Coodinator()
        {
        }

        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setName(string name)
        {
            this.name = name;
        }

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public string getName()
        {
            return name;
        }

        public override string ToString()
        {

            return $"{this.name}( {this.x}, {this.y})";

        }



    }
}
