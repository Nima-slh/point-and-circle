using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace point_and_circle
{
    class circle
    {
        public int Radious { get; set; }
        public point Center { get; set; }
        public circle()
        {
            this.Center = new point();
            this.Radious = 0;
        }
        public circle(point center, int radious)
        {
            this.Center = center;
            this.Radious = radious;
        }
        public circle(int centerX, int centerY, int radious)
        {
            this.Center.setX(centerX);
            this.Center.setY(centerY);
            this.Radious = radious;
        }
        public point GetCenter()
        {
            return this.Center;
        }
        public void SetCenter(point center)
        {
            this.Center = center;
        }
        public static Boolean InOurOut(circle c, point p)
        {
            double d = point.distance(c.Center, p);
            if (d<=c.Radious)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double area(circle c)
        {
            return Math.PI * c.Radious * c.Radious;
        }
        public static double circumference(circle c)
        {
            return 2 * Math.PI * c.Radious;
        }
        public override string ToString()
        {
            return $" center: x = {Center.X} y = {Center.Y} radious = {Radious}";
        }
    }
}
