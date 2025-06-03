using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_5_sem_c_sharp
{
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
        public override string ToString()
        {
            String str = "";
            str += Convert.ToString(coord_x) + " " + Convert.ToString(coord_y) + " " + Convert.ToString(radius);
            return str;
        }

        public circle add(circle circle_1, circle circle_2)// add с двумя аргументами
        {
            circle result_circle = new circle();
            result_circle.coord_x = (circle_1.coord_x + circle_2.coord_x) / 2.0;
            result_circle.coord_y = (circle_1.coord_y + circle_2.coord_y) / 2.0;
            result_circle.radius = circle_1.radius + circle_2.radius;
            return result_circle;
        }
        public circle add(circle use_circle)// add с одним аргументом
        {
            circle result_circle = new circle();
            result_circle.coord_x = (use_circle.coord_x + this.coord_x) / 2.0;
            result_circle.coord_y = (use_circle.coord_y + this.coord_y) / 2.0;
            result_circle.radius = use_circle.radius + this.radius;
            return result_circle;

        }
        public double distance()
        {
            if (coord_x == 0 && coord_y == 0)
                throw e2 = new Exception("Окружность находится в начале координат");
            if (radius == 0)
                throw e2 = new Exception("Радиус окружности равен 0");
            return Math.Pow((coord_x * coord_x + coord_y * coord_y), (1.0 / 2.0));
        }
        public void Init(double x, double y, double rad)
        {
            coord_x = x;
            coord_y = y;
            radius = rad;
        }
        public void Display()
        {
            Console.WriteLine("Координаты окружности (" + coord_x + ";" + coord_y + ")\nРадиус окружности: " + radius);
        }
        public void Read()
        {
            Console.Write("\nВведите координату х: ");
            coord_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите координату y: ");
            coord_y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите радиус окружности: ");
            radius = Convert.ToDouble(Console.ReadLine());
        }
        public circle(double new_x, double new_y, double new_radius)
        {
            coord_x = new_x;
            coord_y = new_y;
            radius = new_radius;
        }
        public circle(double new_radius)
        {
            radius = new_radius;
            coord_x = 0;
            coord_y = 0;
        }
        public circle()
        {
            radius = 0;
            coord_y = 0;
            coord_x = 0;
        }
        static public double Sdistance(circle result)
        {
            return Math.Pow((result.coord_x * result.coord_x + result.coord_y * result.coord_y), (1.0 / 2.0));
        }
        public static circle operator +(circle circle_1, circle circle_2)
        {
            circle result = new circle();
            result.coord_x = (circle_1.coord_x + circle_2.coord_x) / 2.0;
            result.coord_y = (circle_1.coord_y + circle_2.coord_y) / 2.0;
            result.radius = circle_1.radius + circle_2.radius;
            return result;
        }
        public static circle operator +(circle circle_1, double num)
        {
            circle result = new circle();
            result.coord_x = circle_1.coord_x;
            result.coord_y = circle_1.coord_y;
            result.radius = num + circle_1.radius;
            return result;
        }
        public static circle operator +(double num, circle circle_1)
        {
            circle result = new circle();
            result.coord_x = circle_1.coord_x;
            result.coord_y = circle_1.coord_y;
            result.radius = num + circle_1.radius;
            return result;
        }
        public static circle operator ++(circle circle_1)
        {
            circle_1.radius++;
            return circle_1;
        }
        public override bool Equals(object obj)
        {
            if (obj is not circle other) return false;
            return radius == other.radius && coord_x == other.coord_x && coord_y == other.coord_y;
        }
    }
}
