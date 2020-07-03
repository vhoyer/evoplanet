namespace Teste
{
    partial class frmRoma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoma));
            this.PctrColiseu = new System.Windows.Forms.PictureBox();
            this.pctrCasa = new System.Windows.Forms.PictureBox();
            this.pctrMercado = new System.Windows.Forms.PictureBox();
            this.pctrTreinamento = new System.Windows.Forms.PictureBox();
            this.pctrBiblio = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PctrColiseu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMercado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrTreinamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBiblio)).BeginInit();
            this.SuspendLayout();
            // 
            // PctrColiseu
            // 
            this.PctrColiseu.BackColor = System.Drawing.Color.Transparent;
            this.PctrColiseu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PctrColiseu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PctrColiseu.Location = new System.Drawing.Point(302, 159);
            this.PctrColiseu.Name = "PctrColiseu";
            this.PctrColiseu.Size = new System.Drawing.Size(223, 130);
            this.PctrColiseu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PctrColiseu.TabIndex = 0;
            this.PctrColiseu.TabStop = false;
            this.PctrColiseu.Click += new System.EventHandler(this.PicbColiseu_Click);
            // 
            // pctrCasa
            // 
            this.pctrCasa.BackColor = System.Drawing.Color.Transparent;
            this.pctrCasa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrCasa.Location = new System.Drawing.Point(1, 249);
            this.pctrCasa.MaximumSize = new System.Drawing.Size(109, 69);
            this.pctrCasa.MinimumSize = new System.Drawing.Size(109, 69);
            this.pctrCasa.Name = "pctrCasa";
            this.pctrCasa.Size = new System.Drawing.Size(109, 69);
            this.pctrCasa.TabIndex = 1;
            this.pctrCasa.TabStop = false;
            this.pctrCasa.Click += new System.EventHandler(this.PicBCasa_Click);
            // 
            // pctrMercado
            // 
            this.pctrMercado.BackColor = System.Drawing.Color.Transparent;
            this.pctrMercado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrMercado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrMercado.Location = new System.Drawing.Point(21, 179);
            this.pctrMercado.Name = "pctrMercado";
            this.pctrMercado.Size = new System.Drawing.Size(156, 64);
            this.pctrMercado.TabIndex = 2;
            this.pctrMercado.TabStop = false;
            this.pctrMercado.Click += new System.EventHandler(this.pctrMercado_Click);
            // 
            // pctrTreinamento
            // 
            this.pctrTreinamento.BackColor = System.Drawing.Color.Transparent;
            this.pctrTreinamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrTreinamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrTreinamento.Location = new System.Drawing.Point(539, 190);
            this.pctrTreinamento.Name = "pctrTreinamento";
            this.pctrTreinamento.Size = new System.Drawing.Size(124, 53);
            this.pctrTreinamento.TabIndex = 3;
            this.pctrTreinamento.TabStop = false;
            this.pctrTreinamento.Click += new System.EventHandler(this.pctrTreinamento_Click);
            // 
            // pctrBiblio
            // 
            this.pctrBiblio.BackColor = System.Drawing.Color.Transparent;
            this.pctrBiblio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctrBiblio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctrBiblio.Location = new System.Drawing.Point(486, 1);
            this.pctrBiblio.Name = "pctrBiblio";
            this.pctrBiblio.Size = new System.Drawing.Size(177, 98);
            this.pctrBiblio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrBiblio.TabIndex = 4;
            this.pctrBiblio.TabStop = false;
            this.pctrBiblio.Click += new System.EventHandler(this.pctrBiblio_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(577, 352);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // frmRoma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.Mapa;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(664, 387);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pctrBiblio);
            this.Controls.Add(this.pctrTreinamento);
            this.Controls.Add(this.pctrMercado);
            this.Controls.Add(this.pctrCasa);
            this.Controls.Add(this.PctrColiseu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(680, 426);
            this.MinimumSize = new System.Drawing.Size(680, 426);
            this.Name = "frmRoma";
            this.Text = "Roma";
            ((System.ComponentModel.ISupportInitialize)(this.PctrColiseu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrCasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrMercado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrTreinamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBiblio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PctrColiseu;
        private System.Windows.Forms.PictureBox pctrCasa;
        private System.Windows.Forms.PictureBox pctrMercado;
        private System.Windows.Forms.PictureBox pctrTreinamento;
        private System.Windows.Forms.PictureBox pctrBiblio;
        private System.Windows.Forms.Button btnVoltar;
    }
}

