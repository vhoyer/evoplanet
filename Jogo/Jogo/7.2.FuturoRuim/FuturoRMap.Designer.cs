namespace Jogo._7._2.FuturoRuim
{
    partial class FuturoRMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FuturoRMap));
            this.lblCasa = new System.Windows.Forms.Label();
            this.lblTrabalhar = new System.Windows.Forms.Label();
            this.lblMercado = new System.Windows.Forms.Label();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblJogo = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCasa
            // 
            this.lblCasa.BackColor = System.Drawing.Color.Transparent;
            this.lblCasa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCasa.Location = new System.Drawing.Point(219, 428);
            this.lblCasa.Name = "lblCasa";
            this.lblCasa.Size = new System.Drawing.Size(55, 40);
            this.lblCasa.TabIndex = 2;
            this.lblCasa.Click += new System.EventHandler(this.lblCasa_Click);
            // 
            // lblTrabalhar
            // 
            this.lblTrabalhar.BackColor = System.Drawing.Color.Transparent;
            this.lblTrabalhar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTrabalhar.Location = new System.Drawing.Point(724, 108);
            this.lblTrabalhar.Name = "lblTrabalhar";
            this.lblTrabalhar.Size = new System.Drawing.Size(124, 62);
            this.lblTrabalhar.TabIndex = 3;
            this.lblTrabalhar.Click += new System.EventHandler(this.lblTrabalhar_Click);
            // 
            // lblMercado
            // 
            this.lblMercado.BackColor = System.Drawing.Color.Transparent;
            this.lblMercado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblMercado.Location = new System.Drawing.Point(724, 252);
            this.lblMercado.Name = "lblMercado";
            this.lblMercado.Size = new System.Drawing.Size(124, 82);
            this.lblMercado.TabIndex = 4;
            this.lblMercado.Click += new System.EventHandler(this.lblMercado_Click);
            // 
            // lblFor
            // 
            this.lblFor.BackColor = System.Drawing.Color.Transparent;
            this.lblFor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFor.Location = new System.Drawing.Point(28, 30);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(298, 119);
            this.lblFor.TabIndex = 7;
            this.lblFor.Click += new System.EventHandler(this.lblFor_Click);
            // 
            // lblInt
            // 
            this.lblInt.BackColor = System.Drawing.Color.Transparent;
            this.lblInt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblInt.Location = new System.Drawing.Point(293, 404);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(130, 104);
            this.lblInt.TabIndex = 8;
            this.lblInt.Click += new System.EventHandler(this.lblInt_Click);
            // 
            // lblCar
            // 
            this.lblCar.BackColor = System.Drawing.Color.Transparent;
            this.lblCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCar.Location = new System.Drawing.Point(207, 508);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(109, 77);
            this.lblCar.TabIndex = 9;
            this.lblCar.Click += new System.EventHandler(this.lblCar_Click);
            // 
            // lblJogo
            // 
            this.lblJogo.BackColor = System.Drawing.Color.Transparent;
            this.lblJogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblJogo.Location = new System.Drawing.Point(104, 227);
            this.lblJogo.Name = "lblJogo";
            this.lblJogo.Size = new System.Drawing.Size(55, 40);
            this.lblJogo.TabIndex = 10;
            this.lblJogo.Click += new System.EventHandler(this.lblJogo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVoltar.Location = new System.Drawing.Point(817, 573);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "Voltar >>";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FuturoRMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Jogo.Properties.Resources.BadFuturo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(904, 608);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblJogo);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.lblMercado);
            this.Controls.Add(this.lblTrabalhar);
            this.Controls.Add(this.lblCasa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(920, 647);
            this.MinimumSize = new System.Drawing.Size(920, 647);
            this.Name = "FuturoRMap";
            this.Text = "Mapa do Futuro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCasa;
        private System.Windows.Forms.Label lblTrabalhar;
        private System.Windows.Forms.Label lblMercado;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblJogo;
        private System.Windows.Forms.Button btnVoltar;
    }
}