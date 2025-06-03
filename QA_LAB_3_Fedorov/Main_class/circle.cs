using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_5_sem_c_sharp
{
    /**\brief 
    @class This class has three coordinate fields: x, y, and the radius of a circle.
    */
    public class circle
    {
        static Exception e1;
        static Exception e2;
        protected double coord_x;
        protected double coord_y;
        protected double radius;
        public double Gestcoord_x()
        {
            return coord_x;
        }
        public double Getcoord_y()
        {
            return coord_y;
        }
        
        /** This method convert circle in string
        Function return string
         */
        public override string ToString()
        {
            String str = "";
            str += Convert.ToString(coord_x) + " " + Convert.ToString(coord_y) + " " + Convert.ToString(radius);
            return str;
        }
        /**
         The add function is called for two elements of the waist circumference type, 
         the sum coordinates are found as the arithmetic mean of the original 
         coordinates and the radius as the sum
        */
        public circle add(circle circle_1, circle circle_2)
        {
            circle result_circle = new circle();
            result_circle.coord_x = (circle_1.coord_x + circle_2.coord_x) / 2.0;
            result_circle.coord_y = (circle_1.coord_y + circle_2.coord_y) / 2.0;
            result_circle.radius = circle_1.radius + circle_2.radius;
            return result_circle;
        }

        /**
        The add function is called for a single element of the circle type and the object 
        relative to which the function is called, the coordinates of the sum are found as 
        the arefmetical average of the original coordinates and the radius as the sum
         */
        public circle add(circle use_circle)
        {
            circle result_circle = new circle();
            result_circle.coord_x = (use_circle.coord_x + this.coord_x) / 2.0;
            result_circle.coord_y = (use_circle.coord_y + this.coord_y) / 2.0;
            result_circle.radius = use_circle.radius + this.radius;
            return result_circle;

        }

        /**
         The distance function returns the distance from the origin to the center of the circle
        Интеграл: \f$ s = \sqrt(x^2+y^2) \f$ 
         */
        public double distance()
        {
            if (coord_x == 0 && coord_y == 0)
                throw e2 = new Exception("Окружность находится в начале координат");
            if (radius == 0)
                throw e2 = new Exception("Радиус окружности равен 0");
            return Math.Pow((coord_x * coord_x + coord_y * coord_y), (1.0 / 2.0));
        }

        /**
        This method initialization new circle
        @param x - coord x new circle
        @param y - coord y new circle
        @param rad - coord radius new circle
         */
        public void Init(double x, double y, double rad)
        {
            coord_x = x;
            coord_y = y;
            radius = rad;
        }

        /**
        This method outputs the circle data to the console.
        */
        public void Display()
        {
            Console.WriteLine("Координаты окружности (" + coord_x + ";" + coord_y + ")\nРадиус окружности: " + radius);
        }

        /**
        This method inputs data from console in circle.
        */
        public void Read()
        {
            Console.Write("\nВведите координату х: ");
            coord_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y: ");
            coord_y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите радиус окружности: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        /**
        This method initialization new circle
        @param x - coord x new circle
        @param y - coord y new circle
        @param rad - coord radius new circle
         */
        public circle(double new_x, double new_y, double new_radius)
        {
            coord_x = new_x;
            coord_y = new_y;
            radius = new_radius;
        }
        /**
        This method initialization new circle
        @param rad - coord radius new circle
         */
        public circle(double new_radius)
        {
            radius = new_radius;
            coord_x = 0;
            coord_y = 0;
        }

        /**
        This method initialization new circle
         */
        public circle()
        {
            radius = 0;
            coord_y = 0;
            coord_x = 0;
        }
        /**
        The static method returns the distance from the origin to the center of the circle
        */
        static public double Sdistance(circle result)
        {
            return Math.Pow((result.coord_x * result.coord_x + result.coord_y * result.coord_y), (1.0 / 2.0));
        }
        /**
         This is an overload of the + operator for two circles.
        @param circle_1, circle_2 sum circle
        @param result - result of the function execution
         */
        public static circle operator +(circle circle_1, circle circle_2)
        {
            circle result = new circle();
            result.coord_x = (circle_1.coord_x + circle_2.coord_x) / 2.0;
            result.coord_y = (circle_1.coord_y + circle_2.coord_y) / 2.0;
            result.radius = circle_1.radius + circle_2.radius;
            return result;
        }

        /**
         This is an overload of the + operator for circles and number.
        @param circle_1 - sum circle
        @param num - double number for sum
        @param result - result of the function execution
         */
        public static circle operator +(circle circle_1, double num)
        {
            circle result = new circle();
            result.coord_x = circle_1.coord_x;
            result.coord_y = circle_1.coord_y;
            result.radius = num + circle_1.radius;
            return result;
        }

        /**
         This is an overload of the + operator for circles and number.
        @param num - double number for sum
        @param circle_1 - sum circle
        @param result - result of the function execution
         */
        public static circle operator +(double num, circle circle_1)
        {
            circle result = new circle();
            result.coord_x = circle_1.coord_x;
            result.coord_y = circle_1.coord_y;
            result.radius = num + circle_1.radius;
            return result;
        }

        /**
        This is an overload of the ++ operator for circle
        Return radius+1
         */
        public static circle operator ++(circle circle_1)
        {
            circle_1.radius++;
            return circle_1;
        }

        /**
         A function for checking the equality of two circles
        */
        public override bool Equals(object obj)
        {
            if (obj is not circle other) return false;
            return radius == other.radius && coord_x == other.coord_x && coord_y == other.coord_y;
        }
    }
}
