using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Caixas;
using Trabalho_02___ClubeDaLeitura.Compartilhado;
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
                int telaEscolhida = telaPrincipal.ApresentarMenuPrincipal();

                if (telaEscolhida == 5)
                    break;

                if (telaEscolhida == 1)
                {
                    int opcao = telaAmigo.ControleAmigos();

                    switch (opcao)
                    {
                        case 1:
                            telaAmigo.CadastrarRegistro();
                            break;

                        case 2:
                            telaAmigo.VisualizarRegistros();
                            break;

                        case 3:
                            telaAmigo.EditarRegistro();
                            break;
                        case 4:
                            telaAmigo.ExcluirRegistro();
                            break;
                    }
                }

                if (telaEscolhida == 2)
                {
                    int opcao = telaCaixas.ControleDeCaixas();

                    switch (opcao)
                    {
                        case 1:
                            telaCaixas.CadastrarRegistro();
                            break;
                        case 2:
                            telaCaixas.VisualizarRegistros();
                            break;

                        case 3:
                            telaCaixas.EditarRegistro();
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
