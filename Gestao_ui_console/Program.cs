//using Internal;
using System.ComponentModel;
using System;
using Gestao_ui_console.Entities;
using Gestao_ui_console.Assets;
using System.Collections.Generic;

namespace Gestao_ui_console
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            List<Professor> professores = new List<Professor>();
            List<Turma> turmas = new List<Turma>();
            
            int op = 0;

            do{
                try{
                    Console.Clear();
                    Console.WriteLine("SGAN - Sistema de Gestão de Aulas de Natação");
                    Console.WriteLine("[1] - GESTAO DE PROFESSORES");
                    Console.WriteLine("[2] - GESTAO DE ALUNOS");
                    Console.WriteLine("[3] - GESTAO DE TURMAS");
                    Console.WriteLine("[4] - SAIR");
                    Console.Write("OPCAO: ");
                    op = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(op);

                    switch (op){
                        
                        case 1: 
                        Console.Clear();
                        Console.WriteLine("Professores");
                        Console.ReadKey();
                        break;

                        case 2: 
                        Console.Clear();
                        menus menu = new menus();
                        menu.menuAluno(alunos);
                        break;

                        case 3: 
                        Console.Clear();
                        Console.WriteLine("Turmas");
                        Console.ReadKey();
                        break;

                        case 4: 
                        Console.Clear();
                        Console.WriteLine("BYE!");
                        Console.ReadKey();
                        break;

                        default: 
                        Console.Clear();
                        Console.WriteLine("OPCAO INVALIDA!"); 
                        Console.ReadKey();
                        break;
                    }
                }
                catch(System.Exception e){
                    Console.Clear();
                    Console.WriteLine("VALOR INFORMADO INVÁLIDO!\n");
                    Console.WriteLine(e.Message);
                    op = 8;
                    Console.ReadKey();
                }
                
            }while(op != 4);
        }
    }
}
