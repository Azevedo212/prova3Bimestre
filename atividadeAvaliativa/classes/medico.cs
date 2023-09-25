using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeAvaliativa.classes
{
    internal class Medico:Funcionario
    {

        public string Crm { get; set; }
        public double ValorHoraExtra { get; set; }
        public string Especialidade { get; set; }
   
        public Medico(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario,
            string crm, double valorHoraExtra, string especialidade): base(nome, cpf, matricula, dataNascimento, sexo, salario)
        {
            this.Crm = crm;
            this.ValorHoraExtra = valorHoraExtra;
            this.Especialidade = especialidade;
        }

        public Medico()
        {

        }

        public override void salario(double valor)
        {
            Salario = valor;
            ValorHoraExtra = 10;        
            double auxilio = (0.2 * Salario);
            Salario = Salario + auxilio + ValorHoraExtra;

            Console.WriteLine($"O seu sálario é de {Salario.ToString("c2")}");
        }
    }
}
