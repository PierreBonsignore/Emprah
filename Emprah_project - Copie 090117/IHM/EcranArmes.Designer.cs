namespace IHM
{
    partial class EcranArmes
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.button_export = new System.Windows.Forms.Button();
            this.button_import = new System.Windows.Forms.Button();
            this.grilleArmes = new System.Windows.Forms.DataGridView();
            this.ImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.comboBox_sources = new System.Windows.Forms.ComboBox();
            this.comboBox_categories = new System.Windows.Forms.ComboBox();
            this.groupBox_filtres = new System.Windows.Forms.GroupBox();
            this.checkBox_dispo = new System.Windows.Forms.CheckBox();
            this.checkBox_At = new System.Windows.Forms.CheckBox();
            this.checkBox_pen = new System.Windows.Forms.CheckBox();
            this.checkBox_portée = new System.Windows.Forms.CheckBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.comboBox_typeArme = new System.Windows.Forms.ComboBox();
            this.label_type = new System.Windows.Forms.Label();
            this.label_categorie = new System.Windows.Forms.Label();
            this.numUpDown_pen = new System.Windows.Forms.NumericUpDown();
            this.textBox_cadence = new System.Windows.Forms.TextBox();
            this.label_portee = new System.Windows.Forms.Label();
            this.label_cadence = new System.Windows.Forms.Label();
            this.numericUpDown_at = new System.Windows.Forms.NumericUpDown();
            this.label_at = new System.Windows.Forms.Label();
            this.label_deg = new System.Windows.Forms.Label();
            this.label_pen = new System.Windows.Forms.Label();
            this.numericUpDown_portee = new System.Windows.Forms.NumericUpDown();
            this.label_atts = new System.Windows.Forms.Label();
            this.label_dispo = new System.Windows.Forms.Label();
            this.comboBox_dispoArme = new System.Windows.Forms.ComboBox();
            this.numericUpDown_poids = new System.Windows.Forms.NumericUpDown();
            this.label_pds = new System.Windows.Forms.Label();
            this.comboBox_cateArme = new System.Windows.Forms.ComboBox();
            this.label_gr = new System.Windows.Forms.Label();
            this.label_m = new System.Windows.Forms.Label();
            this.label_rech = new System.Windows.Forms.Label();
            this.comboBox_typeRech = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listbox_attributs = new System.Windows.Forms.ListBox();
            this.groupBox_armeDetails = new System.Windows.Forms.GroupBox();
            this.numericUpDown_degValeur = new System.Windows.Forms.NumericUpDown();
            this.comboBox_typeDeg = new System.Windows.Forms.ComboBox();
            this.label_degDés = new System.Windows.Forms.Label();
            this.numericUpDown_rech = new System.Windows.Forms.NumericUpDown();
            this.label_nomArme = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_file = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilleArmes)).BeginInit();
            this.groupBox_filtres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_pen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_at)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_portee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_poids)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox_armeDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_degValeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rech)).BeginInit();
            this.SuspendLayout();
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.CreatePrompt = true;
            this.saveFileDialog.DefaultExt = "weaponEmp";
            this.saveFileDialog.Title = "Sauver XML";
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(34, 628);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(75, 21);
            this.button_export.TabIndex = 0;
            this.button_export.Text = "exporter";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // button_import
            // 
            this.button_import.Location = new System.Drawing.Point(115, 628);
            this.button_import.Name = "button_import";
            this.button_import.Size = new System.Drawing.Size(75, 21);
            this.button_import.TabIndex = 1;
            this.button_import.Text = "importer";
            this.button_import.UseVisualStyleBackColor = true;
            this.button_import.Click += new System.EventHandler(this.button_import_Click);
            // 
            // grilleArmes
            // 
            this.grilleArmes.AllowUserToAddRows = false;
            this.grilleArmes.AllowUserToDeleteRows = false;
            this.grilleArmes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.grilleArmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilleArmes.Location = new System.Drawing.Point(34, 99);
            this.grilleArmes.Name = "grilleArmes";
            this.grilleArmes.RowHeadersVisible = false;
            this.grilleArmes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grilleArmes.Size = new System.Drawing.Size(286, 523);
            this.grilleArmes.TabIndex = 2;
            this.grilleArmes.CurrentCellChanged += new System.EventHandler(this.grilleArmes_CurrentCellChanged);
            // 
            // comboBox_sources
            // 
            this.comboBox_sources.FormattingEnabled = true;
            this.comboBox_sources.Location = new System.Drawing.Point(34, 70);
            this.comboBox_sources.Name = "comboBox_sources";
            this.comboBox_sources.Size = new System.Drawing.Size(121, 21);
            this.comboBox_sources.TabIndex = 13;
            this.comboBox_sources.Text = "Sources";
            // 
            // comboBox_categories
            // 
            this.comboBox_categories.FormattingEnabled = true;
            this.comboBox_categories.Location = new System.Drawing.Point(199, 70);
            this.comboBox_categories.Name = "comboBox_categories";
            this.comboBox_categories.Size = new System.Drawing.Size(121, 21);
            this.comboBox_categories.TabIndex = 14;
            this.comboBox_categories.Text = "Catégories";
            // 
            // groupBox_filtres
            // 
            this.groupBox_filtres.Controls.Add(this.checkBox_dispo);
            this.groupBox_filtres.Controls.Add(this.checkBox_At);
            this.groupBox_filtres.Controls.Add(this.checkBox_pen);
            this.groupBox_filtres.Controls.Add(this.checkBox_portée);
            this.groupBox_filtres.Location = new System.Drawing.Point(344, 99);
            this.groupBox_filtres.Name = "groupBox_filtres";
            this.groupBox_filtres.Size = new System.Drawing.Size(94, 131);
            this.groupBox_filtres.TabIndex = 15;
            this.groupBox_filtres.TabStop = false;
            this.groupBox_filtres.Text = "Filtres";
            // 
            // checkBox_dispo
            // 
            this.checkBox_dispo.AutoSize = true;
            this.checkBox_dispo.Location = new System.Drawing.Point(16, 96);
            this.checkBox_dispo.Name = "checkBox_dispo";
            this.checkBox_dispo.Size = new System.Drawing.Size(56, 17);
            this.checkBox_dispo.TabIndex = 3;
            this.checkBox_dispo.Text = "Dispo.";
            this.checkBox_dispo.UseVisualStyleBackColor = true;
            this.checkBox_dispo.CheckedChanged += new System.EventHandler(this.checkBox_filtres_CheckedChanged);
            // 
            // checkBox_At
            // 
            this.checkBox_At.AutoSize = true;
            this.checkBox_At.Location = new System.Drawing.Point(16, 73);
            this.checkBox_At.Name = "checkBox_At";
            this.checkBox_At.Size = new System.Drawing.Size(43, 17);
            this.checkBox_At.TabIndex = 2;
            this.checkBox_At.Text = "AT.";
            this.checkBox_At.UseVisualStyleBackColor = true;
            this.checkBox_At.CheckedChanged += new System.EventHandler(this.checkBox_filtres_CheckedChanged);
            // 
            // checkBox_pen
            // 
            this.checkBox_pen.AutoSize = true;
            this.checkBox_pen.Location = new System.Drawing.Point(16, 50);
            this.checkBox_pen.Name = "checkBox_pen";
            this.checkBox_pen.Size = new System.Drawing.Size(48, 17);
            this.checkBox_pen.TabIndex = 1;
            this.checkBox_pen.Text = "Pén.";
            this.checkBox_pen.UseVisualStyleBackColor = true;
            this.checkBox_pen.CheckedChanged += new System.EventHandler(this.checkBox_filtres_CheckedChanged);
            // 
            // checkBox_portée
            // 
            this.checkBox_portée.AutoSize = true;
            this.checkBox_portée.Location = new System.Drawing.Point(16, 27);
            this.checkBox_portée.Name = "checkBox_portée";
            this.checkBox_portée.Size = new System.Drawing.Size(57, 17);
            this.checkBox_portée.TabIndex = 0;
            this.checkBox_portée.Text = "Portée";
            this.checkBox_portée.UseVisualStyleBackColor = true;
            this.checkBox_portée.CheckedChanged += new System.EventHandler(this.checkBox_filtres_CheckedChanged);
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(34, 44);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(121, 20);
            this.searchBox.TabIndex = 16;
            this.searchBox.Text = "recherche";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(162, 44);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(75, 23);
            this.button_search.TabIndex = 17;
            this.button_search.Text = "Chercher";
            this.button_search.UseVisualStyleBackColor = true;
            // 
            // comboBox_typeArme
            // 
            this.comboBox_typeArme.FormattingEnabled = true;
            this.comboBox_typeArme.Location = new System.Drawing.Point(73, 80);
            this.comboBox_typeArme.Name = "comboBox_typeArme";
            this.comboBox_typeArme.Size = new System.Drawing.Size(121, 21);
            this.comboBox_typeArme.TabIndex = 6;
            this.comboBox_typeArme.Text = "TypeArme";
            // 
            // label_type
            // 
            this.label_type.AutoSize = true;
            this.label_type.Location = new System.Drawing.Point(29, 83);
            this.label_type.Name = "label_type";
            this.label_type.Size = new System.Drawing.Size(31, 13);
            this.label_type.TabIndex = 13;
            this.label_type.Text = "Type";
            this.label_type.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_categorie
            // 
            this.label_categorie.AutoSize = true;
            this.label_categorie.Location = new System.Drawing.Point(13, 113);
            this.label_categorie.Name = "label_categorie";
            this.label_categorie.Size = new System.Drawing.Size(52, 13);
            this.label_categorie.TabIndex = 14;
            this.label_categorie.Text = "Catégorie";
            // 
            // numUpDown_pen
            // 
            this.numUpDown_pen.Location = new System.Drawing.Point(95, 227);
            this.numUpDown_pen.Name = "numUpDown_pen";
            this.numUpDown_pen.Size = new System.Drawing.Size(44, 20);
            this.numUpDown_pen.TabIndex = 7;
            this.numUpDown_pen.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // textBox_cadence
            // 
            this.textBox_cadence.Location = new System.Drawing.Point(73, 137);
            this.textBox_cadence.Name = "textBox_cadence";
            this.textBox_cadence.Size = new System.Drawing.Size(57, 20);
            this.textBox_cadence.TabIndex = 13;
            this.textBox_cadence.Text = "C/2/10";
            this.textBox_cadence.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label_portee
            // 
            this.label_portee.AutoSize = true;
            this.label_portee.Location = new System.Drawing.Point(51, 257);
            this.label_portee.Name = "label_portee";
            this.label_portee.Size = new System.Drawing.Size(38, 13);
            this.label_portee.TabIndex = 8;
            this.label_portee.Text = "Portée";
            // 
            // label_cadence
            // 
            this.label_cadence.AutoSize = true;
            this.label_cadence.Location = new System.Drawing.Point(10, 140);
            this.label_cadence.Name = "label_cadence";
            this.label_cadence.Size = new System.Drawing.Size(50, 13);
            this.label_cadence.TabIndex = 15;
            this.label_cadence.Text = "Cadence";
            // 
            // numericUpDown_at
            // 
            this.numericUpDown_at.Location = new System.Drawing.Point(95, 283);
            this.numericUpDown_at.Name = "numericUpDown_at";
            this.numericUpDown_at.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_at.TabIndex = 9;
            this.numericUpDown_at.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_at
            // 
            this.label_at.AutoSize = true;
            this.label_at.Location = new System.Drawing.Point(32, 283);
            this.label_at.Name = "label_at";
            this.label_at.Size = new System.Drawing.Size(57, 13);
            this.label_at.TabIndex = 10;
            this.label_at.Text = "Autonomie";
            // 
            // label_deg
            // 
            this.label_deg.AutoSize = true;
            this.label_deg.Location = new System.Drawing.Point(10, 166);
            this.label_deg.Name = "label_deg";
            this.label_deg.Size = new System.Drawing.Size(41, 13);
            this.label_deg.TabIndex = 17;
            this.label_deg.Text = "Dégats";
            // 
            // label_pen
            // 
            this.label_pen.AutoSize = true;
            this.label_pen.Location = new System.Drawing.Point(26, 229);
            this.label_pen.Name = "label_pen";
            this.label_pen.Size = new System.Drawing.Size(61, 13);
            this.label_pen.TabIndex = 18;
            this.label_pen.Text = "Pénétration";
            // 
            // numericUpDown_portee
            // 
            this.numericUpDown_portee.Location = new System.Drawing.Point(95, 255);
            this.numericUpDown_portee.Name = "numericUpDown_portee";
            this.numericUpDown_portee.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_portee.TabIndex = 19;
            this.numericUpDown_portee.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_atts
            // 
            this.label_atts.AutoSize = true;
            this.label_atts.Location = new System.Drawing.Point(92, 434);
            this.label_atts.Name = "label_atts";
            this.label_atts.Size = new System.Drawing.Size(45, 13);
            this.label_atts.TabIndex = 21;
            this.label_atts.Text = "Attributs";
            // 
            // label_dispo
            // 
            this.label_dispo.AutoSize = true;
            this.label_dispo.Location = new System.Drawing.Point(26, 379);
            this.label_dispo.Name = "label_dispo";
            this.label_dispo.Size = new System.Drawing.Size(63, 13);
            this.label_dispo.TabIndex = 23;
            this.label_dispo.Text = "Disponibilité";
            // 
            // comboBox_dispoArme
            // 
            this.comboBox_dispoArme.FormattingEnabled = true;
            this.comboBox_dispoArme.Location = new System.Drawing.Point(95, 376);
            this.comboBox_dispoArme.Name = "comboBox_dispoArme";
            this.comboBox_dispoArme.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dispoArme.TabIndex = 22;
            this.comboBox_dispoArme.Text = "Rare";
            // 
            // numericUpDown_poids
            // 
            this.numericUpDown_poids.Location = new System.Drawing.Point(95, 350);
            this.numericUpDown_poids.Name = "numericUpDown_poids";
            this.numericUpDown_poids.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_poids.TabIndex = 24;
            this.numericUpDown_poids.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label_pds
            // 
            this.label_pds.AutoSize = true;
            this.label_pds.Location = new System.Drawing.Point(32, 352);
            this.label_pds.Name = "label_pds";
            this.label_pds.Size = new System.Drawing.Size(33, 13);
            this.label_pds.TabIndex = 25;
            this.label_pds.Text = "Poids";
            // 
            // comboBox_cateArme
            // 
            this.comboBox_cateArme.FormattingEnabled = true;
            this.comboBox_cateArme.Location = new System.Drawing.Point(73, 110);
            this.comboBox_cateArme.Name = "comboBox_cateArme";
            this.comboBox_cateArme.Size = new System.Drawing.Size(121, 21);
            this.comboBox_cateArme.TabIndex = 11;
            this.comboBox_cateArme.Text = "Categorie";
            // 
            // label_gr
            // 
            this.label_gr.AutoSize = true;
            this.label_gr.Location = new System.Drawing.Point(145, 352);
            this.label_gr.Name = "label_gr";
            this.label_gr.Size = new System.Drawing.Size(16, 13);
            this.label_gr.TabIndex = 26;
            this.label_gr.Text = "gr";
            // 
            // label_m
            // 
            this.label_m.AutoSize = true;
            this.label_m.Location = new System.Drawing.Point(146, 257);
            this.label_m.Name = "label_m";
            this.label_m.Size = new System.Drawing.Size(15, 13);
            this.label_m.TabIndex = 27;
            this.label_m.Text = "m";
            // 
            // label_rech
            // 
            this.label_rech.AutoSize = true;
            this.label_rech.Location = new System.Drawing.Point(12, 327);
            this.label_rech.Name = "label_rech";
            this.label_rech.Size = new System.Drawing.Size(77, 13);
            this.label_rech.TabIndex = 28;
            this.label_rech.Text = "Rechargement";
            // 
            // comboBox_typeRech
            // 
            this.comboBox_typeRech.FormattingEnabled = true;
            this.comboBox_typeRech.Location = new System.Drawing.Point(149, 323);
            this.comboBox_typeRech.Name = "comboBox_typeRech";
            this.comboBox_typeRech.Size = new System.Drawing.Size(95, 21);
            this.comboBox_typeRech.TabIndex = 29;
            this.comboBox_typeRech.Text = "Action";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(276, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 318);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // listbox_attributs
            // 
            this.listbox_attributs.FormattingEnabled = true;
            this.listbox_attributs.Location = new System.Drawing.Point(95, 451);
            this.listbox_attributs.Name = "listbox_attributs";
            this.listbox_attributs.Size = new System.Drawing.Size(142, 121);
            this.listbox_attributs.TabIndex = 31;
            // 
            // groupBox_armeDetails
            // 
            this.groupBox_armeDetails.Controls.Add(this.numericUpDown_degValeur);
            this.groupBox_armeDetails.Controls.Add(this.comboBox_typeDeg);
            this.groupBox_armeDetails.Controls.Add(this.label_degDés);
            this.groupBox_armeDetails.Controls.Add(this.numericUpDown_rech);
            this.groupBox_armeDetails.Controls.Add(this.label_nomArme);
            this.groupBox_armeDetails.Controls.Add(this.listbox_attributs);
            this.groupBox_armeDetails.Controls.Add(this.pictureBox1);
            this.groupBox_armeDetails.Controls.Add(this.comboBox_typeRech);
            this.groupBox_armeDetails.Controls.Add(this.label_rech);
            this.groupBox_armeDetails.Controls.Add(this.label_m);
            this.groupBox_armeDetails.Controls.Add(this.label_gr);
            this.groupBox_armeDetails.Controls.Add(this.comboBox_cateArme);
            this.groupBox_armeDetails.Controls.Add(this.label_pds);
            this.groupBox_armeDetails.Controls.Add(this.numericUpDown_poids);
            this.groupBox_armeDetails.Controls.Add(this.comboBox_dispoArme);
            this.groupBox_armeDetails.Controls.Add(this.label_dispo);
            this.groupBox_armeDetails.Controls.Add(this.label_atts);
            this.groupBox_armeDetails.Controls.Add(this.numericUpDown_portee);
            this.groupBox_armeDetails.Controls.Add(this.label_pen);
            this.groupBox_armeDetails.Controls.Add(this.label_deg);
            this.groupBox_armeDetails.Controls.Add(this.label_at);
            this.groupBox_armeDetails.Controls.Add(this.numericUpDown_at);
            this.groupBox_armeDetails.Controls.Add(this.label_cadence);
            this.groupBox_armeDetails.Controls.Add(this.label_portee);
            this.groupBox_armeDetails.Controls.Add(this.textBox_cadence);
            this.groupBox_armeDetails.Controls.Add(this.numUpDown_pen);
            this.groupBox_armeDetails.Controls.Add(this.label_categorie);
            this.groupBox_armeDetails.Controls.Add(this.label_type);
            this.groupBox_armeDetails.Controls.Add(this.comboBox_typeArme);
            this.groupBox_armeDetails.Location = new System.Drawing.Point(459, 44);
            this.groupBox_armeDetails.Name = "groupBox_armeDetails";
            this.groupBox_armeDetails.Size = new System.Drawing.Size(582, 605);
            this.groupBox_armeDetails.TabIndex = 12;
            this.groupBox_armeDetails.TabStop = false;
            this.groupBox_armeDetails.Text = "Nom Arme";
            // 
            // numericUpDown_degValeur
            // 
            this.numericUpDown_degValeur.Location = new System.Drawing.Point(121, 166);
            this.numericUpDown_degValeur.Name = "numericUpDown_degValeur";
            this.numericUpDown_degValeur.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_degValeur.TabIndex = 36;
            this.numericUpDown_degValeur.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // comboBox_typeDeg
            // 
            this.comboBox_typeDeg.FormattingEnabled = true;
            this.comboBox_typeDeg.Location = new System.Drawing.Point(171, 166);
            this.comboBox_typeDeg.Name = "comboBox_typeDeg";
            this.comboBox_typeDeg.Size = new System.Drawing.Size(73, 21);
            this.comboBox_typeDeg.TabIndex = 35;
            this.comboBox_typeDeg.Text = "D";
            // 
            // label_degDés
            // 
            this.label_degDés.AutoSize = true;
            this.label_degDés.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_degDés.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_degDés.Location = new System.Drawing.Point(74, 168);
            this.label_degDés.Name = "label_degDés";
            this.label_degDés.Size = new System.Drawing.Size(44, 15);
            this.label_degDés.TabIndex = 34;
            this.label_degDés.Text = "1D10 +";
            // 
            // numericUpDown_rech
            // 
            this.numericUpDown_rech.Location = new System.Drawing.Point(95, 324);
            this.numericUpDown_rech.Name = "numericUpDown_rech";
            this.numericUpDown_rech.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown_rech.TabIndex = 33;
            this.numericUpDown_rech.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_nomArme
            // 
            this.label_nomArme.AutoSize = true;
            this.label_nomArme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nomArme.Location = new System.Drawing.Point(29, 34);
            this.label_nomArme.Name = "label_nomArme";
            this.label_nomArme.Size = new System.Drawing.Size(124, 25);
            this.label_nomArme.TabIndex = 32;
            this.label_nomArme.Text = "Nom_arme";
            // 
            // button_file
            // 
            this.button_file.Location = new System.Drawing.Point(311, 628);
            this.button_file.Name = "button_file";
            this.button_file.Size = new System.Drawing.Size(127, 21);
            this.button_file.TabIndex = 18;
            this.button_file.Text = "selectionner dossier";
            this.button_file.UseVisualStyleBackColor = true;
            this.button_file.Click += new System.EventHandler(this.button_file_Click);
            // 
            // EcranArmes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.button_file);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.groupBox_filtres);
            this.Controls.Add(this.comboBox_categories);
            this.Controls.Add(this.comboBox_sources);
            this.Controls.Add(this.grilleArmes);
            this.Controls.Add(this.button_import);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.groupBox_armeDetails);
            this.Name = "EcranArmes";
            this.Text = "Armes";
            ((System.ComponentModel.ISupportInitialize)(this.grilleArmes)).EndInit();
            this.groupBox_filtres.ResumeLayout(false);
            this.groupBox_filtres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_pen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_at)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_portee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_poids)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox_armeDetails.ResumeLayout(false);
            this.groupBox_armeDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_degValeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rech)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button button_export;
        private System.Windows.Forms.Button button_import;
        private System.Windows.Forms.DataGridView grilleArmes;
        private System.Windows.Forms.OpenFileDialog ImportDialog;
        private System.Windows.Forms.ComboBox comboBox_sources;
        private System.Windows.Forms.ComboBox comboBox_categories;
        private System.Windows.Forms.GroupBox groupBox_filtres;
        private System.Windows.Forms.CheckBox checkBox_dispo;
        private System.Windows.Forms.CheckBox checkBox_At;
        private System.Windows.Forms.CheckBox checkBox_pen;
        private System.Windows.Forms.CheckBox checkBox_portée;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.ComboBox comboBox_typeArme;
        private System.Windows.Forms.Label label_type;
        private System.Windows.Forms.Label label_categorie;
        private System.Windows.Forms.NumericUpDown numUpDown_pen;
        private System.Windows.Forms.TextBox textBox_cadence;
        private System.Windows.Forms.Label label_portee;
        private System.Windows.Forms.Label label_cadence;
        private System.Windows.Forms.NumericUpDown numericUpDown_at;
        private System.Windows.Forms.Label label_at;
        private System.Windows.Forms.Label label_deg;
        private System.Windows.Forms.Label label_pen;
        private System.Windows.Forms.NumericUpDown numericUpDown_portee;
        private System.Windows.Forms.Label label_atts;
        private System.Windows.Forms.Label label_dispo;
        private System.Windows.Forms.ComboBox comboBox_dispoArme;
        private System.Windows.Forms.NumericUpDown numericUpDown_poids;
        private System.Windows.Forms.Label label_pds;
        private System.Windows.Forms.ComboBox comboBox_cateArme;
        private System.Windows.Forms.Label label_gr;
        private System.Windows.Forms.Label label_m;
        private System.Windows.Forms.Label label_rech;
        private System.Windows.Forms.ComboBox comboBox_typeRech;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listbox_attributs;
        public System.Windows.Forms.GroupBox groupBox_armeDetails;
        private System.Windows.Forms.Label label_nomArme;
        private System.Windows.Forms.NumericUpDown numericUpDown_rech;
        private System.Windows.Forms.ComboBox comboBox_typeDeg;
        private System.Windows.Forms.Label label_degDés;
        private System.Windows.Forms.NumericUpDown numericUpDown_degValeur;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_file;
    }
}

