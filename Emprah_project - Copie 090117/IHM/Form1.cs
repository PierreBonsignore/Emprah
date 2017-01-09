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
        public Form1()
        {
            InitializeComponent();

           
        }

        private FileStream SelectionnerSortie()
        {
            saveFileDialog.ShowDialog();
            return (FileStream)saveFileDialog.OpenFile();
        }

        private void SauverXML()
        {
            BindingList<Arme> liste = new BindingList<Arme>();
            Arme flingue = new Arme();
            flingue.Nom = "My Big Zooka";
            liste.Add(flingue);
            FileStream flux = SelectionnerSortie();
            new ArmesDAL().ExportXML(liste, flux);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SauverXML();
        }
    }
}
