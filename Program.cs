using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            double work_income = 2000;
            double material_help = 2000;
            double author_income = 2000;
            double sell_income = 2000;
            double present_income = 2000;
            double transactions_income = 2000;

            Person person = new Person(work_income, material_help, author_income, sell_income, present_income, transactions_income);

            person.ToString();
            person.sort();
            Console.ReadKey();
        }
    }
}
