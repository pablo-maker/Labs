using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs paintEvnt)
        {
            // Get the graphics object 
            Graphics gfx = paintEvnt.Graphics;
            // Create a new pen that we shall use for drawing the line 
            Pen myPen = new Pen(Color.Black);

            // Loop until the coordinates reach 250 (the lower right corner of the form) 
            for (int i = 0; i < 250; i = i + 50)
            {
                // Draw a 50x50 pixels rectangle 
                gfx.DrawRectangle(myPen, i, i, 50, 50);
            }
        }



    }
}
