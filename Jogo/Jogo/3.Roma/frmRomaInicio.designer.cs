namespace Teste
{
    partial class frmRomaInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRomaInicio));
            this.btnAbriMapa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarESairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairSemSalvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEvoluir = new System.Windows.Forms.Button();
            this.lblSEnergia = new System.Windows.Forms.Label();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFome = new System.Windows.Forms.Label();
            this.lblSFor = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblSFome = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barXP = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pctrHero = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbriMapa
            // 
            this.btnAbriMapa.Location = new System.Drawing.Point(400, 293);
            this.btnAbriMapa.Name = "btnAbriMapa";
            this.btnAbriMapa.Size = new System.Drawing.Size(75, 23);
            this.btnAbriMapa.TabIndex = 0;
            this.btnAbriMapa.Text = "Abrir Mapa";
            this.btnAbriMapa.UseVisualStyleBackColor = true;
            this.btnAbriMapa.Click += new System.EventHandler(this.btnAbriMapa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem,
            this.instruçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(487, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarToolStripMenuItem,
            this.salvarESairToolStripMenuItem,
            this.sairSemSalvarToolStripMenuItem,
            this.fecharProramaToolStripMenuItem});
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // salvarESairToolStripMenuItem
            // 
            this.salvarESairToolStripMenuItem.Name = "salvarESairToolStripMenuItem";
            this.salvarESairToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.salvarESairToolStripMenuItem.Text = "Salvar e sair";
            this.salvarESairToolStripMenuItem.Click += new System.EventHandler(this.salvarESairToolStripMenuItem_Click);
            // 
            // sairSemSalvarToolStripMenuItem
            // 
            this.sairSemSalvarToolStripMenuItem.Name = "sairSemSalvarToolStripMenuItem";
            this.sairSemSalvarToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.sairSemSalvarToolStripMenuItem.Text = "Sair sem salvar";
            this.sairSemSalvarToolStripMenuItem.Click += new System.EventHandler(this.sairSemSalvarToolStripMenuItem_Click);
            // 
            // fecharProramaToolStripMenuItem
            // 
            this.fecharProramaToolStripMenuItem.Name = "fecharProramaToolStripMenuItem";
            this.fecharProramaToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.fecharProramaToolStripMenuItem.Text = "Fechar prorama";
            this.fecharProramaToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // instruçõesToolStripMenuItem
            // 
            this.instruçõesToolStripMenuItem.Name = "instruçõesToolStripMenuItem";
            this.instruçõesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.instruçõesToolStripMenuItem.Text = "Instruções";
            this.instruçõesToolStripMenuItem.Click += new System.EventHandler(this.instruçõesToolStripMenuItem_Click);
            // 
            // btnEvoluir
            // 
            this.btnEvoluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEvoluir.Location = new System.Drawing.Point(363, 135);
            this.btnEvoluir.Name = "btnEvoluir";
            this.btnEvoluir.Size = new System.Drawing.Size(100, 23);
            this.btnEvoluir.TabIndex = 15;
            this.btnEvoluir.Text = "Evoluir >>";
            this.btnEvoluir.UseVisualStyleBackColor = true;
            this.btnEvoluir.Visible = false;
            this.btnEvoluir.Click += new System.EventHandler(this.btnEvoluir_Click);
            // 
            // lblSEnergia
            // 
            this.lblSEnergia.AutoSize = true;
            this.lblSEnergia.BackColor = System.Drawing.Color.Transparent;
            this.lblSEnergia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSEnergia.Location = new System.Drawing.Point(21, 16);
            this.lblSEnergia.Name = "lblSEnergia";
            this.lblSEnergia.Size = new System.Drawing.Size(49, 13);
            this.lblSEnergia.TabIndex = 7;
            this.lblSEnergia.Text = "Energia: ";
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergia.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEnergia.Location = new System.Drawing.Point(76, 16);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(0, 13);
            this.lblEnergia.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(3, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inteligência: ";
            // 
            // lblFome
            // 
            this.lblFome.AutoSize = true;
            this.lblFome.BackColor = System.Drawing.Color.Transparent;
            this.lblFome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFome.Location = new System.Drawing.Point(76, 29);
            this.lblFome.Name = "lblFome";
            this.lblFome.Size = new System.Drawing.Size(0, 13);
            this.lblFome.TabIndex = 2;
            // 
            // lblSFor
            // 
            this.lblSFor.AutoSize = true;
            this.lblSFor.BackColor = System.Drawing.Color.Transparent;
            this.lblSFor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSFor.Location = new System.Drawing.Point(30, 42);
            this.lblSFor.Name = "lblSFor";
            this.lblSFor.Size = new System.Drawing.Size(40, 13);
            this.lblSFor.TabIndex = 9;
            this.lblSFor.Text = "Força: ";
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.BackColor = System.Drawing.Color.Transparent;
            this.lblFor.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFor.Location = new System.Drawing.Point(76, 42);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(0, 13);
            this.lblFor.TabIndex = 3;
            // 
            // lblSFome
            // 
            this.lblSFome.AutoSize = true;
            this.lblSFome.BackColor = System.Drawing.Color.Transparent;
            this.lblSFome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSFome.Location = new System.Drawing.Point(31, 29);
            this.lblSFome.Name = "lblSFome";
            this.lblSFome.Size = new System.Drawing.Size(39, 13);
            this.lblSFome.TabIndex = 8;
            this.lblSFome.Text = "Fome: ";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.BackColor = System.Drawing.Color.Transparent;
            this.lblInt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInt.Location = new System.Drawing.Point(76, 55);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(0, 13);
            this.lblInt.TabIndex = 4;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.BackColor = System.Drawing.Color.Transparent;
            this.lblCar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCar.Location = new System.Drawing.Point(76, 68);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(0, 13);
            this.lblCar.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.barXP);
            this.panel1.Controls.Add(this.lblSEnergia);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblEnergia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblFome);
            this.panel1.Controls.Add(this.lblSFor);
            this.panel1.Controls.Add(this.lblFor);
            this.panel1.Controls.Add(this.lblSFome);
            this.panel1.Controls.Add(this.lblInt);
            this.panel1.Controls.Add(this.lblCar);
            this.panel1.Location = new System.Drawing.Point(351, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 117);
            this.panel1.TabIndex = 14;
            // 
            // barXP
            // 
            this.barXP.Location = new System.Drawing.Point(12, 84);
            this.barXP.Maximum = 20;
            this.barXP.Name = "barXP";
            this.barXP.Size = new System.Drawing.Size(100, 23);
            this.barXP.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(20, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Carisma: ";
            // 
            // pctrHero
            // 
            this.pctrHero.BackColor = System.Drawing.Color.Transparent;
            this.pctrHero.Image = global::Jogo.Properties.Resources.Eu_stick;
            this.pctrHero.Location = new System.Drawing.Point(45, 67);
            this.pctrHero.Name = "pctrHero";
            this.pctrHero.Size = new System.Drawing.Size(137, 211);
            this.pctrHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHero.TabIndex = 18;
            this.pctrHero.TabStop = false;
            // 
            // frmRomaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.RomaAntiga;
            this.ClientSize = new System.Drawing.Size(487, 328);
            this.ControlBox = false;
            this.Controls.Add(this.pctrHero);
            this.Controls.Add(this.btnEvoluir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbriMapa);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(503, 367);
            this.MinimumSize = new System.Drawing.Size(503, 367);
            this.Name = "frmRomaInicio";
            this.Text = "Roma";
            this.Load += new System.EventHandler(this.frmRomaInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctrHero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbriMapa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem opçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarESairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairSemSalvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharProramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instruçõesToolStripMenuItem;
        private System.Windows.Forms.Button btnEvoluir;
        private System.Windows.Forms.Label lblSEnergia;
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFome;
        private System.Windows.Forms.Label lblSFor;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblSFome;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ProgressBar barXP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pctrHero;
    }
}