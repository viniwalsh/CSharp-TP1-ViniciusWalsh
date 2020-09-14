using System;
using Utils;

namespace Soma
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Utils.ExibirTitulo("adição");

            var numero1 = Utils.Utils.LerNumero("primeiro");
            var numero2 = Utils.Utils.LerNumero("segundo");
            var resultado = Somar(numero1, numero2);

            Utils.Utils.ExibirResultado("adição", numero1, numero2, resultado);
        }

        static double Somar(double numero1, double numero2)
        {
            return numero1 + numero2;
        }
    }
}
