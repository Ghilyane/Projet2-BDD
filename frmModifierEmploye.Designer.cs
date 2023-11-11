namespace ProjetFinal
{
    partial class frmModifierEmploye
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label cellulaireLabel;
            System.Windows.Forms.Label codePostalLabel;
            System.Windows.Forms.Label courrielLabel;
            System.Windows.Forms.Label idProvinceLabel;
            System.Windows.Forms.Label motDePasseLabel;
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label noCiviqueLabel;
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label noTypeEmployeLabel;
            System.Windows.Forms.Label prenomLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label rueLabel;
            System.Windows.Forms.Label salaireHoraireLabel;
            System.Windows.Forms.Label sexeLabel;
            System.Windows.Forms.Label telephoneLabel;
            System.Windows.Forms.Label villeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModifierEmploye));
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbTypeEmploye = new System.Windows.Forms.ComboBox();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nudSalaire = new System.Windows.Forms.NumericUpDown();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbNoCivique = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            cellulaireLabel = new System.Windows.Forms.Label();
            codePostalLabel = new System.Windows.Forms.Label();
            courrielLabel = new System.Windows.Forms.Label();
            idProvinceLabel = new System.Windows.Forms.Label();
            motDePasseLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            noCiviqueLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            noTypeEmployeLabel = new System.Windows.Forms.Label();
            prenomLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            rueLabel = new System.Windows.Forms.Label();
            salaireHoraireLabel = new System.Windows.Forms.Label();
            sexeLabel = new System.Windows.Forms.Label();
            telephoneLabel = new System.Windows.Forms.Label();
            villeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label4.Location = new System.Drawing.Point(690, 93);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(20, 24);
            label4.TabIndex = 95;
            label4.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(259, 215);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(250, 24);
            label3.TabIndex = 93;
            label3.Text = "Informations personnelles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(294, 413);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 24);
            label2.TabIndex = 92;
            label2.Text = "Adresse complète";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            ageLabel.Location = new System.Drawing.Point(34, 325);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(55, 24);
            ageLabel.TabIndex = 63;
            ageLabel.Text = "Âge :";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cellulaireLabel.Location = new System.Drawing.Point(430, 303);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(93, 24);
            cellulaireLabel.TabIndex = 64;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            codePostalLabel.Location = new System.Drawing.Point(34, 603);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(120, 24);
            codePostalLabel.TabIndex = 65;
            codePostalLabel.Text = "Code postal :";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            courrielLabel.Location = new System.Drawing.Point(430, 340);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(81, 24);
            courrielLabel.TabIndex = 66;
            courrielLabel.Text = "Courriel:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            idProvinceLabel.Location = new System.Drawing.Point(34, 569);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(94, 24);
            idProvinceLabel.TabIndex = 68;
            idProvinceLabel.Text = "Province :";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            motDePasseLabel.Location = new System.Drawing.Point(230, 58);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(133, 24);
            motDePasseLabel.TabIndex = 69;
            motDePasseLabel.Text = "Mot de passe :";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noLabel.Location = new System.Drawing.Point(83, 158);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(40, 24);
            noLabel.TabIndex = 71;
            noLabel.Text = "No:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noCiviqueLabel.Location = new System.Drawing.Point(34, 466);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(110, 24);
            noCiviqueLabel.TabIndex = 73;
            noCiviqueLabel.Text = "No civique :";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            nomLabel.Location = new System.Drawing.Point(34, 263);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(56, 24);
            nomLabel.TabIndex = 75;
            nomLabel.Text = "Nom:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noTypeEmployeLabel.Location = new System.Drawing.Point(230, 21);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(156, 24);
            noTypeEmployeLabel.TabIndex = 77;
            noTypeEmployeLabel.Text = "Type d\'employé :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            prenomLabel.Location = new System.Drawing.Point(34, 293);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(87, 24);
            prenomLabel.TabIndex = 78;
            prenomLabel.Text = "Prénom :";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            remarqueLabel.Location = new System.Drawing.Point(551, 466);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(125, 24);
            remarqueLabel.TabIndex = 80;
            remarqueLabel.Text = "Remarque(s):";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rueLabel.Location = new System.Drawing.Point(34, 500);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(50, 24);
            rueLabel.TabIndex = 82;
            rueLabel.Text = "Rue:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            salaireHoraireLabel.Location = new System.Drawing.Point(230, 91);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(141, 24);
            salaireHoraireLabel.TabIndex = 84;
            salaireHoraireLabel.Text = "Salaire horaire :";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            sexeLabel.Location = new System.Drawing.Point(34, 359);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(59, 24);
            sexeLabel.TabIndex = 85;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            telephoneLabel.Location = new System.Drawing.Point(430, 263);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(113, 24);
            telephoneLabel.TabIndex = 86;
            telephoneLabel.Text = "Téléphone :";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            villeLabel.Location = new System.Drawing.Point(31, 533);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(51, 24);
            villeLabel.TabIndex = 87;
            villeLabel.Text = "Ville:";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAnnuler.Location = new System.Drawing.Point(622, 658);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(119, 37);
            this.btnAnnuler.TabIndex = 104;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnModifier.Location = new System.Drawing.Point(489, 658);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(119, 37);
            this.btnModifier.TabIndex = 103;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Location = new System.Drawing.Point(159, 352);
            this.cbSexe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(176, 30);
            this.cbSexe.TabIndex = 102;
            // 
            // nudAge
            // 
            this.nudAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudAge.Location = new System.Drawing.Point(211, 320);
            this.nudAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudAge.Maximum = new decimal(new int[] {
            65,
            0,
            0,
            0});
            this.nudAge.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(124, 28);
            this.nudAge.TabIndex = 101;
            this.nudAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAge.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCodePostal.Location = new System.Drawing.Point(342, 603);
            this.mtbCodePostal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCodePostal.Mask = "L0L 0L0";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(73, 28);
            this.mtbCodePostal.TabIndex = 100;
            this.mtbCodePostal.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCellulaire.Location = new System.Drawing.Point(557, 303);
            this.mtbCellulaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbCellulaire.Mask = "(000)000-0000";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(185, 28);
            this.mtbCellulaire.TabIndex = 99;
            this.mtbCellulaire.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbTelephone.Location = new System.Drawing.Point(557, 264);
            this.mtbTelephone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mtbTelephone.Mask = "(000)000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(185, 28);
            this.mtbTelephone.TabIndex = 98;
            this.mtbTelephone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(159, 567);
            this.cbProvince.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(256, 30);
            this.cbProvince.TabIndex = 97;
            this.cbProvince.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(ProjetFinal.Provinces);
            // 
            // cbTypeEmploye
            // 
            this.cbTypeEmploye.DataSource = this.typesEmployeBindingSource;
            this.cbTypeEmploye.DisplayMember = "Description";
            this.cbTypeEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeEmploye.Enabled = false;
            this.cbTypeEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbTypeEmploye.FormattingEnabled = true;
            this.cbTypeEmploye.Location = new System.Drawing.Point(469, 20);
            this.cbTypeEmploye.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTypeEmploye.Name = "cbTypeEmploye";
            this.cbTypeEmploye.Size = new System.Drawing.Size(243, 30);
            this.cbTypeEmploye.TabIndex = 96;
            this.cbTypeEmploye.ValueMember = "No";
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(ProjetFinal.TypesEmploye);
            // 
            // nudSalaire
            // 
            this.nudSalaire.DecimalPlaces = 2;
            this.nudSalaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudSalaire.Location = new System.Drawing.Point(559, 91);
            this.nudSalaire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSalaire.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nudSalaire.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSalaire.Name = "nudSalaire";
            this.nudSalaire.Size = new System.Drawing.Size(124, 28);
            this.nudSalaire.TabIndex = 94;
            this.nudSalaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSalaire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(54, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 128);
            this.pictureBox1.TabIndex = 89;
            this.pictureBox1.TabStop = false;
            // 
            // tbCourriel
            // 
            this.tbCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbCourriel.Location = new System.Drawing.Point(557, 338);
            this.tbCourriel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(185, 28);
            this.tbCourriel.TabIndex = 67;
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbMDP.Location = new System.Drawing.Point(469, 55);
            this.tbMDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(243, 28);
            this.tbMDP.TabIndex = 70;
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNo.Location = new System.Drawing.Point(141, 154);
            this.tbNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(71, 28);
            this.tbNo.TabIndex = 72;
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNoCivique.Location = new System.Drawing.Point(342, 462);
            this.tbNoCivique.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(73, 28);
            this.tbNoCivique.TabIndex = 74;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNom.Location = new System.Drawing.Point(159, 259);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(175, 28);
            this.tbNom.TabIndex = 76;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbPrenom.Location = new System.Drawing.Point(159, 290);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(175, 28);
            this.tbPrenom.TabIndex = 79;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRemarque.Location = new System.Drawing.Point(469, 500);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(272, 132);
            this.tbRemarque.TabIndex = 81;
            // 
            // tbRue
            // 
            this.tbRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRue.Location = new System.Drawing.Point(159, 496);
            this.tbRue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(256, 28);
            this.tbRue.TabIndex = 83;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbVille.Location = new System.Drawing.Point(159, 530);
            this.tbVille.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(256, 28);
            this.tbVille.TabIndex = 88;
            // 
            // frmModifierEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 714);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cbSexe);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.mtbCodePostal);
            this.Controls.Add(this.mtbCellulaire);
            this.Controls.Add(this.mtbTelephone);
            this.Controls.Add(this.cbProvince);
            this.Controls.Add(this.cbTypeEmploye);
            this.Controls.Add(label4);
            this.Controls.Add(this.nudSalaire);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(ageLabel);
            this.Controls.Add(cellulaireLabel);
            this.Controls.Add(codePostalLabel);
            this.Controls.Add(courrielLabel);
            this.Controls.Add(this.tbCourriel);
            this.Controls.Add(idProvinceLabel);
            this.Controls.Add(motDePasseLabel);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.tbNo);
            this.Controls.Add(noCiviqueLabel);
            this.Controls.Add(this.tbNoCivique);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(noTypeEmployeLabel);
            this.Controls.Add(prenomLabel);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(rueLabel);
            this.Controls.Add(this.tbRue);
            this.Controls.Add(salaireHoraireLabel);
            this.Controls.Add(sexeLabel);
            this.Controls.Add(telephoneLabel);
            this.Controls.Add(villeLabel);
            this.Controls.Add(this.tbVille);
            this.Name = "frmModifierEmploye";
            this.Text = "Modification d\'un employé";
            this.Load += new System.EventHandler(this.frmModifierEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.MaskedTextBox mtbCodePostal;
        private System.Windows.Forms.MaskedTextBox mtbCellulaire;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.ComboBox cbTypeEmploye;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.NumericUpDown nudSalaire;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbNoCivique;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
    }
}