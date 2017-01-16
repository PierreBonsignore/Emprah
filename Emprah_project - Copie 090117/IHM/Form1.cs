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
        private static BindingList<Arme> liste = new BindingList<Arme>();

        public Form1()
        {
            InitializeComponent();

            Grille();
        }

        private void Grille()
        {
            dataGridView1.DataSource = liste;
        }

        private FileStream SelectionnerSortie()
        {
            saveFileDialog.ShowDialog();
            return (FileStream)saveFileDialog.OpenFile();
        }
        private FileStream SelectionnerEntree()
        {
            openFileDialog1.ShowDialog();          
            return (FileStream)openFileDialog1.OpenFile();          
            
        }


        private void SauverXML()
        {
            BindingList<Arme> liste = new BindingList<Arme>();
            Arme flingue = new Arme(TypesArmes.Pistolet, "ZeGun", 12, new Cadence(1, 3, 12), new Degats(2, TypeDegats.Impact), 2, 10, new Rech(1, TypeRech.Action), new ArmeSpecial("dégommant", "ca dégomme"), Disponibilité.Rare, 42, "page 23");
            liste.Add(flingue);
            try
            {
                using (FileStream flux = SelectionnerSortie())
                {
                    new ArmesDAL().ExportSoap(liste, flux);
                    flux.Dispose();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors de la Sauvegarde "+e.Message);                
            }    
        }
        private void ChargerXML()
        {

            try
            {
                using (FileStream flux = SelectionnerEntree())
                {
                    liste = new ArmesDAL().ImportSoap(flux);
                    flux.Dispose();
                }                
            }
            catch (Exception e)
            {
                MessageBox.Show("Erreur lors du Chargement"+e.Message);
            }
            Grille();
            Arme arme = (Arme)dataGridView1.Rows[0].DataBoundItem;
            label1.Text = arme.Nom;
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SauverXML();
        }

        private void button_import_Click(object sender, EventArgs e)
        {
            ChargerXML();
        }


    }
}
