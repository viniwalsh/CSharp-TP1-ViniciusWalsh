using System;
using Utils;

namespace Multiplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Utils.Utils.ExibirTitulo("subtração");

            var numero1 = Utils.Utils.LerNumero("primeiro");
            var numero2 = Utils.Utils.LerNumero("segundo");
            var resultado = Multiplicar(numero1, numero2);

            Utils.Utils.ExibirResultado("subtração", numero1, numero2, resultado);
        }

        static double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
    }
}

