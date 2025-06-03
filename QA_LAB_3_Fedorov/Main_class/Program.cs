namespace lab_6_5_sem_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            shop first_shop = new shop();
            Console.WriteLine("Использование функций Read и Display");
            first_shop.Read();
            first_shop.Display();
            double num_res = 0;
            num_res = first_shop.all_cost();
            Console.WriteLine("Сумма всех изделий магазина: " + num_res);
            cylinder main_cylinder = new cylinder();
            Console.WriteLine("Использование инициализатора без параметров");
            main_cylinder.Display();
            cylinder second_cylinder = new cylinder(5);
            Console.WriteLine("Использование инициализатора с однима параметром");
            second_cylinder.Display();
            cylinder therd_cylinder = new cylinder(6, 2, 7, 3.2);
            Console.WriteLine("Использование инициализатора со всеми параметрами");
            therd_cylinder.Display();
            circle main_cir = new circle();
            Console.WriteLine("Использование инициализатора без параметров");
            main_cir.Display();
            circle second_cir = new circle(5);
            Console.WriteLine("Использование инициализатора с однима параметром");
            second_cir.Display();
            circle therd_cir = new circle(6, 2, 7);
            Console.WriteLine("Использование инициализатора со всеми параметрами");
            therd_cir.Display();
            Console.WriteLine("Использование функции Init");
            main_cylinder.Init(5, 7, 3, 4);
            main_cylinder.Display();
            
            double num = main_cylinder.distance();
            Console.WriteLine("Расстояние от центра цилиндра до начала координат: " + num);
            num = second_cylinder.Getcoord_z();
            Console.WriteLine("Координата z: " + num);
            num = 7;
            second_cylinder.Putcoord_z(num);
            second_cylinder.Display();
        }
    }
}