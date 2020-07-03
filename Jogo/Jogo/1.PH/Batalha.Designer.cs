namespace Jogo
{
    partial class Batalha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Batalha));
            this.lblClicar = new System.Windows.Forms.Label();
            this.lblMensagem1 = new System.Windows.Forms.Label();
            this.pctrVilao = new System.Windows.Forms.PictureBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.btnAtk4 = new System.Windows.Forms.Button();
            this.btnAtk3 = new System.Windows.Forms.Button();
            this.btnAtk2 = new System.Windows.Forms.Button();
            this.btnAtk1 = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnCapturar = new System.Windows.Forms.Button();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.barRivalHP = new System.Windows.Forms.ProgressBar();
            this.lblRivalN = new System.Windows.Forms.Label();
            this.lblPLayerHP = new System.Windows.Forms.Label();
            this.barPlayerHP = new System.Windows.Forms.ProgressBar();
            this.lblPlayerN = new System.Windows.Forms.Label();
            this.pctrPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrVilao)).BeginInit();
            this.pnl1.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClicar
            // 
            this.lblClicar.BackColor = System.Drawing.Color.Transparent;
            this.lblClicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblClicar.Location = new System.Drawing.Point(12, 104);
            this.lblClicar.Name = "lblClicar";
            this.lblClicar.Size = new System.Drawing.Size(765, 351);
            this.lblClicar.TabIndex = 6;
            this.lblClicar.Click += new System.EventHandler(this.lblClicar_Click);
            // 
            // lblMensagem1
            // 
            this.lblMensagem1.AutoSize = true;
            this.lblMensagem1.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem1.Location = new System.Drawing.Point(15, 15);
            this.lblMensagem1.Name = "lblMensagem1";
            this.lblMensagem1.Size = new System.Drawing.Size(241, 23);
            this.lblMensagem1.TabIndex = 0;
            this.lblMensagem1.Text = "Esse campo parece inabitado...";
            // 
            // pctrVilao
            // 
            this.pctrVilao.BackColor = System.Drawing.Color.Transparent;
            this.pctrVilao.Image = global::Jogo.Properties.Resources.Tiranossauro;
            this.pctrVilao.ImageLocation = "";
            this.pctrVilao.Location = new System.Drawing.Point(-213, 12);
            this.pctrVilao.Name = "pctrVilao";
            this.pctrVilao.Size = new System.Drawing.Size(216, 211);
            this.pctrVilao.TabIndex = 5;
            this.pctrVilao.TabStop = false;
            // 
            // pnl1
            // 
            this.pnl1.BackColor = System.Drawing.SystemColors.Control;
            this.pnl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl1.Controls.Add(this.pnl3);
            this.pnl1.Controls.Add(this.pnl2);
            this.pnl1.Controls.Add(this.lblMensagem1);
            this.pnl1.Location = new System.Drawing.Point(12, 467);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(765, 126);
            this.pnl1.TabIndex = 4;
            // 
            // pnl3
            // 
            this.pnl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl3.Controls.Add(this.btnAtk4);
            this.pnl3.Controls.Add(this.btnAtk3);
            this.pnl3.Controls.Add(this.btnAtk2);
            this.pnl3.Controls.Add(this.btnAtk1);
            this.pnl3.Location = new System.Drawing.Point(424, 7);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(300, 110);
            this.pnl3.TabIndex = 5;
            this.pnl3.Visible = false;
            // 
            // btnAtk4
            // 
            this.btnAtk4.Enabled = false;
            this.btnAtk4.Location = new System.Drawing.Point(13, 59);
            this.btnAtk4.Name = "btnAtk4";
            this.btnAtk4.Size = new System.Drawing.Size(123, 42);
            this.btnAtk4.TabIndex = 16;
            this.btnAtk4.UseVisualStyleBackColor = true;
            this.btnAtk4.Click += new System.EventHandler(this.btnAtk4_Click);
            // 
            // btnAtk3
            // 
            this.btnAtk3.Enabled = false;
            this.btnAtk3.Location = new System.Drawing.Point(149, 59);
            this.btnAtk3.Name = "btnAtk3";
            this.btnAtk3.Size = new System.Drawing.Size(123, 42);
            this.btnAtk3.TabIndex = 15;
            this.btnAtk3.UseVisualStyleBackColor = true;
            this.btnAtk3.Click += new System.EventHandler(this.btnAtk3_Click);
            // 
            // btnAtk2
            // 
            this.btnAtk2.Enabled = false;
            this.btnAtk2.Location = new System.Drawing.Point(149, 11);
            this.btnAtk2.Name = "btnAtk2";
            this.btnAtk2.Size = new System.Drawing.Size(123, 42);
            this.btnAtk2.TabIndex = 14;
            this.btnAtk2.UseVisualStyleBackColor = true;
            this.btnAtk2.Click += new System.EventHandler(this.btnAtk2_Click);
            // 
            // btnAtk1
            // 
            this.btnAtk1.Location = new System.Drawing.Point(13, 11);
            this.btnAtk1.Name = "btnAtk1";
            this.btnAtk1.Size = new System.Drawing.Size(123, 42);
            this.btnAtk1.TabIndex = 13;
            this.btnAtk1.UseVisualStyleBackColor = true;
            this.btnAtk1.Click += new System.EventHandler(this.btnAtk1_Click);
            // 
            // pnl2
            // 
            this.pnl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl2.Controls.Add(this.btnCapturar);
            this.pnl2.Controls.Add(this.btnCorrer);
            this.pnl2.Controls.Add(this.btnAtacar);
            this.pnl2.Location = new System.Drawing.Point(487, 3);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(273, 118);
            this.pnl2.TabIndex = 2;
            this.pnl2.Visible = false;
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(3, 62);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(123, 42);
            this.btnCapturar.TabIndex = 4;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(145, 62);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(123, 42);
            this.btnCorrer.TabIndex = 1;
            this.btnCorrer.Text = "Sair";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(3, 3);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(265, 42);
            this.btnAtacar.TabIndex = 0;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // barRivalHP
            // 
            this.barRivalHP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.barRivalHP.Location = new System.Drawing.Point(109, 78);
            this.barRivalHP.MarqueeAnimationSpeed = 0;
            this.barRivalHP.Name = "barRivalHP";
            this.barRivalHP.Size = new System.Drawing.Size(160, 23);
            this.barRivalHP.TabIndex = 13;
            this.barRivalHP.Visible = false;
            // 
            // lblRivalN
            // 
            this.lblRivalN.AutoSize = true;
            this.lblRivalN.BackColor = System.Drawing.Color.Transparent;
            this.lblRivalN.Location = new System.Drawing.Point(109, 51);
            this.lblRivalN.Name = "lblRivalN";
            this.lblRivalN.Size = new System.Drawing.Size(0, 13);
            this.lblRivalN.TabIndex = 12;
            // 
            // lblPLayerHP
            // 
            this.lblPLayerHP.AutoSize = true;
            this.lblPLayerHP.BackColor = System.Drawing.Color.Transparent;
            this.lblPLayerHP.Location = new System.Drawing.Point(559, 355);
            this.lblPLayerHP.Name = "lblPLayerHP";
            this.lblPLayerHP.Size = new System.Drawing.Size(0, 13);
            this.lblPLayerHP.TabIndex = 16;
            // 
            // barPlayerHP
            // 
            this.barPlayerHP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.barPlayerHP.Location = new System.Drawing.Point(500, 329);
            this.barPlayerHP.MarqueeAnimationSpeed = 0;
            this.barPlayerHP.Name = "barPlayerHP";
            this.barPlayerHP.Size = new System.Drawing.Size(160, 23);
            this.barPlayerHP.TabIndex = 15;
            this.barPlayerHP.Visible = false;
            // 
            // lblPlayerN
            // 
            this.lblPlayerN.AutoSize = true;
            this.lblPlayerN.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerN.Location = new System.Drawing.Point(500, 302);
            this.lblPlayerN.Name = "lblPlayerN";
            this.lblPlayerN.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerN.TabIndex = 14;
            // 
            // pctrPlayer
            // 
            this.pctrPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pctrPlayer.Image = global::Jogo.Properties.Resources.Eu_stick;
            this.pctrPlayer.Location = new System.Drawing.Point(783, 253);
            this.pctrPlayer.Name = "pctrPlayer";
            this.pctrPlayer.Size = new System.Drawing.Size(137, 211);
            this.pctrPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrPlayer.TabIndex = 17;
            this.pctrPlayer.TabStop = false;
            // 
            // Batalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::Jogo.Properties.Resources.paisajes_Ajalvir_18;
            this.ClientSize = new System.Drawing.Size(789, 605);
            this.ControlBox = false;
            this.Controls.Add(this.pctrPlayer);
            this.Controls.Add(this.lblPLayerHP);
            this.Controls.Add(this.barPlayerHP);
            this.Controls.Add(this.lblPlayerN);
            this.Controls.Add(this.barRivalHP);
            this.Controls.Add(this.lblRivalN);
            this.Controls.Add(this.pctrVilao);
            this.Controls.Add(this.pnl1);
            this.Controls.Add(this.lblClicar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(805, 644);
            this.MinimumSize = new System.Drawing.Size(805, 644);
            this.Name = "Batalha";
            this.Text = "Campo";
            ((System.ComponentModel.ISupportInitialize)(this.pctrVilao)).EndInit();
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctrPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClicar;
        private System.Windows.Forms.Label lblMensagem1;
        private System.Windows.Forms.PictureBox pctrVilao;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Button btnCapturar;
        private System.Windows.Forms.ProgressBar barRivalHP;
        private System.Windows.Forms.Label lblRivalN;
        private System.Windows.Forms.Label lblPLayerHP;
        private System.Windows.Forms.ProgressBar barPlayerHP;
        private System.Windows.Forms.Label lblPlayerN;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Button btnAtk4;
        private System.Windows.Forms.Button btnAtk3;
        private System.Windows.Forms.Button btnAtk2;
        private System.Windows.Forms.Button btnAtk1;
        private System.Windows.Forms.PictureBox pctrPlayer;
    }
}