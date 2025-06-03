using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Emprestimo
{
    public class RepositorioEmprestimo: RepositorioBase
    {
        public bool TemEmprestimoDoAmigo(int idAmigo)
        {
            foreach (EntidadeBase entidade in SelecionarRegistros())
            {
                if (entidade == null)
                    continue;

                Emprestimo emprestimo = (Emprestimo)entidade;

                if (emprestimo.idAmigo == idAmigo)
                    return true;
            }

            return false;
        }
    }
}
