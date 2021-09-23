using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gestao_ui_console.Entities
{
    public class Turma
    {
        public Guid idTurma = Guid.NewGuid();
        public int turno { get; set; }
        public int tipo { get; set; }
        public int responsavel { get; set; }
        public List<int> matriculados = new List<int>();
    }
}
