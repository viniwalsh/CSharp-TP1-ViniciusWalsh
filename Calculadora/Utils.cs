using System;

namespace Utils
{
public static class Utils
    {
        public static void ExibirTitulo(string operacao)
        {
            Console.WriteLine($"Essa aplicação calcula {operacao} de dois números!");
        }

        public static void ExibirResultado(string operacao, double numero1, double numero2, double resultado)
        {
            Console.WriteLine($"O resultado da {operacao} dos números {numero1} e {numero2} é: {resultado}!");

        }


        public static double LerNumero(string tituloNumero)
        {
            Console.WriteLine($"Digite o {tituloNumero} número: ");
            var numero = Console.ReadLine();

            if (double.TryParse(numero, out double numeroConvertido)) return numeroConvertido;

            return 0;
        }
    }
}
