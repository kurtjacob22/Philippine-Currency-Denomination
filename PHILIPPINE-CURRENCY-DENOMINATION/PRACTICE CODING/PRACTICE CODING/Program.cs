using System;
using System.Linq;

// Philippine Currency Denomination
// by Juan Marko 

namespace PRACTICE_CODING
{
    class Program
    {
        

        static void Main(string[] args)
        {

            Console.Write("Input Money Php: ");
            double cash = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n");
            double[] moneyBills = new double[10] {
                1000,500,200,100,50,20,10,5,1,.25
            };

            double[] container = new double[10];
            double counter = 0;

            int i = 0;
            while (i < container.Length)
            {
                if (cash >= moneyBills[i])
                {
                    counter = cash / moneyBills[i];
                    cash = cash % moneyBills[i];
                    container[i] = Convert.ToInt32(counter);

                } else if (cash < moneyBills[i]) {
                    container[i] = 0;
                }
                i++;
            }

            for (int x = 0; x < container.Length; x++) {
                Console.WriteLine(moneyBills[x] +  ":" + container[x]);
            }

            Console.ReadKey();
        }
    }
}
