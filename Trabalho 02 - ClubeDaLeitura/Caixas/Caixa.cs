using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Caixas
{
    public class Caixas : EntidadeBase
    {
        public int id;
        public string etiqueta;
        public string cor;
        public  int dias;

        public override void AtualizarRegistro(EntidadeBase entidade)
        {
            Caixas caixaAtualizado = (Caixas)entidade;

            this.etiqueta = caixaAtualizado.etiqueta;
            this.cor = caixaAtualizado.cor;
            
        }

        public override string Validar()
        {
            string erros = "";

            if (etiqueta.Length > 50)
                erros += "O campo \"Etiqueta\" deve conter no máximo 50 caracteres.\n";

            if (cor != "branco" && cor != "azul" && cor != "verde" && cor != "vermelho" && cor != "amarelo")
                erros += "O campo \"Cor\" deve conter uma das cores válidas.\n";

            return erros;
        }

        
    }
}
