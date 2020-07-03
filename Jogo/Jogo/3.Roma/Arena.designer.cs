namespace Teste
{
    partial class FrmBatalha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBatalha));
            this.PicbMarciano = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.picBescudo = new System.Windows.Forms.PictureBox();
            this.PrgBVidaMarciano = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrgBvidaDoAnimal = new System.Windows.Forms.ProgressBar();
            this.tmrAtake = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicbMarciano)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBescudo)).BeginInit();
            this.SuspendLayout();
            // 
            // PicbMarciano
            // 
            this.PicbMarciano.BackColor = System.Drawing.Color.Transparent;
            this.PicbMarciano.Image = global::Jogo.Properties.Resources.MarcianoParado;
            this.PicbMarciano.Location = new System.Drawing.Point(99, 247);
            this.PicbMarciano.Name = "PicbMarciano";
            this.PicbMarciano.Size = new System.Drawing.Size(75, 100);
            this.PicbMarciano.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PicbMarciano.TabIndex = 0;
            this.PicbMarciano.TabStop = false;
            this.PicbMarciano.Click += new System.EventHandler(this.PicbMarciano_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Jogo.Properties.Resources.Leao1;
            this.pictureBox1.Location = new System.Drawing.Point(542, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Jogo.Properties.Resources.BotaoATACAR;
            this.pictureBox2.Location = new System.Drawing.Point(177, 268);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picBescudo
            // 
            this.picBescudo.BackColor = System.Drawing.Color.Transparent;
            this.picBescudo.Image = global::Jogo.Properties.Resources.BotaoESCUDO_2_0;
            this.picBescudo.Location = new System.Drawing.Point(147, 227);
            this.picBescudo.Name = "picBescudo";
            this.picBescudo.Size = new System.Drawing.Size(35, 35);
            this.picBescudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBescudo.TabIndex = 3;
            this.picBescudo.TabStop = false;
            this.picBescudo.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // PrgBVidaMarciano
            // 
            this.PrgBVidaMarciano.Location = new System.Drawing.Point(59, 15);
            this.PrgBVidaMarciano.Name = "PrgBVidaMarciano";
            this.PrgBVidaMarciano.Size = new System.Drawing.Size(185, 23);
            this.PrgBVidaMarciano.TabIndex = 4;
            this.PrgBVidaMarciano.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "HP";
            // 
            // PrgBvidaDoAnimal
            // 
            this.PrgBvidaDoAnimal.Location = new System.Drawing.Point(442, 16);
            this.PrgBvidaDoAnimal.Name = "PrgBvidaDoAnimal";
            this.PrgBvidaDoAnimal.Size = new System.Drawing.Size(185, 23);
            this.PrgBvidaDoAnimal.TabIndex = 7;
            this.PrgBvidaDoAnimal.Value = 100;
            // 
            // tmrAtake
            // 
            this.tmrAtake.Tick += new System.EventHandler(this.tmrAtake_Tick);
            // 
            // FrmBatalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.Batalha_Pronta_2_0;
            this.ClientSize = new System.Drawing.Size(639, 423);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PrgBvidaDoAnimal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrgBVidaMarciano);
            this.Controls.Add(this.picBescudo);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PicbMarciano);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(655, 462);
            this.MinimumSize = new System.Drawing.Size(655, 462);
            this.Name = "FrmBatalha";
            this.Text = "Arena";
            this.Load += new System.EventHandler(this.FrmBatalha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicbMarciano)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBescudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicbMarciano;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox picBescudo;
        private System.Windows.Forms.ProgressBar PrgBVidaMarciano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar PrgBvidaDoAnimal;
        private System.Windows.Forms.Timer tmrAtake;
    }
}