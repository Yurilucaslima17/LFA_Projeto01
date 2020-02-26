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
        Grafo grafo = new Grafo();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNovaFrase_Click(object sender, EventArgs e)
        {
            string resultado = null;

            //Logica
            //Le o arquivo em csv e transforma em uma lista de strings
            var listaPronomes = lerCSV(@"pronomes.csv");
            var listaSubstantivos = lerCSV(@"substantivos.csv");
            var listaVerbos = lerCSV(@"verbos.csv");
            var listaAdjetivos = lerCSV(@"adjetivos.csv");

            //Pegar uma palavra aleatório da lista
            var pronome = pegarPalavra(listaPronomes);
            var verbo = pegarPalavra(listaVerbos);
            var adjetivo = pegarPalavra(listaAdjetivos);

            Random aleatorio = new Random();
            var estrutura  = aleatorio.Next(1, 3);

            //Fim Logica
            if(estrutura == 1)
            {
                resultado = pronome + " " + verbo + " " + adjetivo + " ";
            }
            else if (estrutura == 2)
            {
                var substantivoSimples = pegarPalavra(listaSubstantivos);
                resultado = pronome + " " + verbo + " the " + substantivoSimples;
            }
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

        private string pegarPalavra(List<string> lista)
        {
            Random numeroAleatorio = new Random();
            return lista[numeroAleatorio.Next(0, lista.Count)];
        }
    }
}
