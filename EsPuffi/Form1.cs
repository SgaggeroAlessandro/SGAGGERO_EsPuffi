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
        int pg = 0; 
        int velocità = 10; 
        int l = 110; 
        int h = 120;

        int lp = 95;
        int hp = 98;

        int nm = 20; 
        int nmg = 20;

        bool p1 = true; 

        Panel[] alberiArray = new Panel[10];
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
            this.KeyPreview = true; //this è il riferimento dell'oggetto stesso, è il form stesso, keypreview dà la priorità di lettura dell'input da tastiera al form1, altrimenti non si potrebbero fare tutti i controlli successivi per lo spostamento
            panelAvvio.Visible = true;
            pnlP.Visible = false;
            pictureBoxGarga.Visible = false;
            lblR.Visible = false;
            lblR2.Visible = false;
            lblTrn.Visible = false;
            lblT.Visible = false;
            pictureBoxPuffo.Visible = true;
            Punto punto = new Punto();
            Random rnd = new Random();

            int Xmax = pnlP.Width - lp;
            int Ymax = pnlP.Height - hp;
            punto.x = rnd.Next(0, Xmax);
            punto.y = rnd.Next(0, Ymax);

            pictureBoxPuffo.Location = new Point(punto.x, punto.y);


        }

        private void btn_Avvia_Click(object sender, EventArgs e)
        {
            panelAvvio.Visible = false; 
            pnlP.Visible = true; 
            pictureBoxCasa.Visible = true; 
            pictureBoxCasa.BackgroundImage = Image.FromFile(@"C:\Users\alesg\OneDrive\Desktop\casa.jpg");
            pictureBoxCasa.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGarga.Visible = true; 
            pictureBoxPuffo.BackgroundImage = Image.FromFile(@"C:\Users\alesg\OneDrive\Desktop\puffo.png");
            pictureBoxGarga.BackgroundImage = Image.FromFile(@"C:\Users\alesg\OneDrive\Desktop\garga.jpg");
            pictureBoxPuffo.Visible = true;
            pictureBoxPuffo.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxGarga.BackgroundImageLayout = ImageLayout.Stretch;
            lblR.Visible = true; 
            lblP.Text = p.ToString(); 
            lblTrn.Visible = true; 
            lblR2.Visible = true; 
            lblPG.Text = pg.ToString(); 
            lblT.Visible = true; 


            lblTc.Text = nm.ToString();

            alberi();
        }
        private void casettaraggiunta() 

        {
            int puffoD = pictureBoxPuffo.Location.X + pictureBoxPuffo.Width; 
            int puffoG = pictureBoxPuffo.Location.Y + pictureBoxPuffo.Height;


            int casaD = pictureBoxCasa.Location.X + pictureBoxCasa.Width; 
            int casaG = pictureBoxCasa.Location.Y + pictureBoxCasa.Height; 
            if (pictureBoxPuffo.Location.X < casaD && puffoD > pictureBoxCasa.Location.X && pictureBoxPuffo.Location.Y < casaG && puffoG > pictureBoxCasa.Location.Y)
//pictureBoxPuffo.Location.X < casaD: il lato sinistro del puffo è a sinistra del lato destro della casa
//puffoD > pictureBoxCasa.Location.X: il lato destro del puffo è a destra del lato sinistro della casa
//pictureBoxPuffo.Location.Y < casaG:  il lato alto del puffo è sopra il lato basso della casa
//puffoG > pictureBoxCasa.Location.Y: il lato basso del puffo è sotto il lato alto della casa
            {
                p++; 
                lblP.Text = p.ToString(); 
                Random rnd = new Random(); 
                int Xmax = pnlP.Width - l; 
                int Ymax = pnlP.Height - h;
                int x = rnd.Next(0, Xmax); 
                int y = rnd.Next(0, Ymax);
                pictureBoxCasa.Location = new Point(x, y); 

                for (int i = 0; i < 10; i++)
                {
                    int maxX = pnlP.Width - alberiArray[i].Width;
                    int maxY = pnlP.Height - alberiArray[i].Height;
                    int posX = rnd.Next(0, maxX);
                    int posY = rnd.Next(0,  maxY);
                    alberiArray[i].Location = new Point(posX, posY);
                }

            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (p1 == true && nm > 0)
            {
                lblPT.Text = "Puffo";
                if (e.KeyCode == Keys.W)
                {
                    if (pictureBoxPuffo.Location.Y - velocità < 0)
                    {
                        pictureBoxPuffo.Location = new Point(pictureBoxPuffo.Location.X, 0);

                    }
                    else
                    {
                        pictureBoxPuffo.Location = new Point(pictureBoxPuffo.Location.X, pictureBoxPuffo.Location.Y - velocità);
                    }
                    nm--;
                    casettaraggiunta();
                    toccaAlbero();
                }
                else if (e.KeyCode == Keys.A)
                {
                    if (pictureBoxPuffo.Location.X - velocità < 0)
                    {
                        pictureBoxPuffo.Location = new Point(0, pictureBoxPuffo.Location.Y);

                    }
                    else
                    {
                        pictureBoxPuffo.Location = new Point(pictureBoxPuffo.Location.X - velocità, pictureBoxPuffo.Location.Y);
                    }
                    nm--;
                    casettaraggiunta();
                    toccaAlbero();
                }
                else if (e.KeyCode == Keys.S)
                {
                    int maxY = pnlP.Height - pictureBoxPuffo.Height;
                    if (pictureBoxPuffo.Location.Y + velocità >= maxY)
                    {
                        pictureBoxPuffo.Location = new Point(pictureBoxPuffo.Location.X, maxY);

                    }
                    else
                    {
                        pictureBoxPuffo.Location = new Point(pictureBoxPuffo.Location.X, pictureBoxPuffo.Location.Y + velocità);
                    }
                    nm--;
                    casettaraggiunta();
                    toccaAlbero();
                }
                else if (e.KeyCode == Keys.D)
                {
                    int maxX = pnlP.Width - pictureBoxPuffo.Width;
                    if (pictureBoxPuffo.Location.X + velocità >= maxX)
                    {
                        pictureBoxPuffo.Location = new Point(maxX, pictureBoxPuffo.Location.Y);

                    }
                    else
                    {
                        pictureBoxPuffo.Location = new Point(pictureBoxPuffo.Location.X + velocità, pictureBoxPuffo.Location.Y);
                    }
                    nm--;
                    casettaraggiunta();
                    toccaAlbero();
                }
                lblTc.Text = nm.ToString();


                if (nm == 0)
                {
                    p1 = false;
                    nmg = 20;
                }

            }
            else if (p1 == false && nmg > 0)
            {
                lblPT.Text = "Gargamella";
                if (e.KeyCode == Keys.I)
                {
                    if (pictureBoxGarga.Location.Y - velocità < 0)
                    {
                        pictureBoxGarga.Location = new Point(pictureBoxGarga.Location.X, 0);

                    }
                    else
                    {
                        pictureBoxGarga.Location = new Point(pictureBoxGarga.Location.X, pictureBoxGarga.Location.Y - velocità);
                    }
                    nmg--;
                    pufforaggiunto();
                    toccaAlbero();
                }
                else if (e.KeyCode == Keys.J)
                {
                    if (pictureBoxGarga.Location.X - velocità < 0)
                    {
                        pictureBoxGarga.Location = new Point(0, pictureBoxGarga.Location.Y);

                    }
                    else
                    {
                        pictureBoxGarga.Location = new Point(pictureBoxGarga.Location.X - velocità, pictureBoxGarga.Location.Y);
                    }
                    nmg--;
                    pufforaggiunto();
                    toccaAlbero();
                }
                else if (e.KeyCode == Keys.K)
                {
                    int maxY = pnlP.Height - pictureBoxGarga.Height;
                    if (pictureBoxGarga.Location.Y + velocità >= maxY)
                    {
                        pictureBoxGarga.Location = new Point(pictureBoxGarga.Location.X, maxY);

                    }
                    else
                    {
                        pictureBoxGarga.Location = new Point(pictureBoxGarga.Location.X, pictureBoxGarga.Location.Y + velocità);
                    }
                    nmg--;
                    pufforaggiunto();
                    toccaAlbero();
                }
                else if (e.KeyCode == Keys.L)
                {
                    int maxX = pnlP.Width - pictureBoxGarga.Width;
                    if (pictureBoxGarga.Location.X + velocità >= maxX)
                    {
                        pictureBoxGarga.Location = new Point(maxX, pictureBoxGarga.Location.Y);

                    }
                    else
                    {
                        pictureBoxGarga.Location = new Point(pictureBoxGarga.Location.X + velocità, pictureBoxGarga.Location.Y);
                    }
                    nmg--;
                    pufforaggiunto();
                    toccaAlbero();
                }
                lblTc.Text = nmg.ToString();


                if (nmg == 0)
                {
                    nm = 20;
                    p1 = true;
                }

            }
        }

        private void pufforaggiunto()
        {
            int GargaD = pictureBoxGarga.Location.X + pictureBoxGarga.Width; 
            int GargaG = pictureBoxGarga.Location.Y + pictureBoxGarga.Height;


            int puffoD = pictureBoxPuffo.Location.X + pictureBoxPuffo.Width; 
            int puffoG = pictureBoxPuffo.Location.Y + pictureBoxPuffo.Height;
            if (pictureBoxGarga.Location.X < puffoD && GargaD > pictureBoxPuffo.Location.X && pictureBoxGarga.Location.Y < puffoG && GargaG > pictureBoxPuffo.Location.Y) 
            {
                if (p == 0)
                {
                    p = 0;
                }
                else
                {
                    p--;
                }

                pg++;
                lblP.Text = p.ToString(); 
                lblPG.Text = pg.ToString();
                Random rnd = new Random(); 
                int Xmax = pnlP.Width - lp; 
                int Ymax = pnlP.Height - hp;
                int x = rnd.Next(0, Xmax); 
                int y = rnd.Next(0, Ymax);
                pictureBoxPuffo.Location = new Point(x, y); 
            }
        }
        private void alberi()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                alberiArray[i] = new Panel();
                alberiArray[i].Size = new Size(50, 50);
                alberiArray[i].BackgroundImage = Image.FromFile(@"C:\Users\alesg\OneDrive\Desktop\albero.jpg");
                alberiArray[i].BackgroundImageLayout = ImageLayout.Stretch;

                int maxX = pnlP.Width - alberiArray[i].Width;
                int maxY = pnlP.Height - alberiArray[i].Height;

                int posX = rnd.Next(0, maxX);
                int posY = rnd.Next(0, maxY);

                alberiArray[i].Location = new Point(posX, posY);

                pnlP.Controls.Add(alberiArray[i]);

            }
        }

        private void toccaAlbero()
        {
            if (p1 == true)
            {

                for (int i = 0; i < 10; i++)
                {
                    int puffoD = pictureBoxPuffo.Location.X + pictureBoxPuffo.Width;
                    int puffoG = pictureBoxPuffo.Location.Y + pictureBoxPuffo.Height;



                    int alberoD = alberiArray[i].Location.X + alberiArray[i].Width;
                    int alberoG = alberiArray[i].Location.Y + alberiArray[i].Height;
                    if (pictureBoxPuffo.Location.X < alberoD && puffoD > alberiArray[i].Location.X && pictureBoxPuffo.Location.Y < alberoG && puffoG > alberiArray[i].Location.Y)
                    {
                        p1 = false;
                        nmg = 20;
                        lblTc.Text = nmg.ToString();
                        break;
                    }

                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    int GargaD = pictureBoxGarga.Location.X + pictureBoxGarga.Width;
                    int GargaG = pictureBoxGarga.Location.Y + pictureBoxGarga.Height;



                    int alberoD = alberiArray[i].Location.X + alberiArray[i].Width;
                    int alberoG = alberiArray[i].Location.Y + alberiArray[i].Height;

                    if (pictureBoxGarga.Location.X < alberoD && GargaD > alberiArray[i].Location.X && pictureBoxGarga.Location.Y < alberoG && GargaG > alberiArray[i].Location.Y)
                    {
                        p1 = true;
                        nm = 20;
                        lblTc.Text = nm.ToString();
                        break;
                    }
                }
            }
        }

        
    }
}
