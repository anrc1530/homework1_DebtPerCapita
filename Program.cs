using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebtPerCapita
{
    class Program
    {
        static void Main(string[] args)
        {
            double TotalDebt = 17381987122876; //I am using double because the digit is too large to fit in an int value

            int USPopulation = 313900000; //I am using int because the population is a whole number

            double DebtPerCapita = TotalDebt / USPopulation;  //Whenever two numbers are divided there's a high chance for the value to be a decimal, which is why I used double

            Console.WriteLine("The total US debt is ${0} or approximately ${1} \nper every person living in the US \n", USPopulation, DebtPerCapita);

            Console.ReadLine();
        }
    }
}
