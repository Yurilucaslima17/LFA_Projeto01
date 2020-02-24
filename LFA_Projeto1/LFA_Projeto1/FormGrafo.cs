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

            System.Object[] ItemObject = new System.Object[grafo.Grafos.Count];
            for (int i = 0; i <= grafo.Grafos.Count; i++)
            {
                ItemObject[i] = grafo.Grafos[i];
            }
            comboBox1.Items.AddRange(ItemObject);
            comboBox2.Items.AddRange(ItemObject);
            dataGridView1.DataSource = Grafo.Grafos;
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
