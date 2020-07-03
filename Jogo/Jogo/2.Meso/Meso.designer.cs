namespace Jogo
{
    partial class frmMeso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeso));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarESairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairSemSalvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instruçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEnergia = new System.Windows.Forms.Label();
            this.lblFome = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblSInt = new System.Windows.Forms.Label();
            this.lblSCar = new System.Windows.Forms.Label();
            this.lblSForça = new System.Windows.Forms.Label();
            this.lblSFome = new System.Windows.Forms.Label();
            this.lblSEnergia = new System.Windows.Forms.Label();
            this.barXP = new System.Windows.Forms.ProgressBar();
            this.btnEvoluir = new System.Windows.Forms.Button();
            this.btnMapa = new System.Windows.Forms.Button();
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
            this.menuStrip1.TabIndex = 0;
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
            this.panel1.Controls.Add(this.lblEnergia);
            this.panel1.Controls.Add(this.lblFome);
            this.panel1.Controls.Add(this.lblFor);
            this.panel1.Controls.Add(this.lblInt);
            this.panel1.Controls.Add(this.lblCar);
            this.panel1.Controls.Add(this.lblSInt);
            this.panel1.Controls.Add(this.lblSCar);
            this.panel1.Controls.Add(this.lblSForça);
            this.panel1.Controls.Add(this.lblSFome);
            this.panel1.Controls.Add(this.lblSEnergia);
            this.panel1.Controls.Add(this.barXP);
            this.panel1.Location = new System.Drawing.Point(350, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 132);
            this.panel1.TabIndex = 1;
            // 
            // lblEnergia
            // 
            this.lblEnergia.AutoSize = true;
            this.lblEnergia.Location = new System.Drawing.Point(76, 11);
            this.lblEnergia.Name = "lblEnergia";
            this.lblEnergia.Size = new System.Drawing.Size(0, 13);
            this.lblEnergia.TabIndex = 2;
            // 
            // lblFome
            // 
            this.lblFome.AutoSize = true;
            this.lblFome.Location = new System.Drawing.Point(76, 24);
            this.lblFome.Name = "lblFome";
            this.lblFome.Size = new System.Drawing.Size(0, 13);
            this.lblFome.TabIndex = 3;
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(76, 37);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(0, 13);
            this.lblFor.TabIndex = 4;
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(76, 50);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(0, 13);
            this.lblInt.TabIndex = 5;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(76, 63);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(0, 13);
            this.lblCar.TabIndex = 6;
            // 
            // lblSInt
            // 
            this.lblSInt.AutoSize = true;
            this.lblSInt.Location = new System.Drawing.Point(6, 50);
            this.lblSInt.Name = "lblSInt";
            this.lblSInt.Size = new System.Drawing.Size(64, 13);
            this.lblSInt.TabIndex = 2;
            this.lblSInt.Text = "Inteligência:";
            // 
            // lblSCar
            // 
            this.lblSCar.AutoSize = true;
            this.lblSCar.Location = new System.Drawing.Point(12, 63);
            this.lblSCar.Name = "lblSCar";
            this.lblSCar.Size = new System.Drawing.Size(58, 13);
            this.lblSCar.TabIndex = 3;
            this.lblSCar.Text = "Sabedoria:";
            // 
            // lblSForça
            // 
            this.lblSForça.AutoSize = true;
            this.lblSForça.Location = new System.Drawing.Point(33, 37);
            this.lblSForça.Name = "lblSForça";
            this.lblSForça.Size = new System.Drawing.Size(37, 13);
            this.lblSForça.TabIndex = 5;
            this.lblSForça.Text = "Força:";
            // 
            // lblSFome
            // 
            this.lblSFome.AutoSize = true;
            this.lblSFome.Location = new System.Drawing.Point(34, 24);
            this.lblSFome.Name = "lblSFome";
            this.lblSFome.Size = new System.Drawing.Size(36, 13);
            this.lblSFome.TabIndex = 4;
            this.lblSFome.Text = "Fome:";
            // 
            // lblSEnergia
            // 
            this.lblSEnergia.AutoSize = true;
            this.lblSEnergia.Location = new System.Drawing.Point(24, 11);
            this.lblSEnergia.Name = "lblSEnergia";
            this.lblSEnergia.Size = new System.Drawing.Size(46, 13);
            this.lblSEnergia.TabIndex = 3;
            this.lblSEnergia.Text = "Energia:";
            // 
            // barXP
            // 
            this.barXP.Location = new System.Drawing.Point(18, 94);
            this.barXP.Maximum = 20;
            this.barXP.Name = "barXP";
            this.barXP.Size = new System.Drawing.Size(100, 23);
            this.barXP.TabIndex = 2;
            // 
            // btnEvoluir
            // 
            this.btnEvoluir.Location = new System.Drawing.Point(387, 150);
            this.btnEvoluir.Name = "btnEvoluir";
            this.btnEvoluir.Size = new System.Drawing.Size(75, 23);
            this.btnEvoluir.TabIndex = 7;
            this.btnEvoluir.Text = "Evoluir >>";
            this.btnEvoluir.UseVisualStyleBackColor = true;
            this.btnEvoluir.Visible = false;
            this.btnEvoluir.Click += new System.EventHandler(this.btnEvoluir_Click);
            // 
            // btnMapa
            // 
            this.btnMapa.Location = new System.Drawing.Point(387, 299);
            this.btnMapa.Name = "btnMapa";
            this.btnMapa.Size = new System.Drawing.Size(101, 23);
            this.btnMapa.TabIndex = 8;
            this.btnMapa.Text = "<<Abrir Mapa>>";
            this.btnMapa.UseVisualStyleBackColor = true;
            this.btnMapa.Click += new System.EventHandler(this.btnMapa_Click);
            // 
            // pctrHero
            // 
            this.pctrHero.BackColor = System.Drawing.Color.Transparent;
            this.pctrHero.Image = global::Jogo.Properties.Resources.Eu_stick;
            this.pctrHero.Location = new System.Drawing.Point(30, 62);
            this.pctrHero.Name = "pctrHero";
            this.pctrHero.Size = new System.Drawing.Size(137, 211);
            this.pctrHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrHero.TabIndex = 18;
            this.pctrHero.TabStop = false;
            // 
            // frmMeso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 334);
            this.ControlBox = false;
            this.Controls.Add(this.pctrHero);
            this.Controls.Add(this.btnEvoluir);
            this.Controls.Add(this.btnMapa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(516, 373);
            this.MinimumSize = new System.Drawing.Size(516, 373);
            this.Name = "frmMeso";
            this.Text = "Mesopotamia";
            this.Load += new System.EventHandler(this.frmMeso_Load);
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
        private System.Windows.Forms.Label lblEnergia;
        private System.Windows.Forms.Label lblFome;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblSInt;
        private System.Windows.Forms.Label lblSCar;
        private System.Windows.Forms.Label lblSForça;
        private System.Windows.Forms.Label lblSFome;
        private System.Windows.Forms.Label lblSEnergia;
        private System.Windows.Forms.ProgressBar barXP;
        private System.Windows.Forms.Button btnEvoluir;
        private System.Windows.Forms.Button btnMapa;
        private System.Windows.Forms.PictureBox pctrHero;
    }
}

