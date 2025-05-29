using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaAmigo telaAmigo = new TelaAmigo();


            while (true)
            {
                char telaEscolhida = telaPrincipal.ApresentarMenuPrincipal();


                if (telaEscolhida == 'S') 
                    break;

                if (telaEscolhida == '1')
                {
                    char opcao = telaAmigo.ControleAmigos();

                    switch (opcao)
                    {
                        case '1':
                            telaAmigo.CadastrarAmigos();
                            break;

                        case '2':
                            telaAmigo.VisualizarAmigos();
                            break;

                        case '3':
                            telaAmigo.EditarAmigo();
                            break;
                    }

                }



            }
        }
    }
}
