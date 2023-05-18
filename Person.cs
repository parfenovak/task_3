using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Person
    {
        double work_income;
        double material_help;
        double author_income;
        double sell_income;
        double present_income;
        double transactions_income;

        public Person(double work_income,double material_help, double author_income,double sell_income,double present_income,double transactions_income)
        {
            this.work_income = work_income;
            this.material_help = material_help;
            this.author_income = author_income;
            this.sell_income = sell_income;
            this.present_income = present_income;
            this.transactions_income = transactions_income;
        }
        

        public double countWorkTax()
        {
            return this.work_income * 0.13;
        }

        public double countSellTax()
        {
            return this.sell_income * 0.11;
        }

        public double countMaterialTax()
        {
            return this.material_help * 0.15;
        }

        public double countAuthorTax()
        {
            return this.author_income * 0.05;
        }

        public double countPresentTax()
        {
            return this.present_income * 0.14;
        }
        public double countTransactionsTax()
        {
            return this.transactions_income  * 0.1;
        }


        public override string ToString()
        {
            Console.WriteLine("НДФЛ: " + this.countWorkTax() + "\n");
            Console.WriteLine("Материальная помощь: " + this.countMaterialTax() + "\n");
            Console.WriteLine("Авторские вознаграждения: " + this.countAuthorTax() + "\n");
            Console.WriteLine("Продажа имущества: " + this.countSellTax() + "\n");
            Console.WriteLine("Налог на подарки: " + this.countPresentTax() + "\n");
            Console.WriteLine("Налог на переводы: " + this.countTransactionsTax() + "\n");
            return "";
        }

        public void sort()
        {
            List<double> taxes  = new List<double>();
            taxes.Add(this.countWorkTax());
            taxes.Add(this.countSellTax());
            taxes.Add(this.countMaterialTax());
            taxes.Add(this.countAuthorTax());
            taxes.Add(this.countPresentTax());
            taxes.Add(this.countTransactionsTax());

            taxes.Sort();

            foreach(double tax in taxes)
            {
                Console.Write(tax + " ");
            }
        }
    }
}
