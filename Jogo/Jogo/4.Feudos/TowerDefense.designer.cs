namespace Feudo
{
    partial class frmTowerDefense
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTowerDefense));
            this.btnPlantarMandioca = new System.Windows.Forms.Button();
            this.lblMercadorias = new System.Windows.Forms.Label();
            this.lblQuantMercadorias = new System.Windows.Forms.Label();
            this.barDelayMandioca = new System.Windows.Forms.ProgressBar();
            this.tabMansoSenhorial = new System.Windows.Forms.TabControl();
            this.tabLojinha = new System.Windows.Forms.TabPage();
            this.lblQuantFertilizante = new System.Windows.Forms.Label();
            this.btnFertilizante = new System.Windows.Forms.Button();
            this.btnArqueiro = new System.Windows.Forms.Button();
            this.lblFazerArqueiro = new System.Windows.Forms.Label();
            this.lblFazerBárbaro = new System.Windows.Forms.Label();
            this.lblFazerGuerreiro = new System.Windows.Forms.Label();
            this.lblCustosAtaque = new System.Windows.Forms.Label();
            this.btnFazerBarbaro = new System.Windows.Forms.Button();
            this.btnFazerGuerreiro = new System.Windows.Forms.Button();
            this.tabAtaque = new System.Windows.Forms.TabPage();
            this.txtAtaqueBatalha = new System.Windows.Forms.TextBox();
            this.btnAtacar = new System.Windows.Forms.Button();
            this.lblQuantAtaque = new System.Windows.Forms.Label();
            this.tabPlano = new System.Windows.Forms.TabPage();
            this.lblIniciarPlano = new System.Windows.Forms.Label();
            this.btnIniciarPlano = new System.Windows.Forms.Button();
            this.progressBarPlanoSecreto = new System.Windows.Forms.ProgressBar();
            this.tmrDelayMandioca = new System.Windows.Forms.Timer(this.components);
            this.lblExercito = new System.Windows.Forms.Label();
            this.grpInimigo = new System.Windows.Forms.GroupBox();
            this.lblCasoSofrer = new System.Windows.Forms.Label();
            this.lblProxAtaque = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BarDelayAtaqueInimigo = new System.Windows.Forms.ProgressBar();
            this.BarVidaInimigo = new System.Windows.Forms.ProgressBar();
            this.tmrAtaqueInimigo = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabMansoSenhorial.SuspendLayout();
            this.tabLojinha.SuspendLayout();
            this.tabAtaque.SuspendLayout();
            this.tabPlano.SuspendLayout();
            this.grpInimigo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlantarMandioca
            // 
            this.btnPlantarMandioca.Location = new System.Drawing.Point(21, 120);
            this.btnPlantarMandioca.Name = "btnPlantarMandioca";
            this.btnPlantarMandioca.Size = new System.Drawing.Size(148, 47);
            this.btnPlantarMandioca.TabIndex = 0;
            this.btnPlantarMandioca.Text = "Plantar Mandioca";
            this.btnPlantarMandioca.UseVisualStyleBackColor = true;
            this.btnPlantarMandioca.Click += new System.EventHandler(this.btnPlantarMandioca_Click);
            // 
            // lblMercadorias
            // 
            this.lblMercadorias.AutoSize = true;
            this.lblMercadorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMercadorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblMercadorias.Location = new System.Drawing.Point(21, 77);
            this.lblMercadorias.Name = "lblMercadorias";
            this.lblMercadorias.Size = new System.Drawing.Size(117, 24);
            this.lblMercadorias.TabIndex = 4;
            this.lblMercadorias.Text = "Mandiocas:";
            // 
            // lblQuantMercadorias
            // 
            this.lblQuantMercadorias.AutoSize = true;
            this.lblQuantMercadorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantMercadorias.Location = new System.Drawing.Point(159, 76);
            this.lblQuantMercadorias.Name = "lblQuantMercadorias";
            this.lblQuantMercadorias.Size = new System.Drawing.Size(0, 24);
            this.lblQuantMercadorias.TabIndex = 5;
            // 
            // barDelayMandioca
            // 
            this.barDelayMandioca.Location = new System.Drawing.Point(175, 133);
            this.barDelayMandioca.Name = "barDelayMandioca";
            this.barDelayMandioca.Size = new System.Drawing.Size(113, 24);
            this.barDelayMandioca.TabIndex = 7;
            // 
            // tabMansoSenhorial
            // 
            this.tabMansoSenhorial.Controls.Add(this.tabLojinha);
            this.tabMansoSenhorial.Controls.Add(this.tabAtaque);
            this.tabMansoSenhorial.Controls.Add(this.tabPlano);
            this.tabMansoSenhorial.Location = new System.Drawing.Point(21, 173);
            this.tabMansoSenhorial.Name = "tabMansoSenhorial";
            this.tabMansoSenhorial.SelectedIndex = 0;
            this.tabMansoSenhorial.Size = new System.Drawing.Size(513, 196);
            this.tabMansoSenhorial.TabIndex = 8;
            // 
            // tabLojinha
            // 
            this.tabLojinha.Controls.Add(this.lblQuantFertilizante);
            this.tabLojinha.Controls.Add(this.btnFertilizante);
            this.tabLojinha.Controls.Add(this.btnArqueiro);
            this.tabLojinha.Controls.Add(this.lblFazerArqueiro);
            this.tabLojinha.Controls.Add(this.lblFazerBárbaro);
            this.tabLojinha.Controls.Add(this.lblFazerGuerreiro);
            this.tabLojinha.Controls.Add(this.lblCustosAtaque);
            this.tabLojinha.Controls.Add(this.btnFazerBarbaro);
            this.tabLojinha.Controls.Add(this.btnFazerGuerreiro);
            this.tabLojinha.Location = new System.Drawing.Point(4, 22);
            this.tabLojinha.Name = "tabLojinha";
            this.tabLojinha.Padding = new System.Windows.Forms.Padding(3);
            this.tabLojinha.Size = new System.Drawing.Size(505, 170);
            this.tabLojinha.TabIndex = 0;
            this.tabLojinha.Text = "Lojinha";
            this.tabLojinha.UseVisualStyleBackColor = true;
            // 
            // lblQuantFertilizante
            // 
            this.lblQuantFertilizante.AutoSize = true;
            this.lblQuantFertilizante.Location = new System.Drawing.Point(267, 120);
            this.lblQuantFertilizante.Name = "lblQuantFertilizante";
            this.lblQuantFertilizante.Size = new System.Drawing.Size(71, 13);
            this.lblQuantFertilizante.TabIndex = 10;
            this.lblQuantFertilizante.Text = "5 Mandiocas:";
            // 
            // btnFertilizante
            // 
            this.btnFertilizante.Location = new System.Drawing.Point(350, 104);
            this.btnFertilizante.Name = "btnFertilizante";
            this.btnFertilizante.Size = new System.Drawing.Size(135, 44);
            this.btnFertilizante.TabIndex = 9;
            this.btnFertilizante.Text = "Fertilizante";
            this.btnFertilizante.UseVisualStyleBackColor = true;
            this.btnFertilizante.Click += new System.EventHandler(this.btnFertilizante_Click_1);
            // 
            // btnArqueiro
            // 
            this.btnArqueiro.Location = new System.Drawing.Point(350, 37);
            this.btnArqueiro.Name = "btnArqueiro";
            this.btnArqueiro.Size = new System.Drawing.Size(135, 44);
            this.btnArqueiro.TabIndex = 8;
            this.btnArqueiro.Text = "Fazer Arqueiro";
            this.btnArqueiro.UseVisualStyleBackColor = true;
            this.btnArqueiro.Click += new System.EventHandler(this.btnArqueiro_Click);
            // 
            // lblFazerArqueiro
            // 
            this.lblFazerArqueiro.AutoSize = true;
            this.lblFazerArqueiro.Location = new System.Drawing.Point(270, 53);
            this.lblFazerArqueiro.Name = "lblFazerArqueiro";
            this.lblFazerArqueiro.Size = new System.Drawing.Size(74, 13);
            this.lblFazerArqueiro.TabIndex = 7;
            this.lblFazerArqueiro.Text = "15 Mandiocas";
            // 
            // lblFazerBárbaro
            // 
            this.lblFazerBárbaro.AutoSize = true;
            this.lblFazerBárbaro.Location = new System.Drawing.Point(24, 119);
            this.lblFazerBárbaro.Name = "lblFazerBárbaro";
            this.lblFazerBárbaro.Size = new System.Drawing.Size(74, 13);
            this.lblFazerBárbaro.TabIndex = 4;
            this.lblFazerBárbaro.Text = "10 Mandiocas";
            // 
            // lblFazerGuerreiro
            // 
            this.lblFazerGuerreiro.AutoSize = true;
            this.lblFazerGuerreiro.Location = new System.Drawing.Point(24, 53);
            this.lblFazerGuerreiro.Name = "lblFazerGuerreiro";
            this.lblFazerGuerreiro.Size = new System.Drawing.Size(68, 13);
            this.lblFazerGuerreiro.TabIndex = 3;
            this.lblFazerGuerreiro.Text = "5 Mandiocas";
            // 
            // lblCustosAtaque
            // 
            this.lblCustosAtaque.AutoSize = true;
            this.lblCustosAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustosAtaque.ForeColor = System.Drawing.Color.Black;
            this.lblCustosAtaque.Location = new System.Drawing.Point(6, 13);
            this.lblCustosAtaque.Name = "lblCustosAtaque";
            this.lblCustosAtaque.Size = new System.Drawing.Size(67, 18);
            this.lblCustosAtaque.TabIndex = 2;
            this.lblCustosAtaque.Text = "Custos:";
            // 
            // btnFazerBarbaro
            // 
            this.btnFazerBarbaro.Location = new System.Drawing.Point(111, 102);
            this.btnFazerBarbaro.Name = "btnFazerBarbaro";
            this.btnFazerBarbaro.Size = new System.Drawing.Size(135, 46);
            this.btnFazerBarbaro.TabIndex = 1;
            this.btnFazerBarbaro.Text = "Fazer Bárbaro";
            this.btnFazerBarbaro.UseVisualStyleBackColor = true;
            this.btnFazerBarbaro.Click += new System.EventHandler(this.btnFazerBarbaro_Click);
            // 
            // btnFazerGuerreiro
            // 
            this.btnFazerGuerreiro.Location = new System.Drawing.Point(111, 37);
            this.btnFazerGuerreiro.Name = "btnFazerGuerreiro";
            this.btnFazerGuerreiro.Size = new System.Drawing.Size(135, 44);
            this.btnFazerGuerreiro.TabIndex = 0;
            this.btnFazerGuerreiro.Text = "Fazer Guerreiro";
            this.btnFazerGuerreiro.UseVisualStyleBackColor = true;
            this.btnFazerGuerreiro.Click += new System.EventHandler(this.btnFazerGuerreiro_Click);
            // 
            // tabAtaque
            // 
            this.tabAtaque.Controls.Add(this.txtAtaqueBatalha);
            this.tabAtaque.Controls.Add(this.btnAtacar);
            this.tabAtaque.Controls.Add(this.lblQuantAtaque);
            this.tabAtaque.Location = new System.Drawing.Point(4, 22);
            this.tabAtaque.Name = "tabAtaque";
            this.tabAtaque.Padding = new System.Windows.Forms.Padding(3);
            this.tabAtaque.Size = new System.Drawing.Size(505, 170);
            this.tabAtaque.TabIndex = 1;
            this.tabAtaque.Text = "Ataque";
            this.tabAtaque.UseVisualStyleBackColor = true;
            // 
            // txtAtaqueBatalha
            // 
            this.txtAtaqueBatalha.Location = new System.Drawing.Point(95, 53);
            this.txtAtaqueBatalha.Name = "txtAtaqueBatalha";
            this.txtAtaqueBatalha.Size = new System.Drawing.Size(297, 20);
            this.txtAtaqueBatalha.TabIndex = 3;
            this.txtAtaqueBatalha.TextChanged += new System.EventHandler(this.txtAtaqueBatalha_TextChanged);
            this.txtAtaqueBatalha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAtaqueBatalha_KeyPress);
            // 
            // btnAtacar
            // 
            this.btnAtacar.Location = new System.Drawing.Point(116, 102);
            this.btnAtacar.Name = "btnAtacar";
            this.btnAtacar.Size = new System.Drawing.Size(253, 62);
            this.btnAtacar.TabIndex = 2;
            this.btnAtacar.Text = "Atacar";
            this.btnAtacar.UseVisualStyleBackColor = true;
            this.btnAtacar.Click += new System.EventHandler(this.btnAtacar_Click);
            // 
            // lblQuantAtaque
            // 
            this.lblQuantAtaque.AutoSize = true;
            this.lblQuantAtaque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantAtaque.Location = new System.Drawing.Point(61, 13);
            this.lblQuantAtaque.Name = "lblQuantAtaque";
            this.lblQuantAtaque.Size = new System.Drawing.Size(393, 16);
            this.lblQuantAtaque.TabIndex = 1;
            this.lblQuantAtaque.Text = "Escolha o número de soldados que irão para a batalha:";
            // 
            // tabPlano
            // 
            this.tabPlano.Controls.Add(this.lblIniciarPlano);
            this.tabPlano.Controls.Add(this.btnIniciarPlano);
            this.tabPlano.Controls.Add(this.progressBarPlanoSecreto);
            this.tabPlano.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPlano.Location = new System.Drawing.Point(4, 22);
            this.tabPlano.Name = "tabPlano";
            this.tabPlano.Padding = new System.Windows.Forms.Padding(3);
            this.tabPlano.Size = new System.Drawing.Size(505, 170);
            this.tabPlano.TabIndex = 2;
            this.tabPlano.Text = "Plano SUPER Secreto";
            this.tabPlano.UseVisualStyleBackColor = true;
            // 
            // lblIniciarPlano
            // 
            this.lblIniciarPlano.AutoSize = true;
            this.lblIniciarPlano.Location = new System.Drawing.Point(212, 77);
            this.lblIniciarPlano.Name = "lblIniciarPlano";
            this.lblIniciarPlano.Size = new System.Drawing.Size(74, 13);
            this.lblIniciarPlano.TabIndex = 4;
            this.lblIniciarPlano.Text = "20 Mandiocas";
            // 
            // btnIniciarPlano
            // 
            this.btnIniciarPlano.Location = new System.Drawing.Point(150, 19);
            this.btnIniciarPlano.Name = "btnIniciarPlano";
            this.btnIniciarPlano.Size = new System.Drawing.Size(200, 55);
            this.btnIniciarPlano.TabIndex = 1;
            this.btnIniciarPlano.Text = "Iniciar Plano";
            this.btnIniciarPlano.UseVisualStyleBackColor = true;
            this.btnIniciarPlano.Click += new System.EventHandler(this.btnIniciarPlano_Click);
            // 
            // progressBarPlanoSecreto
            // 
            this.progressBarPlanoSecreto.Location = new System.Drawing.Point(64, 109);
            this.progressBarPlanoSecreto.Maximum = 4;
            this.progressBarPlanoSecreto.Name = "progressBarPlanoSecreto";
            this.progressBarPlanoSecreto.Size = new System.Drawing.Size(369, 23);
            this.progressBarPlanoSecreto.TabIndex = 0;
            // 
            // tmrDelayMandioca
            // 
            this.tmrDelayMandioca.Interval = 1000;
            this.tmrDelayMandioca.Tick += new System.EventHandler(this.tmrDelayMandioca_Tick);
            // 
            // lblExercito
            // 
            this.lblExercito.AutoSize = true;
            this.lblExercito.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExercito.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblExercito.Location = new System.Drawing.Point(21, 52);
            this.lblExercito.Name = "lblExercito";
            this.lblExercito.Size = new System.Drawing.Size(93, 24);
            this.lblExercito.TabIndex = 9;
            this.lblExercito.Text = "Exército:";
            // 
            // grpInimigo
            // 
            this.grpInimigo.Controls.Add(this.lblCasoSofrer);
            this.grpInimigo.Controls.Add(this.lblProxAtaque);
            this.grpInimigo.Controls.Add(this.label2);
            this.grpInimigo.Controls.Add(this.BarDelayAtaqueInimigo);
            this.grpInimigo.Controls.Add(this.BarVidaInimigo);
            this.grpInimigo.Location = new System.Drawing.Point(309, 52);
            this.grpInimigo.Name = "grpInimigo";
            this.grpInimigo.Size = new System.Drawing.Size(225, 122);
            this.grpInimigo.TabIndex = 10;
            this.grpInimigo.TabStop = false;
            this.grpInimigo.Text = "Inimigo";
            // 
            // lblCasoSofrer
            // 
            this.lblCasoSofrer.AutoSize = true;
            this.lblCasoSofrer.Location = new System.Drawing.Point(17, 81);
            this.lblCasoSofrer.Name = "lblCasoSofrer";
            this.lblCasoSofrer.Size = new System.Drawing.Size(201, 39);
            this.lblCasoSofrer.TabIndex = 4;
            this.lblCasoSofrer.Text = "  Em caso de sofrer um ataque do inimigo\r\nsem ter um exército, isso resultará na " +
    "sua\r\nmorte!";
            // 
            // lblProxAtaque
            // 
            this.lblProxAtaque.AutoSize = true;
            this.lblProxAtaque.Location = new System.Drawing.Point(5, 54);
            this.lblProxAtaque.Name = "lblProxAtaque";
            this.lblProxAtaque.Size = new System.Drawing.Size(80, 13);
            this.lblProxAtaque.TabIndex = 3;
            this.lblProxAtaque.Text = "Ataque Inimigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vida:";
            // 
            // BarDelayAtaqueInimigo
            // 
            this.BarDelayAtaqueInimigo.Enabled = false;
            this.BarDelayAtaqueInimigo.Location = new System.Drawing.Point(91, 54);
            this.BarDelayAtaqueInimigo.Maximum = 600;
            this.BarDelayAtaqueInimigo.Name = "BarDelayAtaqueInimigo";
            this.BarDelayAtaqueInimigo.Size = new System.Drawing.Size(127, 23);
            this.BarDelayAtaqueInimigo.TabIndex = 7;
            this.BarDelayAtaqueInimigo.Click += new System.EventHandler(this.BarDelayAtaqueInimigo_Click);
            // 
            // BarVidaInimigo
            // 
            this.BarVidaInimigo.BackColor = System.Drawing.Color.Red;
            this.BarVidaInimigo.ForeColor = System.Drawing.Color.Red;
            this.BarVidaInimigo.Location = new System.Drawing.Point(40, 25);
            this.BarVidaInimigo.Name = "BarVidaInimigo";
            this.BarVidaInimigo.Size = new System.Drawing.Size(179, 23);
            this.BarVidaInimigo.TabIndex = 0;
            this.BarVidaInimigo.Value = 100;
            // 
            // tmrAtaqueInimigo
            // 
            this.tmrAtaqueInimigo.Enabled = true;
            this.tmrAtaqueInimigo.Interval = 1000;
            this.tmrAtaqueInimigo.Tick += new System.EventHandler(this.tmrAtaqueInimigo_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(546, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // frmTowerDefense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 381);
            this.ControlBox = false;
            this.Controls.Add(this.grpInimigo);
            this.Controls.Add(this.lblExercito);
            this.Controls.Add(this.tabMansoSenhorial);
            this.Controls.Add(this.barDelayMandioca);
            this.Controls.Add(this.lblQuantMercadorias);
            this.Controls.Add(this.lblMercadorias);
            this.Controls.Add(this.btnPlantarMandioca);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(562, 420);
            this.MinimumSize = new System.Drawing.Size(562, 420);
            this.Name = "frmTowerDefense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manso Senhorial";
            this.Load += new System.EventHandler(this.frmTowerDefense_Load);
            this.tabMansoSenhorial.ResumeLayout(false);
            this.tabLojinha.ResumeLayout(false);
            this.tabLojinha.PerformLayout();
            this.tabAtaque.ResumeLayout(false);
            this.tabAtaque.PerformLayout();
            this.tabPlano.ResumeLayout(false);
            this.tabPlano.PerformLayout();
            this.grpInimigo.ResumeLayout(false);
            this.grpInimigo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlantarMandioca;
        private System.Windows.Forms.Label lblMercadorias;
        private System.Windows.Forms.Label lblQuantMercadorias;
        private System.Windows.Forms.ProgressBar barDelayMandioca;
        private System.Windows.Forms.TabControl tabMansoSenhorial;
        private System.Windows.Forms.TabPage tabLojinha;
        private System.Windows.Forms.Button btnFazerBarbaro;
        private System.Windows.Forms.Button btnFazerGuerreiro;
        private System.Windows.Forms.TabPage tabAtaque;
        private System.Windows.Forms.TabPage tabPlano;
        private System.Windows.Forms.Label lblCustosAtaque;
        private System.Windows.Forms.Button btnArqueiro;
        private System.Windows.Forms.Label lblFazerArqueiro;
        private System.Windows.Forms.Label lblFazerBárbaro;
        private System.Windows.Forms.Label lblFazerGuerreiro;
        private System.Windows.Forms.Button btnIniciarPlano;
        private System.Windows.Forms.ProgressBar progressBarPlanoSecreto;
        private System.Windows.Forms.Timer tmrDelayMandioca;
        private System.Windows.Forms.Label lblQuantFertilizante;
        private System.Windows.Forms.Button btnFertilizante;
        private System.Windows.Forms.Label lblExercito;
        private System.Windows.Forms.GroupBox grpInimigo;
        private System.Windows.Forms.Label lblCasoSofrer;
        private System.Windows.Forms.Label lblProxAtaque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar BarDelayAtaqueInimigo;
        private System.Windows.Forms.Label lblQuantAtaque;
        private System.Windows.Forms.Button btnAtacar;
        private System.Windows.Forms.Label lblIniciarPlano;
        private System.Windows.Forms.Timer tmrAtaqueInimigo;
        private System.Windows.Forms.TextBox txtAtaqueBatalha;
        private System.Windows.Forms.ProgressBar BarVidaInimigo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Timer tmrUpdate;
    }
}