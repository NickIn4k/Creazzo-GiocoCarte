namespace Creazzo_GiocoCarte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DGV_TABELLONE = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LBL_USERNAME1 = new System.Windows.Forms.Label();
            this.BTN_INSERISCI = new System.Windows.Forms.Button();
            this.LBL_USERNAME = new System.Windows.Forms.Label();
            this.PIC_USER = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BTN_INSERISCI2 = new System.Windows.Forms.Button();
            this.LBL_USERNAME2 = new System.Windows.Forms.Label();
            this.PIC_USER2 = new System.Windows.Forms.PictureBox();
            this.PIC_MAZZO1 = new System.Windows.Forms.PictureBox();
            this.PIC_MAZZO2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_INIZIA = new System.Windows.Forms.Button();
            this.PNL_BATTAGLIA = new System.Windows.Forms.Panel();
            this.PRG_PV_DIFENSORE = new System.Windows.Forms.ProgressBar();
            this.PRG_PV_ATTACCANTE = new System.Windows.Forms.ProgressBar();
            this.BTN_CHIUDI = new System.Windows.Forms.Button();
            this.PIC_DIFENSORE = new System.Windows.Forms.PictureBox();
            this.PIC_ANIMAZIONE = new System.Windows.Forms.PictureBox();
            this.PIC_ATTACCANTE = new System.Windows.Forms.PictureBox();
            this.LBL_DANNO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TABELLONE)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_USER)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_USER2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MAZZO1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MAZZO2)).BeginInit();
            this.PNL_BATTAGLIA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_DIFENSORE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ANIMAZIONE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ATTACCANTE)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_TABELLONE
            // 
            this.DGV_TABELLONE.AllowUserToAddRows = false;
            this.DGV_TABELLONE.AllowUserToDeleteRows = false;
            this.DGV_TABELLONE.AllowUserToResizeColumns = false;
            this.DGV_TABELLONE.AllowUserToResizeRows = false;
            this.DGV_TABELLONE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_TABELLONE.ColumnHeadersVisible = false;
            this.DGV_TABELLONE.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.DGV_TABELLONE.Location = new System.Drawing.Point(306, 57);
            this.DGV_TABELLONE.MultiSelect = false;
            this.DGV_TABELLONE.Name = "DGV_TABELLONE";
            this.DGV_TABELLONE.RowHeadersVisible = false;
            this.DGV_TABELLONE.Size = new System.Drawing.Size(753, 569);
            this.DGV_TABELLONE.TabIndex = 0;
            this.DGV_TABELLONE.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_TABELLONE_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.LBL_USERNAME1);
            this.panel1.Controls.Add(this.BTN_INSERISCI);
            this.panel1.Controls.Add(this.LBL_USERNAME);
            this.panel1.Controls.Add(this.PIC_USER);
            this.panel1.Location = new System.Drawing.Point(28, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 395);
            this.panel1.TabIndex = 1;
            // 
            // LBL_USERNAME1
            // 
            this.LBL_USERNAME1.AutoSize = true;
            this.LBL_USERNAME1.BackColor = System.Drawing.Color.DarkMagenta;
            this.LBL_USERNAME1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_USERNAME1.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_USERNAME1.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_USERNAME1.Location = new System.Drawing.Point(79, 253);
            this.LBL_USERNAME1.Name = "LBL_USERNAME1";
            this.LBL_USERNAME1.Size = new System.Drawing.Size(98, 34);
            this.LBL_USERNAME1.TabIndex = 3;
            this.LBL_USERNAME1.Text = "Username";
            // 
            // BTN_INSERISCI
            // 
            this.BTN_INSERISCI.BackColor = System.Drawing.Color.Indigo;
            this.BTN_INSERISCI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_INSERISCI.Font = new System.Drawing.Font("Niagara Engraved", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERISCI.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_INSERISCI.Location = new System.Drawing.Point(35, 334);
            this.BTN_INSERISCI.Name = "BTN_INSERISCI";
            this.BTN_INSERISCI.Size = new System.Drawing.Size(184, 32);
            this.BTN_INSERISCI.TabIndex = 3;
            this.BTN_INSERISCI.Text = "Player 1";
            this.BTN_INSERISCI.UseVisualStyleBackColor = false;
            this.BTN_INSERISCI.Click += new System.EventHandler(this.BTN_INSERISCI_Click);
            // 
            // LBL_USERNAME
            // 
            this.LBL_USERNAME.AutoSize = true;
            this.LBL_USERNAME.Location = new System.Drawing.Point(97, 270);
            this.LBL_USERNAME.Name = "LBL_USERNAME";
            this.LBL_USERNAME.Size = new System.Drawing.Size(0, 13);
            this.LBL_USERNAME.TabIndex = 1;
            // 
            // PIC_USER
            // 
            this.PIC_USER.BackColor = System.Drawing.Color.Transparent;
            this.PIC_USER.Location = new System.Drawing.Point(35, 19);
            this.PIC_USER.Name = "PIC_USER";
            this.PIC_USER.Size = new System.Drawing.Size(184, 191);
            this.PIC_USER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_USER.TabIndex = 0;
            this.PIC_USER.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.BTN_INSERISCI2);
            this.panel2.Controls.Add(this.LBL_USERNAME2);
            this.panel2.Controls.Add(this.PIC_USER2);
            this.panel2.Location = new System.Drawing.Point(1100, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 395);
            this.panel2.TabIndex = 3;
            // 
            // BTN_INSERISCI2
            // 
            this.BTN_INSERISCI2.BackColor = System.Drawing.Color.Indigo;
            this.BTN_INSERISCI2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_INSERISCI2.Font = new System.Drawing.Font("Niagara Engraved", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERISCI2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BTN_INSERISCI2.Location = new System.Drawing.Point(35, 334);
            this.BTN_INSERISCI2.Name = "BTN_INSERISCI2";
            this.BTN_INSERISCI2.Size = new System.Drawing.Size(184, 32);
            this.BTN_INSERISCI2.TabIndex = 2;
            this.BTN_INSERISCI2.Text = "Player 2";
            this.BTN_INSERISCI2.UseVisualStyleBackColor = false;
            this.BTN_INSERISCI2.Click += new System.EventHandler(this.BTN_INSERISCI2_Click);
            // 
            // LBL_USERNAME2
            // 
            this.LBL_USERNAME2.AutoSize = true;
            this.LBL_USERNAME2.BackColor = System.Drawing.Color.DarkMagenta;
            this.LBL_USERNAME2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LBL_USERNAME2.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_USERNAME2.ForeColor = System.Drawing.SystemColors.Control;
            this.LBL_USERNAME2.Location = new System.Drawing.Point(76, 253);
            this.LBL_USERNAME2.Name = "LBL_USERNAME2";
            this.LBL_USERNAME2.Size = new System.Drawing.Size(98, 34);
            this.LBL_USERNAME2.TabIndex = 1;
            this.LBL_USERNAME2.Text = "Username";
            // 
            // PIC_USER2
            // 
            this.PIC_USER2.BackColor = System.Drawing.Color.Transparent;
            this.PIC_USER2.Location = new System.Drawing.Point(35, 19);
            this.PIC_USER2.Name = "PIC_USER2";
            this.PIC_USER2.Size = new System.Drawing.Size(184, 191);
            this.PIC_USER2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_USER2.TabIndex = 0;
            this.PIC_USER2.TabStop = false;
            // 
            // PIC_MAZZO1
            // 
            this.PIC_MAZZO1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PIC_MAZZO1.BackgroundImage")));
            this.PIC_MAZZO1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIC_MAZZO1.Location = new System.Drawing.Point(28, 496);
            this.PIC_MAZZO1.Name = "PIC_MAZZO1";
            this.PIC_MAZZO1.Size = new System.Drawing.Size(250, 151);
            this.PIC_MAZZO1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_MAZZO1.TabIndex = 4;
            this.PIC_MAZZO1.TabStop = false;
            this.PIC_MAZZO1.Click += new System.EventHandler(this.PIC_MAZZO1_Click);
            // 
            // PIC_MAZZO2
            // 
            this.PIC_MAZZO2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PIC_MAZZO2.BackgroundImage")));
            this.PIC_MAZZO2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIC_MAZZO2.Location = new System.Drawing.Point(1100, 496);
            this.PIC_MAZZO2.Name = "PIC_MAZZO2";
            this.PIC_MAZZO2.Size = new System.Drawing.Size(250, 151);
            this.PIC_MAZZO2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_MAZZO2.TabIndex = 5;
            this.PIC_MAZZO2.TabStop = false;
            this.PIC_MAZZO2.Click += new System.EventHandler(this.PIC_MAZZO2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(122, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mazzo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Niagara Engraved", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1190, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 34);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mazzo";
            // 
            // BTN_INIZIA
            // 
            this.BTN_INIZIA.BackColor = System.Drawing.Color.MediumOrchid;
            this.BTN_INIZIA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_INIZIA.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INIZIA.Location = new System.Drawing.Point(518, 12);
            this.BTN_INIZIA.Name = "BTN_INIZIA";
            this.BTN_INIZIA.Size = new System.Drawing.Size(335, 30);
            this.BTN_INIZIA.TabIndex = 7;
            this.BTN_INIZIA.Text = "INIZIA LA PARTITA";
            this.BTN_INIZIA.UseVisualStyleBackColor = false;
            this.BTN_INIZIA.Click += new System.EventHandler(this.BTN_INIZIA_Click);
            // 
            // PNL_BATTAGLIA
            // 
            this.PNL_BATTAGLIA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PNL_BATTAGLIA.BackgroundImage")));
            this.PNL_BATTAGLIA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PNL_BATTAGLIA.Controls.Add(this.LBL_DANNO);
            this.PNL_BATTAGLIA.Controls.Add(this.PRG_PV_DIFENSORE);
            this.PNL_BATTAGLIA.Controls.Add(this.PRG_PV_ATTACCANTE);
            this.PNL_BATTAGLIA.Controls.Add(this.BTN_CHIUDI);
            this.PNL_BATTAGLIA.Controls.Add(this.PIC_DIFENSORE);
            this.PNL_BATTAGLIA.Controls.Add(this.PIC_ANIMAZIONE);
            this.PNL_BATTAGLIA.Controls.Add(this.PIC_ATTACCANTE);
            this.PNL_BATTAGLIA.Location = new System.Drawing.Point(306, 57);
            this.PNL_BATTAGLIA.Name = "PNL_BATTAGLIA";
            this.PNL_BATTAGLIA.Size = new System.Drawing.Size(752, 569);
            this.PNL_BATTAGLIA.TabIndex = 8;
            // 
            // PRG_PV_DIFENSORE
            // 
            this.PRG_PV_DIFENSORE.ForeColor = System.Drawing.Color.LimeGreen;
            this.PRG_PV_DIFENSORE.Location = new System.Drawing.Point(504, 439);
            this.PRG_PV_DIFENSORE.Name = "PRG_PV_DIFENSORE";
            this.PRG_PV_DIFENSORE.Size = new System.Drawing.Size(231, 23);
            this.PRG_PV_DIFENSORE.TabIndex = 5;
            // 
            // PRG_PV_ATTACCANTE
            // 
            this.PRG_PV_ATTACCANTE.ForeColor = System.Drawing.Color.LimeGreen;
            this.PRG_PV_ATTACCANTE.Location = new System.Drawing.Point(15, 439);
            this.PRG_PV_ATTACCANTE.Name = "PRG_PV_ATTACCANTE";
            this.PRG_PV_ATTACCANTE.Size = new System.Drawing.Size(231, 23);
            this.PRG_PV_ATTACCANTE.TabIndex = 4;
            // 
            // BTN_CHIUDI
            // 
            this.BTN_CHIUDI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_CHIUDI.BackgroundImage")));
            this.BTN_CHIUDI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CHIUDI.Font = new System.Drawing.Font("Niagara Engraved", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CHIUDI.Location = new System.Drawing.Point(532, 514);
            this.BTN_CHIUDI.Name = "BTN_CHIUDI";
            this.BTN_CHIUDI.Size = new System.Drawing.Size(205, 40);
            this.BTN_CHIUDI.TabIndex = 3;
            this.BTN_CHIUDI.Text = "CHIUDI SCHERMATA";
            this.BTN_CHIUDI.UseVisualStyleBackColor = true;
            this.BTN_CHIUDI.Click += new System.EventHandler(this.BTN_CHIUDI_Click);
            // 
            // PIC_DIFENSORE
            // 
            this.PIC_DIFENSORE.BackColor = System.Drawing.Color.Transparent;
            this.PIC_DIFENSORE.Location = new System.Drawing.Point(504, 145);
            this.PIC_DIFENSORE.Name = "PIC_DIFENSORE";
            this.PIC_DIFENSORE.Size = new System.Drawing.Size(231, 249);
            this.PIC_DIFENSORE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_DIFENSORE.TabIndex = 2;
            this.PIC_DIFENSORE.TabStop = false;
            // 
            // PIC_ANIMAZIONE
            // 
            this.PIC_ANIMAZIONE.BackColor = System.Drawing.Color.Transparent;
            this.PIC_ANIMAZIONE.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PIC_ANIMAZIONE.BackgroundImage")));
            this.PIC_ANIMAZIONE.Image = ((System.Drawing.Image)(resources.GetObject("PIC_ANIMAZIONE.Image")));
            this.PIC_ANIMAZIONE.Location = new System.Drawing.Point(258, 145);
            this.PIC_ANIMAZIONE.Name = "PIC_ANIMAZIONE";
            this.PIC_ANIMAZIONE.Size = new System.Drawing.Size(231, 249);
            this.PIC_ANIMAZIONE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_ANIMAZIONE.TabIndex = 1;
            this.PIC_ANIMAZIONE.TabStop = false;
            // 
            // PIC_ATTACCANTE
            // 
            this.PIC_ATTACCANTE.BackColor = System.Drawing.Color.Transparent;
            this.PIC_ATTACCANTE.Location = new System.Drawing.Point(15, 145);
            this.PIC_ATTACCANTE.Name = "PIC_ATTACCANTE";
            this.PIC_ATTACCANTE.Size = new System.Drawing.Size(231, 249);
            this.PIC_ATTACCANTE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_ATTACCANTE.TabIndex = 0;
            this.PIC_ATTACCANTE.TabStop = false;
            // 
            // LBL_DANNO
            // 
            this.LBL_DANNO.AutoSize = true;
            this.LBL_DANNO.BackColor = System.Drawing.Color.Transparent;
            this.LBL_DANNO.Font = new System.Drawing.Font("Niagara Solid", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DANNO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LBL_DANNO.Location = new System.Drawing.Point(294, 74);
            this.LBL_DANNO.Name = "LBL_DANNO";
            this.LBL_DANNO.Size = new System.Drawing.Size(30, 34);
            this.LBL_DANNO.TabIndex = 6;
            this.LBL_DANNO.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1330, 749);
            this.Controls.Add(this.PNL_BATTAGLIA);
            this.Controls.Add(this.BTN_INIZIA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PIC_MAZZO2);
            this.Controls.Add(this.PIC_MAZZO1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DGV_TABELLONE);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_TABELLONE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_USER)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_USER2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MAZZO1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_MAZZO2)).EndInit();
            this.PNL_BATTAGLIA.ResumeLayout(false);
            this.PNL_BATTAGLIA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_DIFENSORE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ANIMAZIONE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_ATTACCANTE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_TABELLONE;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox PIC_USER;
        private System.Windows.Forms.Label LBL_USERNAME;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BTN_INSERISCI2;
        private System.Windows.Forms.Label LBL_USERNAME2;
        private System.Windows.Forms.PictureBox PIC_USER2;
        private System.Windows.Forms.Button BTN_INSERISCI;
        private System.Windows.Forms.Label LBL_USERNAME1;
        private System.Windows.Forms.PictureBox PIC_MAZZO1;
        private System.Windows.Forms.PictureBox PIC_MAZZO2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_INIZIA;
        private System.Windows.Forms.Panel PNL_BATTAGLIA;
        private System.Windows.Forms.PictureBox PIC_DIFENSORE;
        private System.Windows.Forms.PictureBox PIC_ANIMAZIONE;
        private System.Windows.Forms.PictureBox PIC_ATTACCANTE;
        private System.Windows.Forms.Button BTN_CHIUDI;
        private System.Windows.Forms.ProgressBar PRG_PV_DIFENSORE;
        private System.Windows.Forms.ProgressBar PRG_PV_ATTACCANTE;
        private System.Windows.Forms.Label LBL_DANNO;
    }
}

