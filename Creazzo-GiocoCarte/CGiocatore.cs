using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creazzo_Combattimento
{
    public class CGiocatore
    {
        public List<CPersonaggio> mazzo;
        public string Username { get; set; }
        public string Path { get; set; }

        public CGiocatore(string username, string path) 
        {
            this.Username = username;
            this.Path = path;
            mazzo = new List<CPersonaggio>();
        }

        public CPersonaggio DrawCard(int index)
        {
            return mazzo[index];
        }

        public void AggiungiCarta(CPersonaggio p)
        {
            mazzo.Add(p);
        }

        public bool FineGioco()
        {
            if (mazzo.Count == 0)
                return true;
            else
                return false;
        }
    }
}
