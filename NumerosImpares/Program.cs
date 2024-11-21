using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessaNumeros processaNumeros = new ProcessaNumeros();

            int[] numeros = {2,4,6,8,9,11,12,14,16,33};

            List<int> listImpares = processaNumeros.ObterNumImpar(numeros);

            Console.WriteLine("Números ímpares: ");
            foreach (int n in listImpares) 
            { 
                Console.WriteLine(n);
            }

            Console.ReadKey();
        }
    }
}
