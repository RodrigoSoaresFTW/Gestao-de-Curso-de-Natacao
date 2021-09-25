using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gestao_ui_console.Entities;

namespace Gestao_ui_console.Assets
{
    public class Cadastro
    {
            public int matricula(List<Aluno>alunos){
                Random rand = new Random();
                int id = rand.Next(1,101);
                bool matOK = false;
                
                if(alunos.Count()>0){
                    for(int i = 0; i < alunos.Count(); i++){
                        int mat = alunos[i].matricula;
                        if(id == mat){
                            matOK = true;
                        }
                    }
                    if(!matOK){
                    return id;
                    }
                    else{
                        return matricula(alunos);
                    }  
                }else{
                    return id;
                }
            }
    }
}
