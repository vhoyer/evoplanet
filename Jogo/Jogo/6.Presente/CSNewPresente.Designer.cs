﻿namespace Jogo._6.Presente
{
    partial class CSNewPresente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSNewPresente));
            this.lblNameCap = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnPrx = new System.Windows.Forms.Button();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.timerGo = new System.Windows.Forms.Timer(this.components);
            this.pctrText3 = new System.Windows.Forms.PictureBox();
            this.pctrText2 = new System.Windows.Forms.PictureBox();
            this.pctrText1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameCap
            // 
            this.lblNameCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNameCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNameCap.Location = new System.Drawing.Point(10, 157);
            this.lblNameCap.Name = "lblNameCap";
            this.lblNameCap.Size = new System.Drawing.Size(431, 34);
            this.lblNameCap.TabIndex = 29;
            this.lblNameCap.Text = "Presente";
            this.lblNameCap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNameCap.Visible = false;
            // 
            // lblCap
            // 
            this.lblCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCap.Location = new System.Drawing.Point(10, 123);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(431, 34);
            this.lblCap.TabIndex = 28;
            this.lblCap.Text = "Capitulo 5";
            this.lblCap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCap.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnVoltar.Location = new System.Drawing.Point(10, 327);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(86, 23);
            this.btnVoltar.TabIndex = 25;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnPrx
            // 
            this.btnPrx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrx.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnPrx.Location = new System.Drawing.Point(355, 327);
            this.btnPrx.Name = "btnPrx";
            this.btnPrx.Size = new System.Drawing.Size(86, 23);
            this.btnPrx.TabIndex = 24;
            this.btnPrx.Text = "Prosseguir >>";
            this.btnPrx.UseVisualStyleBackColor = true;
            this.btnPrx.Click += new System.EventHandler(this.btnPrx_Click);
            // 
            // lblText2
            // 
            this.lblText2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblText2.Location = new System.Drawing.Point(10, 11);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(431, 41);
            this.lblText2.TabIndex = 23;
            this.lblText2.Text = "Nosso herói morreu e renasceu varias e varias vezes, como uma fenix.";
            this.lblText2.Visible = false;
            // 
            // lblText1
            // 
            this.lblText1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblText1.Location = new System.Drawing.Point(10, 11);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(431, 41);
            this.lblText1.TabIndex = 20;
            this.lblText1.Text = "Depois do retorno das cidade, muita coisa aconteceu . . . Surgiram varios reinos," +
    " descobriram novos continentes, varias e varias guerras, acabaram com a escravid" +
    "ão e muitas e muitas coisas.";
            // 
            // lblText3
            // 
            this.lblText3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblText3.Location = new System.Drawing.Point(13, 11);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(431, 41);
            this.lblText3.TabIndex = 26;
            this.lblText3.Text = "Mas agora, nesse renascimento, ele tera um trabalho grande para determinar o futu" +
    "ro...";
            this.lblText3.Visible = false;
            // 
            // timerGo
            // 
            this.timerGo.Interval = 4000;
            this.timerGo.Tick += new System.EventHandler(this.timerGo_Tick);
            // 
            // pctrText3
            // 
            this.pctrText3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pctrText3.BackgroundImage = global::Jogo.Properties.Resources.CSP3;
            this.pctrText3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctrText3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctrText3.Location = new System.Drawing.Point(68, 106);
            this.pctrText3.Name = "pctrText3";
            this.pctrText3.Size = new System.Drawing.Size(303, 200);
            this.pctrText3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrText3.TabIndex = 27;
            this.pctrText3.TabStop = false;
            this.pctrText3.Visible = false;
            // 
            // pctrText2
            // 
            this.pctrText2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pctrText2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrText2.Image = global::Jogo.Properties.Resources.CSP2;
            this.pctrText2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctrText2.Location = new System.Drawing.Point(68, 106);
            this.pctrText2.Name = "pctrText2";
            this.pctrText2.Size = new System.Drawing.Size(303, 200);
            this.pctrText2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrText2.TabIndex = 22;
            this.pctrText2.TabStop = false;
            this.pctrText2.Visible = false;
            // 
            // pctrText1
            // 
            this.pctrText1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pctrText1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrText1.Image = global::Jogo.Properties.Resources.CSP;
            this.pctrText1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctrText1.Location = new System.Drawing.Point(68, 106);
            this.pctrText1.Name = "pctrText1";
            this.pctrText1.Size = new System.Drawing.Size(303, 200);
            this.pctrText1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrText1.TabIndex = 21;
            this.pctrText1.TabStop = false;
            // 
            // CSNewPresente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(455, 360);
            this.ControlBox = false;
            this.Controls.Add(this.lblNameCap);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPrx);
            this.Controls.Add(this.pctrText1);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.pctrText3);
            this.Controls.Add(this.pctrText2);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(471, 399);
            this.MinimumSize = new System.Drawing.Size(471, 399);
            this.Name = "CSNewPresente";
            this.Text = "CSNewPresente";
            ((System.ComponentModel.ISupportInitialize)(this.pctrText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameCap;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnPrx;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.Timer timerGo;
        private System.Windows.Forms.PictureBox pctrText3;
        private System.Windows.Forms.PictureBox pctrText2;
        private System.Windows.Forms.PictureBox pctrText1;
    }
}