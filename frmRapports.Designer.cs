namespace ProjetFinal
{
    partial class frmRapports
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
            System.Windows.Forms.Label lblNomEmploye;
            System.Windows.Forms.Label lblMontant;
            System.Windows.Forms.Label lblDateDepense;
            System.Windows.Forms.Label lblTypeService;
            System.Windows.Forms.Label lblNomAbonne;
            System.Windows.Forms.Label lblRecherche;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapports));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rapportDesDépensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dépensesParAbonnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dépensesParAnnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dépensesParEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rapportPartiesJouéesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partiesJouéesParTerrainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partiesJouéesParAbonnementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partiesJouéesParAnnéeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nudMontant = new System.Windows.Forms.NumericUpDown();
            this.txtNomEmploye = new System.Windows.Forms.TextBox();
            this.depensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDepenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtTypeService = new System.Windows.Forms.TextBox();
            this.txtNomAbonne = new System.Windows.Forms.TextBox();
            this.lblAffiche = new System.Windows.Forms.Label();
            this.txtRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnPremier = new System.Windows.Forms.ToolStripButton();
            this.BtnPrecedent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbIndex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLblTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSuivant = new System.Windows.Forms.ToolStripButton();
            this.BtnDernier = new System.Windows.Forms.ToolStripButton();
            lblNomEmploye = new System.Windows.Forms.Label();
            lblMontant = new System.Windows.Forms.Label();
            lblDateDepense = new System.Windows.Forms.Label();
            lblTypeService = new System.Windows.Forms.Label();
            lblNomAbonne = new System.Windows.Forms.Label();
            lblRecherche = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomEmploye
            // 
            lblNomEmploye.AutoSize = true;
            lblNomEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomEmploye.Location = new System.Drawing.Point(430, 205);
            lblNomEmploye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNomEmploye.Name = "lblNomEmploye";
            lblNomEmploye.Size = new System.Drawing.Size(126, 22);
            lblNomEmploye.TabIndex = 53;
            lblNomEmploye.Text = "Nom Employé:";
            lblNomEmploye.Visible = false;
            // 
            // lblMontant
            // 
            lblMontant.AutoSize = true;
            lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblMontant.Location = new System.Drawing.Point(9, 355);
            lblMontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblMontant.Name = "lblMontant";
            lblMontant.Size = new System.Drawing.Size(79, 22);
            lblMontant.TabIndex = 45;
            lblMontant.Text = "Montant:";
            lblMontant.Visible = false;
            // 
            // lblDateDepense
            // 
            lblDateDepense.AutoSize = true;
            lblDateDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDateDepense.Location = new System.Drawing.Point(430, 282);
            lblDateDepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblDateDepense.Name = "lblDateDepense";
            lblDateDepense.Size = new System.Drawing.Size(130, 22);
            lblDateDepense.TabIndex = 42;
            lblDateDepense.Text = "Date Depense:";
            lblDateDepense.Visible = false;
            // 
            // lblTypeService
            // 
            lblTypeService.AutoSize = true;
            lblTypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTypeService.Location = new System.Drawing.Point(9, 282);
            lblTypeService.Name = "lblTypeService";
            lblTypeService.Size = new System.Drawing.Size(124, 20);
            lblTypeService.TabIndex = 59;
            lblTypeService.Text = "Type Service:";
            lblTypeService.Visible = false;
            // 
            // lblNomAbonne
            // 
            lblNomAbonne.AutoSize = true;
            lblNomAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblNomAbonne.Location = new System.Drawing.Point(12, 202);
            lblNomAbonne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblNomAbonne.Name = "lblNomAbonne";
            lblNomAbonne.Size = new System.Drawing.Size(119, 22);
            lblNomAbonne.TabIndex = 61;
            lblNomAbonne.Text = "Nom Abonné:";
            lblNomAbonne.Visible = false;
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRecherche.Location = new System.Drawing.Point(9, 125);
            lblRecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new System.Drawing.Size(144, 22);
            lblRecherche.TabIndex = 64;
            lblRecherche.Text = "Entrez le nom de";
            lblRecherche.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportDesDépensesToolStripMenuItem,
            this.rapportPartiesJouéesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 437);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rapportDesDépensesToolStripMenuItem
            // 
            this.rapportDesDépensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dépensesParAbonnementToolStripMenuItem,
            this.dépensesParAnnéeToolStripMenuItem,
            this.dépensesParEmployéToolStripMenuItem});
            this.rapportDesDépensesToolStripMenuItem.Name = "rapportDesDépensesToolStripMenuItem";
            this.rapportDesDépensesToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.rapportDesDépensesToolStripMenuItem.Text = "Rapport des dépenses";
            // 
            // dépensesParAbonnementToolStripMenuItem
            // 
            this.dépensesParAbonnementToolStripMenuItem.Name = "dépensesParAbonnementToolStripMenuItem";
            this.dépensesParAbonnementToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.dépensesParAbonnementToolStripMenuItem.Text = "Dépenses par abonnement";
            this.dépensesParAbonnementToolStripMenuItem.Click += new System.EventHandler(this.dépensesParAbonnementToolStripMenuItem_Click);
            // 
            // dépensesParAnnéeToolStripMenuItem
            // 
            this.dépensesParAnnéeToolStripMenuItem.Name = "dépensesParAnnéeToolStripMenuItem";
            this.dépensesParAnnéeToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.dépensesParAnnéeToolStripMenuItem.Text = "Dépenses par année";
            this.dépensesParAnnéeToolStripMenuItem.Click += new System.EventHandler(this.dépensesParAnnéeToolStripMenuItem_Click);
            // 
            // dépensesParEmployéToolStripMenuItem
            // 
            this.dépensesParEmployéToolStripMenuItem.Name = "dépensesParEmployéToolStripMenuItem";
            this.dépensesParEmployéToolStripMenuItem.Size = new System.Drawing.Size(270, 26);
            this.dépensesParEmployéToolStripMenuItem.Text = "Dépenses par employé";
            this.dépensesParEmployéToolStripMenuItem.Click += new System.EventHandler(this.dépensesParEmployéToolStripMenuItem_Click);
            // 
            // rapportPartiesJouéesToolStripMenuItem
            // 
            this.rapportPartiesJouéesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partiesJouéesParTerrainToolStripMenuItem,
            this.partiesJouéesParAbonnementToolStripMenuItem,
            this.partiesJouéesParAnnéeToolStripMenuItem});
            this.rapportPartiesJouéesToolStripMenuItem.Name = "rapportPartiesJouéesToolStripMenuItem";
            this.rapportPartiesJouéesToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.rapportPartiesJouéesToolStripMenuItem.Text = "Rapport parties jouées";
            // 
            // partiesJouéesParTerrainToolStripMenuItem
            // 
            this.partiesJouéesParTerrainToolStripMenuItem.Name = "partiesJouéesParTerrainToolStripMenuItem";
            this.partiesJouéesParTerrainToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.partiesJouéesParTerrainToolStripMenuItem.Text = "Parties jouées par terrain";
            // 
            // partiesJouéesParAbonnementToolStripMenuItem
            // 
            this.partiesJouéesParAbonnementToolStripMenuItem.Name = "partiesJouéesParAbonnementToolStripMenuItem";
            this.partiesJouéesParAbonnementToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.partiesJouéesParAbonnementToolStripMenuItem.Text = "Parties jouées par abonnement";
            // 
            // partiesJouéesParAnnéeToolStripMenuItem
            // 
            this.partiesJouéesParAnnéeToolStripMenuItem.Name = "partiesJouéesParAnnéeToolStripMenuItem";
            this.partiesJouéesParAnnéeToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.partiesJouéesParAnnéeToolStripMenuItem.Text = "Parties jouées par année";
            // 
            // nudMontant
            // 
            this.nudMontant.DecimalPlaces = 2;
            this.nudMontant.Enabled = false;
            this.nudMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMontant.Location = new System.Drawing.Point(162, 355);
            this.nudMontant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMontant.Name = "nudMontant";
            this.nudMontant.Size = new System.Drawing.Size(124, 27);
            this.nudMontant.TabIndex = 55;
            this.nudMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMontant.Visible = false;
            // 
            // txtNomEmploye
            // 
            this.txtNomEmploye.Enabled = false;
            this.txtNomEmploye.Location = new System.Drawing.Point(576, 207);
            this.txtNomEmploye.Name = "txtNomEmploye";
            this.txtNomEmploye.Size = new System.Drawing.Size(212, 22);
            this.txtNomEmploye.TabIndex = 54;
            this.txtNomEmploye.Visible = false;
            // 
            // depensesBindingSource
            // 
            this.depensesBindingSource.DataSource = typeof(ProjetFinal.Depenses);
            // 
            // dateDepenseDateTimePicker
            // 
            this.dateDepenseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depensesBindingSource, "DateDepense", true));
            this.dateDepenseDateTimePicker.Enabled = false;
            this.dateDepenseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDepenseDateTimePicker.Location = new System.Drawing.Point(576, 282);
            this.dateDepenseDateTimePicker.Name = "dateDepenseDateTimePicker";
            this.dateDepenseDateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.dateDepenseDateTimePicker.TabIndex = 57;
            this.dateDepenseDateTimePicker.Visible = false;
            // 
            // txtTypeService
            // 
            this.txtTypeService.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Services.TypeService", true));
            this.txtTypeService.Enabled = false;
            this.txtTypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeService.Location = new System.Drawing.Point(162, 282);
            this.txtTypeService.Name = "txtTypeService";
            this.txtTypeService.Size = new System.Drawing.Size(212, 27);
            this.txtTypeService.TabIndex = 60;
            this.txtTypeService.Visible = false;
            // 
            // txtNomAbonne
            // 
            this.txtNomAbonne.Enabled = false;
            this.txtNomAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAbonne.Location = new System.Drawing.Point(162, 202);
            this.txtNomAbonne.Name = "txtNomAbonne";
            this.txtNomAbonne.Size = new System.Drawing.Size(214, 27);
            this.txtNomAbonne.TabIndex = 62;
            this.txtNomAbonne.Visible = false;
            // 
            // lblAffiche
            // 
            this.lblAffiche.AutoSize = true;
            this.lblAffiche.BackColor = System.Drawing.Color.Transparent;
            this.lblAffiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffiche.ForeColor = System.Drawing.Color.Black;
            this.lblAffiche.Location = new System.Drawing.Point(287, 49);
            this.lblAffiche.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblAffiche.Name = "lblAffiche";
            this.lblAffiche.Size = new System.Drawing.Size(118, 31);
            this.lblAffiche.TabIndex = 63;
            this.lblAffiche.Text = "Rapport";
            this.lblAffiche.Visible = false;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Enabled = false;
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(309, 124);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(212, 27);
            this.txtRecherche.TabIndex = 65;
            this.txtRecherche.Visible = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(555, 128);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(131, 27);
            this.btnRechercher.TabIndex = 66;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Visible = false;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnPremier
            // 
            this.BtnPremier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPremier.Image = ((System.Drawing.Image)(resources.GetObject("BtnPremier.Image")));
            this.BtnPremier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPremier.Name = "BtnPremier";
            this.BtnPremier.Size = new System.Drawing.Size(29, 24);
            this.BtnPremier.Text = "toolStripButton1";
            // 
            // BtnPrecedent
            // 
            this.BtnPrecedent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrecedent.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrecedent.Image")));
            this.BtnPrecedent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrecedent.Name = "BtnPrecedent";
            this.BtnPrecedent.Size = new System.Drawing.Size(29, 24);
            this.BtnPrecedent.Text = "toolStripButton2";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tbIndex
            // 
            this.tbIndex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(164, 27);
            // 
            // toolStripLblTotal
            // 
            this.toolStripLblTotal.Name = "toolStripLblTotal";
            this.toolStripLblTotal.Size = new System.Drawing.Size(48, 24);
            this.toolStripLblTotal.Text = "de {0}";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // BtnSuivant
            // 
            this.BtnSuivant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSuivant.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuivant.Image")));
            this.BtnSuivant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSuivant.Name = "BtnSuivant";
            this.BtnSuivant.Size = new System.Drawing.Size(29, 24);
            this.BtnSuivant.Text = "toolStripButton3";
            // 
            // BtnDernier
            // 
            this.BtnDernier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDernier.Image = ((System.Drawing.Image)(resources.GetObject("BtnDernier.Image")));
            this.BtnDernier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDernier.Name = "BtnDernier";
            this.BtnDernier.Size = new System.Drawing.Size(29, 24);
            this.BtnDernier.Text = "toolStripButton4";
            // 
            // frmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(lblRecherche);
            this.Controls.Add(this.lblAffiche);
            this.Controls.Add(this.txtNomAbonne);
            this.Controls.Add(lblNomAbonne);
            this.Controls.Add(lblTypeService);
            this.Controls.Add(this.txtTypeService);
            this.Controls.Add(this.dateDepenseDateTimePicker);
            this.Controls.Add(this.nudMontant);
            this.Controls.Add(this.txtNomEmploye);
            this.Controls.Add(lblNomEmploye);
            this.Controls.Add(lblMontant);
            this.Controls.Add(lblDateDepense);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRapports";
            this.Text = "frmRapports";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rapportDesDépensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dépensesParAbonnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dépensesParAnnéeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dépensesParEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rapportPartiesJouéesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partiesJouéesParTerrainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partiesJouéesParAbonnementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partiesJouéesParAnnéeToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudMontant;
        private System.Windows.Forms.TextBox txtNomEmploye;
        private System.Windows.Forms.BindingSource depensesBindingSource;
        private System.Windows.Forms.DateTimePicker dateDepenseDateTimePicker;
        private System.Windows.Forms.TextBox txtTypeService;
        private System.Windows.Forms.TextBox txtNomAbonne;
        private System.Windows.Forms.Label lblAffiche;
        private System.Windows.Forms.TextBox txtRecherche;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnPremier;
        private System.Windows.Forms.ToolStripButton BtnPrecedent;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox tbIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLblTotal;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BtnSuivant;
        private System.Windows.Forms.ToolStripButton BtnDernier;
    }
}