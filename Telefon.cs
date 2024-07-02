using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magazin_telefoane
{
    internal class Telefon
    {
        private int id;
        private string producator;
        private string model;
        private double pret;
        private int nrBucati;
        public enum TipCategorie { CuFir, FaraFir};
        private TipCategorie categorie;

        public int Id { get { return id; } }
        public string Producator { get { return producator; } }
        public string Model { get { return model; } }
        public double Pret { get { return pret;} }
        public int NrBucati { get { return nrBucati; } }
        public TipCategorie Categorie { get { return categorie; } set { } }

        public Telefon(int id, string producator, string model, double pret, int nrBucati, TipCategorie categorie)
        {
            if(!ValidarePret(pret))
            {
                MessageBox.Show("Pretul este invalid!");
            }
            this.id = id;
            this.producator = producator;
            this.model = model;
            this.pret = pret;
            this.nrBucati = nrBucati;
            this.categorie = categorie;
        }

        private bool ValidarePret(double pret)
        {
            if(pret<0) return false; return true;
        }
    }
}
