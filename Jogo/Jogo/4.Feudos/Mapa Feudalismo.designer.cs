namespace Feudo
{
    partial class frmMapa_Feudalismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapa_Feudalismo));
            this.btnVoltarFeudalismo = new System.Windows.Forms.Button();
            this.btnPlantarMandioca = new System.Windows.Forms.Button();
            this.btnIgreja = new System.Windows.Forms.Button();
            this.btnCasa = new System.Windows.Forms.Button();
            this.btnArtesanato = new System.Windows.Forms.Button();
            this.btnMercadinho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltarFeudalismo
            // 
            this.btnVoltarFeudalismo.Location = new System.Drawing.Point(434, 351);
            this.btnVoltarFeudalismo.Name = "btnVoltarFeudalismo";
            this.btnVoltarFeudalismo.Size = new System.Drawing.Size(88, 23);
            this.btnVoltarFeudalismo.TabIndex = 0;
            this.btnVoltarFeudalismo.Text = "Voltar";
            this.btnVoltarFeudalismo.UseVisualStyleBackColor = true;
            this.btnVoltarFeudalismo.Click += new System.EventHandler(this.btnVoltarFeudalismo_Click);
            // 
            // btnPlantarMandioca
            // 
            this.btnPlantarMandioca.Location = new System.Drawing.Point(416, 56);
            this.btnPlantarMandioca.Name = "btnPlantarMandioca";
            this.btnPlantarMandioca.Size = new System.Drawing.Size(106, 23);
            this.btnPlantarMandioca.TabIndex = 1;
            this.btnPlantarMandioca.Text = "Manso Senhorial";
            this.btnPlantarMandioca.UseVisualStyleBackColor = true;
            this.btnPlantarMandioca.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIgreja
            // 
            this.btnIgreja.Location = new System.Drawing.Point(155, 306);
            this.btnIgreja.Name = "btnIgreja";
            this.btnIgreja.Size = new System.Drawing.Size(94, 23);
            this.btnIgreja.TabIndex = 2;
            this.btnIgreja.Text = "Igreja";
            this.btnIgreja.UseVisualStyleBackColor = true;
            this.btnIgreja.Click += new System.EventHandler(this.btnIgreja_Click);
            // 
            // btnCasa
            // 
            this.btnCasa.Location = new System.Drawing.Point(32, 167);
            this.btnCasa.Name = "btnCasa";
            this.btnCasa.Size = new System.Drawing.Size(92, 23);
            this.btnCasa.TabIndex = 3;
            this.btnCasa.Text = "Sua Casa";
            this.btnCasa.UseVisualStyleBackColor = true;
            this.btnCasa.Click += new System.EventHandler(this.btnCasa_Click);
            // 
            // btnArtesanato
            // 
            this.btnArtesanato.Location = new System.Drawing.Point(76, 263);
            this.btnArtesanato.Name = "btnArtesanato";
            this.btnArtesanato.Size = new System.Drawing.Size(81, 23);
            this.btnArtesanato.TabIndex = 4;
            this.btnArtesanato.Text = "Artesanato";
            this.btnArtesanato.UseVisualStyleBackColor = true;
            this.btnArtesanato.Click += new System.EventHandler(this.btnArtesanato_Click);
            // 
            // btnMercadinho
            // 
            this.btnMercadinho.Location = new System.Drawing.Point(290, 315);
            this.btnMercadinho.Name = "btnMercadinho";
            this.btnMercadinho.Size = new System.Drawing.Size(75, 23);
            this.btnMercadinho.TabIndex = 5;
            this.btnMercadinho.Text = "Mercadinho";
            this.btnMercadinho.UseVisualStyleBackColor = true;
            this.btnMercadinho.Click += new System.EventHandler(this.btnMercadinho_Click);
            // 
            // frmMapa_Feudalismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(534, 386);
            this.ControlBox = false;
            this.Controls.Add(this.btnMercadinho);
            this.Controls.Add(this.btnArtesanato);
            this.Controls.Add(this.btnCasa);
            this.Controls.Add(this.btnIgreja);
            this.Controls.Add(this.btnPlantarMandioca);
            this.Controls.Add(this.btnVoltarFeudalismo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(550, 425);
            this.MinimumSize = new System.Drawing.Size(550, 425);
            this.Name = "frmMapa_Feudalismo";
            this.Text = "Mapa do Feudo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarFeudalismo;
        private System.Windows.Forms.Button btnPlantarMandioca;
        private System.Windows.Forms.Button btnIgreja;
        private System.Windows.Forms.Button btnCasa;
        private System.Windows.Forms.Button btnArtesanato;
        private System.Windows.Forms.Button btnMercadinho;
    }
}