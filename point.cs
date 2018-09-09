using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_and_circle
{
    class point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public String Color { get; set; }
        public point()
        {
            this.X = 0;
            this.Y = 0;
        }
        public point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public point(int x, int y, string color) : this(x, y)
        {
            this.Color = color;
        }
        public int getX()
        {
            return X;
        }
        public void setX(int x)
        {
            this.X = x;
        }
        public int getY()
        {
            return Y;
        }
        public void setY(int y)
        {
            this.Y = y;
        }
        /// <summary>
        /// فاصله دو نقطه
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double distance(point a, point b)
        {
            int XDis = a.X - b.X;
            int YDis = a.Y - b.Y;
            return Math.Abs(Math.Sqrt(XDis * XDis + YDis * YDis));
        }
        /// <summary>
        /// فاصله از مبدا
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static double distance(point a)
        {
            point b = new point();
            return distance(a, b);
        }
        public override string ToString()
        {
            return $" x = {X} y = {Y}";
        }
    }
}
