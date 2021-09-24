using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_ui_console.Entities
{
    public class pessoa
    {
        public Guid id = Guid.NewGuid();
        public int matricula { get; set; }
        public string nome { get; set; }
        public DateTime dtNascimento { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
    }
}