using Creazzo_Combattimento;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creazzo_GiocoCarte
{
    public partial class Form1 : Form
    {
        private CGiocatore player1;
        private CGiocatore player2;
        int index1, index2; //indici per inserire le carte dal mazzo una volta sconfitto un guerriero
        bool turno; //true = p1; false = p2;

        bool[,] campo;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            index1 = 0;
            index2 = 0;
            turno = true;
            campo = new bool[4, 3];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PNL_BATTAGLIA.Visible = false;
            PNL_BATTAGLIA.Enabled = false;
            DGV_TABELLONE.ScrollBars = ScrollBars.None;
            DGV_TABELLONE.RowCount = 3;
            for (int i = 0; i < 4; i++)
            {
                DataGridViewImageColumn column = new DataGridViewImageColumn();
                column.Name = i.ToString();
                column.ImageLayout = DataGridViewImageCellLayout.Stretch;
                DGV_TABELLONE.Columns.Add(column);
            }
            DGV_TABELLONE.Columns.RemoveAt(0);

            DGV_TABELLONE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;   //Imposta grandezza celle
            foreach (DataGridViewRow row in DGV_TABELLONE.Rows)
                row.Height = DGV_TABELLONE.Height / 3;

            for (int i = 0; i < 4; i++) 
            {
                for (int j = 0; j < 3; j++) 
                {
                    DGV_TABELLONE[i, j].Value = Image.FromFile(@"Imgs/Campo.png");
                }
            }
            PIC_MAZZO1.Enabled = false;
            PIC_MAZZO2.Enabled = false;
            DGV_TABELLONE.Enabled = false;
        }

        private void BTN_INSERISCI_Click(object sender, EventArgs e)
        {
            FUtente f1 = new FUtente();
            if(f1.ShowDialog() == DialogResult.OK) 
            {
                BTN_INSERISCI.Enabled = false;
                player1 = f1.Player;
                LBL_USERNAME1.Text = player1.Username;
                PIC_USER.Image = Image.FromFile(player1.Path);
            }
        }

        private void BTN_INSERISCI2_Click(object sender, EventArgs e)
        {
            FUtente f1 = new FUtente();
            if (f1.ShowDialog() == DialogResult.OK)
            {
                BTN_INSERISCI2.Enabled = false;
                player2 = f1.Player;
                LBL_USERNAME2.Text = player2.Username;
                PIC_USER2.Image = Image.FromFile(player2.Path);
            }
        }

        private void PIC_MAZZO1_Click(object sender, EventArgs e)
        {
            CPersonaggio carta;
            if (index1 < 10)
            {
                if (player1.mazzo.Count == 10)
                    carta = player1.DrawCard(index1);
                else
                    carta = player1.DrawCard(2);
                for (int i = 0; i < 3; i++)
                {
                    if (!campo[0, i])
                    {
                        DGV_TABELLONE[0, i].Value = Image.FromFile(carta.Path);
                        if (carta is CGuerriero)
                            DGV_TABELLONE[1, i].Value = Image.FromFile(@"Imgs/Spada.png");
                        else if (carta is CMago)
                            DGV_TABELLONE[1, i].Value = Image.FromFile(@"Imgs/Bacchetta.png");
                        else
                            DGV_TABELLONE[1, i].Value = Image.FromFile(@"Imgs/Arco.png");
                        campo[0, i] = true;
                        index1++;
                        return;
                    }
                }  
            }
            else
                MessageBox.Show("Hai terminato tutte le tue carte!");
        }

        private void PIC_MAZZO2_Click(object sender, EventArgs e)
        {
            if (index2 < 10)
            {
                CPersonaggio carta;
                if (player2.mazzo.Count == 10)
                    carta = player2.DrawCard(index2);
                else
                    carta = player2.DrawCard(2);
                for (int i = 0; i < 3; i++)
                {
                    if (!campo[3, i])
                    {
                        DGV_TABELLONE[3, i].Value = Image.FromFile(carta.Path);
                        if (carta is CGuerriero)
                            DGV_TABELLONE[2, i].Value = Image.FromFile(@"Imgs/Spada.png");
                        else if (carta is CMago)
                            DGV_TABELLONE[2, i].Value = Image.FromFile(@"Imgs/Bacchetta.png");
                        else
                            DGV_TABELLONE[2, i].Value = Image.FromFile(@"Imgs/Arco.png");
                        campo[3,i] = true;
                        index2 += 1;
                        return;
                    }
                }    
            }
            else
                MessageBox.Show("Hai terminato le carte!");
        }


        CPersonaggio attaccante = null, difensore = null;

        //Battaglia
        private void DGV_TABELLONE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int riga = e.RowIndex, colonna = e.ColumnIndex;

            if (turno && campo[e.ColumnIndex, e.RowIndex])   //Turno di player1
                Selezione(player1, player2, e.RowIndex, e.ColumnIndex, 0, 3);
            else if(!turno && campo[e.ColumnIndex, e.RowIndex])   //Turno di player2
                Selezione(player2, player1, e.RowIndex, e.ColumnIndex, 3, 0);
        }

        private void BTN_CHIUDI_Click(object sender, EventArgs e)
        {
            PNL_BATTAGLIA.Visible = false;
            PNL_BATTAGLIA.Enabled = false;
        }

        private void BTN_INIZIA_Click(object sender, EventArgs e)
        {
            if (player1 != null && player2 != null)
            {
                BTN_INIZIA.Enabled = false;
                BTN_INIZIA.Visible = false;
                DGV_TABELLONE.Enabled = true;
                PIC_MAZZO2.Enabled = true;
                PIC_MAZZO1.Enabled = true;
            }
            else
                MessageBox.Show("Devi prima inserire i 2 giocatori!");
        }

        private void Reset()
        {
            index1 = 0;
            index2 = 0;
            BTN_INSERISCI.Enabled = true;
            BTN_INSERISCI2.Enabled = true;
            BTN_INIZIA.Enabled = true;
            BTN_INIZIA.Visible = true;
        }

        private void Selezione(CGiocatore p1,  CGiocatore p2, int riga, int colonna, int at, int dif)
        {
            if (attaccante == null && colonna == at)
            {
                attaccante = p1.DrawCard(riga);
                MessageBox.Show($"{p1.Username} ha selezionato il suo attaccante: \n{attaccante.Stampa()}!");
            }
            else if(attaccante != null && colonna == dif)
            {
                turno = !turno;
                difensore = p2.DrawCard(riga);
                MessageBox.Show($"{p1.Username} ha selezionato chi attaccare: \n{difensore.Stampa()}!");
                SchermoBattaglia(attaccante, difensore);
                if (!difensore.E_vivo())
                {

                    p2.mazzo.Remove(difensore);
                    SpostaImmagini(riga,dif);
                    if (dif == 0)
                        SpostaIcone(riga, 1);
                    else
                        SpostaIcone(riga, 2);
                }
                attaccante = null;
                difensore = null;
                if (p2.FineGioco())
                {
                    MessageBox.Show($"{p1} ha vinto la partita!");
                    Reset();
                }
            }
        }

        private void SchermoBattaglia(CPersonaggio attaccante, CPersonaggio difensore)
        {
            PNL_BATTAGLIA.Enabled = true;
            PNL_BATTAGLIA.Visible = true;
            PIC_ATTACCANTE.Image = Image.FromFile(attaccante.Path);
            PIC_DIFENSORE.Image = Image.FromFile(difensore.Path);
            LBL_DANNO.Text = $"Danno inflitto: {attaccante.Attacca()}";

            //vita massima attaccante
            PRG_PV_ATTACCANTE.Maximum = GetMaxHp(attaccante);
            PRG_PV_DIFENSORE.Maximum = GetMaxHp(difensore);
            PRG_PV_ATTACCANTE.Value = attaccante.GetHp();
            if(attaccante is CMago)
            {
                Random rnd = new Random();
                rnd.Next(4);
                if(rnd.Next(4) == 0)
                {
                    difensore.Ricevi_danno((attaccante as CMago).AbilitaSpeciale());
                    MessageBox.Show("Abilità speciale del mago attivata!\nDanno Infinito!");
                }
            }
            difensore.Ricevi_danno(attaccante.Attacca());
            if (difensore.GetHp() > 0)
                PRG_PV_DIFENSORE.Value = difensore.GetHp();
            else
            {
                MessageBox.Show($"{difensore.Stampa()} è stato eliminato");
                PRG_PV_DIFENSORE.Value = 0;
            }
        }

        private int GetMaxHp(CPersonaggio p)
        {
            if (p is CGuerriero)
                return 100;
            else if (p is CArciere)
                return 80;
            return 70;
        }

        private void SpostaImmagini(int riga, int colonna)
        {
            DGV_TABELLONE[colonna, riga].Value = Image.FromFile(@"Imgs/Campo.png");
            campo[colonna, riga] = false;

            for (int i = riga; i < DGV_TABELLONE.RowCount - 1; i++) 
            {
                if (campo[colonna, i + 1]) // Se la riga sopra contiene un personaggio
                {
                    DGV_TABELLONE[colonna, i].Value = DGV_TABELLONE[colonna, i + 1].Value;
                    campo[colonna, i] = true;
                    DGV_TABELLONE[colonna, i + 1].Value = Image.FromFile(@"Imgs/Campo.png");
                    campo[colonna, i + 1] = false;
                }
            }
        }
        private void SpostaIcone(int riga, int colonna)
        {
            DGV_TABELLONE[colonna, riga].Value = Image.FromFile(@"Imgs/Campo.png");

            for (int i = riga; i < DGV_TABELLONE.RowCount - 1; i++)
            {
                if (DGV_TABELLONE[colonna, i].Value != Image.FromFile(@"Imgs/Campo.png"))
                {
                    DGV_TABELLONE[colonna, i].Value = DGV_TABELLONE[colonna, i + 1].Value;
                    DGV_TABELLONE[colonna, i + 1].Value = Image.FromFile(@"Imgs/Campo.png");
                }
            }
        }
    }
}