using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_02___ClubeDaLeitura.Compartilhado
{
     public class TelaPrincipal
    {
        private char opcaoEscolhida;

        public char ApresentarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("       Clube do Livro      ");
            Console.WriteLine("---------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Controle de Amigos");
            Console.WriteLine("2 - Controle de Caixas");
            Console.WriteLine("3 - Controle de Revistas");
            Console.WriteLine("4 - Controle de Emprestimos");
            Console.WriteLine("S - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma opção válida: ");
            opcaoEscolhida = Console.ReadLine().ToUpper()[0];

            return opcaoEscolhida;
        }

    }
}
