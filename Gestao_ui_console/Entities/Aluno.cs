using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_ui_console.Entities
{
    public class Aluno : pessoa
    {
        
        public void ListarAlunos(List<Aluno>alunos){
            int cont = 0;
            foreach(var aluno in alunos){
                String idade = Convert.ToString(DateTime.Now - aluno.dtNascimento);
                Console.WriteLine(" "+cont+" - "+aluno.matricula+" - "+aluno.nome+" - "+idade+" anos");
                cont++;
            }
        }

        public void CadastrarAlunos(List<Aluno>alunos){
            Aluno a1 = new Aluno();

            Console.Write("NOME: ");
            a1.nome = Console.ReadLine();

            Console.Write("DATA NASCIMENTO: ");
            a1.dtNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.Write("E-MAIL: ");
            a1.email = Console.ReadLine();

            Console.Write("TELEFONE: ");
            a1.telefone = Console.ReadLine();

            Random rand = new Random();

            a1.matricula = rand.Next();

            alunos.Add(a1);

        }
    }
}
