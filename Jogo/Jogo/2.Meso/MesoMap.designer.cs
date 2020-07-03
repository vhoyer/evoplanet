namespace Jogo
{
    partial class frmMapa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa));
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblMercado = new System.Windows.Forms.Label();
            this.lblTrabalhar = new System.Windows.Forms.Label();
            this.lblLinguas = new System.Windows.Forms.Label();
            this.lblMat = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblExplorar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCasa
            // 
            this.lblCasa.BackColor = System.Drawing.Color.Transparent;
            this.lblCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCasa.Location = new System.Drawing.Point(36, 436);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(56, 51);
            this.lblCasa.TabIndex = 1;
            this.lblCasa.Click += new System.EventHandler(this.lblCasa_Click);
            // 
            // lblMercado
            // 
            this.lblMercado.BackColor = System.Drawing.Color.Transparent;
            this.lblMercado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMercado.Location = new System.Drawing.Point(36, 249);
            this.lblMercado.Name = "lblMercado";
            this.lblMercado.Size = new System.Drawing.Size(56, 51);
            this.lblMercado.TabIndex = 2;
            this.lblMercado.Click += new System.EventHandler(this.lblMercado_Click);
            // 
            // lblTrabalhar
            // 
            this.lblTrabalhar.BackColor = System.Drawing.Color.Transparent;
            this.lblTrabalhar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrabalhar.Location = new System.Drawing.Point(414, 136);
            this.lblTrabalhar.Name = "lblTrabalhar";
            this.lblTrabalhar.Size = new System.Drawing.Size(56, 51);
            this.lblTrabalhar.TabIndex = 3;
            this.lblTrabalhar.Click += new System.EventHandler(this.lblTrabalhar_Click);
            // 
            // lblLinguas
            // 
            this.lblLinguas.BackColor = System.Drawing.Color.Transparent;
            this.lblLinguas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLinguas.Location = new System.Drawing.Point(183, 27);
            this.lblLinguas.Name = "lblLinguas";
            this.lblLinguas.Size = new System.Drawing.Size(56, 51);
            this.lblLinguas.TabIndex = 4;
            this.lblLinguas.Click += new System.EventHandler(this.lblLinguas_Click);
            // 
            // lblMat
            // 
            this.lblMat.BackColor = System.Drawing.Color.Transparent;
            this.lblMat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMat.Location = new System.Drawing.Point(268, 9);
            this.lblMat.Name = "lblMat";
            this.lblMat.Size = new System.Drawing.Size(56, 51);
            this.lblMat.TabIndex = 5;
            this.lblMat.Click += new System.EventHandler(this.lblMat_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(426, 476);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 6;
            this.btnVoltar.Text = "Voltar >>";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblExplorar
            // 
            this.lblExplorar.BackColor = System.Drawing.Color.Transparent;
            this.lblExplorar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblExplorar.Location = new System.Drawing.Point(330, 9);
            this.lblExplorar.Name = "lblExplorar";
            this.lblExplorar.Size = new System.Drawing.Size(171, 51);
            this.lblExplorar.TabIndex = 7;
            this.lblExplorar.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMapa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.MesoMap;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(513, 511);
            this.ControlBox = false;
            this.Controls.Add(this.lblExplorar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblMat);
            this.Controls.Add(this.lblLinguas);
            this.Controls.Add(this.lblTrabalhar);
            this.Controls.Add(this.lblMercado);
            this.Controls.Add(this.lblCasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(529, 550);
            this.MinimumSize = new System.Drawing.Size(529, 550);
            this.Name = "frmMapa";
            this.Text = "Mapa";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblMercado;
        private System.Windows.Forms.Label lblTrabalhar;
        private System.Windows.Forms.Label lblLinguas;
        private System.Windows.Forms.Label lblMat;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblExplorar;
    }
}