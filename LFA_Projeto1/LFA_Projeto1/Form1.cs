using LFA_Projeto1.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LFA_Projeto1
{
    public partial class Form1 : Form
    {
        public Grafo grafo = new Grafo();

        public Form1()
        {
            InitializeComponent();
            var no1 = grafo.CriarGrafos(lerCSV(@"pronomes.csv"));
            var no2 = grafo.CriarGrafos(lerCSV(@"substantivos.csv"));
            var no3 = grafo.CriarGrafos(lerCSV(@"verbos.csv"));
            var no4 = grafo.CriarGrafos(lerCSV(@"adjetivos.csv"));
            var no5 = grafo.CriarGrafos(new List<string>() {"the"});
            grafo.CriarAresta(no1, no3);
            grafo.CriarAresta(no3, no5);
            grafo.CriarAresta(no5, no2);
            grafo.CriarAresta(no3, no4);
            grafo.CriarAresta(no2, null);
            grafo.CriarAresta(no4, null);
        }

        private void btnNovaFrase_Click(object sender, EventArgs e)
        {
            string resultado = null;

            //Logica
            //Le o arquivo em csv e transforma em uma lista de strings
            //var listaPronomes = lerCSV(@"pronomes.csv");
            //var listaSubstantivos = lerCSV(@"substantivos.csv");
            //var listaVerbos = lerCSV(@"verbos.csv");
            //var listaAdjetivos = lerCSV(@"adjetivos.csv");

            ////Pegar uma palavra aleatório da lista
            //var pronome = pegarPalavra(listaPronomes);
            //var verbo = pegarPalavra(listaVerbos);
            //var adjetivo = pegarPalavra(listaAdjetivos);

            //Random aleatorio = new Random();
            //var estrutura = aleatorio.Next(1, 3);

            ////Fim Logica
            //if (estrutura == 1)
            //{
            //    resultado = pronome + " " + verbo + " " + adjetivo + " ";
            //}
            //else if (estrutura == 2)
            //{
            //    var substantivoSimples = pegarPalavra(listaSubstantivos);
            //    resultado = pronome + " " + verbo + " the " + substantivoSimples;
            //}
            resultado = NavegarGrafo(1);

            lblFrase.Text = resultado;
        }

        private void btnCriarGrafo_Click(object sender, EventArgs e)
        {
            FormGrafo fg = new FormGrafo(grafo);
            fg.ShowDialog();
        }

        private List<string> lerCSV(string nome)
        {
            var lista = File.ReadAllText(nome).Split(',').ToList();
            return lista;
        }

        //private string pegarPalavra(List<string> lista)
        //{
        //    Random numeroAleatorio = new Random();
        //    return lista[numeroAleatorio.Next(0, lista.Count)];
        //}

        private string NavegarGrafo(int x)
        {
            No no1 = grafo.Nos.Find(lamba => lamba.Id == x);
            List<Aresta> arestas = grafo.Arestas.FindAll(lamba => lamba.Node1.Id == no1.Id);
            if (arestas.Count >1) {
                Random n = new Random();
                return no1.PalavraAleatoria() + " " + NavegarGrafo(arestas[n.Next(0,arestas.Count)].Node2.Id);
            }
            else
            {
                if (arestas[0].Node2 == null)
                {
                    return no1.PalavraAleatoria();
                }
                return no1.PalavraAleatoria() + " " + NavegarGrafo(arestas[0].Node2.Id);
            }
        }
    }
}
