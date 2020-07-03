﻿namespace Feudo
{
    partial class frmFeudalismo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFeudalismo));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarESairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairSemSalvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEne = new System.Windows.Forms.Label();
            this.lblFom = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.barXP = new System.Windows.Forms.ProgressBar();
            this.lblCarisma = new System.Windows.Forms.Label();
            this.lblInteligência = new System.Windows.Forms.Label();
            this.lblForça = new System.Windows.Forms.Label();
            this.lblFome = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.btnAbrirMapaFeudalismo = new System.Windows.Forms.Button();
            this.btnEvoluir = new System.Windows.Forms.Button();
            this.pctrHero = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHero)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.instruçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(500, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.salvarESairToolStripMenuItem,
            this.sairSemSalvarToolStripMenuItem,
            this.fecharProgramaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarESairToolStripMenuItem
            // 
            this.salvarESairToolStripMenuItem.Name = "salvarESairToolStripMenuItem";
            this.salvarESairToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.salvarESairToolStripMenuItem.Text = "Salvar e sair";
            this.salvarESairToolStripMenuItem.Click += new System.EventHandler(this.salvarESairToolStripMenuItem_Click);
            // 
            // sairSemSalvarToolStripMenuItem
            // 
            this.sairSemSalvarToolStripMenuItem.Name = "sairSemSalvarToolStripMenuItem";
            this.sairSemSalvarToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sairSemSalvarToolStripMenuItem.Text = "Sair sem salvar";
            this.sairSemSalvarToolStripMenuItem.Click += new System.EventHandler(this.sairSemSalvarToolStripMenuItem_Click);
            // 
            // fecharProgramaToolStripMenuItem
            // 
            this.fecharProgramaToolStripMenuItem.Name = "fecharProgramaToolStripMenuItem";
            this.fecharProgramaToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.fecharProgramaToolStripMenuItem.Text = "Fechar programa";
            this.fecharProgramaToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // instruçõesToolStripMenuItem
            // 
            this.instruçõesToolStripMenuItem.Name = "instruçõesToolStripMenuItem";
            this.instruçõesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.instruçõesToolStripMenuItem.Text = "Instruções";
            this.instruçõesToolStripMenuItem.Click += new System.EventHandler(this.instruçõesToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblEne);
            this.panel1.Controls.Add(this.lblFom);
            this.panel1.Controls.Add(this.lblFor);
            this.panel1.Controls.Add(this.lblInt);
            this.panel1.Controls.Add(this.lblCar);
            this.panel1.Controls.Add(this.barXP);
            this.panel1.Controls.Add(this.lblCarisma);
            this.panel1.Controls.Add(this.lblInteligência);
            this.panel1.Controls.Add(this.lblForça);
            this.panel1.Controls.Add(this.lblFome);
            this.panel1.Controls.Add(this.lblEnergia);
            this.panel1.Location = new System.Drawing.Point(345, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 121);
            this.panel1.TabIndex = 2;
            // 
            // lblEne
            // 
            this.lblEne.AutoSize = true;
            this.lblEne.BackColor = System.Drawing.Color.Transparent;
            this.lblEne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEne.Location = new System.Drawing.Point(79, 12);
            this.lblEne.Name = "lblEne";
            this.lblEne.Size = new System.Drawing.Size(0, 13);
            this.lblEne.TabIndex = 6;
            // 
            // lblFom
            // 
            this.lblFom.AutoSize = true;
            this.lblFom.BackColor = System.Drawing.Color.Transparent;
            this.lblFom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFom.Location = new System.Drawing.Point(79, 25);
            this.lblFom.Name = "lblFom";
            this.lblFom.Size = new System.Drawing.Size(0, 13);
            this.lblFom.TabIndex = 7;
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.BackColor = System.Drawing.Color.Transparent;
            this.lblFor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFor.Location = new System.Drawing.Point(79, 38);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(0, 13);
            this.lblFor.TabIndex = 8;
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.BackColor = System.Drawing.Color.Transparent;
            this.lblInt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInt.Location = new System.Drawing.Point(79, 51);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(0, 13);
            this.lblInt.TabIndex = 9;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.BackColor = System.Drawing.Color.Transparent;
            this.lblCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCar.Location = new System.Drawing.Point(79, 64);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(0, 13);
            this.lblCar.TabIndex = 10;
            // 
            // barXP
            // 
            this.barXP.Location = new System.Drawing.Point(12, 80);
            this.barXP.Maximum = 20;
            this.barXP.Name = "barXP";
            this.barXP.Size = new System.Drawing.Size(106, 27);
            this.barXP.TabIndex = 5;
            // 
            // lblCarisma
            // 
            this.lblCarisma.AutoSize = true;
            this.lblCarisma.Location = new System.Drawing.Point(26, 64);
            this.lblCarisma.Name = "lblCarisma";
            this.lblCarisma.Size = new System.Drawing.Size(47, 13);
            this.lblCarisma.TabIndex = 4;
            this.lblCarisma.Text = "Carisma:";
            // 
            // lblInteligência
            // 
            this.lblInteligência.AutoSize = true;
            this.lblInteligência.Location = new System.Drawing.Point(9, 51);
            this.lblInteligência.Name = "lblInteligência";
            this.lblInteligência.Size = new System.Drawing.Size(64, 13);
            this.lblInteligência.TabIndex = 3;
            this.lblInteligência.Text = "Inteligência:";
            // 
            // lblForça
            // 
            this.lblForça.AutoSize = true;
            this.lblForça.Location = new System.Drawing.Point(36, 38);
            this.lblForça.Name = "lblForça";
            this.lblForça.Size = new System.Drawing.Size(37, 13);
            this.lblForça.TabIndex = 2;
            this.lblForça.Text = "Força:";
            // 
            // lblFome
            // 
            this.lblFome.AutoSize = true;
            this.lblFome.Location = new System.Drawing.Point(37, 25);
            this.lblFome.Name = "lblFome";
            this.lblFome.Size = new System.Drawing.Size(36, 13);
            this.lblFome.TabIndex = 1;
            this.lblFome.Text = "Fome:";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Location = new System.Drawing.Point(27, 12);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(46, 13);
            this.lblEnergia.TabIndex = 0;
            this.lblEnergia.Text = "Energia:";
            // 
            // btnAbrirMapaFeudalismo
            // 
            this.btnAbrirMapaFeudalismo.Location = new System.Drawing.Point(391, 298);
            this.btnAbrirMapaFeudalismo.Name = "btnAbrirMapaFeudalismo";
            this.btnAbrirMapaFeudalismo.Size = new System.Drawing.Size(97, 23);
            this.btnAbrirMapaFeudalismo.TabIndex = 3;
            this.btnAbrirMapaFeudalismo.Text = "Abrir Mapa";
            this.btnAbrirMapaFeudalismo.UseVisualStyleBackColor = true;
            this.btnAbrirMapaFeudalismo.Click += new System.EventHandler(this.btnAbrirMapaFeudalismo_Click);
            // 
            // btnEvoluir
            // 
            this.btnEvoluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEvoluir.Location = new System.Drawing.Point(357, 139);
            this.btnEvoluir.Name = "btnEvoluir";
            this.btnEvoluir.Size = new System.Drawing.Size(100, 23);
            this.btnEvoluir.TabIndex = 14;
            this.btnEvoluir.Text = "Evoluir >>";
            this.btnEvoluir.UseVisualStyleBackColor = true;
            this.btnEvoluir.Visible = false;
            this.btnEvoluir.Click += new System.EventHandler(this.btnEvoluir_Click);
            // 
            // pctrHero
            // 
            this.pctrHero.BackColor = System.Drawing.Color.Transparent;
            this.pctrHero.Image = global::Jogo.Properties.Resources.Eu_stick;
            this.pctrHero.Location = new System.Drawing.Point(28, 63);
            this.pctrHero.Name = "pctrHero";
            this.pctrHero.Size = new System.Drawing.Size(137, 211);
            this.pctrHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHero.TabIndex = 18;
            this.pctrHero.TabStop = false;
            // 
            // frmFeudalismo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 328);
            this.ControlBox = false;
            this.Controls.Add(this.pctrHero);
            this.Controls.Add(this.btnEvoluir);
            this.Controls.Add(this.btnAbrirMapaFeudalismo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(516, 367);
            this.MinimumSize = new System.Drawing.Size(516, 367);
            this.Name = "frmFeudalismo";
            this.Text = "Feudalismo";
            this.Load += new System.EventHandler(this.frmFeudalismo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarESairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairSemSalvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruçõesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar barXP;
        private System.Windows.Forms.Label lblCarisma;
        private System.Windows.Forms.Label lblInteligência;
        private System.Windows.Forms.Label lblForça;
        private System.Windows.Forms.Label lblFome;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Button btnAbrirMapaFeudalismo;
        private System.Windows.Forms.Label lblEne;
        private System.Windows.Forms.Label lblFom;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Button btnEvoluir;
        private System.Windows.Forms.PictureBox pctrHero;
    }
}
