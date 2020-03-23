using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam2019.Foregone
{
    class Effective
    {

        public static void EffectiveForegone()
        {
            Console.WriteLine("insert number of cases");
            int numOfCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfCases; i++)
            {
                Console.WriteLine("insert case {0} number", i);
                string jamcoins = Console.ReadLine();
                Console.WriteLine("Case #{0}: {1} {2}", i + 1, CreateFirstNumber(jamcoins), CreateSecondNumber(jamcoins));
            }
        }

        //first number - 4 will be replaced by 2 and the rest of the digits will remain the same
        private static string CreateFirstNumber(string number)
        {
            string str = number.ToString();
            string first = null;
            foreach (char ch in str)
            {
                if (ch == '4')
                {
                    first = first + '2';

                }
                else
                {
                    first = first + ch;
                }

            }
            return first;
        }

        //second number - up to the leading 4 no digits will be added
        // 4 will be replaced by 2 and the rest of the digits will be replaced by 0
        private static string CreateSecondNumber(string number)
        {
            bool leaderFound = false;
            string second = null;
            string str = number.ToString();
            foreach (char ch in str)
            {
                if (!leaderFound && ch == '4')
                {
                    leaderFound = true;
                }
                if (leaderFound)
                {
                    if (ch == '4')
                    {
                        second = second + '2';

                    }
                    else
                    {
                        second = second + '0';
                    }
                }
            }
            return second;
        }
    }
}
