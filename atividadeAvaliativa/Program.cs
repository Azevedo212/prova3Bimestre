using atividadeAvaliativa.classes;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Channels;

class Program
{
    
    static void Main(string[] args)
    {
        List<Funcionario> list = new List<Funcionario>();

        while (true)
        {
            Console.WriteLine("0 - Sair \n1 - Funcionário normal \n2 - Funcionário administrativo \n3 - Médico \n");
            Console.Write("Escolha a opção para prosseguir: ");
            int opcaoescolhida = Convert.ToInt32(Console.ReadLine());

            switch (opcaoescolhida)
            {
                case 0:
                    goto exit;

                case 1:
                    Funcionario f = new Funcionario();

                    Console.Write("Digite o nome: ");
                    f.Nome = Console.ReadLine();

                    Console.Write("Digite o cpf: ");
                    f.CPF = Console.ReadLine();

                    Console.Write("Numero matricula: ");
                    f.Matricula = Console.ReadLine();

                    Console.Write("Digite a data de nascimento: ");
                    f.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Digite o sexo: ");
                    f.Sexo = Console.ReadLine();

                    Console.Write("Digite o salário: ");
                    f.Salario = Convert.ToDouble(Console.ReadLine());

                    list.Add(f);

                    
                    Console.WriteLine("-------------------");
                    Console.WriteLine("CADASTRADO COM SUCESSO");
                    Console.WriteLine("-------------------\n");

                    

                    while (true)
                    {
                        Console.WriteLine("1 - Sair \n2 - consultar salario \n");
                        Console.Write("Escolha uma opção: ");
                        int opcao = Convert.ToInt32(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                Console.Clear();
                                goto sair1;

                            case 2:
                                f.salario(f.Salario);
                                break;
                        }
                        
                    }
                sair1:;
                    break;

                case 2:
                    administrativo adm = new administrativo();

                    Console.Write("Digite o nome: ");
                    adm.Nome = Console.ReadLine();

                    Console.Write("Digite o cpf: ");
                    adm.CPF = Console.ReadLine();

                    Console.Write("Numero matricula: ");
                    adm.Matricula = Console.ReadLine();

                    Console.Write("Digite a data de nascimento: ");
                    adm.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Digite o sexo: ");
                    adm.Sexo = Console.ReadLine();

                    Console.Write("Digite o salário: ");
                    adm.Salario = Convert.ToDouble(Console.ReadLine());

                    list.Add(adm);

                    Console.WriteLine("-------------------");
                    Console.WriteLine("CADASTRADO COM SUCESSO");
                    Console.WriteLine("-------------------\n");

                    while(true)
                    {
                        Console.WriteLine("1 - Sair \n2 - consultar salario \n");
                        Console.Write("Escolha uma opção: ");
                        int opcao = Convert.ToInt32(Console.ReadLine());
                        
                        switch(opcao)
                        {
                            case 1:
                                Console.Clear();
                                goto sair;

                            case 2:
                                adm.salario(adm.Salario);
                                break;
                        }
                       
                    }
                sair:;
                      break;

                case 3:
                    Medico medico = new Medico();

                    Console.Write("Digite o nome: ");
                    medico.Nome = Console.ReadLine();

                    Console.Write("Digite o cpf: ");
                    medico.CPF = Console.ReadLine();

                    Console.Write("Numero matricula: ");
                    medico.Matricula = Console.ReadLine();

                    Console.Write("Digite a data de nascimento: ");
                    medico.DataNascimento = Convert.ToDateTime(Console.ReadLine());

                    Console.Write("Digite o sexo: ");
                    medico.Sexo = Console.ReadLine();

                    Console.Write("Digite o salário: ");
                    medico.Salario = Convert.ToDouble(Console.ReadLine());

                    Console.Write("CRM: ");
                    medico.Crm = Console.ReadLine();

                    Console.Write("especialidade: ");
                    medico.Especialidade = Console.ReadLine();

                    list.Add(medico);

                    Console.WriteLine("-------------------");
                    Console.WriteLine("CADASTRADO COM SUCESSO");
                    Console.WriteLine("-------------------\n");
                    

                    while (true)
                    {
                        Console.WriteLine("1 - Sair \n2 - consultar salario \n");
                        Console.Write("Escolha uma opção: ");
                        int opcao = Convert.ToInt32(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                Console.Clear();
                                goto sair2;

                            case 2:
                                medico.salario(medico.Salario);
                                break;
                        }
                        
                    }
                sair2:;
                    break;


                default:
                    Console.WriteLine("Opção inválida!! \n");
                    break;
            }

            foreach (Funcionario str in list)
            {
                Console.WriteLine();
            }
        }
    exit:;

        
    }
}