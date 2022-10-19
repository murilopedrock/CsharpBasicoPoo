using System;

namespace CsharpDebugandoAplicacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Debugging
            var numerosString = Console.ReadLine();
            var numeros = numerosString.Split(' ');

            foreach (var numero in numeros)
            {
                var numeroInt = int.Parse(numero);

                var aoQuadrado = Math.Pow(numeroInt, 2);

                Console.WriteLine($"{numeroInt}² =  {aoQuadrado}");
            }

            #endregion Debugging

            Console.ReadKey();
        }
    }
}
