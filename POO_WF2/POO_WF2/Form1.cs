using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO_WF2
{
    public partial class Form1 : Form
    {
        private Ball ball;

        public Form1()
        {
            InitializeComponent();

            //Turn on double-buffering to eliminate flickering
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.DoubleBuffer, true);

            //Create Event Handler for Timer Tick. Every time timer Ticks run UpdateGame method
            Timer timer = new Timer();
            timer.Interval = 1;
            timer.Start();
            timer.Tick += new EventHandler(UpdateGame);

            //Create Event Handler for Paint run. Every time Windows says it's time to repaint the canvas, run DrawGame method
            Paint += new PaintEventHandler(DrawGame);

            ball = new Ball(this.Width / 2, this.Height / 2);            
        }

        private void UpdateGame(object sender, EventArgs e)
        {            
            ball.Update(this.Width);
            Invalidate();
        }

        private void DrawGame(Object sender, PaintEventArgs PaintNow) 
        { 
            ball.Draw(PaintNow.Graphics); 
        }
    }
}
