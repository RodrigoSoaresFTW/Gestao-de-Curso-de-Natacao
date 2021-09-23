using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_ui_console.Entities
{
    public class Aluno
    {
        public Guid idAluno = Guid.NewGuid();
        public int matricula { get; set; }
        public string mome { get; set; }
        public DateTime dataNascimento { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        
    }

    
}
