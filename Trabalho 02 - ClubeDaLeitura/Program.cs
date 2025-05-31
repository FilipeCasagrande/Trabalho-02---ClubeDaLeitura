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
            
            TelaPrincipal telaPrincipal = new TelaPrincipal();

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
                    case 1:
                        telaEscolhida.CadastrarRegistro();
                        break;

                    case 2:
                        telaEscolhida.VisualizarRegistros();
                        break;

                    case 3:
                        telaEscolhida.EditarRegistro();
                        break;

                    case 4:
                        telaEscolhida.ExcluirRegistro();
                        break;
                }
            }
            
        }
    }
}
