using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao_ui_console.Entities;

namespace Gestao_ui_console.Assets
{
    public class Cadastro
    {
        public string cadastroNome(){
            
            Console.Write("NOME: ");
            string nome = Console.ReadLine();
            return nome;
        }
    }
}
