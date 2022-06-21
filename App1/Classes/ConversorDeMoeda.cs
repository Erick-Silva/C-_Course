using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp.Classes
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double ValorEmReais(double quantia, double cotacao)
        {
            var total = quantia * cotacao;
            return total + total * (Iof / 100);
        }
    }
}
