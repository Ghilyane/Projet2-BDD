namespace ProjetFinal
{
    partial class frmPrixEtDepenses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.prixDepensesAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prixDepensesAbonnementsDataGridView = new System.Windows.Forms.DataGridView();
            this.typesAbonnementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgAnnee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgPrix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgDepenses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prixDepensesAbonnementsBindingSource
            // 
            this.prixDepensesAbonnementsBindingSource.DataSource = typeof(ProjetFinal.PrixDepensesAbonnements);
            // 
            // prixDepensesAbonnementsDataGridView
            // 
            this.prixDepensesAbonnementsDataGridView.AllowUserToAddRows = false;
            this.prixDepensesAbonnementsDataGridView.AllowUserToDeleteRows = false;
            this.prixDepensesAbonnementsDataGridView.AutoGenerateColumns = false;
            this.prixDepensesAbonnementsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.prixDepensesAbonnementsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.prixDepensesAbonnementsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prixDepensesAbonnementsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dgAnnee,
            this.dgPrix,
            this.dgDepenses,
            this.dataGridViewTextBoxColumn5});
            this.prixDepensesAbonnementsDataGridView.DataSource = this.prixDepensesAbonnementsBindingSource;
            this.prixDepensesAbonnementsDataGridView.Location = new System.Drawing.Point(69, 70);
            this.prixDepensesAbonnementsDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.prixDepensesAbonnementsDataGridView.Name = "prixDepensesAbonnementsDataGridView";
            this.prixDepensesAbonnementsDataGridView.RowHeadersWidth = 51;
            this.prixDepensesAbonnementsDataGridView.RowTemplate.Height = 24;
            this.prixDepensesAbonnementsDataGridView.Size = new System.Drawing.Size(544, 179);
            this.prixDepensesAbonnementsDataGridView.TabIndex = 1;
            this.prixDepensesAbonnementsDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.prixDepensesAbonnementsDataGridView_CellBeginEdit);
            this.prixDepensesAbonnementsDataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.prixDepensesAbonnementsDataGridView_CellEndEdit);
            this.prixDepensesAbonnementsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.prixDepensesAbonnementsDataGridView_DataError);
            this.prixDepensesAbonnementsDataGridView.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.prixDepensesAbonnementsDataGridView_RowValidating);
            // 
            // typesAbonnementBindingSource
            // 
            this.typesAbonnementBindingSource.DataSource = typeof(ProjetFinal.TypesAbonnement);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 39);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prix et dépenses";
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnModifier.Location = new System.Drawing.Point(269, 279);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(150, 42);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NoTypeAbonnement";
            this.dataGridViewTextBoxColumn1.DataSource = this.typesAbonnementBindingSource;
            this.dataGridViewTextBoxColumn1.DisplayMember = "Description";
            this.dataGridViewTextBoxColumn1.HeaderText = "Type d\'abonnement";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn1.ValueMember = "No";
            this.dataGridViewTextBoxColumn1.Width = 157;
            // 
            // dgAnnee
            // 
            this.dgAnnee.DataPropertyName = "Annee";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgAnnee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgAnnee.HeaderText = "Année";
            this.dgAnnee.MinimumWidth = 6;
            this.dgAnnee.Name = "dgAnnee";
            this.dgAnnee.Width = 75;
            // 
            // dgPrix
            // 
            this.dgPrix.DataPropertyName = "Prix";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.dgPrix.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgPrix.HeaderText = "Prix ($)";
            this.dgPrix.MinimumWidth = 6;
            this.dgPrix.Name = "dgPrix";
            this.dgPrix.Width = 76;
            // 
            // dgDepenses
            // 
            this.dgDepenses.DataPropertyName = "DepensesObligatoires";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.dgDepenses.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgDepenses.HeaderText = "Dépenses obligatoires ($)";
            this.dgDepenses.MinimumWidth = 6;
            this.dgDepenses.Name = "dgDepenses";
            this.dgDepenses.Width = 191;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Remarque";
            this.dataGridViewTextBoxColumn5.HeaderText = "Remarque";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // frmPrixEtDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 366);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.prixDepensesAbonnementsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPrixEtDepenses";
            this.Text = "frmPrixEtDepenses";
            this.Load += new System.EventHandler(this.frmPrixEtDepenses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prixDepensesAbonnementsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typesAbonnementBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "frmPrixEtDepenses";
        }

        #endregion

        private System.Windows.Forms.BindingSource prixDepensesAbonnementsBindingSource;
        private System.Windows.Forms.DataGridView prixDepensesAbonnementsDataGridView;
        private System.Windows.Forms.BindingSource typesAbonnementBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgAnnee;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgPrix;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgDepenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}