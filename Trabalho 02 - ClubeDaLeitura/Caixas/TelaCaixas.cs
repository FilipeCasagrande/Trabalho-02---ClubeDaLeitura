﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_02___ClubeDaLeitura.Amigos;
using Trabalho_02___ClubeDaLeitura.Compartilhado;

namespace Trabalho_02___ClubeDaLeitura.Caixas
{
    public class TelaCaixas : TelaBase
    {

        private RepositorioCaixas repositorioCaixas;

        public TelaCaixas(RepositorioCaixas repositorioCaixas) : base("Caixas", repositorioCaixas)
        {
            this.repositorioCaixas = repositorioCaixas;
        }
        public int ControleDeCaixas()
        {

            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Controle de Caixas    ");
            Console.WriteLine("---------------------------");

            Console.WriteLine();

            Console.WriteLine("1 - Inserir novas Caixas");
            Console.WriteLine("2 - Visualizar Todas as caixas ");
            Console.WriteLine("3 - Editar Caixa");
            Console.WriteLine("4 - Excluir Caixas");
            Console.WriteLine("5 - Sair");

            Console.WriteLine();
            Console.Write("Infome uma opção válida:");
            int opcao = Convert.ToInt32(Console.ReadLine());
            return opcao;
        }

            protected override Caixas  ObterDados() 
        {
            Console.WriteLine("Informe o nome da etiqueta");
            string etiqueta = Console.ReadLine();

            Console.WriteLine("Informe a cor da etiqueta, Branco, Azul, Verde, Vermelho ou Amarelo");
            string cor = Console.ReadLine().ToLower();

            Console.WriteLine("Defina o prazo maximo de emprestimo da caixa");
            int dias = Convert.ToInt32(Console.ReadLine());

            EntidadeBase[] verificarCaixas = repositorioCaixas.SelecionarRegistros();

            foreach (Caixas c in verificarCaixas)
            {
                if (c != null && c.etiqueta == etiqueta)
                {
                    Console.WriteLine("Já existe uma etiqueta cadastrada com esse nome, cadastre novamente");
                    Console.WriteLine();
                    ObterDados();
                    return null;
                }
            }

            Caixas caixa = new Caixas();

            caixa.etiqueta = etiqueta;
            caixa.cor = cor;
            caixa.dias = dias;

            return caixa;
        }

        public override void VisualizarRegistros()
        {
            Console.Clear();
            Console.WriteLine("---------------------------");
            Console.WriteLine("     Visualizar Caixas     ");
            Console.WriteLine("---------------------------");

            Console.WriteLine("Visualização de Caixas");

            Console.WriteLine();

            Console.WriteLine(
                "{0, -10} | {1, -10} | {2, -20} | {3, -30}",
                 "ID", "Etiqueta", "Cor", "Dias"
            );

            EntidadeBase[] caixas = repositorioCaixas.SelecionarRegistros();

            for (int i = 0; i < caixas.Length; i++)
            {
                Caixas c = (Caixas)caixas[i];

                if (c == null)
                    continue;

                Console.WriteLine(
                   "{0, -10} | {1, -10} | {2, -20} | {3, -30} ",
                    c.id, c.etiqueta, c.cor, c.dias
                );
            }
            Console.ReadLine();
        }
    }
    
}
