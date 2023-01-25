using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvjeraZnanjaZadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fibonaccijev = 0, Fibonaccijevm1 = 1, Fibonaccijevm2 = 0;
            Console.Write("Unesi broj: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i=2; i<n; i++)
            {
                Fibonaccijev = Fibonaccijevm1 + Fibonaccijevm2;
                Fibonaccijevm2 = Fibonaccijevm1;
                Fibonaccijevm1 = Fibonaccijev;
            }
            if (n == 2) { Fibonaccijev = 1; }
            Console.WriteLine(Fibonaccijev);
            Console.ReadLine();
        }
    }
}
