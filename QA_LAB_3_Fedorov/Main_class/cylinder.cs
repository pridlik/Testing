using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_5_sem_c_sharp
{
    public class cylinder :circle
    {
        private double coord_z;

        /**
        Return coord z cylinder
        */
        public double Getcoord_z()
        {
            return coord_z;
        }
        /**
        Update coord z cylinder
        */
        public void Putcoord_z(double z)
        {
            coord_z = z;
        }

        /**
        This method initialization new cylinder
        @param x - coord x new cylinder
        @param y - coord y new cylinder
        @param rad - radius new cylinder
        @param z - coord z new cylinder
         */
        public void Init(double x, double y, double rad, double z)
        {
            base.Init(x, y, rad);
            coord_z = z;
        }

        /**
       This method outputs the circle data to the console.
       */
        public void Display()
        {
            base.Display();
            Console.WriteLine("Высота цилиндра: " + coord_z);
        }

        /**
        This method initialization new cylinder
         */
        public cylinder():base()
        {
            coord_z = 0;
        }

        /**
        This method initialization new cylinder
        @param rad - radius new cylinder
         */
        public cylinder(double rad):base(rad)
        {
            
            coord_z = 0;
        }

        /**
        This method initialization new cylinder
        @param x - coord x new cylinder
        @param y - coord y new cylinder
        @param rad - radius new cylinder
        @param z - coord z new cylinder
         */
        public cylinder(double x, double y, double rad, double z) : base(x, y, z)
        {
            coord_z = z;
        }

        /**
         The distance function returns the distance from the origin to the center of the cylinder
         */
        public double distance()
        {
            double result;
            result = Math.Sqrt((coord_x * coord_x) + (coord_y * coord_y));
            result = Math.Sqrt((result * result) + (coord_z * coord_z));
            return result;
        }
    }
}
