namespace ProjetFinal
{
    partial class frmAjoutAbonnement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label dateAbonnementLabel;
            System.Windows.Forms.Label dateNaissanceLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label noTypeAbonnementLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label villeLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.dtpDateAbonnement = new System.Windows.Forms.DateTimePicker();
            this.dtpNaissance = new System.Windows.Forms.DateTimePicker();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNoCivique = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.dependantsDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAjoutAbonnement = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAjoutDependant = new System.Windows.Forms.Button();
            this.cbTypeAbonnement = new System.Windows.Forms.ComboBox();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cellulaireLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            dateAbonnementLabel = new System.Windows.Forms.Label();
            dateNaissanceLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            noTypeAbonnementLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cellulaireLabel.Location = new System.Drawing.Point(582, 122);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(93, 24);
            cellulaireLabel.TabIndex = 1;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            codePostalLabel.Location = new System.Drawing.Point(45, 494);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(116, 24);
            codePostalLabel.TabIndex = 3;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            courrielLabel.Location = new System.Drawing.Point(582, 157);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(81, 24);
            courrielLabel.TabIndex = 5;
            courrielLabel.Text = "Courriel:";
            // 
            // dateAbonnementLabel
            // 
            dateAbonnementLabel.AutoSize = true;
            dateAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dateAbonnementLabel.Location = new System.Drawing.Point(582, 191);
            dateAbonnementLabel.Name = "dateAbonnementLabel";
            dateAbonnementLabel.Size = new System.Drawing.Size(185, 24);
            dateAbonnementLabel.TabIndex = 7;
            dateAbonnementLabel.Text = "Date d\'abonnement :";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dateNaissanceLabel.Location = new System.Drawing.Point(41, 260);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(170, 24);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date de naissance:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            idLabel.Location = new System.Drawing.Point(41, 121);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 24);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            idProvinceLabel.Location = new System.Drawing.Point(45, 528);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(89, 24);
            idProvinceLabel.TabIndex = 13;
            idProvinceLabel.Text = "Province:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noCiviqueLabel.Location = new System.Drawing.Point(45, 389);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(105, 24);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            nomLabel.Location = new System.Drawing.Point(41, 156);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(56, 24);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noTypeAbonnementLabel.Location = new System.Drawing.Point(41, 87);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(190, 24);
            noTypeAbonnementLabel.TabIndex = 19;
            noTypeAbonnementLabel.Text = "Type d\'abonnement :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            prenomLabel.Location = new System.Drawing.Point(41, 191);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(82, 24);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            remarqueLabel.Location = new System.Drawing.Point(582, 228);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(104, 24);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rueLabel.Location = new System.Drawing.Point(45, 424);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(50, 24);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            sexeLabel.Location = new System.Drawing.Point(41, 225);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(59, 24);
            sexeLabel.TabIndex = 27;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            telephoneLabel.Location = new System.Drawing.Point(582, 90);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(108, 24);
            telephoneLabel.TabIndex = 29;
            telephoneLabel.Text = "Téléphone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            villeLabel.Location = new System.Drawing.Point(45, 459);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(51, 24);
            villeLabel.TabIndex = 31;
            villeLabel.Text = "Ville:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(41, 45);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(453, 24);
            label1.TabIndex = 36;
            label1.Text = "Informations personnelles de l\'abonné principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(42, 343);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 24);
            label2.TabIndex = 37;
            label2.Text = "Adresse complète";
            // 
            // tbCourriel
            // 
            this.tbCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbCourriel.Location = new System.Drawing.Point(786, 150);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(249, 28);
            this.tbCourriel.TabIndex = 6;
            // 
            // dtpDateAbonnement
            // 
            this.dtpDateAbonnement.Enabled = false;
            this.dtpDateAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDateAbonnement.Location = new System.Drawing.Point(786, 188);
            this.dtpDateAbonnement.Name = "dtpDateAbonnement";
            this.dtpDateAbonnement.Size = new System.Drawing.Size(249, 28);
            this.dtpDateAbonnement.TabIndex = 8;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpNaissance.Location = new System.Drawing.Point(227, 256);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(327, 28);
            this.dtpNaissance.TabIndex = 10;
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbID.Location = new System.Drawing.Point(227, 116);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(327, 28);
            this.tbID.TabIndex = 12;
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNoCivique.Location = new System.Drawing.Point(231, 386);
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(200, 28);
            this.tbNoCivique.TabIndex = 16;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNom.Location = new System.Drawing.Point(227, 153);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(327, 28);
            this.tbNom.TabIndex = 18;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbPrenom.Location = new System.Drawing.Point(227, 188);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(327, 28);
            this.tbPrenom.TabIndex = 22;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRemarque.Location = new System.Drawing.Point(790, 225);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(249, 121);
            this.tbRemarque.TabIndex = 24;
            // 
            // tbRue
            // 
            this.tbRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRue.Location = new System.Drawing.Point(231, 421);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(200, 28);
            this.tbRue.TabIndex = 26;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(231, 456);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(200, 28);
            this.tbVille.TabIndex = 32;
            // 
            // dependantsDataGridView
            // 
            this.dependantsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dependantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dependantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dependantsDataGridView.Location = new System.Drawing.Point(459, 371);
            this.dependantsDataGridView.Name = "dependantsDataGridView";
            this.dependantsDataGridView.RowHeadersWidth = 51;
            this.dependantsDataGridView.RowTemplate.Height = 24;
            this.dependantsDataGridView.Size = new System.Drawing.Size(576, 261);
            this.dependantsDataGridView.TabIndex = 32;
            // 
            // btnAjoutAbonnement
            // 
            this.btnAjoutAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAjoutAbonnement.Location = new System.Drawing.Point(49, 570);
            this.btnAjoutAbonnement.Name = "btnAjoutAbonnement";
            this.btnAjoutAbonnement.Size = new System.Drawing.Size(156, 58);
            this.btnAjoutAbonnement.TabIndex = 33;
            this.btnAjoutAbonnement.Text = "Ajouter l\'abonnement";
            this.btnAjoutAbonnement.UseVisualStyleBackColor = true;
            this.btnAjoutAbonnement.Click += new System.EventHandler(this.btnAjoutAbonnement_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(275, 570);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 58);
            this.button2.TabIndex = 34;
            this.button2.Text = "Annuler l\'abonnement";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAjoutDependant
            // 
            this.btnAjoutDependant.Enabled = false;
            this.btnAjoutDependant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAjoutDependant.Location = new System.Drawing.Point(753, 638);
            this.btnAjoutDependant.Name = "btnAjoutDependant";
            this.btnAjoutDependant.Size = new System.Drawing.Size(268, 37);
            this.btnAjoutDependant.TabIndex = 35;
            this.btnAjoutDependant.Text = "Ajouter un dépendant";
            this.btnAjoutDependant.UseVisualStyleBackColor = true;
            this.btnAjoutDependant.Click += new System.EventHandler(this.btnAjoutDependant_Click);
            // 
            // cbTypeAbonnement
            // 
            this.cbTypeAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.cbTypeAbonnement.DisplayMember = "Description";
            this.cbTypeAbonnement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbTypeAbonnement.FormattingEnabled = true;
            this.cbTypeAbonnement.Location = new System.Drawing.Point(227, 80);
            this.cbTypeAbonnement.Name = "cbTypeAbonnement";
            this.cbTypeAbonnement.Size = new System.Drawing.Size(327, 30);
            this.cbTypeAbonnement.TabIndex = 38;
            this.cbTypeAbonnement.ValueMember = "No";
            this.cbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cbTypeAbonnement_SelectedIndexChanged);
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Location = new System.Drawing.Point(227, 222);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(327, 30);
            this.cbSexe.TabIndex = 39;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbTelephone.Location = new System.Drawing.Point(786, 86);
            this.mtbTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelephone.Mask = "(000)000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(249, 28);
            this.mtbTelephone.TabIndex = 57;
            this.mtbTelephone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCellulaire.Location = new System.Drawing.Point(786, 118);
            this.mtbCellulaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCellulaire.Mask = "(000)000-0000";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(249, 28);
            this.mtbCellulaire.TabIndex = 58;
            this.mtbCellulaire.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCodePostal.Location = new System.Drawing.Point(338, 491);
            this.mtbCodePostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCodePostal.Mask = "L0L 0L0";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(93, 28);
            this.mtbCodePostal.TabIndex = 59;
            this.mtbCodePostal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(175, 528);
            this.cbProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(256, 30);
            this.cbProvince.TabIndex = 60;
            this.cbProvince.ValueMember = "Id";
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataSource = typeof(ProjetFinal.Dependants);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetFinal.TypesAbonnement);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(ProjetFinal.Provinces);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 47;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 65;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Prenom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Prenom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 83;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Sexe";
            this.dataGridViewTextBoxColumn4.HeaderText = "Sexe";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 67;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DateNaissance";
            this.dataGridViewTextBoxColumn5.HeaderText = "DateNaissance";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 130;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "IdAbonnement";
            this.dataGridViewTextBoxColumn6.HeaderText = "IdAbonnement";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 123;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn7.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // frmAjoutAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 754);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.mtbCodePostal);
            this.Controls.Add(this.mtbCellulaire);
            this.Controls.Add(this.mtbTelephone);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.cbTypeAbonnement);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnAjoutDependant);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAjoutAbonnement);
            this.Controls.Add(this.dependantsDataGridView);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(dateAbonnementLabel);
            this.Controls.Add(this.dtpDateAbonnement);
            this.Controls.Add(dateNaissanceLabel);
            this.Controls.Add(this.dtpNaissance);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.tbID);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.tbNoCivique);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(noTypeAbonnementLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.tbVille);
            this.Name = "frmAjoutAbonnement";
            this.Text = "Ajout d\'un abonnement";
            this.Load += new System.EventHandler(this.frmAjoutAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dependantsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.DateTimePicker dtpDateAbonnement;
        private System.Windows.Forms.DateTimePicker dtpNaissance;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNoCivique;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.DataGridView dependantsDataGridView;
        private System.Windows.Forms.Button btnAjoutAbonnement;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAjoutDependant;
        private System.Windows.Forms.ComboBox cbTypeAbonnement;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbCellulaire;
        private System.Windows.Forms.MaskedTextBox mtbCodePostal;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}