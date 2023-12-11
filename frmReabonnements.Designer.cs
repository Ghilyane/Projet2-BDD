namespace ProjetFinal
{
    partial class frmReabonnements
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
            this.abonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgAbonnements = new System.Windows.Forms.DataGridView();
            this.idAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCompletAbonnementDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noetNomAbonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbRemarque = new System.Windows.Forms.TextBox();
            this.btnReabonnement = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.reabonnementsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noetNomAbonnementsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abonnementsBindingSource
            // 
            this.abonnementsBindingSource.DataSource = typeof(ProjetFinal.Abonnements);
            // 
            // dgAbonnements
            // 
            this.dgAbonnements.AutoGenerateColumns = false;
            this.dgAbonnements.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgAbonnements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAbonnements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAbonnementDataGridViewTextBoxColumn,
            this.nomCompletAbonnementDataGridViewTextBoxColumn});
            this.dgAbonnements.DataSource = this.noetNomAbonnementsBindingSource;
            this.dgAbonnements.Location = new System.Drawing.Point(21, 91);
            this.dgAbonnements.Margin = new System.Windows.Forms.Padding(2);
            this.dgAbonnements.Name = "dgAbonnements";
            this.dgAbonnements.RowHeadersWidth = 51;
            this.dgAbonnements.RowTemplate.Height = 24;
            this.dgAbonnements.Size = new System.Drawing.Size(228, 309);
            this.dgAbonnements.TabIndex = 3;
            // 
            // idAbonnementDataGridViewTextBoxColumn
            // 
            this.idAbonnementDataGridViewTextBoxColumn.DataPropertyName = "idAbonnement";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAbonnementDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.idAbonnementDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idAbonnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAbonnementDataGridViewTextBoxColumn.Name = "idAbonnementDataGridViewTextBoxColumn";
            this.idAbonnementDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAbonnementDataGridViewTextBoxColumn.Width = 48;
            // 
            // nomCompletAbonnementDataGridViewTextBoxColumn
            // 
            this.nomCompletAbonnementDataGridViewTextBoxColumn.DataPropertyName = "nomCompletAbonnement";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomCompletAbonnementDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.nomCompletAbonnementDataGridViewTextBoxColumn.HeaderText = "Nom complet";
            this.nomCompletAbonnementDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomCompletAbonnementDataGridViewTextBoxColumn.Name = "nomCompletAbonnementDataGridViewTextBoxColumn";
            this.nomCompletAbonnementDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomCompletAbonnementDataGridViewTextBoxColumn.Width = 110;
            // 
            // noetNomAbonnementsBindingSource
            // 
            this.noetNomAbonnementsBindingSource.DataSource = typeof(ProjetFinal.NoetNomAbonnements);
            // 
            // tbRemarque
            // 
            this.tbRemarque.Location = new System.Drawing.Point(298, 188);
            this.tbRemarque.Margin = new System.Windows.Forms.Padding(2);
            this.tbRemarque.Multiline = true;
            this.tbRemarque.Name = "tbRemarque";
            this.tbRemarque.Size = new System.Drawing.Size(240, 162);
            this.tbRemarque.TabIndex = 4;
            // 
            // btnReabonnement
            // 
            this.btnReabonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReabonnement.Location = new System.Drawing.Point(308, 374);
            this.btnReabonnement.Margin = new System.Windows.Forms.Padding(2);
            this.btnReabonnement.Name = "btnReabonnement";
            this.btnReabonnement.Size = new System.Drawing.Size(130, 26);
            this.btnReabonnement.TabIndex = 5;
            this.btnReabonnement.Text = "Réabonner";
            this.btnReabonnement.UseVisualStyleBackColor = true;
            this.btnReabonnement.Click += new System.EventHandler(this.btnReabonnement_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(294, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Remarque :";
            // 
            // reabonnementsBindingSource
            // 
            this.reabonnementsBindingSource.DataSource = typeof(ProjetFinal.Reabonnements);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Réabonnements";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 39);
            this.panel1.TabIndex = 7;
            // 
            // frmReabonnements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 463);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReabonnement);
            this.Controls.Add(this.tbRemarque);
            this.Controls.Add(this.dgAbonnements);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmReabonnements";
            this.Text = "frmReabonnements";
            this.Load += new System.EventHandler(this.frmReabonnements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.abonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAbonnements)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noetNomAbonnementsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reabonnementsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource abonnementsBindingSource;
        private System.Windows.Forms.BindingSource noetNomAbonnementsBindingSource;
        private System.Windows.Forms.DataGridView dgAbonnements;
        private System.Windows.Forms.TextBox tbRemarque;
        private System.Windows.Forms.Button btnReabonnement;
        private System.Windows.Forms.ErrorProvider errMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCompletAbonnementDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource reabonnementsBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}