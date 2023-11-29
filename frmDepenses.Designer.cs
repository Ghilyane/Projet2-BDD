﻿namespace ProjetFinal
{
    partial class frmDepenses
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
            System.Windows.Forms.Label dateDepenseLabel;
            System.Windows.Forms.Label idAbonnementLabel;
            System.Windows.Forms.Label montantLabel;
            System.Windows.Forms.Label noLabel;
            System.Windows.Forms.Label noServiceLabel;
            System.Windows.Forms.Label remarqueLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepenses));
            this.label1 = new System.Windows.Forms.Label();
            this.dateDepenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idAbonnementTextBox = new System.Windows.Forms.TextBox();
            this.montantTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.noServiceTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbIndex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLblTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.BtnPremier = new System.Windows.Forms.ToolStripButton();
            this.BtnPrecedent = new System.Windows.Forms.ToolStripButton();
            this.BtnSuivant = new System.Windows.Forms.ToolStripButton();
            this.BtnDernier = new System.Windows.Forms.ToolStripButton();
            this.depensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            dateDepenseLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            montantLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            noServiceLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateDepenseLabel
            // 
            dateDepenseLabel.AutoSize = true;
            dateDepenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateDepenseLabel.Location = new System.Drawing.Point(16, 102);
            dateDepenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateDepenseLabel.Name = "dateDepenseLabel";
            dateDepenseLabel.Size = new System.Drawing.Size(106, 18);
            dateDepenseLabel.TabIndex = 5;
            dateDepenseLabel.Text = "Date Depense:";
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAbonnementLabel.Location = new System.Drawing.Point(382, 197);
            idAbonnementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(110, 18);
            idAbonnementLabel.TabIndex = 6;
            idAbonnementLabel.Text = "Id Abonnement:";
            // 
            // montantLabel
            // 
            montantLabel.AutoSize = true;
            montantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montantLabel.Location = new System.Drawing.Point(386, 273);
            montantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            montantLabel.Name = "montantLabel";
            montantLabel.Size = new System.Drawing.Size(66, 18);
            montantLabel.TabIndex = 7;
            montantLabel.Text = "Montant:";
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noLabel.Location = new System.Drawing.Point(22, 200);
            noLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(32, 18);
            noLabel.TabIndex = 8;
            noLabel.Text = "No:";
            // 
            // noServiceLabel
            // 
            noServiceLabel.AutoSize = true;
            noServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noServiceLabel.Location = new System.Drawing.Point(18, 334);
            noServiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noServiceLabel.Name = "noServiceLabel";
            noServiceLabel.Size = new System.Drawing.Size(85, 18);
            noServiceLabel.TabIndex = 10;
            noServiceLabel.Text = "No Service:";
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(22, 273);
            remarqueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(81, 18);
            remarqueLabel.TabIndex = 12;
            remarqueLabel.Text = "Remarque:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(250, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ajout d\'une dépense";
            // 
            // dateDepenseDateTimePicker
            // 
            this.dateDepenseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depensesBindingSource, "DateDepense", true));
            this.dateDepenseDateTimePicker.Location = new System.Drawing.Point(149, 102);
            this.dateDepenseDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dateDepenseDateTimePicker.Name = "dateDepenseDateTimePicker";
            this.dateDepenseDateTimePicker.Size = new System.Drawing.Size(198, 23);
            this.dateDepenseDateTimePicker.TabIndex = 6;
            // 
            // idAbonnementTextBox
            // 
            this.idAbonnementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "IdAbonnement", true));
            this.idAbonnementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAbonnementTextBox.Location = new System.Drawing.Point(504, 194);
            this.idAbonnementTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idAbonnementTextBox.Name = "idAbonnementTextBox";
            this.idAbonnementTextBox.Size = new System.Drawing.Size(124, 23);
            this.idAbonnementTextBox.TabIndex = 7;
            // 
            // montantTextBox
            // 
            this.montantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Montant", true));
            this.montantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantTextBox.Location = new System.Drawing.Point(504, 270);
            this.montantTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.montantTextBox.Name = "montantTextBox";
            this.montantTextBox.Size = new System.Drawing.Size(170, 23);
            this.montantTextBox.TabIndex = 8;
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "No", true));
            this.noTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTextBox.Location = new System.Drawing.Point(145, 197);
            this.noTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(78, 23);
            this.noTextBox.TabIndex = 9;
            // 
            // noServiceTextBox
            // 
            this.noServiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "NoService", true));
            this.noServiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noServiceTextBox.Location = new System.Drawing.Point(145, 334);
            this.noServiceTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noServiceTextBox.Name = "noServiceTextBox";
            this.noServiceTextBox.Size = new System.Drawing.Size(124, 23);
            this.noServiceTextBox.TabIndex = 11;
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Remarque", true));
            this.remarqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(145, 270);
            this.remarqueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(178, 23);
            this.remarqueTextBox.TabIndex = 13;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnPremier,
            this.BtnPrecedent,
            this.toolStripSeparator1,
            this.tbIndex,
            this.toolStripLblTotal,
            this.toolStripSeparator2,
            this.BtnSuivant,
            this.BtnDernier});
            this.toolStrip1.Location = new System.Drawing.Point(0, 495);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(730, 27);
            this.toolStrip1.TabIndex = 36;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbIndex
            // 
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(164, 27);
            // 
            // toolStripLblTotal
            // 
            this.toolStripLblTotal.Name = "toolStripLblTotal";
            this.toolStripLblTotal.Size = new System.Drawing.Size(37, 24);
            this.toolStripLblTotal.Text = "de {0}";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(695, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 18);
            this.label2.TabIndex = 37;
            this.label2.Text = "$";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(241, 425);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(251, 28);
            this.btnAjouter.TabIndex = 38;
            this.btnAjouter.Text = "Ajouter une dépense";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // BtnPremier
            // 
            this.BtnPremier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPremier.Image = ((System.Drawing.Image)(resources.GetObject("BtnPremier.Image")));
            this.BtnPremier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPremier.Name = "BtnPremier";
            this.BtnPremier.Size = new System.Drawing.Size(24, 24);
            this.BtnPremier.Text = "toolStripButton1";
            this.BtnPremier.Click += new System.EventHandler(this.BtnPremier_Click);
            // 
            // BtnPrecedent
            // 
            this.BtnPrecedent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrecedent.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrecedent.Image")));
            this.BtnPrecedent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrecedent.Name = "BtnPrecedent";
            this.BtnPrecedent.Size = new System.Drawing.Size(24, 24);
            this.BtnPrecedent.Text = "toolStripButton2";
            this.BtnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);
            // 
            // BtnSuivant
            // 
            this.BtnSuivant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSuivant.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuivant.Image")));
            this.BtnSuivant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSuivant.Name = "BtnSuivant";
            this.BtnSuivant.Size = new System.Drawing.Size(24, 24);
            this.BtnSuivant.Text = "toolStripButton3";
            this.BtnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // BtnDernier
            // 
            this.BtnDernier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDernier.Image = ((System.Drawing.Image)(resources.GetObject("BtnDernier.Image")));
            this.BtnDernier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDernier.Name = "BtnDernier";
            this.BtnDernier.Size = new System.Drawing.Size(24, 24);
            this.BtnDernier.Text = "toolStripButton4";
            this.BtnDernier.Click += new System.EventHandler(this.BtnDernier_Click);
            // 
            // depensesBindingSource
            // 
            this.depensesBindingSource.DataSource = typeof(ProjetFinal.Depenses);
            // 
            // frmDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 522);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(noServiceLabel);
            this.Controls.Add(this.noServiceTextBox);
            this.Controls.Add(noLabel);
            this.Controls.Add(this.noTextBox);
            this.Controls.Add(montantLabel);
            this.Controls.Add(this.montantTextBox);
            this.Controls.Add(idAbonnementLabel);
            this.Controls.Add(this.idAbonnementTextBox);
            this.Controls.Add(dateDepenseLabel);
            this.Controls.Add(this.dateDepenseDateTimePicker);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDepenses";
            this.Text = "Depenses";
            this.Load += new System.EventHandler(this.frmDepenses_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource depensesBindingSource;
        private System.Windows.Forms.DateTimePicker dateDepenseDateTimePicker;
        private System.Windows.Forms.TextBox idAbonnementTextBox;
        private System.Windows.Forms.TextBox montantTextBox;
        private System.Windows.Forms.TextBox noTextBox;
        private System.Windows.Forms.TextBox noServiceTextBox;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnPremier;
        private System.Windows.Forms.ToolStripButton BtnPrecedent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tbIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnSuivant;
        private System.Windows.Forms.ToolStripButton BtnDernier;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
    }
}