using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicPlayer
{
    public static class bgCollider
    {
        public static System.Drawing.Point SupLeft, InfRight, pntOfInterest;
        static musicPlayer.MegaMarte frm = new MegaMarte();
        public static ArrayList plats = new ArrayList();

        public static void InitializeBgCollider()
        {
            //setPoints(picBoxes)
            setPoints(frm.pictureBox1);
            setPoints(frm.pictureBox2);
            setPoints(frm.pictureBox3);
            setPoints(frm.pictureBox4);
            setPoints(frm.pictureBox5);
            setPoints(frm.pictureBox6);
            setPoints(frm.pictureBox7);
            setPoints(frm.pictureBox8);
            setPoints(frm.pictureBox9);
            setPoints(frm.pictureBox10);
            setPoints(frm.pictureBox11);
            setPoints(frm.pictureBox12);
        } 

        public static void ClearPlat()
        {
            plats.Clear();

            for (int height = 0; height < frm.platMaxY; height++)
            {
                for (int width = 0; width < frm.platMaxX; width++)
                {
                    musicPlayer.MegaMarte.plat[width, height] = false;
                }
            }
        }

        private static void setPoints(System.Windows.Forms.PictureBox picb)
        {
            SupLeft = picb.Location;
            InfRight = new System.Drawing.Point(picb.Location.X + picb.Size.Width, picb.Location.Y + picb.Size.Height);
            plats.Add(picb);

            for (int height = 0; height < frm.platMaxY; height++)
            {
                for (int width = 0; width < frm.platMaxX; width++)
                {
                    if ((height >= SupLeft.Y) && (height <= InfRight.Y) && (width >= SupLeft.X) && (width <= InfRight.X))
                    {
                        musicPlayer.MegaMarte.plat[width, height] = true;
                    }
                }
            }
        }
        
        /// <summary>
        /// Testa se um pictureBox Colidiu com um outro
        /// </summary>
        /// <param name="pctAlvo">PictureBox Alvo</param>
        /// <param name="pctProjetil">PictureBox Projétil</param>
        /// <returns>Retorna uma boolean = true se colidir</returns>
        public static bool Collided(System.Windows.Forms.PictureBox pctAlvo, System.Windows.Forms.PictureBox pctProjetil)
        {
            System.Drawing.Point secPoint;
            System.Drawing.Point secPointAlvo;
            
            secPoint = new System.Drawing.Point(pctProjetil.Location.X + pctProjetil.Size.Width, pctProjetil.Location.Y + pctProjetil.Size.Height);
			secPointAlvo = new System.Drawing.Point (pctAlvo.Location.X + pctAlvo.Size.Width, pctAlvo.Location.Y + pctAlvo.Size.Height);

            //Ponto Superior Esquerdo
            if ((pctProjetil.Location.X > pctAlvo.Location.X && pctProjetil.Location.X < secPointAlvo.X) && 
                (pctProjetil.Location.Y > pctAlvo.Location.Y && pctProjetil.Location.Y < secPointAlvo.Y))
            {
                pntOfInterest = new System.Drawing.Point(pctProjetil.Location.X, pctProjetil.Location.Y);
                return true;
            }

            //Ponto Inferior Esquerdo
            if ((pctProjetil.Location.X > pctAlvo.Location.X && pctProjetil.Location.X < secPointAlvo.X) &&
                (secPoint.Y             > pctAlvo.Location.Y && secPoint.Y             < secPointAlvo.Y))
            {
                pntOfInterest = new System.Drawing.Point(pctProjetil.Location.X, secPoint.Y);
                return true;
            }

            //Ponto Inferior Direito
            if ((secPoint.X             > pctAlvo.Location.X && secPoint.X             < secPointAlvo.X) &&
                (secPoint.Y             > pctAlvo.Location.Y && secPoint.Y             < secPointAlvo.Y)) 
            {
                pntOfInterest = new System.Drawing.Point(secPoint.X, secPoint.Y);
                return true;
            }

            //Ponto Superior Direito
            if ((secPoint.X             > pctAlvo.Location.X && secPoint.X             < secPointAlvo.X) &&
                (pctProjetil.Location.Y > pctAlvo.Location.Y && pctProjetil.Location.Y < secPointAlvo.Y))
            {
                pntOfInterest = new System.Drawing.Point(secPoint.X, pctProjetil.Location.Y);
                return true;
            }
            return false;
        }
    }
}
