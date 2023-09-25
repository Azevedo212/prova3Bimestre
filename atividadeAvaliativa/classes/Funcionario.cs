using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeAvaliativa.classes
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Matricula = matricula;
            this.DataNascimento = dataNascimento;
            this.Sexo = sexo;
            this.Salario = salario;
        }

        public Funcionario() 
        { 
        
        }
        
        public virtual void salario(double valor)
        {
            Salario = valor;
            Console.WriteLine($"Seu salário é de: {Salario.ToString("c2")}");
        }
        
    }
}
