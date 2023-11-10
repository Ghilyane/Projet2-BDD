namespace ProjetFinal
{
    partial class frmAjoutEmploye
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjoutEmploye));
            this.tbCourriel = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbNo = new System.Windows.Forms.TextBox();
            this.tbNoCivique = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.tbRue = new System.Windows.Forms.TextBox();
            this.tbVille = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbMDPConfirme = new System.Windows.Forms.TextBox();
            this.nudSalaire = new System.Windows.Forms.NumericUpDown();
            this.cbTypeEmploye = new System.Windows.Forms.ComboBox();
            this.typesEmployeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbProvince = new System.Windows.Forms.ComboBox();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mtbTelephone = new System.Windows.Forms.MaskedTextBox();
            this.mtbCellulaire = new System.Windows.Forms.MaskedTextBox();
            this.mtbCodePostal = new System.Windows.Forms.MaskedTextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.cbSexe = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            ageLabel.Location = new System.Drawing.Point(24, 270);
            ageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(41, 18);
            ageLabel.TabIndex = 1;
            ageLabel.Text = "Âge :";
            // 
            // cellulaireLabel
            // 
            cellulaireLabel.AutoSize = true;
            cellulaireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            cellulaireLabel.Location = new System.Drawing.Point(321, 252);
            cellulaireLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cellulaireLabel.Name = "cellulaireLabel";
            cellulaireLabel.Size = new System.Drawing.Size(72, 18);
            cellulaireLabel.TabIndex = 3;
            cellulaireLabel.Text = "Cellulaire:";
            // 
            // codePostalLabel
            // 
            codePostalLabel.AutoSize = true;
            codePostalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            codePostalLabel.Location = new System.Drawing.Point(24, 496);
            codePostalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            codePostalLabel.Name = "codePostalLabel";
            codePostalLabel.Size = new System.Drawing.Size(96, 18);
            codePostalLabel.TabIndex = 5;
            codePostalLabel.Text = "Code postal :";
            // 
            // courrielLabel
            // 
            courrielLabel.AutoSize = true;
            courrielLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            courrielLabel.Location = new System.Drawing.Point(321, 282);
            courrielLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            courrielLabel.Name = "courrielLabel";
            courrielLabel.Size = new System.Drawing.Size(64, 18);
            courrielLabel.TabIndex = 7;
            courrielLabel.Text = "Courriel:";
            // 
            // idProvinceLabel
            // 
            idProvinceLabel.AutoSize = true;
            idProvinceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            idProvinceLabel.Location = new System.Drawing.Point(24, 468);
            idProvinceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idProvinceLabel.Name = "idProvinceLabel";
            idProvinceLabel.Size = new System.Drawing.Size(74, 18);
            idProvinceLabel.TabIndex = 9;
            idProvinceLabel.Text = "Province :";
            // 
            // motDePasseLabel
            // 
            motDePasseLabel.AutoSize = true;
            motDePasseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            motDePasseLabel.Location = new System.Drawing.Point(171, 53);
            motDePasseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            motDePasseLabel.Name = "motDePasseLabel";
            motDePasseLabel.Size = new System.Drawing.Size(106, 18);
            motDePasseLabel.TabIndex = 11;
            motDePasseLabel.Text = "Mot de passe :";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noLabel.Location = new System.Drawing.Point(61, 134);
            noLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(32, 18);
            noLabel.TabIndex = 13;
            noLabel.Text = "No:";
            // 
            // noCiviqueLabel
            // 
            noCiviqueLabel.AutoSize = true;
            noCiviqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noCiviqueLabel.Location = new System.Drawing.Point(24, 384);
            noCiviqueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noCiviqueLabel.Name = "noCiviqueLabel";
            noCiviqueLabel.Size = new System.Drawing.Size(85, 18);
            noCiviqueLabel.TabIndex = 15;
            noCiviqueLabel.Text = "No civique :";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            nomLabel.Location = new System.Drawing.Point(24, 219);
            nomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(45, 18);
            nomLabel.TabIndex = 17;
            nomLabel.Text = "Nom:";
            // 
            // noTypeEmployeLabel
            // 
            noTypeEmployeLabel.AutoSize = true;
            noTypeEmployeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            noTypeEmployeLabel.Location = new System.Drawing.Point(171, 23);
            noTypeEmployeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            noTypeEmployeLabel.Name = "noTypeEmployeLabel";
            noTypeEmployeLabel.Size = new System.Drawing.Size(119, 18);
            noTypeEmployeLabel.TabIndex = 19;
            noTypeEmployeLabel.Text = "Type d\'employé :";
            // 
            // prenomLabel
            // 
            prenomLabel.AutoSize = true;
            prenomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            prenomLabel.Location = new System.Drawing.Point(24, 244);
            prenomLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            prenomLabel.Name = "prenomLabel";
            prenomLabel.Size = new System.Drawing.Size(69, 18);
            prenomLabel.TabIndex = 21;
            prenomLabel.Text = "Prénom :";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            remarqueLabel.Location = new System.Drawing.Point(412, 384);
            remarqueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(99, 18);
            remarqueLabel.TabIndex = 23;
            remarqueLabel.Text = "Remarque(s):";
            // 
            // rueLabel
            // 
            rueLabel.AutoSize = true;
            rueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            rueLabel.Location = new System.Drawing.Point(24, 412);
            rueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rueLabel.Name = "rueLabel";
            rueLabel.Size = new System.Drawing.Size(39, 18);
            rueLabel.TabIndex = 25;
            rueLabel.Text = "Rue:";
            // 
            // salaireHoraireLabel
            // 
            salaireHoraireLabel.AutoSize = true;
            salaireHoraireLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            salaireHoraireLabel.Location = new System.Drawing.Point(171, 106);
            salaireHoraireLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            salaireHoraireLabel.Name = "salaireHoraireLabel";
            salaireHoraireLabel.Size = new System.Drawing.Size(111, 18);
            salaireHoraireLabel.TabIndex = 27;
            salaireHoraireLabel.Text = "Salaire horaire :";
            // 
            // sexeLabel
            // 
            sexeLabel.AutoSize = true;
            sexeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            sexeLabel.Location = new System.Drawing.Point(24, 297);
            sexeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sexeLabel.Name = "sexeLabel";
            sexeLabel.Size = new System.Drawing.Size(45, 18);
            sexeLabel.TabIndex = 29;
            sexeLabel.Text = "Sexe:";
            // 
            // telephoneLabel
            // 
            telephoneLabel.AutoSize = true;
            telephoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            telephoneLabel.Location = new System.Drawing.Point(321, 219);
            telephoneLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telephoneLabel.Name = "telephoneLabel";
            telephoneLabel.Size = new System.Drawing.Size(85, 18);
            telephoneLabel.TabIndex = 31;
            telephoneLabel.Text = "Téléphone :";
            // 
            // villeLabel
            // 
            villeLabel.AutoSize = true;
            villeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            villeLabel.Location = new System.Drawing.Point(22, 439);
            villeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            villeLabel.Name = "villeLabel";
            villeLabel.Size = new System.Drawing.Size(38, 18);
            villeLabel.TabIndex = 33;
            villeLabel.Text = "Ville:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label1.Location = new System.Drawing.Point(171, 81);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(176, 18);
            label1.TabIndex = 48;
            label1.Text = "Confirmer mot de passe :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(212, 341);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(143, 18);
            label2.TabIndex = 50;
            label2.Text = "Adresse complète";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(193, 180);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(203, 18);
            label3.TabIndex = 51;
            label3.Text = "Informations personnelles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            label4.Location = new System.Drawing.Point(516, 107);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(16, 18);
            label4.TabIndex = 53;
            label4.Text = "$";
            // 
            // tbCourriel
            // 
            this.tbCourriel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbCourriel.Location = new System.Drawing.Point(416, 280);
            this.tbCourriel.Margin = new System.Windows.Forms.Padding(2);
            this.tbCourriel.Name = "tbCourriel";
            this.tbCourriel.Size = new System.Drawing.Size(140, 24);
            this.tbCourriel.TabIndex = 8;
            // 
            // tbMDP
            // 
            this.tbMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbMDP.Location = new System.Drawing.Point(350, 50);
            this.tbMDP.Margin = new System.Windows.Forms.Padding(2);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(183, 24);
            this.tbMDP.TabIndex = 12;
            // 
            // tbNo
            // 
            this.tbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNo.Location = new System.Drawing.Point(104, 131);
            this.tbNo.Margin = new System.Windows.Forms.Padding(2);
            this.tbNo.Name = "tbNo";
            this.tbNo.ReadOnly = true;
            this.tbNo.Size = new System.Drawing.Size(54, 24);
            this.tbNo.TabIndex = 14;
            // 
            // tbNoCivique
            // 
            this.tbNoCivique.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNoCivique.Location = new System.Drawing.Point(255, 381);
            this.tbNoCivique.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoCivique.Name = "tbNoCivique";
            this.tbNoCivique.Size = new System.Drawing.Size(56, 24);
            this.tbNoCivique.TabIndex = 16;
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbNom.Location = new System.Drawing.Point(118, 216);
            this.tbNom.Margin = new System.Windows.Forms.Padding(2);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(132, 24);
            this.tbNom.TabIndex = 18;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbPrenom.Location = new System.Drawing.Point(118, 241);
            this.tbPrenom.Margin = new System.Windows.Forms.Padding(2);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(132, 24);
            this.tbPrenom.TabIndex = 22;
            // 
            // tbRemarque
            // 
            this.tbRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRemarque.Location = new System.Drawing.Point(350, 412);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(2);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(205, 108);
            this.tbRemarque.TabIndex = 24;
            // 
            // tbRue
            // 
            this.tbRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbRue.Location = new System.Drawing.Point(118, 409);
            this.tbRue.Margin = new System.Windows.Forms.Padding(2);
            this.tbRue.Name = "tbRue";
            this.tbRue.Size = new System.Drawing.Size(193, 24);
            this.tbRue.TabIndex = 26;
            // 
            // tbVille
            // 
            this.tbVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbVille.Location = new System.Drawing.Point(118, 436);
            this.tbVille.Margin = new System.Windows.Forms.Padding(2);
            this.tbVille.Name = "tbVille";
            this.tbVille.Size = new System.Drawing.Size(193, 24);
            this.tbVille.TabIndex = 34;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(39, 22);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 104);
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // tbMDPConfirme
            // 
            this.tbMDPConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbMDPConfirme.Location = new System.Drawing.Point(350, 78);
            this.tbMDPConfirme.Margin = new System.Windows.Forms.Padding(2);
            this.tbMDPConfirme.Name = "tbMDPConfirme";
            this.tbMDPConfirme.Size = new System.Drawing.Size(183, 24);
            this.tbMDPConfirme.TabIndex = 49;
            // 
            // nudSalaire
            // 
            this.nudSalaire.DecimalPlaces = 2;
            this.nudSalaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudSalaire.Location = new System.Drawing.Point(418, 106);
            this.nudSalaire.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudSalaire.Size = new System.Drawing.Size(93, 24);
            this.nudSalaire.TabIndex = 52;
            this.nudSalaire.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSalaire.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbTypeEmploye
            // 
            this.cbTypeEmploye.DataSource = this.typesEmployeBindingSource;
            this.cbTypeEmploye.DisplayMember = "Description";
            this.cbTypeEmploye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbTypeEmploye.FormattingEnabled = true;
            this.cbTypeEmploye.Location = new System.Drawing.Point(350, 22);
            this.cbTypeEmploye.Margin = new System.Windows.Forms.Padding(2);
            this.cbTypeEmploye.Name = "cbTypeEmploye";
            this.cbTypeEmploye.Size = new System.Drawing.Size(183, 26);
            this.cbTypeEmploye.TabIndex = 54;
            this.cbTypeEmploye.ValueMember = "No";
            // 
            // typesEmployeBindingSource
            // 
            this.typesEmployeBindingSource.DataSource = typeof(ProjetFinal.TypesEmploye);
            // 
            // cbProvince
            // 
            this.cbProvince.DataSource = this.provincesBindingSource;
            this.cbProvince.DisplayMember = "Nom";
            this.cbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbProvince.FormattingEnabled = true;
            this.cbProvince.Location = new System.Drawing.Point(118, 466);
            this.cbProvince.Margin = new System.Windows.Forms.Padding(2);
            this.cbProvince.Name = "cbProvince";
            this.cbProvince.Size = new System.Drawing.Size(193, 26);
            this.cbProvince.TabIndex = 55;
            this.cbProvince.ValueMember = "Id";
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(ProjetFinal.Provinces);
            // 
            // mtbTelephone
            // 
            this.mtbTelephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbTelephone.Location = new System.Drawing.Point(416, 220);
            this.mtbTelephone.Margin = new System.Windows.Forms.Padding(2);
            this.mtbTelephone.Mask = "(000)000-0000";
            this.mtbTelephone.Name = "mtbTelephone";
            this.mtbTelephone.Size = new System.Drawing.Size(140, 24);
            this.mtbTelephone.TabIndex = 56;
            // 
            // mtbCellulaire
            // 
            this.mtbCellulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCellulaire.Location = new System.Drawing.Point(416, 252);
            this.mtbCellulaire.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCellulaire.Mask = "(000)000-0000";
            this.mtbCellulaire.Name = "mtbCellulaire";
            this.mtbCellulaire.Size = new System.Drawing.Size(140, 24);
            this.mtbCellulaire.TabIndex = 57;
            // 
            // mtbCodePostal
            // 
            this.mtbCodePostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.mtbCodePostal.Location = new System.Drawing.Point(255, 496);
            this.mtbCodePostal.Margin = new System.Windows.Forms.Padding(2);
            this.mtbCodePostal.Mask = "L0L 0L0";
            this.mtbCodePostal.Name = "mtbCodePostal";
            this.mtbCodePostal.Size = new System.Drawing.Size(56, 24);
            this.mtbCodePostal.TabIndex = 58;
            // 
            // nudAge
            // 
            this.nudAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.nudAge.Location = new System.Drawing.Point(157, 266);
            this.nudAge.Margin = new System.Windows.Forms.Padding(2);
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
            this.nudAge.Size = new System.Drawing.Size(93, 24);
            this.nudAge.TabIndex = 59;
            this.nudAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudAge.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // cbSexe
            // 
            this.cbSexe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSexe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbSexe.FormattingEnabled = true;
            this.cbSexe.Location = new System.Drawing.Point(118, 292);
            this.cbSexe.Margin = new System.Windows.Forms.Padding(2);
            this.cbSexe.Name = "cbSexe";
            this.cbSexe.Size = new System.Drawing.Size(133, 26);
            this.cbSexe.TabIndex = 60;
            // 
            // btnAjouter
            // 
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAjouter.Location = new System.Drawing.Point(365, 540);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(89, 30);
            this.btnAjouter.TabIndex = 61;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAnnuler.Location = new System.Drawing.Point(465, 540);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(89, 30);
            this.btnAnnuler.TabIndex = 62;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // frmAjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 580);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
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
            this.Controls.Add(label1);
            this.Controls.Add(this.tbMDPConfirme);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAjoutEmploye";
            this.Text = "Ajout d\'un employé";
            this.Load += new System.EventHandler(this.frmAjoutEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalaire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesEmployeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbCourriel;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNo;
        private System.Windows.Forms.TextBox tbNoCivique;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.TextBox tbRue;
        private System.Windows.Forms.TextBox tbVille;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbMDPConfirme;
        private System.Windows.Forms.NumericUpDown nudSalaire;
        private System.Windows.Forms.ComboBox cbTypeEmploye;
        private System.Windows.Forms.ComboBox cbProvince;
        private System.Windows.Forms.BindingSource typesEmployeBindingSource;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.MaskedTextBox mtbTelephone;
        private System.Windows.Forms.MaskedTextBox mtbCellulaire;
        private System.Windows.Forms.MaskedTextBox mtbCodePostal;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.ComboBox cbSexe;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}