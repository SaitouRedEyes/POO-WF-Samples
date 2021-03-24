using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_WF1
{
    public partial class Form1 : Form
    {
        private Character c1, c2;
        private Random r;

        public Form1()
        {
            InitializeComponent();
            r = new Random();
        }

        private void btnCreateChar_Click(object sender, EventArgs e)
        {
            btnCreateChar.Enabled = false;
            CreateChar(r.Next(2), ref c1, 200, 100, 150, 250, r.Next(4) + 1);
            lbLevelP1.Text = c1.Level.ToString();
        }

        private void btnCreateChar2_Click(object sender, EventArgs e)
        {
            btnCreateChar2.Enabled = false;
            CreateChar(r.Next(2), ref c2, 500, 100, 150, 250, r.Next(4) + 1);
            lbLevelP2.Text = c2.Level.ToString();
        }

        private void btnAttackP1_Click(object sender, EventArgs e)
        {
            lbDamage.Text = c1.Attack().ToString();
        }

        private void btnAttackP2_Click(object sender, EventArgs e)
        {
            lbDamage.Text = c2.Attack().ToString();
        }

        private void CreateChar(int random, ref Character character, int x, int y, int w, int h, int level)
        {
            switch (random)
            {
                case 0: character = new Character("Mage", Properties.Resources.mage, x, y, w, h, level); break;
                case 1: character = new Character("Warrior", Properties.Resources.warrior, x, y, w, h, level); break;
            }

            this.Controls.Add(character.image);

            if(c1 != null && c2 != null)
            {
                btnAttackP1.Enabled = true;
                btnAttackP2.Enabled = true;
            }
        }
    }
}
