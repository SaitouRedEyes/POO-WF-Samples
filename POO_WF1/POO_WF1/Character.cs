using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_WF1
{
    class Character
    {
        public PictureBox image = new PictureBox();
        private string myClass;
        private int lvl;

        public Character(string newClass, Bitmap newImage, int x, int y, int w, int h, int newLevel)
        {
            myClass = newClass;

            image.BackgroundImage = newImage;
            image.BackgroundImageLayout = ImageLayout.Stretch;
            image.Location = new Point(x, y);
            image.Size = new Size(w, h);
            image.BackColor = Color.Transparent;            

            lvl = newLevel;
        }

        public int Level
        {
            get { return lvl; }
        }

        public int Attack()
        {            
            if(myClass.Equals("Warrior"))
            {
                return lvl * 2;
            }
            else if (myClass.Equals("Mage"))
            {
                return lvl * 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
