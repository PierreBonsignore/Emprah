
using BLL;
using BO;
using BO.Equipements.Armes.Propriétés;
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
    public partial class EcranArmes : Form
    {
        static BindingList<Arme> listeArmes = new BindingList<Arme>();

        public EcranArmes()
        {
            InitializeComponent();

            Arme arme = new Arme("épée", TypesArmes.Melee, CategoriesArmes.BasseTech, 12, new Cadence(1, 0, 0), new Degats(4, TypeDegats.Dechirant), 4, 1, 1, TypeRech.Action);
            arme.Disponibilité = Disponibilité.Courant;
            arme.Poids = 10;
            arme.Source = BO.Equipements.Source.Personalisé;
            arme.RefPage = "page 45";
            arme.Attributs.Add(new AttributArme("super classe", "c'est super"));
            listeArmes.Add(arme);

            SetDetails();

        }

        private void SetDetails()
        {
            comboBox_categories.DataSource = Enum.GetValues(typeof(CategoriesArmes));

            comboBox_cateArme.DataSource = Enum.GetValues(typeof(CategoriesArmes));
            comboBox_typeArme.DataSource = Enum.GetValues(typeof(TypesArmes));
            comboBox_dispoArme.DataSource = Enum.GetValues(typeof(Disponibilité));
            comboBox_typeRech.DataSource = Enum.GetValues(typeof(TypeRech));
            comboBox_typeDeg.DataSource = Enum.GetValues(typeof(TypeDegats));


        }

        private void Grille()
        {
            try
            {
                grilleArmes.DataSource = listeArmes;
                grilleArmes.Columns["Nom"].DisplayIndex = 0;
                grilleArmes.Columns["Nom"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                grilleArmes.Columns["Autonomie"].Visible = checkBox_At.Checked;
                grilleArmes.Columns["Portee"].Visible = checkBox_portée.Checked;
                grilleArmes.Columns["Penetration"].Visible = checkBox_pen.Checked;
                grilleArmes.Columns["Disponibilité"].Visible = checkBox_dispo.Checked;
                grilleArmes.Columns["Poids"].Visible = false;
                grilleArmes.Columns["RefPage"].Visible = false;
                grilleArmes.Columns["Source"].Visible = false;
            }
            catch (Exception grille)
            {
                MessageBox.Show(grille.Message);
            }


        }

        private void AffichageArme(Arme arme)
        {
            listbox_attributs.DataSource = arme.Attributs;

            label_nomArme.Text = arme.Nom;
            groupBox_armeDetails.Text = arme.Nom;

            textBox_cadence.Text = arme.Cadence.ToString();
            numericUpDown_degValeur.Value = arme.Degats.Valeur;
            comboBox_typeDeg.SelectedItem = arme.Degats.Type;


            comboBox_cateArme.SelectedItem = arme.Categorie;
            comboBox_typeArme.SelectedItem = arme.Type;
            comboBox_dispoArme.SelectedItem = arme.Disponibilité;

            numUpDown_pen.Value = arme.Penetration;
            numericUpDown_portee.Value = arme.Portee;
            numericUpDown_poids.Value = arme.Poids;

            numericUpDown_rech.Value = arme.Rechargement.nbAction;
            comboBox_typeRech.SelectedItem = arme.Rechargement.type;
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



        private void SauverListeXML()
        {
            FileStream flux = null;
            try
            {
                using (flux = SelectionnerSortie())
                {
                    if (flux != null)
                    {
                        new ArmesDAL().ExportListeXml(listeArmes, flux);
                    }
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
                ImportDialog.ShowDialog();
                if (!string.IsNullOrWhiteSpace(ImportDialog.FileName))
                {
                    using (flux = (FileStream)ImportDialog.OpenFile())
                    {
                        listeArmes = ArmesBLL.GetInstance().Importer(flux);
                    }
                    Grille();
                    MessageBox.Show("Objets importés");
                }
                ImportDialog.Reset();
            }
            catch (ApplicationException e)
            {
                MessageBox.Show("Erreur lors du Chargement" + e.Message);
            }           

           
            if (grilleArmes.CurrentRow.DataBoundItem != null)
            {
                AffichageArme((Arme)grilleArmes.CurrentRow.DataBoundItem);
            }
            //label1.Text = liste[0].Nom;

        }



        private void button_import_Click(object sender, EventArgs e)
        {
            try
            {
                ChargerXML();
            }
            catch (ApplicationException import)
            {
                MessageBox.Show(import.Message);
            }
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            SauverListeXML();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void grilleArmes_CurrentCellChanged(object sender, EventArgs e)
        {
            if (grilleArmes.CurrentRow != null)
            {
                AffichageArme((Arme)grilleArmes.CurrentRow.DataBoundItem);
            }
        }

        private void checkBox_filtres_CheckedChanged(object sender, EventArgs e)
        {
            Grille();
        }

        private void button_file_Click(object sender, EventArgs e)
        {
            SauverXML();
        }

        private void SauverXML()
        {
            string folderPath = "";
            folderBrowserDialog1.ShowDialog();
            folderPath = folderBrowserDialog1.SelectedPath;
            saveFileDialog.InitialDirectory = folderPath;

            foreach (Arme item in listeArmes)
            {
            saveFileDialog.FileName = item.Nom+"-arme";                

                using (FileStream flux = new FileStream(folderPath+"\\"+item.Nom,FileMode.Create) )
                {
                    ArmesBLL.GetInstance().Exporter(item, flux);
                }
            }
           
        }
    }
}
