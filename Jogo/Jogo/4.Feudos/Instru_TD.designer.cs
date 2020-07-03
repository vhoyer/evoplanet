namespace Feudo
{
    partial class frmInstruTD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInstruTD));
            this.btnVoltarTI = new System.Windows.Forms.Button();
            this.lblInfoStatus = new System.Windows.Forms.Label();
            this.lblTituloStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltarTI
            // 
            this.btnVoltarTI.Location = new System.Drawing.Point(349, 275);
            this.btnVoltarTI.Name = "btnVoltarTI";
            this.btnVoltarTI.Size = new System.Drawing.Size(141, 44);
            this.btnVoltarTI.TabIndex = 0;
            this.btnVoltarTI.Text = "Voltar";
            this.btnVoltarTI.UseVisualStyleBackColor = true;
            this.btnVoltarTI.Click += new System.EventHandler(this.btnVoltarTI_Click);
            // 
            // lblInfoStatus
            // 
            this.lblInfoStatus.AutoSize = true;
            this.lblInfoStatus.Location = new System.Drawing.Point(0, 9);
            this.lblInfoStatus.Name = "lblInfoStatus";
            this.lblInfoStatus.Size = new System.Drawing.Size(498, 260);
            this.lblInfoStatus.TabIndex = 1;
            this.lblInfoStatus.Text = resources.GetString("lblInfoStatus.Text");
            // 
            // lblTituloStatus
            // 
            this.lblTituloStatus.AutoSize = true;
            this.lblTituloStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloStatus.Location = new System.Drawing.Point(21, 7);
            this.lblTituloStatus.Name = "lblTituloStatus";
            this.lblTituloStatus.Size = new System.Drawing.Size(459, 32);
            this.lblTituloStatus.TabIndex = 2;
            this.lblTituloStatus.Text = "    Ao decorrer do jogo você vai se deparar com barras de status \r\nencontrada na " +
    "tela inicial, nela você pode encontrar:";
            // 
            // frmInstruTD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 331);
            this.ControlBox = false;
            this.Controls.Add(this.lblTituloStatus);
            this.Controls.Add(this.lblInfoStatus);
            this.Controls.Add(this.btnVoltarTI);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(518, 370);
            this.MinimumSize = new System.Drawing.Size(518, 370);
            this.Name = "frmInstruTD";
            this.Text = "Instruções";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltarTI;
        private System.Windows.Forms.Label lblInfoStatus;
        private System.Windows.Forms.Label lblTituloStatus;
    }
}