using System;

namespace CsharpDiretoAoPonto.EstruturasCondicoesRepeticao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var notaDigitada = Console.ReadLine();

            //var nota = int.Parse(notaDigitada);

            //if (nota >= 70)
            //{
            //    Console.WriteLine("Aprovado.");
            //} else if (nota >= 40)
            //{
            //    Console.WriteLine("Em recuperação.");
            //} else
            //{
            //    Console.WriteLine("Reprovado.");
            //}

            //Switch - Case
            Console.WriteLine("Seja bem-vindo a empresa X.");

            Console.WriteLine("Digite 1 - Contratação de um plano.");
            Console.WriteLine("Digite 2 - Reclamação de serviço prestado.");
            Console.WriteLine("Digite 3 - Segunda via de boleto.");
            Console.WriteLine("Digite 4 - Sair.");

            var opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("Informações de plano novo.");
                    break;
                case "2":
                    Console.WriteLine("Fale sobre sua reclamação.");
                    break;
                case "3":
                    Console.WriteLine("Segunda via de boleto enviada por e-mail.");
                    break;
                case "4":
                    Console.WriteLine("Tenha um bom dia.");
                    break;
                default:
                    Console.WriteLine("Opção não encontrada.");
                    break;
            }
        }
    }
}
