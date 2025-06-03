using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace lab_6_5_sem_c_sharp
{
    [Serializable]
    class product
    {
        protected double cost;
        protected double weight;
        public double cost_product()
        {
            return (cost * weight);
        }

        public void Init(double first, double second)
        {
            cost = first;
            weight = second;
        }
        public void Read()
        {
            Console.Write("Введите стоимость за грамм изделия: ");
            cost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите вес изделия: ");
            weight = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Стоимость изделия за грамм: " + cost);
            Console.WriteLine("Вес изделия: " + weight);
        }
    }
}
