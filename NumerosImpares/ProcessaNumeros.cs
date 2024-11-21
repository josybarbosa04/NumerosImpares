using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosImpares
{
    public class ProcessaNumeros
    {
        public List<int> ObterNumImpar(int[] numeros)
        {
            return numeros.Where(n => n % 2 != 0).ToList();
        }
    }
}
