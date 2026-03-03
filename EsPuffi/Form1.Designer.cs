namespace EsPuffi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAvvio = new System.Windows.Forms.Panel();
            this.btn_Avvia = new System.Windows.Forms.Button();
            this.pnlP = new System.Windows.Forms.Panel();
            this.pnlG = new System.Windows.Forms.Panel();
            this.pnlC = new System.Windows.Forms.Panel();
            this.pnlPuffo = new System.Windows.Forms.Panel();
            this.lblR = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblPG = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.lblPT = new System.Windows.Forms.Label();
            this.lblTrn = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.panelAvvio.SuspendLayout();
            this.pnlP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAvvio
            // 
            this.panelAvvio.Controls.Add(this.btn_Avvia);
            this.panelAvvio.Location = new System.Drawing.Point(765, 463);
            this.panelAvvio.Name = "panelAvvio";
            this.panelAvvio.Size = new System.Drawing.Size(155, 61);
            this.panelAvvio.TabIndex = 0;
            // 
            // btn_Avvia
            // 
            this.btn_Avvia.Location = new System.Drawing.Point(3, 3);
            this.btn_Avvia.Name = "btn_Avvia";
            this.btn_Avvia.Size = new System.Drawing.Size(151, 55);
            this.btn_Avvia.TabIndex = 0;
            this.btn_Avvia.Text = "Avvia gioco";
            this.btn_Avvia.UseVisualStyleBackColor = true;
            this.btn_Avvia.Click += new System.EventHandler(this.btn_Avvia_Click);
            // 
            // pnlP
            // 
            this.pnlP.Controls.Add(this.pnlG);
            this.pnlP.Controls.Add(this.pnlC);
            this.pnlP.Controls.Add(this.pnlPuffo);
            this.pnlP.Location = new System.Drawing.Point(12, 12);
            this.pnlP.Name = "pnlP";
            this.pnlP.Size = new System.Drawing.Size(736, 540);
            this.pnlP.TabIndex = 1;
            // 
            // pnlG
            // 
            this.pnlG.Location = new System.Drawing.Point(330, 335);
            this.pnlG.Name = "pnlG";
            this.pnlG.Size = new System.Drawing.Size(85, 138);
            this.pnlG.TabIndex = 2;
            // 
            // pnlC
            // 
            this.pnlC.Location = new System.Drawing.Point(344, 118);
            this.pnlC.Name = "pnlC";
            this.pnlC.Size = new System.Drawing.Size(109, 117);
            this.pnlC.TabIndex = 1;
            // 
            // pnlPuffo
            // 
            this.pnlPuffo.Location = new System.Drawing.Point(20, 21);
            this.pnlPuffo.Name = "pnlPuffo";
            this.pnlPuffo.Size = new System.Drawing.Size(93, 87);
            this.pnlPuffo.TabIndex = 0;
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(807, 39);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(104, 16);
            this.lblR.TabIndex = 6;
            this.lblR.Text = "Punteggio Puffo:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(814, 89);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 16);
            this.lblP.TabIndex = 7;
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(827, 248);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(145, 16);
            this.lblR2.TabIndex = 8;
            this.lblR2.Text = "Punteggio Gargamella:";
            // 
            // lblPG
            // 
            this.lblPG.AutoSize = true;
            this.lblPG.Location = new System.Drawing.Point(837, 297);
            this.lblPG.Name = "lblPG";
            this.lblPG.Size = new System.Drawing.Size(0, 16);
            this.lblPG.TabIndex = 9;
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Location = new System.Drawing.Point(793, 384);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(45, 16);
            this.lblT.TabIndex = 10;
            this.lblT.Text = "Turno:";
            // 
            // lblPT
            // 
            this.lblPT.AutoSize = true;
            this.lblPT.Location = new System.Drawing.Point(797, 436);
            this.lblPT.Name = "lblPT";
            this.lblPT.Size = new System.Drawing.Size(0, 16);
            this.lblPT.TabIndex = 11;
            // 
            // lblTrn
            // 
            this.lblTrn.AutoSize = true;
            this.lblTrn.Location = new System.Drawing.Point(1026, 33);
            this.lblTrn.Name = "lblTrn";
            this.lblTrn.Size = new System.Drawing.Size(149, 16);
            this.lblTrn.TabIndex = 12;
            this.lblTrn.Text = "Numero turni disponibili:";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(1026, 66);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(0, 16);
            this.lblTc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 727);
            this.Controls.Add(this.lblTc);
            this.Controls.Add(this.lblTrn);
            this.Controls.Add(this.lblPT);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblPG);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.pnlP);
            this.Controls.Add(this.panelAvvio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panelAvvio.ResumeLayout(false);
            this.pnlP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAvvio;
        private System.Windows.Forms.Button btn_Avvia;
        private System.Windows.Forms.Panel pnlP;
        private System.Windows.Forms.Panel pnlPuffo;
        private System.Windows.Forms.Panel pnlC;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblP;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblPG;
        private System.Windows.Forms.Panel pnlG;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblPT;
        private System.Windows.Forms.Label lblTrn;
        private System.Windows.Forms.Label lblTc;
    }
}

