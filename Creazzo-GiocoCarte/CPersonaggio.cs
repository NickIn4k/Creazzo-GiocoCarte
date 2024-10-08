using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creazzo_Combattimento
{
    public class CPersonaggio
    {
        protected int pv;
        protected string nome;
        public string Path { get; set; }

        public CPersonaggio(string nome, int pv, string path)
        {
            this.nome = nome;
            this.pv = pv;
            Path = path;
        }

        public virtual int Attacca()
        {
            return 5;
        }

        public void Ricevi_danno(int danno)
        {
            pv -= danno;
        }

        public bool E_vivo()
        {
            if (pv > 0)
                return true;
            return false;
        }

        public string Stampa()
        {
            return $"{nome} ({pv}pv rimasti)";
        }

        public int GetHp()
        {
            return pv;
        }
    }

    public class CGuerriero : CPersonaggio
    {
        private int danni;
        public CGuerriero(string nome, string path) : base(nome, 100, path)
        {
            danni = 20;
        }

        public override int Attacca()
        {
            return danni;
        }
    }

    public class CMago : CPersonaggio
    {
        private int danni;
        public CMago(string nome, string path) : base(nome, 70, path)
        {
            danni = 30;
        }

        public override int Attacca()
        {
            return danni;
        }

        public int AbilitaSpeciale()
        {
            return 100000;
        }
    }

    public class CArciere : CPersonaggio
    {
        private int danni;
        public CArciere(string nome, string path) : base(nome, 80, path)
        {
            danni = 25;
        }

        public override int Attacca()
        {
            return danni;
        }
    }
}
