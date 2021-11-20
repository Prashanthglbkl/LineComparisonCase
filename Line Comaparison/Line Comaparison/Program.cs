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
            Console.Write("Enter the Co-rdinate x1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate y1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate x2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the Co-rdinate y2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double Powofpoints1 = Math.Pow(2, (x2 - x1));
            double Powofpoints2 = Math.Pow(2, (y2 - y1));
            double LengthofLine = Math.Sqrt((Powofpoints1 + Powofpoints2));
            Console.WriteLine("Length of the Line is: " + LengthofLine);
            Console.ReadLine();
        }
    }
}
