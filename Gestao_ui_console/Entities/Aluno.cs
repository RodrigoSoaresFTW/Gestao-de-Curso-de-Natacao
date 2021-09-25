//using Internal;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao_ui_console.Assets;

namespace Gestao_ui_console.Entities
{
    public class Aluno : pessoa
    {
        
        
        
        public void ListarAlunos(List<Aluno>alunos){
            Console.WriteLine(".:MENU LISTAR ALUNOS.:");
            int cont = 1;
            foreach(var aluno in alunos){
                
                int idade = DateTime.Now.Year - aluno.dtNascimento.Year;
                if(DateTime.Now.DayOfYear < aluno.dtNascimento.DayOfYear){
                    idade = idade - 1;
                }

                Console.WriteLine(" "+cont+" - "+aluno.matricula+" - "+aluno.nome+" - "+idade+" anos");
                cont++;
            }
        }

        public void CadastrarAlunos(List<Aluno>alunos){
            Console.Clear();
            Console.WriteLine(".:MENU CADASTRAR ALUNO:.");
            Aluno a1 = new Aluno();
            Cadastro c = new Cadastro();
            menus m = new menus();
            
           

            try{
                Console.Write("NOME: ");
                string nome = Console.ReadLine();
                
                if(nome.Length > 0 && Regex.IsMatch(nome, @"^[a-zA-Z]+$")){
                    a1.nome = nome;

                    Console.Write("DATA NASCIMENTO: ");
                    string dtnascimento = Console.ReadLine();
                    if(dtnascimento.Length > 0 && Regex.IsMatch(dtnascimento, @"^([0-2]\d)/([0-2]\d)/(\d{4})$")){
                        a1.dtNascimento = Convert.ToDateTime(dtnascimento);

                        Console.Write("E-MAIL: ");
                        string email = Console.ReadLine();
                        if(email.Length > 0 && email.Contains("@") && email.Contains(".com")){
                            a1.email = email;

                            Console.Write("TELEFONE: ");
                            string telefone = Console.ReadLine();
                            if(telefone.Length > 0 && Regex.IsMatch(telefone, @"^[0-9]+$")){
                                a1.telefone = telefone;

                                //Random rand = new Random();
                                //a1.matricula = rand.Next(1,100);
                                a1.matricula = c.matricula(alunos);
                                alunos.Add(a1);
                                //Console.Clear();
                                Console.WriteLine("ALUNO CADASTRADO COM SUCESSO!");
                                Console.ReadKey();
                            }
                            else{
                                m.msgErro("TELEFONE");
                                a1.CadastrarAlunos(alunos);
                            }
                        }
                        else{
                            m.msgErro("EMAIL");
                            a1.CadastrarAlunos(alunos);
                        }
                        
                    }
                    else{
                        m.msgErro("DATA DE NASCIMENTO");
                        a1.CadastrarAlunos(alunos);
                    }
                }
                else{
                    m.msgErro("NOME");
                    a1.CadastrarAlunos(alunos);
                }
            
                
            }
            catch(SystemException e){
                Console.Clear();
                Console.WriteLine("ERRO! CONFIRA OS DADOS CADASTRADOS!");
                Console.WriteLine(e.Message);
                Console.ReadKey();
                a1.CadastrarAlunos(alunos);
            }
        }


        public void ExcluirAluno(List<Aluno>alunos){
            Console.WriteLine(".:MENU EXCLUIR ALUNO:.");
            Console.Write("NOME: ");
            string nomeTemp = Console.ReadLine();

            foreach(var aluno in alunos){
                if(nomeTemp == aluno.nome){
                    alunos.Remove(aluno);
                    Console.WriteLine("Aluno removido com sucesso!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
