using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Caixas;
using Trabalho_02___ClubeDaLeitura.Emprestimo;
using Trabalho_02___ClubeDaLeitura.Revistas;

namespace Trabalho_02___ClubeDaLeitura.Compartilhado
{
     public class TelaPrincipal
    {
        private RepositorioEmprestimo repositorioEmprestimo;
        private RepositorioAmigo repositorioAmigo;
        private RepositorioCaixas repositorioCaixas;
        private RepositorioRevistas repositorioRevistas;

        private TelaAmigo telaAmigo;
        private TelaCaixas telaCaixas;
        private TelaRevistas telaRevistas;
        private TelaEmprestimo telaEmprestimo;

        public TelaPrincipal()
        {
            repositorioEmprestimo = new RepositorioEmprestimo();
            repositorioAmigo = new RepositorioAmigo();
            repositorioCaixas = new RepositorioCaixas();
            repositorioRevistas = new RepositorioRevistas();

            telaCaixas = new TelaCaixas(repositorioCaixas);
            telaAmigo = new TelaAmigo(repositorioAmigo,repositorioCaixas);
            telaRevistas = new TelaRevistas(repositorioRevistas, repositorioAmigo, repositorioCaixas);
            telaEmprestimo = new TelaEmprestimo(repositorioEmprestimo, repositorioRevistas, repositorioAmigo, repositorioCaixas);


        }

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

        public TelaBase ObterTela()
        {
            if (opcaoEscolhida == 1)
                return telaAmigo;

            else if (opcaoEscolhida == 2)
                return telaCaixas;

            else if (opcaoEscolhida == 3)
                return telaRevistas;
            else if (opcaoEscolhida == 4)
                return telaEmprestimo;

                return null;
        }

    }
}
