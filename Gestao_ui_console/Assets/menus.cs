using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_ui_console.Assets
{
    public class menus
    {
        public void menuAluno(){
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
                        Console.WriteLine("LISTAS ALUNOS");
                        Console.ReadKey();
                break;

                case 2: 
                        Console.Clear();
                        Console.WriteLine("CADASTRO ALUNO");
                        Console.ReadKey();
                break;

                case 3: 
                        Console.Clear();
                        Console.WriteLine("MANUTENÇÃO ALUNO");
                        Console.ReadKey();
                break;

                case 4: 
                        Console.Clear();
                        Console.WriteLine("EXCLUSÃO ALUNO");
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
    }
}
