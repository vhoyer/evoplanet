namespace musicPlayer
{
    partial class Hardware
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hardware));
            this.pnlWebMesa = new System.Windows.Forms.Panel();
            this.webMesa = new System.Windows.Forms.WebBrowser();
            this.btnMenu = new System.Windows.Forms.Button();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.btnGoogle = new System.Windows.Forms.Label();
            this.separador3 = new System.Windows.Forms.Label();
            this.btnAgrad = new System.Windows.Forms.Label();
            this.btnAnima = new System.Windows.Forms.Label();
            this.separador2 = new System.Windows.Forms.Label();
            this.btnWebTeclado = new System.Windows.Forms.Label();
            this.btnTeclado = new System.Windows.Forms.Label();
            this.separador1 = new System.Windows.Forms.Label();
            this.btnWebMesa = new System.Windows.Forms.Label();
            this.btnMesa = new System.Windows.Forms.Label();
            this.pnlWebTeclado = new System.Windows.Forms.Panel();
            this.webTeclado = new System.Windows.Forms.WebBrowser();
            this.pnlWeb = new System.Windows.Forms.Panel();
            this.webGoogle = new System.Windows.Forms.WebBrowser();
            this.pnlTeclado = new System.Windows.Forms.Panel();
            this.pctTeclado = new System.Windows.Forms.PictureBox();
            this.lblTextTeclado = new System.Windows.Forms.Label();
            this.pnlMesa = new System.Windows.Forms.Panel();
            this.pctMesa = new System.Windows.Forms.PictureBox();
            this.lblTextMesa = new System.Windows.Forms.Label();
            this.pnlAgradecimentos = new System.Windows.Forms.Panel();
            this.lblAgradTitulo = new System.Windows.Forms.Label();
            this.lblAgrad = new System.Windows.Forms.Label();
            this.pnlAnima = new System.Windows.Forms.Panel();
            this.pctACaneta = new System.Windows.Forms.PictureBox();
            this.pctAMesa = new System.Windows.Forms.PictureBox();
            this.tmrAnima = new System.Windows.Forms.Timer(this.components);
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pnlWebMesa.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.pnlOptions.SuspendLayout();
            this.pnlWebTeclado.SuspendLayout();
            this.pnlWeb.SuspendLayout();
            this.pnlTeclado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTeclado)).BeginInit();
            this.pnlMesa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMesa)).BeginInit();
            this.pnlAgradecimentos.SuspendLayout();
            this.pnlAnima.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctACaneta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAMesa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlWebMesa
            // 
            this.pnlWebMesa.Controls.Add(this.webMesa);
            this.pnlWebMesa.Location = new System.Drawing.Point(12, 455);
            this.pnlWebMesa.Name = "pnlWebMesa";
            this.pnlWebMesa.Size = new System.Drawing.Size(810, 354);
            this.pnlWebMesa.TabIndex = 0;
            this.pnlWebMesa.MouseEnter += new System.EventHandler(this.pnls_MouseEnter);
            // 
            // webMesa
            // 
            this.webMesa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webMesa.Location = new System.Drawing.Point(0, 0);
            this.webMesa.MinimumSize = new System.Drawing.Size(20, 20);
            this.webMesa.Name = "webMesa";
            this.webMesa.Size = new System.Drawing.Size(810, 354);
            this.webMesa.TabIndex = 0;
            this.webMesa.Url = new System.Uri("https://pt.wikipedia.org/wiki/Tablete_gr%C3%A1fico", System.UriKind.Absolute);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMenu.Location = new System.Drawing.Point(745, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(75, 23);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "<< Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DimGray;
            this.pnlMenu.Controls.Add(this.pnlOptions);
            this.pnlMenu.Location = new System.Drawing.Point(828, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 411);
            this.pnlMenu.TabIndex = 2;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.DarkGray;
            this.pnlOptions.Controls.Add(this.btnGoogle);
            this.pnlOptions.Controls.Add(this.separador3);
            this.pnlOptions.Controls.Add(this.btnAgrad);
            this.pnlOptions.Controls.Add(this.btnAnima);
            this.pnlOptions.Controls.Add(this.separador2);
            this.pnlOptions.Controls.Add(this.btnWebTeclado);
            this.pnlOptions.Controls.Add(this.btnTeclado);
            this.pnlOptions.Controls.Add(this.separador1);
            this.pnlOptions.Controls.Add(this.btnWebMesa);
            this.pnlOptions.Controls.Add(this.btnMesa);
            this.pnlOptions.Location = new System.Drawing.Point(16, 84);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(170, 241);
            this.pnlOptions.TabIndex = 0;
            // 
            // btnGoogle
            // 
            this.btnGoogle.BackColor = System.Drawing.Color.DimGray;
            this.btnGoogle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGoogle.Location = new System.Drawing.Point(0, 217);
            this.btnGoogle.Name = "btnGoogle";
            this.btnGoogle.Size = new System.Drawing.Size(170, 23);
            this.btnGoogle.TabIndex = 9;
            this.btnGoogle.Text = "Qualquer outra informação";
            this.btnGoogle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGoogle.Click += new System.EventHandler(this.btnGoogle_Click);
            this.btnGoogle.MouseEnter += new System.EventHandler(this.btnGoogle_MouseEnter);
            this.btnGoogle.MouseLeave += new System.EventHandler(this.btnGoogle_MouseLeave);
            // 
            // separador3
            // 
            this.separador3.BackColor = System.Drawing.Color.DimGray;
            this.separador3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.separador3.Location = new System.Drawing.Point(0, 193);
            this.separador3.Name = "separador3";
            this.separador3.Size = new System.Drawing.Size(170, 23);
            this.separador3.TabIndex = 8;
            this.separador3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgrad
            // 
            this.btnAgrad.BackColor = System.Drawing.Color.DimGray;
            this.btnAgrad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAgrad.Location = new System.Drawing.Point(0, 169);
            this.btnAgrad.Name = "btnAgrad";
            this.btnAgrad.Size = new System.Drawing.Size(170, 23);
            this.btnAgrad.TabIndex = 7;
            this.btnAgrad.Text = "Agradecimentos";
            this.btnAgrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAgrad.Click += new System.EventHandler(this.btnEtep_Click);
            this.btnAgrad.MouseEnter += new System.EventHandler(this.btnEtep_MouseEnter);
            this.btnAgrad.MouseLeave += new System.EventHandler(this.btnEtep_MouseLeave);
            // 
            // btnAnima
            // 
            this.btnAnima.BackColor = System.Drawing.Color.DimGray;
            this.btnAnima.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnima.Location = new System.Drawing.Point(0, 145);
            this.btnAnima.Name = "btnAnima";
            this.btnAnima.Size = new System.Drawing.Size(170, 23);
            this.btnAnima.TabIndex = 6;
            this.btnAnima.Text = "Animação";
            this.btnAnima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnima.Click += new System.EventHandler(this.btnAnima_Click);
            this.btnAnima.MouseEnter += new System.EventHandler(this.btnAnima_MouseEnter);
            this.btnAnima.MouseLeave += new System.EventHandler(this.btnAnima_MouseLeave);
            // 
            // separador2
            // 
            this.separador2.BackColor = System.Drawing.Color.DimGray;
            this.separador2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.separador2.Location = new System.Drawing.Point(0, 121);
            this.separador2.Name = "separador2";
            this.separador2.Size = new System.Drawing.Size(170, 23);
            this.separador2.TabIndex = 5;
            this.separador2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWebTeclado
            // 
            this.btnWebTeclado.BackColor = System.Drawing.Color.DimGray;
            this.btnWebTeclado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnWebTeclado.Location = new System.Drawing.Point(0, 97);
            this.btnWebTeclado.Name = "btnWebTeclado";
            this.btnWebTeclado.Size = new System.Drawing.Size(170, 23);
            this.btnWebTeclado.TabIndex = 4;
            this.btnWebTeclado.Text = "Mais Info. > Teclado";
            this.btnWebTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWebTeclado.Click += new System.EventHandler(this.btnWebTeclado_Click);
            this.btnWebTeclado.MouseEnter += new System.EventHandler(this.btnWebTeclado_MouseEnter);
            this.btnWebTeclado.MouseLeave += new System.EventHandler(this.btnWebTeclado_MouseLeave);
            // 
            // btnTeclado
            // 
            this.btnTeclado.BackColor = System.Drawing.Color.DimGray;
            this.btnTeclado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnTeclado.Location = new System.Drawing.Point(0, 73);
            this.btnTeclado.Name = "btnTeclado";
            this.btnTeclado.Size = new System.Drawing.Size(170, 23);
            this.btnTeclado.TabIndex = 3;
            this.btnTeclado.Text = "Teclado";
            this.btnTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTeclado.Click += new System.EventHandler(this.btnTeclado_Click);
            this.btnTeclado.MouseEnter += new System.EventHandler(this.btnTeclado_MouseEnter);
            this.btnTeclado.MouseLeave += new System.EventHandler(this.btnTeclado_MouseLeave);
            // 
            // separador1
            // 
            this.separador1.BackColor = System.Drawing.Color.DimGray;
            this.separador1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.separador1.Location = new System.Drawing.Point(0, 49);
            this.separador1.Name = "separador1";
            this.separador1.Size = new System.Drawing.Size(170, 23);
            this.separador1.TabIndex = 2;
            this.separador1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWebMesa
            // 
            this.btnWebMesa.BackColor = System.Drawing.Color.DimGray;
            this.btnWebMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnWebMesa.Location = new System.Drawing.Point(0, 25);
            this.btnWebMesa.Name = "btnWebMesa";
            this.btnWebMesa.Size = new System.Drawing.Size(170, 23);
            this.btnWebMesa.TabIndex = 1;
            this.btnWebMesa.Text = "Mais Info. > Mesa Digitalizadora";
            this.btnWebMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWebMesa.Click += new System.EventHandler(this.btnWebMesa_Click);
            this.btnWebMesa.MouseEnter += new System.EventHandler(this.btnWebMesa_MouseEnter);
            this.btnWebMesa.MouseLeave += new System.EventHandler(this.btnWebMesa_MouseLeave);
            // 
            // btnMesa
            // 
            this.btnMesa.BackColor = System.Drawing.Color.DimGray;
            this.btnMesa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMesa.Location = new System.Drawing.Point(0, 1);
            this.btnMesa.Name = "btnMesa";
            this.btnMesa.Size = new System.Drawing.Size(170, 23);
            this.btnMesa.TabIndex = 0;
            this.btnMesa.Text = "Mesa Digitalizadora";
            this.btnMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMesa.Click += new System.EventHandler(this.btnMesa_Click);
            this.btnMesa.MouseEnter += new System.EventHandler(this.btnMesa_MouseEnter);
            this.btnMesa.MouseLeave += new System.EventHandler(this.btnMesa_MouseLeave);
            // 
            // pnlWebTeclado
            // 
            this.pnlWebTeclado.Controls.Add(this.webTeclado);
            this.pnlWebTeclado.Location = new System.Drawing.Point(12, 455);
            this.pnlWebTeclado.Name = "pnlWebTeclado";
            this.pnlWebTeclado.Size = new System.Drawing.Size(810, 354);
            this.pnlWebTeclado.TabIndex = 1;
            this.pnlWebTeclado.Visible = false;
            this.pnlWebTeclado.MouseEnter += new System.EventHandler(this.pnls_MouseEnter);
            // 
            // webTeclado
            // 
            this.webTeclado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webTeclado.Location = new System.Drawing.Point(0, 0);
            this.webTeclado.MinimumSize = new System.Drawing.Size(20, 20);
            this.webTeclado.Name = "webTeclado";
            this.webTeclado.Size = new System.Drawing.Size(810, 354);
            this.webTeclado.TabIndex = 0;
            this.webTeclado.Url = new System.Uri("https://pt.wikipedia.org/wiki/Teclado_(inform%C3%A1tica)", System.UriKind.Absolute);
            // 
            // pnlWeb
            // 
            this.pnlWeb.Controls.Add(this.webGoogle);
            this.pnlWeb.Location = new System.Drawing.Point(12, 455);
            this.pnlWeb.Name = "pnlWeb";
            this.pnlWeb.Size = new System.Drawing.Size(810, 354);
            this.pnlWeb.TabIndex = 3;
            this.pnlWeb.Visible = false;
            this.pnlWeb.MouseEnter += new System.EventHandler(this.pnls_MouseEnter);
            // 
            // webGoogle
            // 
            this.webGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webGoogle.Location = new System.Drawing.Point(0, 0);
            this.webGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.webGoogle.Name = "webGoogle";
            this.webGoogle.Size = new System.Drawing.Size(810, 354);
            this.webGoogle.TabIndex = 0;
            this.webGoogle.Url = new System.Uri("https://www.google.com.br/webhp?hl=pt-BR", System.UriKind.Absolute);
            // 
            // pnlTeclado
            // 
            this.pnlTeclado.Controls.Add(this.pctTeclado);
            this.pnlTeclado.Controls.Add(this.lblTextTeclado);
            this.pnlTeclado.Location = new System.Drawing.Point(12, 455);
            this.pnlTeclado.Name = "pnlTeclado";
            this.pnlTeclado.Size = new System.Drawing.Size(810, 354);
            this.pnlTeclado.TabIndex = 6;
            this.pnlTeclado.Visible = false;
            this.pnlTeclado.MouseEnter += new System.EventHandler(this.pnls_MouseEnter);
            // 
            // pctTeclado
            // 
            this.pctTeclado.BackColor = System.Drawing.Color.Black;
            this.pctTeclado.Image = ((System.Drawing.Image)(resources.GetObject("pctTeclado.Image")));
            this.pctTeclado.Location = new System.Drawing.Point(311, 18);
            this.pctTeclado.Name = "pctTeclado";
            this.pctTeclado.Size = new System.Drawing.Size(188, 124);
            this.pctTeclado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctTeclado.TabIndex = 1;
            this.pctTeclado.TabStop = false;
            // 
            // lblTextTeclado
            // 
            this.lblTextTeclado.ForeColor = System.Drawing.Color.White;
            this.lblTextTeclado.Location = new System.Drawing.Point(23, 145);
            this.lblTextTeclado.Name = "lblTextTeclado";
            this.lblTextTeclado.Size = new System.Drawing.Size(764, 195);
            this.lblTextTeclado.TabIndex = 0;
            this.lblTextTeclado.Text = resources.GetString("lblTextTeclado.Text");
            this.lblTextTeclado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMesa
            // 
            this.pnlMesa.Controls.Add(this.pctMesa);
            this.pnlMesa.Controls.Add(this.lblTextMesa);
            this.pnlMesa.Location = new System.Drawing.Point(12, 455);
            this.pnlMesa.Name = "pnlMesa";
            this.pnlMesa.Size = new System.Drawing.Size(810, 354);
            this.pnlMesa.TabIndex = 7;
            this.pnlMesa.Visible = false;
            this.pnlMesa.MouseEnter += new System.EventHandler(this.pnls_MouseEnter);
            // 
            // pctMesa
            // 
            this.pctMesa.Image = ((System.Drawing.Image)(resources.GetObject("pctMesa.Image")));
            this.pctMesa.Location = new System.Drawing.Point(311, 18);
            this.pctMesa.Name = "pctMesa";
            this.pctMesa.Size = new System.Drawing.Size(188, 124);
            this.pctMesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctMesa.TabIndex = 1;
            this.pctMesa.TabStop = false;
            // 
            // lblTextMesa
            // 
            this.lblTextMesa.ForeColor = System.Drawing.Color.White;
            this.lblTextMesa.Location = new System.Drawing.Point(23, 145);
            this.lblTextMesa.Name = "lblTextMesa";
            this.lblTextMesa.Size = new System.Drawing.Size(764, 195);
            this.lblTextMesa.TabIndex = 0;
            this.lblTextMesa.Text = resources.GetString("lblTextMesa.Text");
            this.lblTextMesa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAgradecimentos
            // 
            this.pnlAgradecimentos.Controls.Add(this.lblAgradTitulo);
            this.pnlAgradecimentos.Controls.Add(this.lblAgrad);
            this.pnlAgradecimentos.Location = new System.Drawing.Point(12, 455);
            this.pnlAgradecimentos.Name = "pnlAgradecimentos";
            this.pnlAgradecimentos.Size = new System.Drawing.Size(810, 354);
            this.pnlAgradecimentos.TabIndex = 8;
            this.pnlAgradecimentos.Visible = false;
            this.pnlAgradecimentos.MouseEnter += new System.EventHandler(this.pnls_MouseEnter);
            // 
            // lblAgradTitulo
            // 
            this.lblAgradTitulo.AutoSize = true;
            this.lblAgradTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgradTitulo.ForeColor = System.Drawing.Color.White;
            this.lblAgradTitulo.Location = new System.Drawing.Point(286, 43);
            this.lblAgradTitulo.Name = "lblAgradTitulo";
            this.lblAgradTitulo.Size = new System.Drawing.Size(239, 29);
            this.lblAgradTitulo.TabIndex = 1;
            this.lblAgradTitulo.Text = "AGRADECIMENTOS";
            // 
            // lblAgrad
            // 
            this.lblAgrad.ForeColor = System.Drawing.Color.White;
            this.lblAgrad.Location = new System.Drawing.Point(23, 100);
            this.lblAgrad.Name = "lblAgrad";
            this.lblAgrad.Size = new System.Drawing.Size(764, 193);
            this.lblAgrad.TabIndex = 0;
            this.lblAgrad.Text = resources.GetString("lblAgrad.Text");
            this.lblAgrad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlAnima
            // 
            this.pnlAnima.Controls.Add(this.pctACaneta);
            this.pnlAnima.Controls.Add(this.pctAMesa);
            this.pnlAnima.Location = new System.Drawing.Point(12, 455);
            this.pnlAnima.Name = "pnlAnima";
            this.pnlAnima.Size = new System.Drawing.Size(810, 354);
            this.pnlAnima.TabIndex = 9;
            this.pnlAnima.Visible = false;
            this.pnlAnima.MouseEnter += new System.EventHandler(this.pnls_MouseEnter);
            // 
            // pctACaneta
            // 
            this.pctACaneta.Image = ((System.Drawing.Image)(resources.GetObject("pctACaneta.Image")));
            this.pctACaneta.Location = new System.Drawing.Point(258, 88);
            this.pctACaneta.Name = "pctACaneta";
            this.pctACaneta.Size = new System.Drawing.Size(118, 131);
            this.pctACaneta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctACaneta.TabIndex = 2;
            this.pctACaneta.TabStop = false;
            // 
            // pctAMesa
            // 
            this.pctAMesa.Image = ((System.Drawing.Image)(resources.GetObject("pctAMesa.Image")));
            this.pctAMesa.Location = new System.Drawing.Point(115, 5);
            this.pctAMesa.Name = "pctAMesa";
            this.pctAMesa.Size = new System.Drawing.Size(580, 330);
            this.pctAMesa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctAMesa.TabIndex = 1;
            this.pctAMesa.TabStop = false;
            // 
            // tmrAnima
            // 
            this.tmrAnima.Enabled = true;
            this.tmrAnima.Tick += new System.EventHandler(this.tmrAnima_Tick);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(259, 50);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(317, 330);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 10;
            this.pctLogo.TabStop = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(12, 12);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 23);
            this.btnVoltar.TabIndex = 11;
            this.btnVoltar.Text = "<< Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // Hardware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(834, 411);
            this.ControlBox = false;
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlAnima);
            this.Controls.Add(this.pnlAgradecimentos);
            this.Controls.Add(this.pnlMesa);
            this.Controls.Add(this.pnlTeclado);
            this.Controls.Add(this.pnlWeb);
            this.Controls.Add(this.pnlWebTeclado);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.pnlWebMesa);
            this.Controls.Add(this.pctLogo);
            this.Name = "Hardware";
            this.Text = "EvoPlanet";
            this.Load += new System.EventHandler(this.Hardware_Load);
            this.MouseEnter += new System.EventHandler(this.Hardware_MouseEnter);
            this.pnlWebMesa.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.pnlOptions.ResumeLayout(false);
            this.pnlWebTeclado.ResumeLayout(false);
            this.pnlWeb.ResumeLayout(false);
            this.pnlTeclado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctTeclado)).EndInit();
            this.pnlMesa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMesa)).EndInit();
            this.pnlAgradecimentos.ResumeLayout(false);
            this.pnlAgradecimentos.PerformLayout();
            this.pnlAnima.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctACaneta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctAMesa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWebMesa;
        private System.Windows.Forms.WebBrowser webMesa;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Label btnGoogle;
        private System.Windows.Forms.Label separador3;
        private System.Windows.Forms.Label btnAgrad;
        private System.Windows.Forms.Label btnAnima;
        private System.Windows.Forms.Label separador2;
        private System.Windows.Forms.Label btnWebTeclado;
        private System.Windows.Forms.Label btnTeclado;
        private System.Windows.Forms.Label separador1;
        private System.Windows.Forms.Label btnWebMesa;
        private System.Windows.Forms.Label btnMesa;
        private System.Windows.Forms.Panel pnlWebTeclado;
        private System.Windows.Forms.WebBrowser webTeclado;
        private System.Windows.Forms.Panel pnlWeb;
        private System.Windows.Forms.WebBrowser webGoogle;
        private System.Windows.Forms.Panel pnlTeclado;
        private System.Windows.Forms.PictureBox pctTeclado;
        private System.Windows.Forms.Label lblTextTeclado;
        private System.Windows.Forms.Panel pnlMesa;
        private System.Windows.Forms.PictureBox pctMesa;
        private System.Windows.Forms.Label lblTextMesa;
        private System.Windows.Forms.Panel pnlAgradecimentos;
        private System.Windows.Forms.Label lblAgrad;
        private System.Windows.Forms.Panel pnlAnima;
        private System.Windows.Forms.PictureBox pctAMesa;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.PictureBox pctACaneta;
        private System.Windows.Forms.Timer tmrAnima;
        private System.Windows.Forms.Label lblAgradTitulo;
        private System.Windows.Forms.Button btnVoltar;
    }
}