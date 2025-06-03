using lab_6_5_sem_c_sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_6_5_sem_c_sharp
{
    internal class shop
    {
        private double all_cost_product;
        private int product_num;
        private int expensive_num;
        private product use_product;
        private most_product expensive_product;
        private String name;
        public double all_cost()
        {
            double result = all_cost_product;
            result += use_product.cost_product();
            result += expensive_product.cost_product();
            return result;
        }


        public void Read()
        {
            Console.Write("Введите название магазина: ");
            int i = 0;
            name = Convert.ToString(Console.ReadLine());
            use_product = new product();
            use_product.Init(0, 0);
            Console.WriteLine("Введите новое украшение: ");
            use_product.Read();
            Console.Write("Введите количество этих украшений: ");
            product_num = Convert.ToInt32(Console.ReadLine());
            expensive_product = new most_product();
            expensive_product.Init(0, 0);
            Console.WriteLine("Введите новое украшение: ");
            expensive_product.Read();
            Console.Write("Введите количество этих украшений: ");
            expensive_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите стоимость остальных товаров магазина: ");
            all_cost_product = Convert.ToInt32(Console.ReadLine()); ;

        }

        public void Init(product shop_p, double all_coste, int num_p, int num_exp, most_product exp_pr)
        {
            expensive_num = num_exp;
            use_product = shop_p;
            all_cost_product = all_coste;
            product_num = num_p;
            expensive_product = exp_pr;

        }

        public void Display()
        {
            Console.Write("Название магазина: ");
            Console.WriteLine(name);
            Console.WriteLine("Продукт номер 1" );
            use_product.Display();
            Console.Write("Количество продукта: " + product_num + "\n");
            Console.WriteLine("Продукт номер 2");
            expensive_product.Display();
            Console.Write("Количество продукта: " + expensive_num + "\n");
            Console.WriteLine("Сумма всех оставшихся изделий: " + all_cost_product + "\n");
        }
    }
}
