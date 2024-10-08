using Creazzo_Combattimento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Creazzo_GiocoCarte
{
    public partial class FUtente : Form
    {
        public CGiocatore Player { get; set; }
        string path;

        public FUtente()
        {
            InitializeComponent();
        }

        private void BTN_CARICA_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PNG files (*.png) |*.png| JPEG files (*.jpg) |*.jpg";
            ofd.InitialDirectory = Directory.GetCurrentDirectory();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
                PIC_PROFILE.Image = Image.FromFile(path);
            }
        }

        private void BTN_INSERISCI_Click(object sender, EventArgs e)
        {
            string name = TXT_NOME.Text;
            if (TXT_NOME.Text != string.Empty && path != string.Empty) 
            {
                Player = new CGiocatore(name, path);
                CreaMazzo();
                Shuffle();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void CreaMazzo()
        {
            Random rnd = new Random();
            string[] nomi = { "Draven", "Ragnar", "Elorath", "Morgrim", "Sigrun", "Harond", "Valthor", "Gianluca", "Darrion", "Barry" };
            int num;
            CPersonaggio p;
            for (int i = 0; i < 10; i++)
            {
                num = rnd.Next(3);
                if (num == 0)
                    p = new CGuerriero($"Guerriero {nomi[i]}", $@"Imgs/{nomi[i]}.png");
                else if (num == 1)
                    p = new CMago($"Mago {nomi[i]}", $@"Imgs/{nomi[i]}.png");
                else
                    p = new CArciere($"Arciere {nomi[i]}", $@"Imgs/{nomi[i]}.png");
                Player.AggiungiCarta(p);   
            }
        }

        private List<int> indexProibiti;
        private void Shuffle()
        {
            indexProibiti = new List<int>();
            Random random = new Random();
            for(int i=0; i<10; i++)
            {
                int n = random.Next(10);
                if (!IsSelected(n))
                {
                    CPersonaggio temp = Player.mazzo[n];
                    Player.mazzo[n] = Player.mazzo[i];
                    Player.mazzo[i] = temp;
                }
                else
                    i--;
            }
        }

        private bool IsSelected(int n)
        {
            if (indexProibiti.Contains(n))
                return true;
            else
            {
                indexProibiti.Add(n);
                return false;
            }
        }
    }
}