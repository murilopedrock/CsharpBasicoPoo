using System;

namespace CsharpDiretoAoPonto.TiposDadosConversoesOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Tipos de Dados

            int numeroInt = 10;

            int maiorNumeroInt = int.MaxValue;
            int menorNumeroInt = int.MinValue;

            long numeroLong = 123123123123123123;

            long maiorNumeroLong = long.MaxValue;
            long menorNumeroLong = long.MinValue;

            decimal numeroDecimal = 10.52m;

            double numeroDouble = 12.3;
            double menorNumeroDouble = double.MinValue;

            bool verdadeiro = true;
            bool falso = false;

            var numero = 10;

            string nome = "Murilo Oliveira";
            char letra = 'M';

            DateTime entradaEmpresa = new DateTime(2022, 1, 1);
            TimeSpan quantoTempoDeEmpresa = DateTime.Now - entradaEmpresa;

            #endregion

            #region Conversões
            int notaAluno = 10;

            // conversão implícita
            double notaAlunoDouble = notaAluno;

            // conversão Explícita
            int numeroDoubleComoInt = (int) notaAlunoDouble;

            // Conversão utilizando Convert
            string notaString = "10";
            int notaConvert = Convert.ToInt32(notaString);

            // Conversão utiliznado Parse
            int notaParse = int.Parse(notaString);
            if(int.TryParse(notaString, out int notaTryParse))
            {

            } else
            {
                Console.WriteLine("Número em formato inválido.");
            }
            #endregion

            #region Operadores Aritméticos
            // Unários ++, --. +
            int numeroOperador = 4;

            Console.WriteLine(numeroOperador++); // 4
            Console.WriteLine(numeroOperador--); // 5

            Console.WriteLine(++numeroOperador); // 5
            Console.WriteLine(--numeroOperador); // 4

            Console.WriteLine(numeroOperador);
            Console.WriteLine(-numeroOperador);
            Console.WriteLine(-(-numeroOperador));

            // Binários * / + -
            var soma = 4 + 5;
            var subtracao = 4 - 5;
            var multiplicacao = 4 * 5;
            var divisao = 20 / 3;
            var divisaoDouble = (double)20 / 3;

            var multiplos = (4 * 5) + 10;

            #endregion

            #region Operadores de Comparação > >= < <=

            Console.WriteLine(4 > 5); //false
            Console.WriteLine(5 > 5); //false
            Console.WriteLine(6 >= 5); //true

            Console.WriteLine(5 < 4); //false
            Console.WriteLine(5 <= 5); //true
            Console.WriteLine(5 < 6); //true

            #endregion

            #region Operadores de Igualdade ==, !=

            Console.WriteLine(5 == 5); //true
            Console.WriteLine(5 == 4); //false

            Console.WriteLine(5 != 5); //false
            Console.WriteLine(4 != 5); //true

            #endregion

            #region Operadores Lógicos AND && e OR ||

            var minhaNota = 4;
            var ultimoAno = true;

            if(minhaNota >= 7 & ultimoAno)
            {
                Console.WriteLine("Aprovado e terminou o curso, parabéns!");
            }

            if (minhaNota >= 7 || ultimoAno)
            {
                Console.WriteLine("Aprovado!");
            }

            Console.WriteLine(true || false); //true
            Console.WriteLine(false || true); //true
            Console.WriteLine(true || true); //true
            Console.WriteLine(false || false); //false

            Console.WriteLine(true && false); //false
            Console.WriteLine(false && true); //false
            Console.WriteLine(true && true); //true
            Console.WriteLine(false && false); //false



            #endregion




            Console.Read();
        }
    }
}
