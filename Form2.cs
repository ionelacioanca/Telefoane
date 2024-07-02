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
    public partial class Form2 : Form
    {
        List<Telefon> telefoane = new List<Telefon>();
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonAdaugare_Click(object sender, EventArgs e)
        {
            Telefon.TipCategorie categorie = (Telefon.TipCategorie)Enum.Parse(typeof(Telefon.TipCategorie), comboBoxCategorie.Text);
            Telefon t = new Telefon(Convert.ToInt32(textBoxIdTelefon.Text), textBoxProducator.Text, textBoxModel.Text, Convert.ToDouble(textBoxPret.Text), Convert.ToInt32(textBoxNrBucati.Text), categorie);
            if (comboBoxCategorie.SelectedIndex == 0)
            {
                telefoane.Add(t);
                Button btn = new Button();
                btn.Text = t.Producator;
                btn.Width = 100;
                btn.Tag = t;
                flowLayoutPanelCuFir.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
            else if (comboBoxCategorie.SelectedIndex == 1)
            {
                telefoane.Add(t);
                Button btn = new Button();
                btn.Text = t.Producator;
                btn.Width = 100;
                btn.Tag = t;
                flowLayoutPanelFaraFir.Controls.Add(btn);
                btn.Click += Btn_Click;
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Telefon t = (Telefon)btn.Tag;

            textBoxIdTelefon.Text = Convert.ToString(t.Id);
            textBoxProducator.Text = t.Producator;
            textBoxModel.Text = t.Model;
            textBoxPret.Text = Convert.ToString(t.Pret);
            textBoxNrBucati.Text = Convert.ToString(t.NrBucati);
            propertyGridTelefoane.SelectedObject = t;
        }

        private void buttonStergere_Click(object sender, EventArgs e)
        {
            if (propertyGridTelefoane.SelectedObject is Telefon telefonSelectat)
            {
                telefoane.Remove(telefonSelectat);

                Control butonSters = null;
                foreach (Control control in flowLayoutPanelCuFir.Controls)
                {
                    if (control is Button buton && buton.Tag == telefonSelectat)
                    {
                        butonSters = control;
                        break;
                    }
                }

                if (butonSters == null)
                {
                    foreach (Control control in flowLayoutPanelFaraFir.Controls)
                    {
                        if (control is Button buton && buton.Tag == telefonSelectat)
                        {
                            butonSters = control;
                            break;
                        }
                    }
                }
                if(butonSters != null)
                {
                    flowLayoutPanelCuFir.Controls.Remove(butonSters);
                    flowLayoutPanelFaraFir.Controls.Remove(butonSters);
                }
                ArhivaTelefoane(telefonSelectat);
            }
            else
            {
                MessageBox.Show("Selectati un telefoon din lista pentru a-l sterge!");
            }
        }

        private void ArhivaTelefoane(Telefon telefon)
        {
            string filePath = "Arhiva.txt";
            using(StreamWriter w = new StreamWriter(filePath, false))
            {
                w.WriteLine($"{telefon.Id}, {telefon.Producator}, {telefon.Model}, {telefon.Pret}, {telefon.NrBucati}");
            }
        }
    }
}
