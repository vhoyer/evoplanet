namespace Jogo
{
    partial class PreHistoriaMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreHistoriaMap));
            this.btnSair = new System.Windows.Forms.Button();
            this.lblFloresta = new System.Windows.Forms.Label();
            this.lblVulcao = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblConstru = new System.Windows.Forms.Label();
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblBar = new System.Windows.Forms.Label();
            this.lblMuseu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(502, 475);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair >>";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblFloresta
            // 
            this.lblFloresta.BackColor = System.Drawing.Color.Transparent;
            this.lblFloresta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFloresta.Location = new System.Drawing.Point(97, -1);
            this.lblFloresta.Name = "lblFloresta";
            this.lblFloresta.Size = new System.Drawing.Size(154, 118);
            this.lblFloresta.TabIndex = 8;
            this.lblFloresta.Click += new System.EventHandler(this.lblFloresta_Click);
            // 
            // lblVulcao
            // 
            this.lblVulcao.BackColor = System.Drawing.Color.Transparent;
            this.lblVulcao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblVulcao.Location = new System.Drawing.Point(288, 40);
            this.lblVulcao.Name = "lblVulcao";
            this.lblVulcao.Size = new System.Drawing.Size(99, 130);
            this.lblVulcao.TabIndex = 9;
            this.lblVulcao.Click += new System.EventHandler(this.lblVulc_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.BackColor = System.Drawing.Color.Transparent;
            this.lblCampo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCampo.Location = new System.Drawing.Point(161, 170);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(132, 91);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Click += new System.EventHandler(this.lblCampo_Click);
            // 
            // lblConstru
            // 
            this.lblConstru.BackColor = System.Drawing.Color.Transparent;
            this.lblConstru.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblConstru.Location = new System.Drawing.Point(299, 261);
            this.lblConstru.Name = "lblConstru";
            this.lblConstru.Size = new System.Drawing.Size(88, 72);
            this.lblConstru.TabIndex = 11;
            this.lblConstru.Click += new System.EventHandler(this.lblConstru_Click);
            // 
            // lblCasa
            // 
            this.lblCasa.BackColor = System.Drawing.Color.Transparent;
            this.lblCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCasa.Location = new System.Drawing.Point(158, 311);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(80, 72);
            this.lblCasa.TabIndex = 12;
            this.lblCasa.Click += new System.EventHandler(this.lblCasa_Click);
            // 
            // lblBar
            // 
            this.lblBar.BackColor = System.Drawing.Color.Transparent;
            this.lblBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBar.Location = new System.Drawing.Point(94, 275);
            this.lblBar.Name = "lblBar";
            this.lblBar.Size = new System.Drawing.Size(58, 48);
            this.lblBar.TabIndex = 13;
            this.lblBar.Click += new System.EventHandler(this.lblBar_Click);
            // 
            // lblMuseu
            // 
            this.lblMuseu.BackColor = System.Drawing.Color.Transparent;
            this.lblMuseu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMuseu.Location = new System.Drawing.Point(50, 202);
            this.lblMuseu.Name = "lblMuseu";
            this.lblMuseu.Size = new System.Drawing.Size(67, 59);
            this.lblMuseu.TabIndex = 14;
            this.lblMuseu.Click += new System.EventHandler(this.lblMuseu_Click);
            // 
            // PreHistoriaMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.MapaPreHistoria1;
            this.ClientSize = new System.Drawing.Size(589, 510);
            this.ControlBox = false;
            this.Controls.Add(this.lblMuseu);
            this.Controls.Add(this.lblBar);
            this.Controls.Add(this.lblCasa);
            this.Controls.Add(this.lblConstru);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.lblVulcao);
            this.Controls.Add(this.lblFloresta);
            this.Controls.Add(this.btnSair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(605, 549);
            this.MinimumSize = new System.Drawing.Size(605, 549);
            this.Name = "PreHistoriaMap";
            this.Text = "Mapa da Pré-História";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblFloresta;
        private System.Windows.Forms.Label lblVulcao;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblConstru;
        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblBar;
        private System.Windows.Forms.Label lblMuseu;
    }
}