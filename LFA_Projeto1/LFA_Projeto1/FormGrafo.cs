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

namespace LFA_Projeto1
{
    public partial class FormGrafo : Form
    {
        public Grafo Grafo { get; set; }
        public FormGrafo(Grafo grafo)
        {
            InitializeComponent();
            Grafo = grafo;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            No[] ItemObject = new No[grafo.Nos.Count];
            for (int i = 0; i < grafo.Nos.Count; i++)
            {
                ItemObject[i] = grafo.Nos[i];
            }
            Aresta[] ItemObject1 = new Aresta[grafo.Arestas.Count];
            for (int i = 0; i < grafo.Arestas.Count; i++)
            {
                ItemObject1[i] = grafo.Arestas[i];
            }
            comboBox1.Items.AddRange(ItemObject);
            comboBox2.Items.AddRange(ItemObject);
            dataGridView1.DataSource = Grafo.Nos;
            dataGridView2.DataSource = Grafo.Arestas;
        }

        private void btnNovaAresta_Click(object sender, EventArgs e)
        {
            Grafo.CriarAresta(Grafo.Procurar(comboBox1.SelectedItem), Grafo.Procurar(comboBox2.SelectedItem));
        }

        private void btnNovoNo_Click(object sender, EventArgs e)
        {
            Grafo.CriarGrafos(txtPath.Text);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
