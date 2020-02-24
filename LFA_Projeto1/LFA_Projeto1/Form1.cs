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

            //Fim Logica

            lblFrase.Text = resultado;
        }

        private void btnCriarGrafo_Click(object sender, EventArgs e)
        {
            FormGrafo fg = new FormGrafo(grafo);
            fg.ShowDialog();
        }
    }
}
