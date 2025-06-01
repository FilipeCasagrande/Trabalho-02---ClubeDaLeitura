using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Caixas;
using Trabalho_02___ClubeDaLeitura.Compartilhado;
using Trabalho_02___ClubeDaLeitura.Emprestimo;
using Trabalho_02___ClubeDaLeitura.Revistas;

namespace Trabalho_02___ClubeDaLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioAmigo repositorioAmigo = new RepositorioAmigo();
            RepositorioCaixas repositorioCaixas = new RepositorioCaixas();
            RepositorioRevistas repositorioRevistas = new RepositorioRevistas();

            TelaRevistas telaRevistas = new TelaRevistas(repositorioCaixas, repositorioRevistas);
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaAmigo telaAmigo = new TelaAmigo(repositorioAmigo);
            TelaCaixas telaCaixas = new TelaCaixas(repositorioCaixas);

            while (true)
            {
                telaPrincipal.ApresentarMenuPrincipal();

                TelaBase telaEscolhida = telaPrincipal.ObterTela();

                if (telaEscolhida == null)
                    break;

                if (telaEscolhida == null)
                    break;

                int opcaoEscolhida = telaEscolhida.ApresentarMenu();

                if (opcaoEscolhida == 'S')
                    break;

                switch (opcaoEscolhida)
                {
                    case '1':
                        telaEscolhida.CadastrarRegistro();
                        break;

                    case '2':
                        telaEscolhida.VisualizarRegistros();
                        break;

                    case '3':
                        telaEscolhida.EditarRegistro();
                        break;

                        case 4:
                            telaCaixas.ExcluirRegistro();
                            break;
                    }

                    }
                if (telaEscolhida == 3)
                {
                    int opcaoEscolha = telaRevistas.ControleDeRevistas();

                    switch (opcaoEscolha)
                    {
                        case 1:
                            telaRevistas.CadastrarRegistro();
                            break;
                        case 2:
                            telaRevistas.VisualizarRegistros();
                            break;
                            
                        case 3:
                            telaRevistas.EditarRegistro();
                            break;
                        case 4:
                            telaRevistas.ExcluirRegistro();
                            break;
                    }
                }
            }
        }
    }
}

