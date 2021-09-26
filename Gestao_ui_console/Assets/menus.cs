using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao_ui_console.Entities;

namespace Gestao_ui_console.Assets
{
    public class menus
    {
        public void menuAluno(List<Aluno> alunos){
            int opAluno;
            try{
                Console.WriteLine("[1] - LISTAS ALUNOS");
                Console.WriteLine("[2] - CADASTRO DE ALUNO");
                Console.WriteLine("[3] - MANUTENÇÃO DE ALUNO");
                Console.WriteLine("[4] - EXCLUSÃO DE ALUNO");
                Console.Write("OPCAO: ");
                opAluno = Convert.ToInt32(Console.ReadLine());
            
                switch(opAluno){
                case 1: 
                        Console.Clear();
                        Aluno a1 = new Aluno();
                        a1.ListarAlunos(alunos);
                        Console.ReadKey();
                break;

                case 2: 
                        Console.Clear();
                        Aluno a2 = new Aluno();
                        a2.CadastrarAlunos(alunos);
                        Console.ReadKey();
                break;

                case 3: 
                        Console.Clear();
                        Aluno a3 = new Aluno();
                        a3.AtualizarAluno(alunos);
                        Console.ReadKey();
                break;

                case 4: 
                        Console.Clear();
                        Aluno a4 = new Aluno();
                        a4.ExcluirAluno(alunos);
                        Console.ReadKey();
                break;

                default:
                    Console.Clear();
                    Console.WriteLine("OPCAO INVALIDA!");
                break;
            }
            }catch(System.Exception e){
                Console.Clear();
                    Console.WriteLine("VALOR INFORMADO INVÁLIDO!\n");
                    Console.WriteLine(e.Message);
                    opAluno = 8;
                    Console.ReadKey();
            }
        }

        
        public void msgErro(string erro){
                        Console.Clear();
                        Console.WriteLine(erro+" INVALIDO(A)");
                        Console.ReadKey();
        }

        public void menuAtualizaCadastro(Aluno aluno){
            Console.Clear();
            Console.WriteLine("ALUNO: "+aluno.nome.ToUpper()+"\n");
            Console.WriteLine("[1] - ATUALIZAR NOME");
            Console.WriteLine("[2] - ATUALIZAR DATA DE NASCIMENTO");
            Console.WriteLine("[3] - ATUALIZAR E-MAIL");
            Console.WriteLine("[4] - ATUALIZAR TELEFONE");
            Console.WriteLine("[0] - VOLTAR");
            Console.Write("OPCAO: ");
            int opAC = Convert.ToInt32(Console.ReadLine());

            switch(opAC){
                case 1: 
                    Console.Clear();
                    Console.WriteLine(".:ATUALIZAÇÃO DE NOME:.\n");
                    Console.Write("NOME: ");
                    aluno.nome = Console.ReadLine();
                    Console.WriteLine("NOME ATUALIZADO COM SUCESSO!");
                    Console.WriteLine("NOVO NOME: "+aluno.nome);
                break;
                case 2:
                    Console.Clear();
                    Console.WriteLine(".:ATUALIZAÇÃO DE DATA DE NASCIMENTO:.\n");
                    Console.Write("DATA DE NASCIMENTO: ");
                    string dtnascimento = Console.ReadLine();
                    if(dtnascimento.Length > 0 && Regex.IsMatch(dtnascimento, @"^([0-2]\d)/([0-2]\d)/(\d{4})$")){
                        aluno.dtNascimento = Convert.ToDateTime(dtnascimento);
                        Console.WriteLine("DATA DE NASCIMENTO ATUALIZADA COM SUCESSO!");
                        Console.WriteLine("NOVA DATA DE NASCIMENTO: "+aluno.dtNascimento.ToString("dd/MM/yyyy"));
                        Console.ReadKey();
                    }
                    else{
                        Console.WriteLine("DATA DE NASCIMENTO INVALIDA!");
                        Console.ReadKey();
                    }
                break;
                case 3:
                    Console.Clear();
                    Console.WriteLine(".:ATUALIZAÇÃO DE E-MAIL:.\n");
                    Console.Write("E-MAIL: ");
                    string email = Console.ReadLine();

                    if(email.Length > 0 && email.Contains("@") && email.Contains(".com")){
                        aluno.email = email;
                        Console.WriteLine("EMAIL ATUALIZADO COM SUCESSO!");
                        Console.WriteLine("NOVO E-MAIL: "+aluno.email);
                        Console.ReadKey();
                    }
                    else{
                        Console.WriteLine("E-MAIL INVALIDO");
                        Console.ReadKey();
                    }
                break;
                case 4:
                    Console.Clear();
                    Console.WriteLine(".:ATUALIZACAO DE TELEFONE:.");
                    Console.Write("INFORME O NOVO TELEFONE: ");
                    string telefone = Console.ReadLine();
                    if(telefone.Length > 0 && Regex.IsMatch(telefone, @"^[0-9]+$")){
                        aluno.telefone = telefone;
                        Console.WriteLine("TELEFONE ATUALIZADO COM SUCESSO!");
                        Console.WriteLine("NOVO TELEFONE: "+aluno.telefone);
                        Console.ReadKey();
                    }
                    else{
                        Console.WriteLine("TELEFONE INVALIDO");
                        Console.ReadKey();
                    }
                break;
            }
        }
    }
}
