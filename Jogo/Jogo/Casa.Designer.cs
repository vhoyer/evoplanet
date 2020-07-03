namespace Jogo
{
    partial class Casa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Casa));
            this.lblComida = new System.Windows.Forms.Label();
            this.btnComer = new System.Windows.Forms.Button();
            this.btnDormir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblComida
            // 
            this.lblComida.AutoSize = true;
            this.lblComida.Location = new System.Drawing.Point(13, 13);
            this.lblComida.Name = "lblComida";
            this.lblComida.Size = new System.Drawing.Size(0, 13);
            this.lblComida.TabIndex = 1;
            // 
            // btnComer
            // 
            this.btnComer.Location = new System.Drawing.Point(63, 177);
            this.btnComer.Name = "btnComer";
            this.btnComer.Size = new System.Drawing.Size(75, 23);
            this.btnComer.TabIndex = 2;
            this.btnComer.Text = "Comer";
            this.btnComer.UseVisualStyleBackColor = true;
            this.btnComer.Click += new System.EventHandler(this.btnComer_Click);
            // 
            // btnDormir
            // 
            this.btnDormir.Location = new System.Drawing.Point(180, 177);
            this.btnDormir.Name = "btnDormir";
            this.btnDormir.Size = new System.Drawing.Size(75, 23);
            this.btnDormir.TabIndex = 3;
            this.btnDormir.Text = "Dormir";
            this.btnDormir.UseVisualStyleBackColor = true;
            this.btnDormir.Click += new System.EventHandler(this.btnDormir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(13, 238);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "<<Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Casa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 273);
            this.ControlBox = false;
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnDormir);
            this.Controls.Add(this.btnComer);
            this.Controls.Add(this.lblComida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(377, 312);
            this.MinimumSize = new System.Drawing.Size(377, 312);
            this.Name = "Casa";
            this.Text = "Casa";
            this.Load += new System.EventHandler(this.Casa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblComida;
        private System.Windows.Forms.Button btnComer;
        private System.Windows.Forms.Button btnDormir;
        private System.Windows.Forms.Button btnSair;
    }
}