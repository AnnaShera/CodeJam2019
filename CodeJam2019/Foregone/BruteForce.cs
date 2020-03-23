using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam2019.Foregone
{
    class BruteForce
    {        
        public static void BruteForceForegone()
        {

            bool result = false;
            Console.WriteLine("insert number of cases");
            int numOfCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCases; i++)
            {
                Console.WriteLine("insert case {0} number",i);
                int jamcoins = int.Parse(Console.ReadLine());

                for (int first = 0; first < jamcoins; first++)
                {
                    result = first > 3 ? checkDigits(first) : true;
                    if (result == true)
                    {
                        int second = jamcoins - first;
                        result = checkDigits(second);
                        if (result == true)
                        {
                            Console.WriteLine("Case #{0}: {1} {2}", i + 1, first, second);
                            break;
                        }
                    }
                }
            }
        }

        //return false if the number contains the digit 4
        private static bool checkDigits(int number)
        {
            int digit = 0;
            while (number > 0)
            {
                digit = number % 10;
                if (digit == 4)
                    return false;
                else
                    number = number / 10;
            }
            return true;
        }
    }
}
