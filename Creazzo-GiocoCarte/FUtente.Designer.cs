namespace Creazzo_GiocoCarte
{
    partial class FUtente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUtente));
            this.TXT_NOME = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_CARICA = new System.Windows.Forms.Button();
            this.BTN_INSERISCI = new System.Windows.Forms.Button();
            this.PIC_PROFILE = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PROFILE)).BeginInit();
            this.SuspendLayout();
            // 
            // TXT_NOME
            // 
            this.TXT_NOME.BackColor = System.Drawing.Color.Peru;
            this.TXT_NOME.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TXT_NOME.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_NOME.Location = new System.Drawing.Point(12, 124);
            this.TXT_NOME.Name = "TXT_NOME";
            this.TXT_NOME.Size = new System.Drawing.Size(172, 23);
            this.TXT_NOME.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome giocatore";
            // 
            // BTN_CARICA
            // 
            this.BTN_CARICA.BackColor = System.Drawing.Color.Peru;
            this.BTN_CARICA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_CARICA.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_CARICA.Location = new System.Drawing.Point(12, 231);
            this.BTN_CARICA.Name = "BTN_CARICA";
            this.BTN_CARICA.Size = new System.Drawing.Size(172, 32);
            this.BTN_CARICA.TabIndex = 2;
            this.BTN_CARICA.Text = "CARICA IMMAGINE";
            this.BTN_CARICA.UseVisualStyleBackColor = false;
            this.BTN_CARICA.Click += new System.EventHandler(this.BTN_CARICA_Click);
            // 
            // BTN_INSERISCI
            // 
            this.BTN_INSERISCI.BackColor = System.Drawing.Color.Peru;
            this.BTN_INSERISCI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_INSERISCI.Font = new System.Drawing.Font("Niagara Solid", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_INSERISCI.Location = new System.Drawing.Point(21, 323);
            this.BTN_INSERISCI.Name = "BTN_INSERISCI";
            this.BTN_INSERISCI.Size = new System.Drawing.Size(425, 59);
            this.BTN_INSERISCI.TabIndex = 3;
            this.BTN_INSERISCI.Text = "CREA GIOCATORE";
            this.BTN_INSERISCI.UseVisualStyleBackColor = false;
            this.BTN_INSERISCI.Click += new System.EventHandler(this.BTN_INSERISCI_Click);
            // 
            // PIC_PROFILE
            // 
            this.PIC_PROFILE.BackColor = System.Drawing.Color.Transparent;
            this.PIC_PROFILE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PIC_PROFILE.Location = new System.Drawing.Point(225, 43);
            this.PIC_PROFILE.Name = "PIC_PROFILE";
            this.PIC_PROFILE.Size = new System.Drawing.Size(221, 247);
            this.PIC_PROFILE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PIC_PROFILE.TabIndex = 4;
            this.PIC_PROFILE.TabStop = false;
            // 
            // FUtente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(458, 394);
            this.Controls.Add(this.PIC_PROFILE);
            this.Controls.Add(this.BTN_INSERISCI);
            this.Controls.Add(this.BTN_CARICA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_NOME);
            this.Name = "FUtente";
            this.Text = "FUtente";
            ((System.ComponentModel.ISupportInitialize)(this.PIC_PROFILE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_NOME;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_CARICA;
        private System.Windows.Forms.Button BTN_INSERISCI;
        private System.Windows.Forms.PictureBox PIC_PROFILE;
    }
}