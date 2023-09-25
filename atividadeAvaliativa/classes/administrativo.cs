using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeAvaliativa.classes
{
    internal class administrativo:Funcionario
    {
        public administrativo(string nome, string cpf, string matricula, DateTime dataNascimento, string sexo, double salario) : base()
        { 
            
        }

        public administrativo()
        {

        }

        public override void salario(double valor)
        {
            Salario = valor;
            double valeTransporte = 150;

            Salario = (Salario * 0.15) + Salario;
            Salario += valeTransporte;

            Console.WriteLine($"O salário com o vale transporte é de: {Salario.ToString("c2")}");
        }
    }
}
