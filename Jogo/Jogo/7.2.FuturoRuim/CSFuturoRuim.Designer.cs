namespace Jogo._7._2.FuturoRuim
{
    partial class CSFuturoRuim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CSFuturoRuim));
            this.timerGo = new System.Windows.Forms.Timer(this.components);
            this.lblNameCap = new System.Windows.Forms.Label();
            this.lblCap = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.pctrText1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctrText1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerGo
            // 
            this.timerGo.Interval = 4000;
            this.timerGo.Tick += new System.EventHandler(this.timerGo_Tick);
            // 
            // lblNameCap
            // 
            this.lblNameCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblNameCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblNameCap.Location = new System.Drawing.Point(12, 157);
            this.lblNameCap.Name = "lblNameCap";
            this.lblNameCap.Size = new System.Drawing.Size(431, 34);
            this.lblNameCap.TabIndex = 44;
            this.lblNameCap.Text = "Futuro";
            this.lblNameCap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblNameCap.Visible = false;
            // 
            // lblCap
            // 
            this.lblCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblCap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblCap.Location = new System.Drawing.Point(12, 123);
            this.lblCap.Name = "lblCap";
            this.lblCap.Size = new System.Drawing.Size(431, 34);
            this.lblCap.TabIndex = 43;
            this.lblCap.Text = "Capitulo 6";
            this.lblCap.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblCap.Visible = false;
            // 
            // btnComecar
            // 
            this.btnComecar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnComecar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnComecar.Location = new System.Drawing.Point(357, 327);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(86, 23);
            this.btnComecar.TabIndex = 42;
            this.btnComecar.Text = "Começar";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // lblText1
            // 
            this.lblText1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblText1.Location = new System.Drawing.Point(12, 11);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(431, 41);
            this.lblText1.TabIndex = 40;
            this.lblText1.Text = "Suas ações foram ruins. A maldade tomou conta do mundo e tudo foi destruidio...";
            // 
            // pctrText1
            // 
            this.pctrText1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.pctrText1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pctrText1.Image = global::Jogo.Properties.Resources.CSFR;
            this.pctrText1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pctrText1.Location = new System.Drawing.Point(70, 106);
            this.pctrText1.Name = "pctrText1";
            this.pctrText1.Size = new System.Drawing.Size(303, 200);
            this.pctrText1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrText1.TabIndex = 41;
            this.pctrText1.TabStop = false;
            // 
            // CSFuturoRuim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(455, 360);
            this.ControlBox = false;
            this.Controls.Add(this.lblNameCap);
            this.Controls.Add(this.lblCap);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.pctrText1);
            this.Controls.Add(this.lblText1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(471, 399);
            this.MinimumSize = new System.Drawing.Size(471, 399);
            this.Name = "CSFuturoRuim";
            this.Text = "Se deu mal...";
            this.Load += new System.EventHandler(this.CSFuturoRuim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrText1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerGo;
        private System.Windows.Forms.Label lblNameCap;
        private System.Windows.Forms.Label lblCap;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.PictureBox pctrText1;
        private System.Windows.Forms.Label lblText1;
    }
}