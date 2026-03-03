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
            int p = 0; //punteggio puffo
            int pg = 0; //punteggio Gargamella
            int velocità = 10; //ogni volta che si clicca il tasto, il puffo si muove di 10 pixel
            int l = 110; //larghezza della casa
            int h = 120;//altezza della casa
        
            int lp = 85;
            int hp = 138;

            int nm = 20; //numero di mosse che sia il puffo che Gargamella possono fare 
            int nmg = 20;

            bool p1 = true; //variabile che indica se è il turno del puffo
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
                this.KeyPreview = true;//this è il riferimento dell'oggetto stesso, è il form stesso
                panelAvvio.Visible = true;
                pnlP.Visible = false;
                pnlG.Visible = false;
                lblR.Visible = false;
                lblR2.Visible = false;
                lblTrn.Visible = false;
                lblT.Visible = false;
                pnlPuffo.Visible = true;
                Punto punto = new Punto();
                Random rnd = new Random();

                int Xmax = pnlP.Width - l;
                int Ymax = pnlP.Height - h;
                punto.x = rnd.Next(0, Xmax);
                punto.y = rnd.Next(0, Ymax);

                pnlPuffo.Location = new Point(punto.x, punto.y);

            alberi();
            }

            private void btn_Avvia_Click(object sender, EventArgs e)
            {
                panelAvvio.Visible = false; //nasconde il pannello di avvio
                pnlP.Visible = true; //rende il campo di gioco visibile
                pnlC.Visible = true; //rende la casa visibile
                pnlC.BackColor = Color.Red; //colore della casa
                pnlG.Visible = true; //rende il puffo visibile
                pnlPuffo.BackColor = Color.Blue; //colora il puffo
                pnlPuffo.Visible = true;
                pnlG.BackColor = Color.Black; //colore del Gargamella
                lblR.Visible = true; //rende visibile il punteggio
                lblP.Text = p.ToString(); //imposta il testo del punteggio a 0
                lblTrn.Visible = true; //rende visibile il turno
                lblR2.Visible = true; //rende visibile il punteggio
                lblPG.Text = p.ToString(); //imposta il testo del punteggio a 0
                lblT.Visible = true; //rende visibile il timer
                pnlPuffo.Visible = true;

                lblTc.Text = nm.ToString(); //imposta il testo del timer a 20
            }
            private void casettaraggiunta() //funzione che controlla se c'è una collisione tra il puffo e la casa

            {
                int puffoD = pnlPuffo.Location.X + pnlPuffo.Width; //bordo destro del puffo, è la somma del bordo sinistro con la larghezza del puffo
                int puffoG = pnlPuffo.Location.Y + pnlPuffo.Height;//bordo basso del puffo, è la somma del bordo superiore con l'altezza del puffo


                int casaD = pnlC.Location.X + pnlC.Width; //bordo destro della casa, è la somma del bordo sinistro con la larghezza della casa
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
                if (p1 == true && nm > 0)
                {
                    lblPT.Text = "Puffo";
                    if (e.KeyCode == Keys.W)
                    {
                        if (pnlPuffo.Location.Y - velocità < 0)
                        {
                            pnlPuffo.Location = new Point(pnlPuffo.Location.X, 0);

                        }
                        else
                        {
                            pnlPuffo.Location = new Point(pnlPuffo.Location.X, pnlPuffo.Location.Y - velocità);
                        }
                        nm--;
                        casettaraggiunta();
                    }
                    else if (e.KeyCode == Keys.A)
                    {
                        if (pnlPuffo.Location.X - velocità < 0)
                        {
                            pnlPuffo.Location = new Point(0, pnlPuffo.Location.Y);

                        }
                        else
                        {
                            pnlPuffo.Location = new Point(pnlPuffo.Location.X - velocità, pnlPuffo.Location.Y);
                        }
                        nm--;
                        casettaraggiunta();
                    }
                    else if (e.KeyCode == Keys.S)
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
                        nm--;
                        casettaraggiunta();
                    }
                    else if (e.KeyCode == Keys.D)
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
                        nm--;
                        casettaraggiunta();
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
                        if (pnlG.Location.Y - velocità < 0)
                        {
                            pnlG.Location = new Point(pnlG.Location.X, 0);

                        }
                        else
                        {
                            pnlG.Location = new Point(pnlG.Location.X, pnlG.Location.Y - velocità);
                        }
                        nmg--;
                        pufforaggiunto();
                    }
                    else if (e.KeyCode == Keys.J)
                    {
                        if (pnlG.Location.X - velocità < 0)
                        {
                            pnlG.Location = new Point(0, pnlG.Location.Y);

                        }
                        else
                        {
                            pnlG.Location = new Point(pnlG.Location.X - velocità, pnlG.Location.Y);
                        }
                        nmg--;
                        pufforaggiunto();
                    }
                    else if (e.KeyCode == Keys.K)
                    {
                        int maxY = pnlP.Height - pnlG.Height;
                        if (pnlG.Location.Y + velocità >= maxY)
                        {
                            pnlG.Location = new Point(pnlG.Location.X, maxY);

                        }
                        else
                        {
                            pnlG.Location = new Point(pnlG.Location.X, pnlG.Location.Y + velocità);
                        }
                        nmg--;
                        pufforaggiunto();
                    }
                    else if (e.KeyCode == Keys.L)
                    {
                        int maxX = pnlP.Width - pnlG.Width;
                        if (pnlG.Location.X + velocità >= maxX)
                        {
                            pnlG.Location = new Point(maxX, pnlG.Location.Y);

                        }
                        else
                        {
                            pnlG.Location = new Point(pnlG.Location.X + velocità, pnlG.Location.Y);
                        }
                        nmg--;
                        pufforaggiunto();
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
                int GargaD = pnlG.Location.X + pnlG.Width; //bordo destro del puffo, è la somma del bordo sinistro con la larghezza del puffo
                int GargaG = pnlG.Location.Y + pnlG.Height;//bordo basso del puffo, è la somma del bordo superiore con l'altezza del puffo


                int puffoD = pnlPuffo.Location.X + pnlPuffo.Width; //bordo destro della casa, è la somma del bordo sinistro con la larghezza della casa
                int puffoG = pnlPuffo.Location.Y + pnlPuffo.Height; //bordo basso della casa, è la somma del bordo superiore con l'altezza della casa
                if (pnlG.Location.X < puffoD && GargaD > pnlPuffo.Location.X && pnlG.Location.Y < puffoG && GargaG > pnlPuffo.Location.Y) //controlla se c'è una collisione tra un bordo del puffo e della casa, entra nell'if solo se tutte e 4 le condizioni sono vere
                {
                    p--;
                    pg++;
                    lblP.Text = p.ToString(); //stampa il punteggio
                    lblPG.Text = pg.ToString();
                    Random rnd = new Random(); //crea un generatore di numeri 
                    int Xmax = pnlP.Width - lp; //calcola i limiti in cui posizionare la casa
                    int Ymax = pnlP.Height - hp;
                    int x = rnd.Next(0, Xmax); //genera un numero randomico
                    int y = rnd.Next(0, Ymax);
                    pnlPuffo.Location = new Point(x, y); //aggiorna la posizione della casa
                }
            }
        private void alberi()
        {
            Random rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                Panel pnlA = new Panel();
                pnlA.Size = new Size(50, 50);
                pnlA.BackColor = Color.Green; // Aggiungi un colore per vederli!

                int maxX = pnlP.Width - pnlA.Width;
                int maxY = pnlP.Height - pnlA.Height;

                // 2. Genera X e Y separatamente (e gestisci il caso in cui pnlP sia piccolo)
                int posX = rnd.Next(0, Math.Max(1, maxX));
                int posY = rnd.Next(0, Math.Max(1, maxY));

                pnlA.Location = new Point(posX, posY);

                // 3. FONDAMENTALE: Aggiungi il pannello al contenitore
                pnlP.Controls.Add(pnlA);
            }
        }
        }
    }