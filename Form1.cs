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

namespace Magazin_telefoane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConectare_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (!ValidareUtilizatorSiParola(textBoxNumeUtilizator.Text, textBoxParola.Text))
            {
                errorProvider1.SetError(textBoxNumeUtilizator, "Nume de utilizator introdus gresit!");
                errorProvider2.SetError(textBoxParola, "Parola este incorecta!");
                textBoxNumeUtilizator.Clear();
                textBoxParola.Clear();
            }
            else
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("V-ati conectat cu succes!");
                this.Hide();

                Form2 f = new Form2();
                f.ShowDialog();
                this.Close();
            }
        }

        private bool ValidareUtilizatorSiParola(string utilizator, string parola)
        {
            string[] linii = File.ReadAllLines("Autentificare.txt");
            foreach(string linie in linii)
            {
                string[] parti = linie.Split(' ');
                if(parti.Length==2)
                {
                    string numeUtilizator = parti[0];
                    string parolaUtilizator = parti[1];
                    if(numeUtilizator == utilizator && parolaUtilizator==parola)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void buttonAnulare_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
