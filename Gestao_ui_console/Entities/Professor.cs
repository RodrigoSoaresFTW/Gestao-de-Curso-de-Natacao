using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_ui_console.Entities
{
    public class Professor
    {
        public Guid idProfessor = Guid.NewGuid();
        public string nome { get; set; }
        public DateTime dtNascimento { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
    }
}
