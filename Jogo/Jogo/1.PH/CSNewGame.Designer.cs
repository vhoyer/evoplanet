﻿namespace Jogo
{
    partial class CSNewGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSNewGame));
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.btnPrx = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblText3 = new System.Windows.Forms.Label();
            this.pctrText3 = new System.Windows.Forms.PictureBox();
            this.pctrText2 = new System.Windows.Forms.PictureBox();
            this.pctrText1 = new System.Windows.Forms.PictureBox();
            this.lblCap = new System.Windows.Forms.Label();
            this.lblNameCap = new System.Windows.Forms.Label();
            this.timerGo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pctrText3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText1
            // 
            resources.ApplyResources(this.lblText1, "lblText1");
            this.lblText1.Name = "lblText1";
            // 
            // lblText2
            // 
            resources.ApplyResources(this.lblText2, "lblText2");
            this.lblText2.Name = "lblText2";
            // 
            // btnPrx
            // 
            this.btnPrx.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btnPrx, "btnPrx");
            this.btnPrx.Name = "btnPrx";
            this.btnPrx.UseVisualStyleBackColor = true;
            this.btnPrx.Click += new System.EventHandler(this.btnPrx_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.btnVoltar, "btnVoltar");
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblText3
            // 
            resources.ApplyResources(this.lblText3, "lblText3");
            this.lblText3.Name = "lblText3";
            // 
            // pctrText3
            // 
            this.pctrText3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.pctrText3, "pctrText3");
            this.pctrText3.Image = global::Jogo.Properties.Resources.Ponto_Verde3;
            this.pctrText3.Name = "pctrText3";
            this.pctrText3.TabStop = false;
            // 
            // pctrText2
            // 
            this.pctrText2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.pctrText2, "pctrText2");
            this.pctrText2.Image = global::Jogo.Properties.Resources.Ponto_Verde2;
            this.pctrText2.Name = "pctrText2";
            this.pctrText2.TabStop = false;
            // 
            // pctrText1
            // 
            this.pctrText1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            resources.ApplyResources(this.pctrText1, "pctrText1");
            this.pctrText1.Image = global::Jogo.Properties.Resources.Ponto_Verde1;
            this.pctrText1.Name = "pctrText1";
            this.pctrText1.TabStop = false;
            // 
            // lblCap
            // 
            resources.ApplyResources(this.lblCap, "lblCap");
            this.lblCap.Name = "lblCap";
            // 
            // lblNameCap
            // 
            resources.ApplyResources(this.lblNameCap, "lblNameCap");
            this.lblNameCap.Name = "lblNameCap";
            // 
            // timerGo
            // 
            this.timerGo.Interval = 4000;
            this.timerGo.Tick += new System.EventHandler(this.timerGo_Tick);
            // 
            // CSNewGame
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ControlBox = false;
            this.Controls.Add(this.lblNameCap);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.pctrText3);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnPrx);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.pctrText2);
            this.Controls.Add(this.pctrText1);
            this.Controls.Add(this.lblText1);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CSNewGame";
            this.Load += new System.EventHandler(this.CSNewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrText3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.PictureBox pctrText1;
        private System.Windows.Forms.PictureBox pctrText2;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Button btnPrx;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.PictureBox pctrText3;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Label lblNameCap;
        private System.Windows.Forms.Timer timerGo;
    }
}