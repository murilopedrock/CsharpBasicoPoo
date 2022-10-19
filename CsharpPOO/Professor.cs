using System;
using System.Collections.Generic;

namespace CsharpPOO
{
    public class Professor : Pessoa
    {
        public Professor(decimal salario, string nome, string documento, DateTime dataNascimento) : base(nome, documento, dataNascimento)
        {
            Salario = salario;
            Turmas = new List<string> { "A", "B" };

        }
        public List<string> Turmas { get; private set; }
        public decimal Salario { get; private set; }

        public override void SeApresentar()
        {
            base.SeApresentar();

            var turmas = string.Join(',', Turmas);

            Console.WriteLine($"Meu salário é {Salario} e leciono para as turmas {turmas}");
        }
    }
}
