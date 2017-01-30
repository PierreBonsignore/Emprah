using BO;
using DAL;
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

namespace IHM
{
    public partial class Form1 : Form
    {
        static BindingList<Arme> listeArmes = new BindingList<Arme>();

        public Form1()
        {
            InitializeComponent();

            Arme flingue = new Arme("Boltgun",TypesArmes.Base,BO.Equipements.Armes.Propriétés.CategoriesArmes.Bolt,12,new Cadence(1,5,10),new Degats(4,TypeDegats.Explosif),2,5);
            flingue.Attributs.Add(new AttributArme("Dégommant", "ça dégomme"));
            flingue.Source = BO.Equipements.Source.Base;
            flingue.RefPage = "24";
            listeArmes.Add(flingue);
                
         
        }

        private void Grille()
        {
            grilleArmes.DataSource = listeArmes;
            grilleArmes.Columns["Nom"].DisplayIndex = 0;
            grilleArmes.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            
        }

        private FileStream SelectionnerSortie()
        {
            FileStream flux = null;
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    flux = (FileStream)saveFileDialog.OpenFile();                    
                }
            }
            catch (ApplicationException e)
            {
                MessageBox.Show(e.Message);
            }          
            return flux;
        }
        private FileStream SelectionnerEntree()
        {
            FileStream flux = null;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                flux = (FileStream)openFileDialog1.OpenFile();
            }
            MessageBox.Show(flux.Name);
            return flux;
        }


        private void SauverXML()
        {
            FileStream flux = null;                      
            try
            {
                using (flux = SelectionnerSortie())
                {
                    new ArmesDAL().ExportXML(listeArmes, flux);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la Sauvegarde " + e.Message);
            }
            flux.Close();
            MessageBox.Show("Export Effectué");
            Grille();
        }
        private void ChargerXML()
        {
            FileStream flux = null;
            try
            {
                using (flux = SelectionnerEntree())
                {
                    listeArmes = new ArmesDAL().ImportXML(flux);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors du Chargement" + e.Message);
            }
            finally
            {
                flux.Close();
            }

            Grille();
            //label1.Text = liste[0].Nom;

        }

       

        private void button_import_Click(object sender, EventArgs e)
        {
            ChargerXML();
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            SauverXML();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
