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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAbonnements = new System.Windows.Forms.DataGridView();
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
            this.provincesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgCodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTelephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCellulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCourriel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTypeAbonnement = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgRemarque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dependantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgDependants = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNomD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrenomD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSexeD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgRemarqueD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnModifier = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.provincesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dependantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDependants)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.dgAbonnements.Location = new System.Drawing.Point(33, 55);
            this.dgAbonnements.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgAbonnements.Name = "dgAbonnements";
            this.dgAbonnements.RowHeadersVisible = false;
            this.dgAbonnements.RowHeadersWidth = 51;
            this.dgAbonnements.RowTemplate.Height = 24;
            this.dgAbonnements.Size = new System.Drawing.Size(896, 220);
            this.dgAbonnements.TabIndex = 1;
            this.dgAbonnements.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.dgAbonnements_CellValidating);
            this.dgAbonnements.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgAbonnements_DataError);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 49;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "DateAbonnement";
            dataGridViewCellStyle1.Format = "D";
            this.dataGridViewTextBoxColumn2.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Date d\'abonnement";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 141;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 65;
            // 
            // dgPrenom
            // 
            this.dgPrenom.DataPropertyName = "Prenom";
            this.dgPrenom.HeaderText = "Prénom";
            this.dgPrenom.MinimumWidth = 6;
            this.dgPrenom.Name = "dgPrenom";
            this.dgPrenom.Width = 83;
            // 
            // dgSexe
            // 
            this.dgSexe.DataPropertyName = "Sexe";
            this.dgSexe.HeaderText = "Sexe";
            this.dgSexe.MinimumWidth = 6;
            this.dgSexe.Name = "dgSexe";
            this.dgSexe.ReadOnly = true;
            this.dgSexe.Width = 67;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle2.Format = "D";
            dataGridViewCellStyle2.NullValue = null;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn6.HeaderText = "Date de naissance";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.Width = 137;
            // 
            // dgNoCivique
            // 
            this.dgNoCivique.DataPropertyName = "NoCivique";
            this.dgNoCivique.HeaderText = "No civique";
            this.dgNoCivique.MinimumWidth = 6;
            this.dgNoCivique.Name = "dgNoCivique";
            this.dgNoCivique.Width = 92;
            // 
            // dgRue
            // 
            this.dgRue.DataPropertyName = "Rue";
            this.dgRue.HeaderText = "Rue";
            this.dgRue.MinimumWidth = 6;
            this.dgRue.Name = "dgRue";
            this.dgRue.Width = 61;
            // 
            // dgVille
            // 
            this.dgVille.DataPropertyName = "Ville";
            this.dgVille.HeaderText = "Ville";
            this.dgVille.MinimumWidth = 6;
            this.dgVille.Name = "dgVille";
            this.dgVille.Width = 62;
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
            this.dgProvince.Width = 89;
            // 
            // provincesBindingSource
            // 
            this.provincesBindingSource.DataSource = typeof(ProjetFinal.Provinces);
            // 
            // dgCodePostal
            // 
            this.dgCodePostal.DataPropertyName = "CodePostal";
            this.dgCodePostal.HeaderText = "Code postal";
            this.dgCodePostal.MinimumWidth = 6;
            this.dgCodePostal.Name = "dgCodePostal";
            this.dgCodePostal.Width = 101;
            // 
            // dgTelephone
            // 
            this.dgTelephone.DataPropertyName = "Telephone";
            this.dgTelephone.HeaderText = "Téléphone";
            this.dgTelephone.MinimumWidth = 6;
            this.dgTelephone.Name = "dgTelephone";
            this.dgTelephone.Width = 102;
            // 
            // dgCellulaire
            // 
            this.dgCellulaire.DataPropertyName = "Cellulaire";
            this.dgCellulaire.HeaderText = "Cellulaire";
            this.dgCellulaire.MinimumWidth = 6;
            this.dgCellulaire.Name = "dgCellulaire";
            this.dgCellulaire.Width = 92;
            // 
            // dgCourriel
            // 
            this.dgCourriel.DataPropertyName = "Courriel";
            this.dgCourriel.HeaderText = "Courriel";
            this.dgCourriel.MinimumWidth = 6;
            this.dgCourriel.Name = "dgCourriel";
            this.dgCourriel.Width = 82;
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
            this.dgTypeAbonnement.Width = 144;
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetFinal.TypesAbonnement);
            // 
            // dgRemarque
            // 
            this.dgRemarque.DataPropertyName = "Remarque";
            this.dgRemarque.HeaderText = "Remarque";
            this.dgRemarque.MinimumWidth = 6;
            this.dgRemarque.Name = "dgRemarque";
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
            this.dgDependants.Location = new System.Drawing.Point(250, 320);
            this.dgDependants.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgDependants.Name = "dgDependants";
            this.dgDependants.RowHeadersWidth = 51;
            this.dgDependants.RowTemplate.Height = 24;
            this.dgDependants.Size = new System.Drawing.Size(677, 220);
            this.dgDependants.TabIndex = 2;
            this.dgDependants.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgDependants_DataError);
            this.dgDependants.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgDependants_RowValidating);
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn19.HeaderText = "ID";
            this.dataGridViewTextBoxColumn19.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.ReadOnly = true;
            this.dataGridViewTextBoxColumn19.Width = 49;
            // 
            // dgNomD
            // 
            this.dgNomD.DataPropertyName = "Nom";
            this.dgNomD.HeaderText = "Nom";
            this.dgNomD.MinimumWidth = 6;
            this.dgNomD.Name = "dgNomD";
            this.dgNomD.Width = 65;
            // 
            // dgPrenomD
            // 
            this.dgPrenomD.DataPropertyName = "Prenom";
            this.dgPrenomD.HeaderText = "Prénom";
            this.dgPrenomD.MinimumWidth = 6;
            this.dgPrenomD.Name = "dgPrenomD";
            this.dgPrenomD.Width = 83;
            // 
            // dgSexeD
            // 
            this.dgSexeD.DataPropertyName = "Sexe";
            this.dgSexeD.HeaderText = "Sexe";
            this.dgSexeD.MinimumWidth = 6;
            this.dgSexeD.Name = "dgSexeD";
            this.dgSexeD.ReadOnly = true;
            this.dgSexeD.Width = 67;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "DateNaissance";
            dataGridViewCellStyle3.Format = "D";
            this.dataGridViewTextBoxColumn23.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn23.HeaderText = "Date de naissance";
            this.dataGridViewTextBoxColumn23.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.ReadOnly = true;
            this.dataGridViewTextBoxColumn23.Width = 137;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "IdAbonnement";
            this.dataGridViewTextBoxColumn24.HeaderText = "Abonnement";
            this.dataGridViewTextBoxColumn24.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.ReadOnly = true;
            this.dataGridViewTextBoxColumn24.Width = 112;
            // 
            // dgRemarqueD
            // 
            this.dgRemarqueD.DataPropertyName = "Remarque";
            this.dgRemarqueD.HeaderText = "Remarque";
            this.dgRemarqueD.MinimumWidth = 6;
            this.dgRemarqueD.Name = "dgRemarqueD";
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifier.Location = new System.Drawing.Point(44, 320);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(167, 33);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(969, 48);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mise à jour des abonnements";
            // 
            // frmMAJAbonnes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 551);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.dgDependants);
            this.Controls.Add(this.dgAbonnements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}