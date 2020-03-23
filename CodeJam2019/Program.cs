using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeJam2019.Foregone;

namespace CodeJam2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1 - Foregone");
            Console.WriteLine("Question 1 - Brute force approach");
            BruteForce.BruteForceForegone();
            Console.WriteLine("Question 2 - Effective approach");
            Effective.EffectiveForegone();
            Console.ReadLine();
        }
    }
}

