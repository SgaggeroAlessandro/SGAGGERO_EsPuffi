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
        int p = 0; //punteggio
        int velocità = 10; //ogni volta che si clicca il tasto, il puffo si muove di 10 pixel
        int l = 110; //larghezza della casa
        int h = 120;//altezza della casa


        struct Punto
        {
            public int x;//coordinate del punto
            public int y;

            public Punto(int x, int y) //costruttore del punto
            {
                this.x = x;
                this.y = y;
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            panelAvvio.Visible = true;
            pnlP.Visible = false;
            
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
            panelAvvio.Visible = false; //nasconde il pannello di avvio
            pnlP.Visible = true; //rende il campo di gioco visibile
            pnlC.Visible = true; //rende la casa visibile
            pnlC.BackColor = Color.Red; //colore della casa
            pnlPuffo.Visible = true; //rende il puffo visibile
            pnlPuffo.BackColor = Color.Blue; //colora il puffo
           
            lblR.Visible = true; //rende visibile il punteggio
            lblP.Text = p.ToString(); //imposta il testo del punteggio a 0
        }
        private void casettaraggiunta() //funzione che controlla se c'è una collisione tra il puffo e la casa

        {
                int puffoD = pnlPuffo.Location.X + pnlPuffo.Width; //bordo destro del puffo, è la somma del bordo sinistro con la larghezza del puffo
                int puffoG = pnlPuffo.Location.Y + pnlPuffo.Height;//bordo basso del puffo, è la somma del bordo superiore con l'altezza del puffo


            int casaD= pnlC.Location.X + pnlC.Width; //bordo destro della casa, è la somma del bordo sinistro con la larghezza della casa
            int casaG = pnlC.Location.Y + pnlC.Height; //bordo basso della casa, è la somma del bordo superiore con l'altezza della casa
            if (pnlPuffo.Location.X < casaD && puffoD > pnlC.Location.X && pnlPuffo.Location.Y < casaG && puffoG > pnlC.Location.Y) //controlla se c'è una collisione tra un bordo del puffo e della casa, entra nell'if solo se tutte e 4 le condizioni sono vere
            {
                p++; //aumenta il punteggio 
                lblP.Text = p.ToString(); //stampa il punteggio
                Random rnd = new Random(); //crea un generatore di numeri 
                int Xmax = pnlP.Width - l; //calcola i limiti in cui posizionare la casa
                int Ymax = pnlP.Height - h;
                int x = rnd.Next(0, Xmax); //genera un numero randomico
                int y = rnd.Next(0, Ymax);
                pnlC.Location = new Point(x, y); //aggiorna la posizione della casa
            }

        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.I)
            {
                if (pnlPuffo.Location.Y - velocità < 0)
                {
                    pnlPuffo.Location = new Point(pnlPuffo.Location.X, 0);

                }
                else
                {
                    pnlPuffo.Location = new Point(pnlPuffo.Location.X, pnlPuffo.Location.Y - velocità);
                }
                casettaraggiunta();
            }
            else if (e.KeyCode == Keys.A || e.KeyCode == Keys.J)
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
            else if (e.KeyCode == Keys.S || e.KeyCode == Keys.K)
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
            else if (e.KeyCode == Keys.D || e.KeyCode == Keys.L)
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

        }
    }
}