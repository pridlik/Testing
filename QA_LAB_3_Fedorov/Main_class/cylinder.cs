using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_5_sem_c_sharp
{
    internal class cylinder :circle
    {
        private double coord_z;
        public double Getcoord_z()
        {
            return coord_z;
        }
        public void Putcoord_z(double z)
        {
            coord_z = z;
        }
        public void Init(double x, double y, double rad, double z)
        {
            base.Init(x, y, rad);
            coord_z = z;
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Высота цилиндра: " + coord_z);
        }
        public cylinder():base()
        {
            coord_z = 0;
        }
        public cylinder(double rad):base(rad)
        {
            
            coord_z = 0;
        }
        public cylinder(double x, double y, double rad, double z) : base(x, y, z)
        {
            coord_z = z;
        }
        public double distance()
        {
            double result;
            result = Math.Sqrt((coord_x * coord_x) + (coord_y * coord_y));
            result = Math.Sqrt((result * result) + (coord_z * coord_z));
            return result;
        }
    }
}
