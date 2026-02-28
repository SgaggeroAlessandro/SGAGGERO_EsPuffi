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
            this.pnlC = new System.Windows.Forms.Panel();
            this.pnlPuffo = new System.Windows.Forms.Panel();
            this.btnA = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.lblR = new System.Windows.Forms.Label();
            this.lblP = new System.Windows.Forms.Label();
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
            this.pnlP.Controls.Add(this.pnlC);
            this.pnlP.Controls.Add(this.pnlPuffo);
            this.pnlP.Location = new System.Drawing.Point(12, 12);
            this.pnlP.Name = "pnlP";
            this.pnlP.Size = new System.Drawing.Size(736, 540);
            this.pnlP.TabIndex = 1;
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
            this.pnlPuffo.Size = new System.Drawing.Size(93, 120);
            this.pnlPuffo.TabIndex = 0;
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(754, 237);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(50, 50);
            this.btnA.TabIndex = 2;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(884, 237);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(50, 50);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(821, 181);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(50, 50);
            this.btnW.TabIndex = 4;
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnW_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(821, 293);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(50, 50);
            this.btnS.TabIndex = 5;
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(807, 39);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(71, 16);
            this.lblR.TabIndex = 6;
            this.lblR.Text = "Punteggio:";
            // 
            // lblP
            // 
            this.lblP.AutoSize = true;
            this.lblP.Location = new System.Drawing.Point(814, 89);
            this.lblP.Name = "lblP";
            this.lblP.Size = new System.Drawing.Size(0, 16);
            this.lblP.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 727);
            this.Controls.Add(this.lblP);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.btnS);
            this.Controls.Add(this.btnW);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.pnlP);
            this.Controls.Add(this.panelAvvio);
            this.Name = "Form1";
            this.Text = "Form1";
            
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
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnW;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblP;
    }
}

