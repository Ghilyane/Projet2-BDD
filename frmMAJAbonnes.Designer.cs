namespace ProjetFinal
{
    partial class frmMAJAbonnes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAbonnements = new System.Windows.Forms.DataGridView();
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgDependants = new System.Windows.Forms.DataGridView();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNoCivique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgVille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProvince = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCellulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeAbonnement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenomD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSexeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRemarqueD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(ProjetFinal.Abonnements);
            this.abonnementsBindingSource.CurrentChanged += new System.EventHandler(this.abonnementsBindingSource_CurrentChanged);
            // 
            // dgAbonnements
            // 
            this.dgAbonnements.AllowUserToAddRows = false;
            this.dgAbonnements.AutoGenerateColumns = false;
            this.dgAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dgPrenom,
            this.dgSexe,
            this.dataGridViewTextBoxColumn6,
            this.dgNoCivique,
            this.dgRue,
            this.dgVille,
            this.dgProvince,
            this.dgCodePostal,
            this.dgTelephone,
            this.dgCellulaire,
            this.dgCourriel,
            this.dgTypeAbonnement,
            this.dgRemarque});
            this.dgAbonnements.DataSource = this.abonnementsBindingSource;
            this.dgAbonnements.Location = new System.Drawing.Point(9, 36);
            this.dgAbonnements.Margin = new System.Windows.Forms.Padding(2);
            this.dgAbonnements.Name = "dgAbonnements";
            this.dgAbonnements.RowHeadersVisible = false;
            this.dgAbonnements.RowHeadersWidth = 51;
            this.dgAbonnements.RowTemplate.Height = 24;
            this.dgAbonnements.Size = new System.Drawing.Size(672, 179);
            this.dgAbonnements.TabIndex = 1;
            this.dgAbonnements.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgAbonnements_CellValidating);
            this.dgAbonnements.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgAbonnements_DataError);
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(ProjetFinal.Provinces);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetFinal.TypesAbonnement);
            // 
            // dependantsBindingSource
            // 
            this.dependantsBindingSource.DataMember = "Dependants";
            this.dependantsBindingSource.DataSource = this.abonnementsBindingSource;
            // 
            // dgDependants
            // 
            this.dgDependants.AllowUserToAddRows = false;
            this.dgDependants.AutoGenerateColumns = false;
            this.dgDependants.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgDependants.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDependants.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dgNomD,
            this.dgPrenomD,
            this.dgSexeD,
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dgRemarqueD});
            this.dgDependants.DataSource = this.dependantsBindingSource;
            this.dgDependants.Location = new System.Drawing.Point(172, 251);
            this.dgDependants.Margin = new System.Windows.Forms.Padding(2);
            this.dgDependants.Name = "dgDependants";
            this.dgDependants.RowHeadersWidth = 51;
            this.dgDependants.RowTemplate.Height = 24;
            this.dgDependants.Size = new System.Drawing.Size(508, 179);
            this.dgDependants.TabIndex = 2;
            this.dgDependants.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgDependants_DataError);
            this.dgDependants.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDependants_RowValidating);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifier.Location = new System.Drawing.Point(17, 251);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(125, 27);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateAbonnement";
            dataGridViewCellStyle4.Format = "D";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date d\'abonnement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 133;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 63;
            // 
            // dgPrenom
            // 
            this.dgPrenom.DataPropertyName = "Prenom";
            this.dgPrenom.HeaderText = "Prénom";
            this.dgPrenom.MinimumWidth = 6;
            this.dgPrenom.Name = "dgPrenom";
            this.dgPrenom.Width = 80;
            // 
            // dgSexe
            // 
            this.dgSexe.DataPropertyName = "Sexe";
            this.dgSexe.HeaderText = "Sexe";
            this.dgSexe.MinimumWidth = 6;
            this.dgSexe.Name = "dgSexe";
            this.dgSexe.ReadOnly = true;
            this.dgSexe.Width = 64;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle5.Format = "D";
            dataGridViewCellStyle5.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTextBoxColumn6.HeaderText = "Date de naissance";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 127;
            // 
            // dgNoCivique
            // 
            this.dgNoCivique.DataPropertyName = "NoCivique";
            this.dgNoCivique.HeaderText = "No civique";
            this.dgNoCivique.MinimumWidth = 6;
            this.dgNoCivique.Name = "dgNoCivique";
            this.dgNoCivique.Width = 86;
            // 
            // dgRue
            // 
            this.dgRue.DataPropertyName = "Rue";
            this.dgRue.HeaderText = "Rue";
            this.dgRue.MinimumWidth = 6;
            this.dgRue.Name = "dgRue";
            this.dgRue.Width = 59;
            // 
            // dgVille
            // 
            this.dgVille.DataPropertyName = "Ville";
            this.dgVille.HeaderText = "Ville";
            this.dgVille.MinimumWidth = 6;
            this.dgVille.Name = "dgVille";
            this.dgVille.Width = 59;
            // 
            // dgProvince
            // 
            this.dgProvince.DataPropertyName = "IdProvince";
            this.dgProvince.DataSource = this.provincesBindingSource;
            this.dgProvince.DisplayMember = "Nom";
            this.dgProvince.HeaderText = "Province";
            this.dgProvince.MinimumWidth = 6;
            this.dgProvince.Name = "dgProvince";
            this.dgProvince.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProvince.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgProvince.ValueMember = "Id";
            this.dgProvince.Width = 83;
            // 
            // dgCodePostal
            // 
            this.dgCodePostal.DataPropertyName = "CodePostal";
            this.dgCodePostal.HeaderText = "Code postal";
            this.dgCodePostal.MinimumWidth = 6;
            this.dgCodePostal.Name = "dgCodePostal";
            this.dgCodePostal.Width = 93;
            // 
            // dgTelephone
            // 
            this.dgTelephone.DataPropertyName = "Telephone";
            this.dgTelephone.HeaderText = "Téléphone";
            this.dgTelephone.MinimumWidth = 6;
            this.dgTelephone.Name = "dgTelephone";
            this.dgTelephone.Width = 95;
            // 
            // dgCellulaire
            // 
            this.dgCellulaire.DataPropertyName = "Cellulaire";
            this.dgCellulaire.HeaderText = "Cellulaire";
            this.dgCellulaire.MinimumWidth = 6;
            this.dgCellulaire.Name = "dgCellulaire";
            this.dgCellulaire.Width = 88;
            // 
            // dgCourriel
            // 
            this.dgCourriel.DataPropertyName = "Courriel";
            this.dgCourriel.HeaderText = "Courriel";
            this.dgCourriel.MinimumWidth = 6;
            this.dgCourriel.Name = "dgCourriel";
            this.dgCourriel.Width = 79;
            // 
            // dgTypeAbonnement
            // 
            this.dgTypeAbonnement.DataPropertyName = "NoTypeAbonnement";
            this.dgTypeAbonnement.DataSource = this.typesAbonnementBindingSource;
            this.dgTypeAbonnement.DisplayMember = "Description";
            this.dgTypeAbonnement.HeaderText = "Type d\'abonnement";
            this.dgTypeAbonnement.MinimumWidth = 6;
            this.dgTypeAbonnement.Name = "dgTypeAbonnement";
            this.dgTypeAbonnement.ReadOnly = true;
            this.dgTypeAbonnement.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTypeAbonnement.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgTypeAbonnement.ValueMember = "No";
            this.dgTypeAbonnement.Width = 133;
            // 
            // dgRemarque
            // 
            this.dgRemarque.DataPropertyName = "Remarque";
            this.dgRemarque.HeaderText = "Remarque";
            this.dgRemarque.MinimumWidth = 6;
            this.dgRemarque.Name = "dgRemarque";
            this.dgRemarque.Width = 95;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn19.HeaderText = "ID";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 48;
            // 
            // dgNomD
            // 
            this.dgNomD.DataPropertyName = "Nom";
            this.dgNomD.HeaderText = "Nom";
            this.dgNomD.MinimumWidth = 6;
            this.dgNomD.Name = "dgNomD";
            this.dgNomD.Width = 63;
            // 
            // dgPrenomD
            // 
            this.dgPrenomD.DataPropertyName = "Prenom";
            this.dgPrenomD.HeaderText = "Prénom";
            this.dgPrenomD.MinimumWidth = 6;
            this.dgPrenomD.Name = "dgPrenomD";
            this.dgPrenomD.Width = 80;
            // 
            // dgSexeD
            // 
            this.dgSexeD.DataPropertyName = "Sexe";
            this.dgSexeD.HeaderText = "Sexe";
            this.dgSexeD.MinimumWidth = 6;
            this.dgSexeD.Name = "dgSexeD";
            this.dgSexeD.ReadOnly = true;
            this.dgSexeD.Width = 64;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle6.Format = "D";
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn23.HeaderText = "Date de naissance";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 127;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "IdAbonnement";
            this.dataGridViewTextBoxColumn24.HeaderText = "Abonnement";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 106;
            // 
            // dgRemarqueD
            // 
            this.dgRemarqueD.DataPropertyName = "Remarque";
            this.dgRemarqueD.HeaderText = "Remarque";
            this.dgRemarqueD.MinimumWidth = 6;
            this.dgRemarqueD.Name = "dgRemarqueD";
            this.dgRemarqueD.Width = 95;
            // 
            // frmMAJAbonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 448);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgDependants);
            this.Controls.Add(this.dgAbonnements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMAJAbonnes";
            this.Text = "frmMAJAbonnes";
            this.Load += new System.EventHandler(this.frmMAJAbonnes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.DataGridView dgAbonnements;
        private System.Windows.Forms.BindingSource dependantsBindingSource;
        private System.Windows.Forms.DataGridView dgDependants;
        private System.Windows.Forms.BindingSource provincesBindingSource;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSexe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNoCivique;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgVille;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTelephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCellulaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCourriel;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgTypeAbonnement;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarque;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNomD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrenomD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSexeD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgRemarqueD;
    }
}