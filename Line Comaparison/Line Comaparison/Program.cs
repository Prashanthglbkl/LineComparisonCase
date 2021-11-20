using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_Comaparison
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("First Line");
            Console.Write("Enter the Co-rdinate x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Second Line");
            Console.Write("Enter the Co-rdinate M1: ");
            double M1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate N1: ");
            double N1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate M2: ");
            double M2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate N2: ");
            double N2 = Convert.ToDouble(Console.ReadLine());

            double pointsx = Math.Pow(2, (x2 - x1));
            double pointsy = Math.Pow(2, (y2 - y1));
            double LengthofLine1 = Math.Sqrt((pointsx + pointsy));
            Console.WriteLine("Length of the First Line is: " + LengthofLine1);

            double pointsM = Math.Pow(2, (M2 - M1));
            double pointsN = Math.Pow(2, (N2 - N1));
            double LengthofLine2 = Math.Sqrt((pointsM + pointsN));
            Console.WriteLine("Length of the Second Line is: " + LengthofLine2);

            Console.WriteLine(LengthofLine1.CompareTo(LengthofLine2));
          
            //gives the ouput as 1, if equals then 0 and if smaller gives the ouput as -1.
            Console.ReadLine();

        }
    }
}
