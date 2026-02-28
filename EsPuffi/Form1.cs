using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace EsPuffi
{
    public partial class Form1 : Form
    {
        int p = 0;
        int velocità = 10;
        int l = 110;
        int h = 120;
       

        struct Punto
        {
            public int x;
            public int y;

            public Punto(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        public Form1()
        {
            InitializeComponent();
            panelAvvio.Visible = true;
            pnlP.Visible = false;
            btnA.Visible = false;
            btnW.Visible = false; 
            btnD.Visible = false;
            btnS.Visible = false;
            lblR.Visible = false;
            Punto punto = new Punto();
            Random rnd = new Random();
             
            int Xmax = pnlP.Width - l;
            int Ymax = pnlP.Height - h;
            punto.x = rnd.Next(0, Xmax);
            punto.y = rnd.Next(0, Ymax);

            pnlC.Location = new Point(punto.x, punto.y);
        }

        private void btn_Avvia_Click(object sender, EventArgs e)
        {
            panelAvvio.Visible = false;
            pnlP.Visible = true;
            pnlC.Visible = true;
            pnlC.BackColor = Color.Red;
            pnlPuffo.Visible = true;
            pnlPuffo.BackColor = Color.Blue;
            btnA.Visible = true;
            btnW.Visible = true;
            btnS.Visible = true;
            btnD.Visible = true;
            lblR.Visible = true;
            lblP.Text = p.ToString();
        }

        private void btnW_Click(object sender, EventArgs e)
        {
            if(pnlPuffo.Location.Y - velocità < 0)
            {
                pnlPuffo.Location = new Point(pnlPuffo.Location.X, 0);

            }
            else
            {
                pnlPuffo.Location = new Point(pnlPuffo.Location.X, pnlPuffo.Location.Y - velocità);
            }
            casettaraggiunta();

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (pnlPuffo.Location.X - velocità < 0)
            {
                pnlPuffo.Location = new Point(0, pnlPuffo.Location.Y);

            }
            else
            {
                pnlPuffo.Location = new Point(pnlPuffo.Location.X - velocità, pnlPuffo.Location.Y);
            }
            
            casettaraggiunta();
             
        }

        private void btnD_Click(object sender, EventArgs e) //correggere
        {
            int maxX = pnlP.Width - pnlPuffo.Width;
            if (pnlPuffo.Location.X + velocità >= maxX)
            {
                pnlPuffo.Location = new Point(maxX, pnlPuffo.Location.Y);

            }
            else
            {
                pnlPuffo.Location = new Point(pnlPuffo.Location.X + velocità, pnlPuffo.Location.Y);
            }
           
            casettaraggiunta();
           
           
        }

        private void btnS_Click(object sender, EventArgs e) //corregere
        {
            int maxY = pnlP.Height - pnlPuffo.Height;
            if (pnlPuffo.Location.Y + velocità >= maxY)
            {
                pnlPuffo.Location = new Point(pnlPuffo.Location.X, maxY);

            }
            else
            {
                pnlPuffo.Location = new Point(pnlPuffo.Location.X, pnlPuffo.Location.Y + velocità);
            }
            
            casettaraggiunta();
            
        }
        private void casettaraggiunta()

        {
            int puffoDx = pnlPuffo.Location.X + pnlPuffo.Width;  
            int puffoGiu = pnlPuffo.Location.Y + pnlPuffo.Height; 

            
            int ciboDx = pnlC.Location.X + pnlC.Width;   
            int ciboGiu = pnlC.Location.Y + pnlC.Height; 
            if (pnlPuffo.Location.X < ciboDx && puffoDx > pnlC.Location.X && pnlPuffo.Location.Y < ciboGiu && puffoGiu > pnlC.Location.Y)
            {
                p++;
                lblP.Text = p.ToString();
                Random rnd = new Random();
                int Xmax = pnlP.Width - l;
                int Ymax = pnlP.Height - h;
                int x = rnd.Next(0, Xmax);
                int y = rnd.Next(0, Ymax);
                pnlC.Location = new Point(x, y);
            }
            
        }

       
    }
}
