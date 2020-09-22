using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDamier
{
    public partial class FormDamier : Form
    {
        public FormDamier()
        {
            InitializeComponent();
            ListBoxColor();
        }

        private void ListBoxColor ()
        {
            // remplie les liste Box avec toutes les couleurs
            Array colorsArray = Enum.GetValues(typeof(KnownColor));
            KnownColor[] p = new KnownColor[colorsArray.Length];
            Array.Copy(colorsArray, p, colorsArray.Length);
            listBoxColorClair.DataSource = colorsArray;
            listBoxColorFonce.DataSource = p;
        }


        private void EventCreationDamier(object sender, EventArgs e)
        {
            int nbDamier, nbLigne;
            Point p;    // coordonnée du bouton
            Size taille;    // taille du bouton

            Color clair = Color.FromName(listBoxColorClair.SelectedItem.ToString());
            Color fonce = Color.FromName(listBoxColorFonce.SelectedItem.ToString());

            // bouton de creation du damier
            if ( int.TryParse(this.textBoxNbColonne.Text,out nbDamier)&& int.TryParse(this.textBoxNbLigne.Text, out nbLigne) )
            {
                this.panelDamier.Controls.Clear();
                p = new Point(0, 9);
                taille = new Size (this.panelDamier.Width / nbDamier-3, this.panelDamier.Width / nbDamier-3);

                for (int j = 0;j< nbLigne; j++)
                {
                    for (int i = 0; i < nbDamier; i++)
                    {
                        ButtonDamier bD = new ButtonDamier(clair, fonce);
                        bD.Location = p;
                        bD.Size = taille;
                        this.panelDamier.Controls.Add(bD);
                        p.X += taille.Width;
                    }

                    if ( nbDamier%2 == 0 ) { ButtonDamier.Color = !ButtonDamier.Color;  }
                    p.X = 0;
                    p.Y += taille.Height;
                }

            }else
            {
                this.textBoxNbColonne.Text = "";
                this.textBoxNbColonne.Focus();
            }


        }
    }
}
