namespace musicPlayer
{
    partial class MegaMarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MegaMarte));
            this.tmrMov = new System.Windows.Forms.Timer(this.components);
            this.tmrJump = new System.Windows.Forms.Timer(this.components);
            this.tmrShot = new System.Windows.Forms.Timer(this.components);
            this.tmrBullet1 = new System.Windows.Forms.Timer(this.components);
            this.tmrHurt = new System.Windows.Forms.Timer(this.components);
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemy = new System.Windows.Forms.Timer(this.components);
            this.pnlLife = new System.Windows.Forms.Panel();
            this.lblHpBar = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.picLife = new System.Windows.Forms.PictureBox();
            this.tmrInvi = new System.Windows.Forms.Timer(this.components);
            this.tmrDiiiie = new System.Windows.Forms.Timer(this.components);
            this.picPorta = new System.Windows.Forms.PictureBox();
            this.Bullet1 = new System.Windows.Forms.PictureBox();
            this.picHero = new System.Windows.Forms.PictureBox();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLife.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPorta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMov
            // 
            this.tmrMov.Interval = 150;
            this.tmrMov.Tick += new System.EventHandler(this.tmrMov_Tick);
            // 
            // tmrJump
            // 
            this.tmrJump.Enabled = true;
            this.tmrJump.Interval = 1;
            this.tmrJump.Tick += new System.EventHandler(this.tmrJump_Tick);
            // 
            // tmrShot
            // 
            this.tmrShot.Interval = 150;
            this.tmrShot.Tick += new System.EventHandler(this.tmrShot_Tick);
            // 
            // tmrBullet1
            // 
            this.tmrBullet1.Interval = 10;
            this.tmrBullet1.Tick += new System.EventHandler(this.tmrBullet1_Tick);
            // 
            // tmrHurt
            // 
            this.tmrHurt.Interval = 10;
            this.tmrHurt.Tick += new System.EventHandler(this.tmrHurt_Tick);
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 1;
            this.tmrUpdate.Tick += new System.EventHandler(this.Update_Tick);
            // 
            // tmrEnemy
            // 
            this.tmrEnemy.Interval = 150;
            this.tmrEnemy.Tick += new System.EventHandler(this.tmrEnemy_Tick);
            // 
            // pnlLife
            // 
            this.pnlLife.BackColor = System.Drawing.SystemColors.Control;
            this.pnlLife.Controls.Add(this.lblHpBar);
            this.pnlLife.Controls.Add(this.lblHp);
            this.pnlLife.Controls.Add(this.lblLife);
            this.pnlLife.Controls.Add(this.picLife);
            this.pnlLife.Location = new System.Drawing.Point(0, 0);
            this.pnlLife.Name = "pnlLife";
            this.pnlLife.Size = new System.Drawing.Size(239, 41);
            this.pnlLife.TabIndex = 13;
            // 
            // lblHpBar
            // 
            this.lblHpBar.BackColor = System.Drawing.Color.Transparent;
            this.lblHpBar.Image = global::musicPlayer.Properties.Resources.hpBar;
            this.lblHpBar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHpBar.Location = new System.Drawing.Point(82, 13);
            this.lblHpBar.Name = "lblHpBar";
            this.lblHpBar.Size = new System.Drawing.Size(145, 15);
            this.lblHpBar.TabIndex = 3;
            // 
            // lblHp
            // 
            this.lblHp.BackColor = System.Drawing.Color.Black;
            this.lblHp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHp.Location = new System.Drawing.Point(80, 11);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(149, 19);
            this.lblHp.TabIndex = 2;
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLife.Location = new System.Drawing.Point(39, 9);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(21, 24);
            this.lblLife.TabIndex = 1;
            this.lblLife.Text = "0";
            // 
            // picLife
            // 
            this.picLife.Image = global::musicPlayer.Properties.Resources.Life;
            this.picLife.Location = new System.Drawing.Point(7, 4);
            this.picLife.Name = "picLife";
            this.picLife.Size = new System.Drawing.Size(25, 33);
            this.picLife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLife.TabIndex = 0;
            this.picLife.TabStop = false;
            // 
            // tmrInvi
            // 
            this.tmrInvi.Interval = 200;
            this.tmrInvi.Tick += new System.EventHandler(this.tmrInvi_Tick);
            // 
            // tmrDiiiie
            // 
            this.tmrDiiiie.Interval = 10;
            this.tmrDiiiie.Tick += new System.EventHandler(this.tmrDiiiie_Tick);
            // 
            // picPorta
            // 
            this.picPorta.Location = new System.Drawing.Point(1489, 424);
            this.picPorta.Name = "picPorta";
            this.picPorta.Size = new System.Drawing.Size(21, 231);
            this.picPorta.TabIndex = 12;
            this.picPorta.TabStop = false;
            // 
            // Bullet1
            // 
            this.Bullet1.Image = global::musicPlayer.Properties.Resources.bulletRight;
            this.Bullet1.Location = new System.Drawing.Point(0, 0);
            this.Bullet1.Name = "Bullet1";
            this.Bullet1.Size = new System.Drawing.Size(34, 16);
            this.Bullet1.TabIndex = 1;
            this.Bullet1.TabStop = false;
            this.Bullet1.Visible = false;
            this.Bullet1.Paint += new System.Windows.Forms.PaintEventHandler(this.Bullet1_Paint);
            // 
            // picHero
            // 
            this.picHero.Image = ((System.Drawing.Image)(resources.GetObject("picHero.Image")));
            this.picHero.Location = new System.Drawing.Point(68, 500);
            this.picHero.Name = "picHero";
            this.picHero.Size = new System.Drawing.Size(94, 100);
            this.picHero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHero.TabIndex = 0;
            this.picHero.TabStop = false;
            this.picHero.LocationChanged += new System.EventHandler(this.picHero_LocationChanged);
            this.picHero.Paint += new System.Windows.Forms.PaintEventHandler(this.picHero_Paint);
            // 
            // picBackGround
            // 
            this.picBackGround.Image = global::musicPlayer.Properties.Resources.Stage1;
            this.picBackGround.Location = new System.Drawing.Point(0, 0);
            this.picBackGround.Margin = new System.Windows.Forms.Padding(0);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(1500, 750);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 2;
            this.picBackGround.TabStop = false;
            this.picBackGround.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 655);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 95);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(535, 581);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 35);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(610, 173);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 32);
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(840, 231);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(205, 38);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(246, 304);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(462, 35);
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(233, 119);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(310, 32);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(1158, 565);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 33);
            this.pictureBox7.TabIndex = 20;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(781, 497);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(36, 35);
            this.pictureBox8.TabIndex = 21;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(671, 424);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(39, 38);
            this.pictureBox9.TabIndex = 22;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(763, 359);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(37, 36);
            this.pictureBox10.TabIndex = 23;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(169, 215);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(37, 35);
            this.pictureBox11.TabIndex = 24;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(1337, 654);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(163, 95);
            this.pictureBox12.TabIndex = 25;
            this.pictureBox12.TabStop = false;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Black;
            this.pnlMain.Controls.Add(this.pictureBox12);
            this.pnlMain.Controls.Add(this.pictureBox1);
            this.pnlMain.Controls.Add(this.pictureBox11);
            this.pnlMain.Controls.Add(this.picHero);
            this.pnlMain.Controls.Add(this.pictureBox10);
            this.pnlMain.Controls.Add(this.picPorta);
            this.pnlMain.Controls.Add(this.pictureBox9);
            this.pnlMain.Controls.Add(this.pictureBox2);
            this.pnlMain.Controls.Add(this.pictureBox8);
            this.pnlMain.Controls.Add(this.pictureBox3);
            this.pnlMain.Controls.Add(this.pictureBox7);
            this.pnlMain.Controls.Add(this.pictureBox4);
            this.pnlMain.Controls.Add(this.pictureBox6);
            this.pnlMain.Controls.Add(this.pictureBox5);
            this.pnlMain.Controls.Add(this.picBackGround);
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(834, 411);
            this.pnlMain.TabIndex = 26;
            // 
            // MegaMarte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.Controls.Add(this.pnlLife);
            this.Controls.Add(this.Bullet1);
            this.Controls.Add(this.pnlMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MegaMarte";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.MagaMarte_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
            this.pnlLife.ResumeLayout(false);
            this.pnlLife.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPorta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tmrMov;
        private System.Windows.Forms.Timer tmrJump;
        private System.Windows.Forms.Timer tmrShot;
        private System.Windows.Forms.PictureBox picHero;
        private System.Windows.Forms.Timer tmrBullet1;
        private System.Windows.Forms.PictureBox Bullet1;
        public System.Windows.Forms.PictureBox picBackGround;
        private System.Windows.Forms.Timer tmrHurt;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Timer tmrEnemy;
        private System.Windows.Forms.PictureBox picPorta;
        private System.Windows.Forms.Panel pnlLife;
        private System.Windows.Forms.PictureBox picLife;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblHpBar;
        private System.Windows.Forms.Timer tmrInvi;
        private System.Windows.Forms.Timer tmrDiiiie;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox3;
        public System.Windows.Forms.PictureBox pictureBox4;
        public System.Windows.Forms.PictureBox pictureBox5;
        public System.Windows.Forms.PictureBox pictureBox6;
        public System.Windows.Forms.PictureBox pictureBox7;
        public System.Windows.Forms.PictureBox pictureBox8;
        public System.Windows.Forms.PictureBox pictureBox9;
        public System.Windows.Forms.PictureBox pictureBox10;
        public System.Windows.Forms.PictureBox pictureBox11;
        public System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.Panel pnlMain;
    }
}