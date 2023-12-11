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
            this.dgDependants = new System.Windows.Forms.DataGridView();
            this.btnAjoutAbonnement = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnAjoutDependant = new System.Windows.Forms.Button();
            this.cbTypeAbonnement = new System.Windows.Forms.ComboBox();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.numDependants = new System.Windows.Forms.NumericUpDown();
            this.dgNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbSexeD = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDependants)).BeginInit();
            this.SuspendLayout();
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cellulaireLabel.Location = new System.Drawing.Point(432, 78);
            cellulaireLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(93, 24);
            cellulaireLabel.TabIndex = 1;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            codePostalLabel.Location = new System.Drawing.Point(30, 368);
            codePostalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(116, 24);
            codePostalLabel.TabIndex = 3;
            codePostalLabel.Text = "Code Postal:";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            courrielLabel.Location = new System.Drawing.Point(432, 107);
            courrielLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(81, 24);
            courrielLabel.TabIndex = 5;
            courrielLabel.Text = "Courriel:";
            // 
            // dateAbonnementLabel
            // 
            dateAbonnementLabel.AutoSize = true;
            dateAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dateAbonnementLabel.Location = new System.Drawing.Point(432, 134);
            dateAbonnementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateAbonnementLabel.Name = "dateAbonnementLabel";
            dateAbonnementLabel.Size = new System.Drawing.Size(185, 24);
            dateAbonnementLabel.TabIndex = 7;
            dateAbonnementLabel.Text = "Date d\'abonnement :";
            // 
            // dateNaissanceLabel
            // 
            dateNaissanceLabel.AutoSize = true;
            dateNaissanceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dateNaissanceLabel.Location = new System.Drawing.Point(31, 193);
            dateNaissanceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            dateNaissanceLabel.Name = "dateNaissanceLabel";
            dateNaissanceLabel.Size = new System.Drawing.Size(170, 24);
            dateNaissanceLabel.TabIndex = 9;
            dateNaissanceLabel.Text = "Date de naissance:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            idLabel.Location = new System.Drawing.Point(31, 80);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(30, 24);
            idLabel.TabIndex = 11;
            idLabel.Text = "Id:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            idProvinceLabel.Location = new System.Drawing.Point(30, 396);
            idProvinceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(89, 24);
            idProvinceLabel.TabIndex = 13;
            idProvinceLabel.Text = "Province:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noCiviqueLabel.Location = new System.Drawing.Point(30, 283);
            noCiviqueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(105, 24);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No civique:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            nomLabel.Location = new System.Drawing.Point(31, 109);
            nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(56, 24);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeAbonnementLabel
            // 
            noTypeAbonnementLabel.AutoSize = true;
            noTypeAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noTypeAbonnementLabel.Location = new System.Drawing.Point(31, 53);
            noTypeAbonnementLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noTypeAbonnementLabel.Name = "noTypeAbonnementLabel";
            noTypeAbonnementLabel.Size = new System.Drawing.Size(190, 24);
            noTypeAbonnementLabel.TabIndex = 19;
            noTypeAbonnementLabel.Text = "Type d\'abonnement :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            prenomLabel.Location = new System.Drawing.Point(31, 137);
            prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(82, 24);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            remarqueLabel.Location = new System.Drawing.Point(432, 164);
            remarqueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(104, 24);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque:";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rueLabel.Location = new System.Drawing.Point(30, 311);
            rueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(50, 24);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            sexeLabel.Location = new System.Drawing.Point(31, 165);
            sexeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(59, 24);
            sexeLabel.TabIndex = 27;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            telephoneLabel.Location = new System.Drawing.Point(432, 52);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(108, 24);
            telephoneLabel.TabIndex = 29;
            telephoneLabel.Text = "Téléphone:";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            villeLabel.Location = new System.Drawing.Point(30, 340);
            villeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(51, 24);
            villeLabel.TabIndex = 31;
            villeLabel.Text = "Ville:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(31, 19);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(453, 24);
            label1.TabIndex = 36;
            label1.Text = "Informations personnelles de l\'abonné principal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(28, 246);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 24);
            label2.TabIndex = 37;
            label2.Text = "Adresse complète";
            // 
            // tbCourriel
            // 
            this.tbCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbCourriel.Location = new System.Drawing.Point(586, 101);
            this.tbCourriel.Margin = new System.Windows.Forms.Padding(2);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(188, 28);
            this.tbCourriel.TabIndex = 6;
            this.tbCourriel.Text = "g@gmail.com";
            // 
            // dtpDateAbonnement
            // 
            this.dtpDateAbonnement.Enabled = false;
            this.dtpDateAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpDateAbonnement.Location = new System.Drawing.Point(586, 132);
            this.dtpDateAbonnement.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateAbonnement.Name = "dtpDateAbonnement";
            this.dtpDateAbonnement.Size = new System.Drawing.Size(188, 28);
            this.dtpDateAbonnement.TabIndex = 8;
            // 
            // dtpNaissance
            // 
            this.dtpNaissance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.dtpNaissance.Location = new System.Drawing.Point(170, 190);
            this.dtpNaissance.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNaissance.Name = "dtpNaissance";
            this.dtpNaissance.Size = new System.Drawing.Size(246, 28);
            this.dtpNaissance.TabIndex = 10;
            this.dtpNaissance.Value = new System.DateTime(1990, 11, 15, 8, 34, 0, 0);
            // 
            // tbID
            // 
            this.tbID.Enabled = false;
            this.tbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbID.Location = new System.Drawing.Point(170, 76);
            this.tbID.Margin = new System.Windows.Forms.Padding(2);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(246, 28);
            this.tbID.TabIndex = 12;
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNoCivique.Location = new System.Drawing.Point(169, 281);
            this.tbNoCivique.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(151, 28);
            this.tbNoCivique.TabIndex = 16;
            this.tbNoCivique.Text = "432";
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNom.Location = new System.Drawing.Point(170, 106);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(246, 28);
            this.tbNom.TabIndex = 18;
            this.tbNom.Text = "Luc";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbPrenom.Location = new System.Drawing.Point(170, 135);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(246, 28);
            this.tbPrenom.TabIndex = 22;
            this.tbPrenom.Text = "Liam";
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRemarque.Location = new System.Drawing.Point(586, 162);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(2);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(188, 70);
            this.tbRemarque.TabIndex = 24;
            // 
            // tbRue
            // 
            this.tbRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRue.Location = new System.Drawing.Point(169, 309);
            this.tbRue.Margin = new System.Windows.Forms.Padding(2);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(151, 28);
            this.tbRue.TabIndex = 26;
            this.tbRue.Text = "Limace";
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVille.Location = new System.Drawing.Point(169, 337);
            this.tbVille.Margin = new System.Windows.Forms.Padding(2);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(151, 28);
            this.tbVille.TabIndex = 32;
            this.tbVille.Text = "Kirkland";
            // 
            // dgDependants
            // 
            this.dgDependants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDependants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDependants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgNom,
            this.dgPrenom,
            this.cbSexeD,
            this.dgDate,
            this.dgRemarque});
            this.dgDependants.Location = new System.Drawing.Point(342, 265);
            this.dgDependants.Margin = new System.Windows.Forms.Padding(2);
            this.dgDependants.Name = "dgDependants";
            this.dgDependants.RowHeadersWidth = 51;
            this.dgDependants.RowTemplate.Height = 24;
            this.dgDependants.Size = new System.Drawing.Size(432, 212);
            this.dgDependants.TabIndex = 32;
            this.dgDependants.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDependants_CellClick);
            this.dgDependants.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDependants_RowValidating);
            this.dgDependants.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgDependants_Scroll);
            this.dgDependants.UserAddedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dgDependants_UserAddedRow);
            // 
            // btnAjoutAbonnement
            // 
            this.btnAjoutAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAjoutAbonnement.Location = new System.Drawing.Point(33, 430);
            this.btnAjoutAbonnement.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutAbonnement.Name = "btnAjoutAbonnement";
            this.btnAjoutAbonnement.Size = new System.Drawing.Size(117, 47);
            this.btnAjoutAbonnement.TabIndex = 33;
            this.btnAjoutAbonnement.Text = "Ajouter l\'abonnement";
            this.btnAjoutAbonnement.UseVisualStyleBackColor = true;
            this.btnAjoutAbonnement.Click += new System.EventHandler(this.btnAjoutAbonnement_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAnnuler.Location = new System.Drawing.Point(202, 430);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(117, 47);
            this.btnAnnuler.TabIndex = 34;
            this.btnAnnuler.Text = "Annuler l\'abonnement";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnAjoutDependant
            // 
            this.btnAjoutDependant.Enabled = false;
            this.btnAjoutDependant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAjoutDependant.Location = new System.Drawing.Point(436, 481);
            this.btnAjoutDependant.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjoutDependant.Name = "btnAjoutDependant";
            this.btnAjoutDependant.Size = new System.Drawing.Size(338, 30);
            this.btnAjoutDependant.TabIndex = 35;
            this.btnAjoutDependant.Text = "Ajouter un abonnement et ses dépendants";
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
            this.cbTypeAbonnement.Location = new System.Drawing.Point(170, 47);
            this.cbTypeAbonnement.Margin = new System.Windows.Forms.Padding(2);
            this.cbTypeAbonnement.Name = "cbTypeAbonnement";
            this.cbTypeAbonnement.Size = new System.Drawing.Size(246, 30);
            this.cbTypeAbonnement.TabIndex = 38;
            this.cbTypeAbonnement.ValueMember = "No";
            this.cbTypeAbonnement.SelectedIndexChanged += new System.EventHandler(this.cbTypeAbonnement_SelectedIndexChanged);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetFinal.TypesAbonnement);
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Location = new System.Drawing.Point(170, 162);
            this.cbSexe.Margin = new System.Windows.Forms.Padding(2);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(246, 30);
            this.cbSexe.TabIndex = 39;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbTelephone.Location = new System.Drawing.Point(586, 49);
            this.mtbTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTelephone.Mask = "(000)000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(188, 28);
            this.mtbTelephone.TabIndex = 57;
            this.mtbTelephone.Text = "5143334444";
            this.mtbTelephone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCellulaire.Location = new System.Drawing.Point(586, 75);
            this.mtbCellulaire.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCellulaire.Mask = "(000)000-0000";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(188, 28);
            this.mtbCellulaire.TabIndex = 58;
            this.mtbCellulaire.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCodePostal.Location = new System.Drawing.Point(250, 366);
            this.mtbCodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCodePostal.Mask = "L0L 0L0";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(71, 28);
            this.mtbCodePostal.TabIndex = 59;
            this.mtbCodePostal.Text = "D3D3D3";
            this.mtbCodePostal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(127, 396);
            this.cbProvince.Margin = new System.Windows.Forms.Padding(2);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(193, 30);
            this.cbProvince.TabIndex = 60;
            this.cbProvince.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(ProjetFinal.Provinces);
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataSource = typeof(ProjetFinal.Dependants);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // numDependants
            // 
            this.numDependants.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.numDependants.Location = new System.Drawing.Point(654, 237);
            this.numDependants.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numDependants.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDependants.Name = "numDependants";
            this.numDependants.Size = new System.Drawing.Size(120, 23);
            this.numDependants.TabIndex = 61;
            this.numDependants.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDependants.Visible = false;
            this.numDependants.ValueChanged += new System.EventHandler(this.numDependants_ValueChanged);
            // 
            // dgNom
            // 
            this.dgNom.DataPropertyName = "Nom";
            this.dgNom.HeaderText = "Nom";
            this.dgNom.MinimumWidth = 6;
            this.dgNom.Name = "dgNom";
            this.dgNom.Width = 63;
            // 
            // dgPrenom
            // 
            this.dgPrenom.DataPropertyName = "Prenom";
            this.dgPrenom.HeaderText = "Prénom";
            this.dgPrenom.MinimumWidth = 6;
            this.dgPrenom.Name = "dgPrenom";
            this.dgPrenom.Width = 80;
            // 
            // cbSexeD
            // 
            this.cbSexeD.DataPropertyName = "Sexe";
            this.cbSexeD.HeaderText = "Sexe";
            this.cbSexeD.MinimumWidth = 6;
            this.cbSexeD.Name = "cbSexeD";
            this.cbSexeD.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cbSexeD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cbSexeD.Width = 64;
            // 
            // dgDate
            // 
            this.dgDate.DataPropertyName = "DateNaissance";
            this.dgDate.HeaderText = "Date de naissance";
            this.dgDate.MinimumWidth = 6;
            this.dgDate.Name = "dgDate";
            this.dgDate.Width = 127;
            // 
            // dgRemarque
            // 
            this.dgRemarque.DataPropertyName = "Remarque";
            this.dgRemarque.HeaderText = "Remarque";
            this.dgRemarque.MinimumWidth = 6;
            this.dgRemarque.Name = "dgRemarque";
            this.dgRemarque.Width = 95;
            // 
            // frmAjoutAbonnement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 537);
            this.Controls.Add(this.numDependants);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.mtbCodePostal);
            this.Controls.Add(this.mtbCellulaire);
            this.Controls.Add(this.mtbTelephone);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.cbTypeAbonnement);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnAjoutDependant);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjoutAbonnement);
            this.Controls.Add(this.dgDependants);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAjoutAbonnement";
            this.Text = "Ajout d\'un abonnement";
            this.Load += new System.EventHandler(this.frmAjoutAbonnement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDependants)).EndInit();
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
        private System.Windows.Forms.DataGridView dgDependants;
        private System.Windows.Forms.Button btnAjoutAbonnement;
        private System.Windows.Forms.Button btnAnnuler;
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
        private System.Windows.Forms.NumericUpDown numDependants;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrenom;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbSexeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarque;
    }
}