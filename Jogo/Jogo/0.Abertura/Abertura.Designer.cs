namespace Jogo
{
    partial class Abertura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abertura));
            this.btnCapitulos = new System.Windows.Forms.Button();
            this.btnInstr = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCred = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.lblExibirNick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCapitulos
            // 
            this.btnCapitulos.Location = new System.Drawing.Point(12, 541);
            this.btnCapitulos.Name = "btnCapitulos";
            this.btnCapitulos.Size = new System.Drawing.Size(101, 33);
            this.btnCapitulos.TabIndex = 0;
            this.btnCapitulos.Text = "Capitulos";
            this.btnCapitulos.UseVisualStyleBackColor = true;
            this.btnCapitulos.Click += new System.EventHandler(this.btnCapitulos_Click);
            // 
            // btnInstr
            // 
            this.btnInstr.Location = new System.Drawing.Point(119, 541);
            this.btnInstr.Name = "btnInstr";
            this.btnInstr.Size = new System.Drawing.Size(101, 33);
            this.btnInstr.TabIndex = 1;
            this.btnInstr.Text = "Instruções";
            this.btnInstr.UseVisualStyleBackColor = true;
            this.btnInstr.Click += new System.EventHandler(this.btnInstr_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(411, 541);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(101, 33);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCred
            // 
            this.btnCred.Location = new System.Drawing.Point(304, 541);
            this.btnCred.Name = "btnCred";
            this.btnCred.Size = new System.Drawing.Size(101, 33);
            this.btnCred.TabIndex = 3;
            this.btnCred.Text = "Creditos";
            this.btnCred.UseVisualStyleBackColor = true;
            this.btnCred.Click += new System.EventHandler(this.btnCred_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(155, 502);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(101, 33);
            this.btnNewGame.TabIndex = 4;
            this.btnNewGame.Text = "Novo Jogo";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnContinuar
            // 
            this.btnContinuar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnContinuar.Location = new System.Drawing.Point(262, 502);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(101, 33);
            this.btnContinuar.TabIndex = 5;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // lblExibirNick
            // 
            this.lblExibirNick.AutoSize = true;
            this.lblExibirNick.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblExibirNick.Location = new System.Drawing.Point(12, 13);
            this.lblExibirNick.Name = "lblExibirNick";
            this.lblExibirNick.Size = new System.Drawing.Size(0, 13);
            this.lblExibirNick.TabIndex = 6;
            // 
            // Abertura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::Jogo.Properties.Resources.Logo_com_Nome;
            this.ClientSize = new System.Drawing.Size(524, 604);
            this.ControlBox = false;
            this.Controls.Add(this.lblExibirNick);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnCred);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnInstr);
            this.Controls.Add(this.btnCapitulos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(540, 643);
            this.MinimumSize = new System.Drawing.Size(540, 643);
            this.Name = "Abertura";
            this.Text = "Bem-Vindo";
            this.Load += new System.EventHandler(this.Abertura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCapitulos;
        private System.Windows.Forms.Button btnInstr;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCred;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label lblExibirNick;
    }
}