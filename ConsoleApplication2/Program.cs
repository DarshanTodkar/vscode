using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "apple,banana,grape";
            string[] fruits = input.Split(',');
            Console.WriteLine(string.Join(", ", fruits));


            Console.ReadKey();







            //double affinity = 7;
            //double unified = Math.Pow(10, -affinity) / (Math.Pow(10,-9));
            //double roundOffTo4 = Math.Round(unified, 4);

            //String resultt = roundOffTo4.ToString("e15", CultureInfo.InvariantCulture);

            //string a = "5.30E-07"; //...put as it is value in affinty field 
            //double d = Double.Parse(a);


            //string b = "9.16 * 10^ -7";
            //b = b.Replace(" * 10^ ", "E");
            //double e = Double.Parse(b)*(Math.Pow(10,9));
            //String result = e.ToString("e15", CultureInfo.InvariantCulture);


            //a = a.Replace("E", " * 10^ "); //...for RDF

        }
    }
}
