namespace Jogo._6.Presente
{
    partial class Presente1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Presente1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTexto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSim = new System.Windows.Forms.Button();
            this.btnNao = new System.Windows.Forms.Button();
            this.pctrEu = new System.Windows.Forms.PictureBox();
            this.pctrPreto = new System.Windows.Forms.PictureBox();
            this.pctrRosto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrEu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPreto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRosto)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Jogo.Properties.Resources.AbajurLigado;
            this.pictureBox1.Location = new System.Drawing.Point(382, 147);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTexto
            // 
            this.lblTexto.AutoSize = true;
            this.lblTexto.Location = new System.Drawing.Point(13, 13);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(250, 13);
            this.lblTexto.TabIndex = 1;
            this.lblTexto.Text = "Vamos logo homem, vamos atrasar para nosso vôo!";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSim
            // 
            this.btnSim.Location = new System.Drawing.Point(301, 175);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(75, 23);
            this.btnSim.TabIndex = 3;
            this.btnSim.Text = "Sim";
            this.btnSim.UseVisualStyleBackColor = true;
            this.btnSim.Visible = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // btnNao
            // 
            this.btnNao.Location = new System.Drawing.Point(522, 174);
            this.btnNao.Name = "btnNao";
            this.btnNao.Size = new System.Drawing.Size(75, 23);
            this.btnNao.TabIndex = 4;
            this.btnNao.Text = "Não";
            this.btnNao.UseVisualStyleBackColor = true;
            this.btnNao.Visible = false;
            this.btnNao.Click += new System.EventHandler(this.btnNão_Click);
            // 
            // pctrEu
            // 
            this.pctrEu.BackColor = System.Drawing.Color.Transparent;
            this.pctrEu.Image = global::Jogo.Properties.Resources.Eu_stick;
            this.pctrEu.Location = new System.Drawing.Point(792, 326);
            this.pctrEu.Name = "pctrEu";
            this.pctrEu.Size = new System.Drawing.Size(116, 189);
            this.pctrEu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctrEu.TabIndex = 5;
            this.pctrEu.TabStop = false;
            // 
            // pctrPreto
            // 
            this.pctrPreto.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pctrPreto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctrPreto.Location = new System.Drawing.Point(0, 0);
            this.pctrPreto.Name = "pctrPreto";
            this.pctrPreto.Size = new System.Drawing.Size(800, 568);
            this.pctrPreto.TabIndex = 6;
            this.pctrPreto.TabStop = false;
            this.pctrPreto.Visible = false;
            // 
            // pctrRosto
            // 
            this.pctrRosto.BackColor = System.Drawing.Color.Transparent;
            this.pctrRosto.BackgroundImage = global::Jogo.Properties.Resources.Feliz;
            this.pctrRosto.Location = new System.Drawing.Point(301, 238);
            this.pctrRosto.Name = "pctrRosto";
            this.pctrRosto.Size = new System.Drawing.Size(275, 218);
            this.pctrRosto.TabIndex = 7;
            this.pctrRosto.TabStop = false;
            this.pctrRosto.Visible = false;
            // 
            // Presente1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.Presente1;
            this.ClientSize = new System.Drawing.Size(800, 568);
            this.ControlBox = false;
            this.Controls.Add(this.pctrRosto);
            this.Controls.Add(this.pctrPreto);
            this.Controls.Add(this.pctrEu);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnSim);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblTexto);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 607);
            this.MinimumSize = new System.Drawing.Size(816, 607);
            this.Name = "Presente1";
            this.Text = "Presente";
            this.Load += new System.EventHandler(this.Presente1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrEu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrPreto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctrRosto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSim;
        private System.Windows.Forms.Button btnNao;
        private System.Windows.Forms.PictureBox pctrEu;
        private System.Windows.Forms.PictureBox pctrPreto;
        private System.Windows.Forms.PictureBox pctrRosto;
    }
}