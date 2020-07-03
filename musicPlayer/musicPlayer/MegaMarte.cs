using System;
using System.Media;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace musicPlayer
{
    public partial class MegaMarte : Form
    {
        #region "Variaveis"
        //
        // Globais, pra um monte de coisa
        //
        int movSpeed = 5;
        Random rnd = new Random();
        //
        // plataforma related & Player position
        //
        Point peR, peL, heroCenter;
        //Referencia
        //[   ][   ][   ]
        //[   ][hCe][   ]
        //[peL][   ][peR]
        public static bool[,] plat = new bool[1500, 750];
        public int platMaxX = 1500, platMaxY = 750;
        //
        // Jump related
        //
        int jumpVel = 5, g = 10;
        int velImp, ForJump;
        bool canJump;
        /* Se eu Fosse levar a sério a simulação...
        double velocidadeInicial, forcaResultante, aceleracao, forcaG, massa, forcaPeso
        aceleracao = velocidadeInicial / 
        forcaPeso = massa* forcaG;
        forcaResultante = massa* aceleracao;
            */
        //
        // Shot related
        //
        Image img;//guarda a imagem para a qual voltar
        int shotDmg = 10;
        int bulletSpeed = 10;
        //
        // animações
        //
        int ani, frm, aniInvi, aniDiiie;
        static public bool isRight, isLeft, inJump, rightShot, canShot, inMov, isHurt;
        //
        // Hurt animação/mecanica de vida/respawn;
        //
        int whereToStop, lifes, Hp;
        const int danoLevado_m = 10, danoLevado_M = danoLevado_m + 40;
        Point respawnPoint;
        //
        // Inimigo
        //
        const int enemyMaxHp = 100;
        int enemyHp;
        int timeIdle, //recebe rnd
            maxIdle = 50,
            minIdle = 20;
        //
        // Backgroud related
        //
        Bitmap bgBmp;
        Point center;
        //
        // sound
        //
        SoundPlayer soundBoom, soundGrito, soundTiro, soundBlik, soundHurt;
        #endregion

        public MegaMarte()
        {
            InitializeComponent();
            InitializeVariables();
        }

        private void MagaMarte_Load(object sender, EventArgs e)
        {
            bgCollider.InitializeBgCollider();
            InitializeGraphics();

            lblLife.Text = lifes.ToString();
            SpawnEnemy(pictureBox4);
        }

        #region "Graphics"
        #region "transparent Control"
        private void trasparantControl()
        {
            picParent(Bullet1);
            picParent(picHero);
            picParent(picPorta);
            //outros -----------------
            picParent(pictureBox1);
            picParent(pictureBox2);
            picParent(pictureBox3);
            picParent(pictureBox4);
            picParent(pictureBox5);
            picParent(pictureBox6);
            picParent(pictureBox7);
            picParent(pictureBox8);
            picParent(pictureBox9);
            picParent(pictureBox10);
            picParent(pictureBox11);
            picParent(pictureBox12);
        }

        private void picParent(PictureBox pct)
        {
            pct.BackColor = Color.Transparent;
            pct.Parent = picBackGround;
        }

        public void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            picHero_Paint(sender, e);
            Bullet1_Paint(sender, e);
            pictureBox9_Paint(sender, e);
        }

        private void picHero_Paint(object sender, PaintEventArgs e)
        {

        }

        public void pictureBox9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Bullet1_Paint(object sender, PaintEventArgs e)
        {

        }
        #endregion

        private void adjustBg()
        {
            Point pntCenter = new Point(picBackGround.Size.Width / 2, picBackGround.Size.Height / 2);
            int difX = pntCenter.X - heroCenter.X,
                difY = pntCenter.Y - heroCenter.Y;

            picBackGround.Location = new Point(difX - center.X, difY - center.Y);
        }

        private void bgPixelCorrection()
        {
            using (bgBmp)
            {
                var bmp2 = new Bitmap(picBackGround.Width, picBackGround.Height);
                using (var g = Graphics.FromImage(bmp2))
                {
                    g.InterpolationMode = InterpolationMode.NearestNeighbor;
                    g.DrawImage(bgBmp, new Rectangle(Point.Empty, bmp2.Size));
                    picBackGround.Image = bmp2;
                }
            }
        }

        private void InitializeGraphics()
        {
            this.Size = new Size(850, 450);
            trasparantControl();
            bgPixelCorrection();
        } 
        #endregion

        private void InitializeVariables()
        {
            //animações
            ani = 0; aniInvi = 0;
            //Vida;/respawn
            Hp = lblHpBar.Size.Width;
            lifes = 3;
            respawnPoint = picHero.Location;
            //Pontos
            peR = new Point(picHero.Location.X + picHero.Size.Width - 36, picHero.Location.Y + picHero.Size.Height);
            peL = new Point(picHero.Location.X + 34, picHero.Location.Y + picHero.Size.Height);
            heroCenter = new Point(picHero.Location.X + (picHero.Size.Width / 2), picHero.Location.Y + (picHero.Size.Height / 2));
            //Booleanas
            canShot = true; inMov = false; isRight = true; isLeft = false; isHurt = false;
            //jump
            if (inJump)
                canJump = false;
            else
                canJump = true;
            velImp = Convert.ToInt32(jumpVel / 0.01d);
            //Fundo
            bgBmp = Properties.Resources.Stage1;
            center = new Point(pnlMain.Size.Width / 2, pnlMain.Size.Height / 2);
            //som
            soundBoom = new SoundPlayer(Properties.Resources.BOOMSom);
            soundBoom.Load();
            soundGrito = new SoundPlayer(Properties.Resources.GritoSom);
            soundGrito.Load();
            soundTiro = new SoundPlayer(Properties.Resources.ShotSom);
            soundTiro.Load();
            soundBlik = new SoundPlayer(Properties.Resources.BlikSom);
            soundBlik.Load();
            soundHurt = new SoundPlayer(Properties.Resources.HurtSom);
            soundHurt.Load();
        }

        private void Hurt()
        {
            if (!tmrInvi.Enabled)
            {
                tmrMov.Stop();
                tmrJump.Stop();
                tmrShot.Stop();

                Hp -= rnd.Next(danoLevado_m, danoLevado_M);
                if (Hp <= 0)
                {
                    lblHpBar.Size = new Size(0, lblHpBar.Size.Height);
                    soundBoom.Play();
                    tmrDiiiie.Start();
                }
                else
                {
                    soundHurt.Play();
                    lblHpBar.Size = new Size(Hp, lblHpBar.Size.Height);
                    canShot = false;
                    if (tmrMov.Enabled)
                        tmrMov.Stop();
                    if (isLeft)
                        whereToStop = picHero.Location.X + 100;
                    else if (isRight)
                        whereToStop = picHero.Location.X - 100;

                    tmrHurt.Start();
                } 
            }
        }

        private void Respawn()
        {
            lifes--;
            if (lifes > 0)
            {
                ForJump = -100;
                picHero.Location = respawnPoint;
                tmrJump.Start();

                isRight = true;
                isLeft = false;
                picHero.Image = Properties.Resources.standRight;

                lblLife.Text = lifes.ToString();

                lblHpBar.Size = new Size(145, lblHpBar.Size.Height);
                Hp = lblHpBar.Size.Width;

                tmrInvi.Stop();
                tmrInvi.Start();
            }
            else
            {
                lblLife.Text = lifes.ToString();
                tmrJump.Stop();
                MessageBox.Show("Mórreu meu fí D=", "Gueime Ouvar");
                this.Close();
            }
        }

        //Updates 1000 a cada segundo, teoricamente
        private void Update_Tick(object sender, EventArgs e)
        {
            if (tmrEnemy.Enabled)
            {
                if (bgCollider.Collided(picHero, picEnemy))
                {
                    Hurt();
                }
                if (bgCollider.Collided(picEnemy, Bullet1))
                {
                    tmrBullet1.Stop();
                    Bullet1.Location = new Point(0, 0);
                    canShot = true;
                    Bullet1.Visible = false;
                    DamageEnemy();
                }
            }

            if (bgCollider.Collided(picPorta, picHero))
            {
                tmrUpdate.Stop();
                MessageBox.Show("YAY! Venceuuuu!!\n\n" + @"\0/ \0/ \0/ \0/ \0/", "CABÔÔÔÔÔÔÔÔÔ!!! É TRETA!!!");
                this.Close();
            }

            adjustBg();
        }

        //controla o som e a animação da explosão
        private void tmrDiiiie_Tick(object sender, EventArgs e)
        {
            aniDiiie++;
            isHurt = true;
            canJump = false;
            canShot = false;
            if (aniDiiie == 1)
            {
                picHero.Image = Properties.Resources.explode;
            }
            else if (aniDiiie == 90)
            {
                soundBoom.Stop();
            }
            else if (aniDiiie == 97)
            {
                tmrDiiiie.Stop();
                isHurt = false;
                canJump = true;
                canShot = true;

                Respawn();
                aniDiiie = 0;
            }
        }

        #region "Enemy" 
        //Begin Enemy ==============================================================================================
        //Variaveis do inimigo
        PictureBox picEnemy;
        Point enemyCenter;
        PictureBox picPackage;
        Timer tmrEnemyShot;
        int iniAni, iniAni2;

        //shot related
        int shotVel = 5, shotImp, ForShot;

        private void SpawnEnemy(PictureBox pic)
        {
            Point pt = new Point(pic.Location.X + pic.Size.Width / 2 - Properties.Resources.enemyStand.Size.Width / 2, pic.Location.Y - Properties.Resources.enemyStand.Size.Height);
           
            #region "Instacia os objetos"
            picEnemy = new PictureBox();
            picPackage = new PictureBox();
            tmrEnemyShot = new Timer(this.components);
            //
            // picEnemy
            //
            picEnemy.Name = "picEnemy";
            picEnemy.Image = Properties.Resources.enemyStand;
            picEnemy.Location = pt;
            picEnemy.Size = Properties.Resources.enemyStand.Size;
            picEnemy.TabIndex = 50;
            picEnemy.TabStop = false;
            picEnemy.Paint += new PaintEventHandler(this.pictureBox9_Paint);
            // 
            // tmrEnemyShot
            // 
            tmrEnemyShot.Interval = 1;
            tmrEnemyShot.Tick += new EventHandler(tmrEnemyShot_Tick);
            //
            // Add to the Form
            //
            this.Controls.Add(picEnemy);
            picEnemy.BackColor = Color.Transparent;
            picEnemy.Parent = this.picBackGround;
            //
            // picPackage
            //
            picPackage.Name = "picPackage";
            picPackage.Image = Properties.Resources.Package1;
            picPackage.Size = Properties.Resources.Package1.Size;
            picPackage.TabIndex = 51;
            picPackage.TabStop = false;
            picPackage.Visible = true;
            picPackage.Location = new Point(picEnemy.Location.X + (picEnemy.Size.Width / 2) - (picPackage.Size.Width / 2) + 10, picEnemy.Location.Y - picPackage.Size.Height);
            picPackage.Paint += new PaintEventHandler(this.pictureBox9_Paint);
            picPackage.LocationChanged += new EventHandler(this.picPackage_LocationChanged);
            //
            // Add pacote no form (na verdade no picbox, mas ok)
            //
            this.Controls.Add(picPackage);
            picPackage.BackColor = Color.Transparent;
            picPackage.Parent = this.picBackGround;
            iniAni = 0;
            enemyHp = enemyMaxHp;
            tmrEnemy.Start();
            #endregion

            enemyCenter = new Point(picEnemy.Location.X + picEnemy.Size.Width / 2, picEnemy.Location.Y + picEnemy.Size.Height / 2);
            shotImp = Convert.ToInt32(shotVel / 0.01d);
            timeIdle = rnd.Next(minIdle, maxIdle);
        }

        private void RespawnEnemy(PictureBox pic)
        {
            Point pt = new Point(pic.Location.X + pic.Size.Width / 2 - Properties.Resources.enemyStand.Size.Width / 2, pic.Location.Y - Properties.Resources.enemyStand.Size.Height);
            //reseta :)
            tmrEnemy.Start();
            enemyHp = enemyMaxHp;
            picEnemy.Image = Properties.Resources.enemyStand;
            picEnemy.Visible = true;
            picEnemy.Location = pt;
            picPackage.Location = new Point(picEnemy.Location.X + (picEnemy.Size.Width / 2) - (picPackage.Size.Width / 2) + 10, picEnemy.Location.Y - picPackage.Size.Height);
        }

        private void tmrEnemy_Tick(object sender, EventArgs e)
        {
            iniAni++;

            if (iniAni == 6)
            {
                if (calculaDistancia() < 0)
                {
                    picEnemy.Image = Properties.Resources.enemy1Left;
                }
                else
                {
                    picEnemy.Image = Properties.Resources.enemy1Right;
                }
                ForShot = shotImp;
                picPackage.Visible = true;
            }
            if (iniAni == 10)
            {
                if (calculaDistancia() < 0)
                {
                    picEnemy.Image = Properties.Resources.enemy2Left;
                }
                else
                {
                    picEnemy.Image = Properties.Resources.enemy2Right;
                }
                tmrEnemyShot.Start();
            }
            if (iniAni == 13)
            {
                picEnemy.Image = Properties.Resources.enemyStand;
            }
            if (iniAni == timeIdle)
            {
                iniAni = 0;
                //tmrEnemy.Stop();
            }
        }

        private int calculaDistancia()
        {
            int dist = heroCenter.X - enemyCenter.X;
            
            return dist / 100;
        }

        private void resetaPacote()
        {
            //
            // picPackage
            //
            picPackage.Visible = false;
            picPackage.Location = new Point(picEnemy.Location.X + (picEnemy.Size.Width / 2) - (picPackage.Size.Width / 2) + 10, picEnemy.Location.Y - picPackage.Size.Height);
        }

        private void tmrEnemyShot_Tick(object sender, EventArgs e)
        {
            picPackage.Location = new Point(picPackage.Location.X + calculaDistancia(), picPackage.Location.Y - Convert.ToInt32(ForShot / 100));

            ForShot -= g;

            if (picPackage.Location.Y > platMaxY)
            {
                tmrEnemyShot.Stop();
                resetaPacote();
            }
            iniAni2++;
        }

        private void picPackage_LocationChanged(object sender, EventArgs e)
        {
            if (bgCollider.Collided(picHero, picPackage))
            {
                Hurt();

                tmrEnemyShot.Stop();
                resetaPacote();
            }
        }

        private void DamageEnemy()
        {
            enemyHp -= shotDmg;

            if (enemyHp > 0)
            {
                //Não sei o que colocar aqui...
                soundBlik.Play();
                //Tá agora eu sei
            }
            else
            {
                if (!tmrEnemyShot.Enabled)
                {
                    picPackage.Visible = false;
                }
                picEnemy.Visible = false;
                tmrEnemy.Stop();

                RespawnEnemy(bgCollider.plats[rnd.Next(11)] as PictureBox);
            }
        }
        #endregion //End Enemy =====================================================================================

        //animação do "machucar"
        private void tmrHurt_Tick(object sender, EventArgs e)
        {
            isHurt = true;
            if (isLeft)
            {
                picHero.Image = Properties.Resources.hurtLeft;
                picHero.Location = new Point(picHero.Location.X + movSpeed, picHero.Location.Y);
            }
            else if (isRight)
            {
                picHero.Image = Properties.Resources.hurtRight;
                picHero.Location = new Point(picHero.Location.X - movSpeed, picHero.Location.Y);
            }

            try
            {
                if (!plat[peL.X, peL.Y + 1] && !plat[peR.X, peR.Y + 1])
                {
                    if (!tmrJump.Enabled)
                    {
                        ForJump = -100;
                    }
                    tmrJump.Start();
                }
            }
            catch { }

            if (picHero.Location.X >= whereToStop && isLeft)
            {
                tmrHurt.Stop();
                tmrInvi.Start();
                picHero.Image = Properties.Resources.standLeft;
                isHurt = false;
                canShot = true;
            }
            else if (picHero.Location.X <= whereToStop &&  isRight)
            {
                tmrHurt.Stop();
                tmrInvi.Start();
                picHero.Image = Properties.Resources.standRight;
                isHurt = false;
                canShot = true;
            }
        }

        //Timer da "invencibilidade" temporaria
        private void tmrInvi_Tick(object sender, EventArgs e)
        {
            if (aniInvi % 2 == 0)
            {
                picHero.Visible = true;
            }
            else
            {
                picHero.Visible = false;
            }
            if (aniInvi == 10)
            {
                picHero.Visible = true;
                aniInvi = 0;
                tmrInvi.Stop();
            }
            aniInvi++;
        }

        //Update dos pontos da localização do pichero
        private void picHero_LocationChanged(object sender, EventArgs e)
        {
            peR = new Point(picHero.Location.X + picHero.Size.Width - 36, picHero.Location.Y + picHero.Size.Height);
            peL = new Point(picHero.Location.X + 34, picHero.Location.Y + picHero.Size.Height);
            heroCenter = new Point(picHero.Location.X + (picHero.Size.Width / 2), picHero.Location.Y + (picHero.Size.Height / 2));

            if (picHero.Location.Y > platMaxY)
            {
                soundGrito.Play();
                System.Threading.Thread.Sleep(1000);
                Respawn();
            }
        }

        //Controla as entradas, e inicia o que precisa
        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (!tmrDiiiie.Enabled)
            {
                //se o tmr não tiver ligado e ele não estiver pulando e estiver apertando uma das duas keys
                if (!tmrMov.Enabled && !inJump && (e.KeyCode == Keys.Right | e.KeyCode == Keys.Left))
                {
                    tmrMov.Start();
                }


                if (e.KeyCode == Keys.Right)
                {
                    isLeft = false;
                    isRight = true;
                    if (!isHurt)
                    {
                        picHero.Location = new Point(picHero.Location.X + movSpeed, picHero.Location.Y);

                        //if (peL.X < platMaxX && peL.X > 0 && peR.X < platMaxX && peR.X > 0 &&
                        //    peL.Y < platMaxY && peL.Y > 0 && peR.Y < platMaxY && peR.Y > 0)
                        //{
                        //    if (!plat[peL.X - 1, peL.Y] && !plat[peR.X + 1, peR.Y])
                        //    {
                        //        foreach (PictureBox pct in bgCollider.plats)
                        //        {
                        //            if (bgCollider.Collided(pct, picHero))
                        //            {
                        //                int dist = heroCenter.X - bgCollider.pntOfInterest.X;
                        //                picHero.Location = new Point(picHero.Location.X - dist, picHero.Location.Y);
                        //            }
                        //        }
                        //    }
                        //} 
                    }
                }
                else if (e.KeyCode == Keys.Left)
                {
                    isRight = false;
                    isLeft = true;
                    if (!isHurt)
                    {
                        picHero.Location = new Point(picHero.Location.X - movSpeed, picHero.Location.Y);

                        //if (peL.X < platMaxX && peL.X > 0 && peR.X < platMaxX && peR.X > 0 &&
                        //    peL.Y < platMaxY && peL.Y > 0 && peR.Y < platMaxY && peR.Y > 0)
                        //{
                        //    if (!plat[peL.X - 1, peL.Y] && !plat[peR.X + 1, peR.Y])
                        //    {
                        //        foreach (PictureBox pct in bgCollider.plats)
                        //        {
                        //            if (bgCollider.Collided(pct, picHero))
                        //            {
                        //                int dist = heroCenter.X - bgCollider.pntOfInterest.X;
                        //                picHero.Location = new Point(picHero.Location.X - dist, picHero.Location.Y);
                        //            }
                        //        }
                        //    }
                        //} 
                    }
                }


                if (e.KeyCode == Keys.Space)
                {
                    if (canJump)
                    {
                        ForJump = velImp;
                        tmrJump.Start();
                    }
                }


                if (e.KeyCode == Keys.X)
                {
                    frm = 0;
                    img = picHero.Image;
                    tmrShot.Start();
                }


                if (e.KeyCode == Keys.Z)
                {
                    
                }

                if (peL.X < platMaxX && peL.X > 0 && peR.X < platMaxX && peR.X > 0 &&
                    peL.Y < platMaxY && peL.Y > 0 && peR.Y < platMaxY && peR.Y > 0)
                {
                    if (!plat[peL.X, peL.Y] && !plat[peR.X, peR.Y])
                    {
                        if (!tmrJump.Enabled)
                        {
                            ForJump = -100;
                        }
                        tmrJump.Start();
                    }
                } 
            }
        }

        //Controla as animações de movimento do player
        private void tmrMov_Tick(object sender, EventArgs e)
        {
            inMov = true;
            ani++;
            if (isRight)
            {
                switch (ani)
                {
                    case 1:
                        picHero.Image = Properties.Resources.run1Right;
                        break;
                    case 2:
                        picHero.Image = Properties.Resources.run2Right;
                        ani = 0;
                        break;
                }
            }
            else if (isLeft)
            {
                switch (ani)
                {
                    case 1:
                        picHero.Image = Properties.Resources.run1Left;
                        break;
                    case 2:
                        picHero.Image = Properties.Resources.run2Left;
                        ani = 0;
                        break;
                }
            }
        }

        //reseta las parada loka
        private void Form2_KeyUp(object sender, KeyEventArgs e)
        {
            if (!tmrDiiiie.Enabled)
            {
                tmrMov.Stop();
                ani = 0;
                inMov = false;
                if (!inJump)
                {
                    if (isRight) picHero.Image = Properties.Resources.standRight;
                    else if (isLeft) picHero.Image = Properties.Resources.standLeft;
                } 
            }
        }

        #region "Controla o evento de tiro, não mexa"
        // Tudo isso aqui é bruxaria, magia negra, é POG, programação orientada à gambiarra
        // NÃO MEXER!!

        //Animação do tiro (falta coisa aqui)
        private void tmrShot_Tick(object sender, EventArgs e)
        {
            if (canShot)
            {
                if (frm == 0)
                {
                    soundTiro.Play();
                    if (isLeft)
                    {
                        picHero.Image = Properties.Resources.shotLeft;
                    }
                    if (isRight)
                    {
                        picHero.Image = Properties.Resources.shotRight;
                    }
                    canShot = false;
                    Bullet1.Visible = true;
                    LeftOrRight();
                    rightShot = isRight;
                    tmrBullet1.Start();
                }
                else if (frm == 2)
                {
                    picHero.Image = img;
                    tmrShot.Stop();
                }
                frm++;
            }
            else if (frm == 4)
            {
                picHero.Image = img;
                tmrShot.Stop();
            }
            frm++;
        }

        private void tmrBullet1_Tick(object sender, EventArgs e)
        {
            if (rightShot)
            {
                this.Bullet1.Location = new System.Drawing.Point(Bullet1.Location.X + bulletSpeed, Bullet1.Location.Y);
            }
            else
            {
                this.Bullet1.Location = new System.Drawing.Point(Bullet1.Location.X - bulletSpeed, Bullet1.Location.Y);
            }

            if (Bullet1.Location.X + Bullet1.Size.Width < 0 | Bullet1.Location.X > platMaxX)
            {
                tmrBullet1.Stop();
                canShot = true;
                Bullet1.Visible = false;
            }
        }

        private void LeftOrRight()
        {
            if (isLeft)
            {
                Bullet1.Location = new Point(picHero.Location.X - Bullet1.Size.Width, picHero.Location.Y + 59);
                this.Bullet1.Image = Properties.Resources.bulletLeft;
            }
            else if (isRight)
            {
                Bullet1.Location = new Point(picHero.Location.X + picHero.Size.Width, picHero.Location.Y + 59);
                this.Bullet1.Image = Properties.Resources.bulletRight;
            }
        }

        #endregion

        //controla o jump (quase)
        private void tmrJump_Tick(object sender, EventArgs e)
        {
            tmrMov.Stop();
            inJump = true;
            canJump = false;

            if (!tmrShot.Enabled && !tmrHurt.Enabled)
            {
                if (isLeft)
                {
                    picHero.Image = Properties.Resources.jumpLeft;
                }
                else if (isRight)
                {
                    picHero.Image = Properties.Resources.jumpRight;
                }
            }

            picHero.Location = new Point(picHero.Location.X, picHero.Location.Y - Convert.ToInt32(ForJump / 100));
            ForJump -= g;

            if ((peL.X < platMaxX && peL.Y < platMaxY && peR.X < platMaxX && peR.Y < platMaxY)
                && (peL.X > 0 && peL.Y > 0 && peR.X > 0 && peR.Y > 0))
            {
                if (plat[peL.X, peL.Y] | plat[peR.X, peR.Y])
                {
                    tmrJump.Stop();
                    inJump = false;
                    canJump = true;
                    if (isLeft)
                    {
                        picHero.Image = Properties.Resources.standLeft;
                    }
                    else if (isRight)
                    {
                        picHero.Image = Properties.Resources.standRight;
                    }
                }
            }
        }
    }
}
