namespace LFA_Projeto1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaFrase = new System.Windows.Forms.Button();
            this.lblFrase = new System.Windows.Forms.Label();
            this.btnCriarGrafo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNovaFrase
            // 
            this.btnNovaFrase.Location = new System.Drawing.Point(53, 31);
            this.btnNovaFrase.Name = "btnNovaFrase";
            this.btnNovaFrase.Size = new System.Drawing.Size(126, 49);
            this.btnNovaFrase.TabIndex = 0;
            this.btnNovaFrase.Text = "Nova Frase";
            this.btnNovaFrase.UseVisualStyleBackColor = true;
            this.btnNovaFrase.Click += new System.EventHandler(this.btnNovaFrase_Click);
            // 
            // lblFrase
            // 
            this.lblFrase.AutoSize = true;
            this.lblFrase.Location = new System.Drawing.Point(50, 224);
            this.lblFrase.Name = "lblFrase";
            this.lblFrase.Size = new System.Drawing.Size(44, 17);
            this.lblFrase.TabIndex = 1;
            this.lblFrase.Text = "Frase";
            // 
            // btnCriarGrafo
            // 
            this.btnCriarGrafo.Location = new System.Drawing.Point(509, 31);
            this.btnCriarGrafo.Name = "btnCriarGrafo";
            this.btnCriarGrafo.Size = new System.Drawing.Size(142, 49);
            this.btnCriarGrafo.TabIndex = 2;
            this.btnCriarGrafo.Text = "Grafo";
            this.btnCriarGrafo.UseVisualStyleBackColor = true;
            this.btnCriarGrafo.Click += new System.EventHandler(this.btnCriarGrafo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCriarGrafo);
            this.Controls.Add(this.lblFrase);
            this.Controls.Add(this.btnNovaFrase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNovaFrase;
        private System.Windows.Forms.Label lblFrase;
        private System.Windows.Forms.Button btnCriarGrafo;
    }
}

