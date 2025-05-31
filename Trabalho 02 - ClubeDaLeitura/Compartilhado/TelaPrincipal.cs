using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_02___ClubeDaLeitura.Compartilhado
{
     public class TelaPrincipal
    {
        private int opcaoEscolhida;

        public int ApresentarMenuPrincipal()
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
            Console.WriteLine("5 - Sair");

            Console.WriteLine();

            Console.Write("Escolha uma opção válida: ");
            opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

            return opcaoEscolhida;
        }

    }
}
