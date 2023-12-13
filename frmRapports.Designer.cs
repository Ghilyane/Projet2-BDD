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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRapports));
            this.lblNomEmploye = new System.Windows.Forms.Label();
            this.lblMontant = new System.Windows.Forms.Label();
            this.lblDateDepense = new System.Windows.Forms.Label();
            this.lblTypeService = new System.Windows.Forms.Label();
            this.lblNomAbonne = new System.Windows.Forms.Label();
            this.lblRecherche = new System.Windows.Forms.Label();
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
            this.depensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtNomEmploye = new System.Windows.Forms.TextBox();
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
            this.txtIdAbonne = new System.Windows.Forms.TextBox();
            this.txtNoEmp = new System.Windows.Forms.TextBox();
            this.partiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblDatePartie = new System.Windows.Forms.Label();
            this.datePartieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblPointage = new System.Windows.Forms.Label();
            this.nudPointage = new System.Windows.Forms.NumericUpDown();
            this.lblTerrain = new System.Windows.Forms.Label();
            this.txtTerrain = new System.Windows.Forms.TextBox();
            this.txtIdAbonnementPartie = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomEmploye
            // 
            this.lblNomEmploye.AutoSize = true;
            this.lblNomEmploye.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomEmploye.Location = new System.Drawing.Point(374, 232);
            this.lblNomEmploye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomEmploye.Name = "lblNomEmploye";
            this.lblNomEmploye.Size = new System.Drawing.Size(108, 16);
            this.lblNomEmploye.TabIndex = 53;
            this.lblNomEmploye.Text = "Nom Employé:";
            this.lblNomEmploye.Visible = false;
            // 
            // lblMontant
            // 
            this.lblMontant.AutoSize = true;
            this.lblMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontant.Location = new System.Drawing.Point(11, 399);
            this.lblMontant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMontant.Name = "lblMontant";
            this.lblMontant.Size = new System.Drawing.Size(65, 16);
            this.lblMontant.TabIndex = 45;
            this.lblMontant.Text = "Montant:";
            this.lblMontant.Visible = false;
            // 
            // lblDateDepense
            // 
            this.lblDateDepense.AutoSize = true;
            this.lblDateDepense.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateDepense.Location = new System.Drawing.Point(374, 325);
            this.lblDateDepense.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDateDepense.Name = "lblDateDepense";
            this.lblDateDepense.Size = new System.Drawing.Size(111, 16);
            this.lblDateDepense.TabIndex = 42;
            this.lblDateDepense.Text = "Date Depense:";
            this.lblDateDepense.Visible = false;
            // 
            // lblTypeService
            // 
            this.lblTypeService.AutoSize = true;
            this.lblTypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeService.Location = new System.Drawing.Point(11, 317);
            this.lblTypeService.Name = "lblTypeService";
            this.lblTypeService.Size = new System.Drawing.Size(104, 16);
            this.lblTypeService.TabIndex = 59;
            this.lblTypeService.Text = "Type Service:";
            this.lblTypeService.Visible = false;
            // 
            // lblNomAbonne
            // 
            this.lblNomAbonne.AutoSize = true;
            this.lblNomAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomAbonne.Location = new System.Drawing.Point(16, 227);
            this.lblNomAbonne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomAbonne.Name = "lblNomAbonne";
            this.lblNomAbonne.Size = new System.Drawing.Size(100, 16);
            this.lblNomAbonne.TabIndex = 61;
            this.lblNomAbonne.Text = "Nom Abonné:";
            this.lblNomAbonne.Visible = false;
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecherche.Location = new System.Drawing.Point(11, 141);
            this.lblRecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(122, 16);
            this.lblRecherche.TabIndex = 64;
            this.lblRecherche.Text = "Entrez le nom de";
            this.lblRecherche.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rapportDesDépensesToolStripMenuItem,
            this.rapportPartiesJouéesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 493);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(809, 30);
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
            this.rapportDesDépensesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
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
            this.rapportPartiesJouéesToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.rapportPartiesJouéesToolStripMenuItem.Text = "Rapport parties jouées";
            // 
            // partiesJouéesParTerrainToolStripMenuItem
            // 
            this.partiesJouéesParTerrainToolStripMenuItem.Name = "partiesJouéesParTerrainToolStripMenuItem";
            this.partiesJouéesParTerrainToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.partiesJouéesParTerrainToolStripMenuItem.Text = "Parties jouées par terrain";
            this.partiesJouéesParTerrainToolStripMenuItem.Click += new System.EventHandler(this.partiesJouéesParTerrainToolStripMenuItem_Click);
            // 
            // partiesJouéesParAbonnementToolStripMenuItem
            // 
            this.partiesJouéesParAbonnementToolStripMenuItem.Name = "partiesJouéesParAbonnementToolStripMenuItem";
            this.partiesJouéesParAbonnementToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.partiesJouéesParAbonnementToolStripMenuItem.Text = "Parties jouées par abonnement";
            this.partiesJouéesParAbonnementToolStripMenuItem.Click += new System.EventHandler(this.partiesJouéesParAbonnementToolStripMenuItem_Click);
            // 
            // partiesJouéesParAnnéeToolStripMenuItem
            // 
            this.partiesJouéesParAnnéeToolStripMenuItem.Name = "partiesJouéesParAnnéeToolStripMenuItem";
            this.partiesJouéesParAnnéeToolStripMenuItem.Size = new System.Drawing.Size(296, 26);
            this.partiesJouéesParAnnéeToolStripMenuItem.Text = "Parties jouées par année";
            this.partiesJouéesParAnnéeToolStripMenuItem.Click += new System.EventHandler(this.partiesJouéesParAnnéeToolStripMenuItem_Click);
            // 
            // nudMontant
            // 
            this.nudMontant.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depensesBindingSource, "Montant", true));
            this.nudMontant.DecimalPlaces = 2;
            this.nudMontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudMontant.Location = new System.Drawing.Point(145, 399);
            this.nudMontant.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMontant.Name = "nudMontant";
            this.nudMontant.ReadOnly = true;
            this.nudMontant.Size = new System.Drawing.Size(156, 24);
            this.nudMontant.TabIndex = 55;
            this.nudMontant.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudMontant.Visible = false;
            // 
            // depensesBindingSource
            // 
            this.depensesBindingSource.DataSource = typeof(ProjetFinal.Depenses);
            // 
            // txtNomEmploye
            // 
            this.txtNomEmploye.Location = new System.Drawing.Point(502, 227);
            this.txtNomEmploye.Name = "txtNomEmploye";
            this.txtNomEmploye.ReadOnly = true;
            this.txtNomEmploye.Size = new System.Drawing.Size(202, 24);
            this.txtNomEmploye.TabIndex = 54;
            this.txtNomEmploye.Visible = false;
            // 
            // dateDepenseDateTimePicker
            // 
            this.dateDepenseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depensesBindingSource, "DateDepense", true));
            this.dateDepenseDateTimePicker.Enabled = false;
            this.dateDepenseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDepenseDateTimePicker.Location = new System.Drawing.Point(502, 317);
            this.dateDepenseDateTimePicker.Name = "dateDepenseDateTimePicker";
            this.dateDepenseDateTimePicker.Size = new System.Drawing.Size(202, 27);
            this.dateDepenseDateTimePicker.TabIndex = 57;
            this.dateDepenseDateTimePicker.Visible = false;
            // 
            // txtTypeService
            // 
            this.txtTypeService.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Services.TypeService", true));
            this.txtTypeService.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeService.Location = new System.Drawing.Point(145, 317);
            this.txtTypeService.Name = "txtTypeService";
            this.txtTypeService.ReadOnly = true;
            this.txtTypeService.Size = new System.Drawing.Size(213, 24);
            this.txtTypeService.TabIndex = 60;
            this.txtTypeService.Visible = false;
            // 
            // txtNomAbonne
            // 
            this.txtNomAbonne.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomAbonne.Location = new System.Drawing.Point(145, 227);
            this.txtNomAbonne.Name = "txtNomAbonne";
            this.txtNomAbonne.ReadOnly = true;
            this.txtNomAbonne.Size = new System.Drawing.Size(213, 24);
            this.txtNomAbonne.TabIndex = 62;
            this.txtNomAbonne.Visible = false;
            // 
            // lblAffiche
            // 
            this.lblAffiche.AutoSize = true;
            this.lblAffiche.BackColor = System.Drawing.Color.Transparent;
            this.lblAffiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffiche.ForeColor = System.Drawing.Color.Black;
            this.lblAffiche.Location = new System.Drawing.Point(197, 53);
            this.lblAffiche.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lblAffiche.Name = "lblAffiche";
            this.lblAffiche.Size = new System.Drawing.Size(118, 31);
            this.lblAffiche.TabIndex = 63;
            this.lblAffiche.Text = "Rapport";
            this.lblAffiche.Visible = false;
            // 
            // txtRecherche
            // 
            this.txtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecherche.Location = new System.Drawing.Point(203, 135);
            this.txtRecherche.Name = "txtRecherche";
            this.txtRecherche.Size = new System.Drawing.Size(264, 27);
            this.txtRecherche.TabIndex = 65;
            this.txtRecherche.Visible = false;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(514, 131);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(163, 34);
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
            this.toolStrip1.Size = new System.Drawing.Size(809, 31);
            this.toolStrip1.TabIndex = 67;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnPremier
            // 
            this.BtnPremier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPremier.Image = ((System.Drawing.Image)(resources.GetObject("BtnPremier.Image")));
            this.BtnPremier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPremier.Name = "BtnPremier";
            this.BtnPremier.Size = new System.Drawing.Size(29, 28);
            this.BtnPremier.Text = "toolStripButton1";
            this.BtnPremier.Click += new System.EventHandler(this.BtnPremier_Click);
            // 
            // BtnPrecedent
            // 
            this.BtnPrecedent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnPrecedent.Image = ((System.Drawing.Image)(resources.GetObject("BtnPrecedent.Image")));
            this.BtnPrecedent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPrecedent.Name = "BtnPrecedent";
            this.BtnPrecedent.Size = new System.Drawing.Size(29, 28);
            this.BtnPrecedent.Text = "toolStripButton2";
            this.BtnPrecedent.Click += new System.EventHandler(this.BtnPrecedent_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // tbIndex
            // 
            this.tbIndex.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(204, 31);
            this.tbIndex.TextChanged += new System.EventHandler(this.tbIndex_TextChanged);
            // 
            // toolStripLblTotal
            // 
            this.toolStripLblTotal.Name = "toolStripLblTotal";
            this.toolStripLblTotal.Size = new System.Drawing.Size(48, 28);
            this.toolStripLblTotal.Text = "de {0}";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // BtnSuivant
            // 
            this.BtnSuivant.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnSuivant.Image = ((System.Drawing.Image)(resources.GetObject("BtnSuivant.Image")));
            this.BtnSuivant.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnSuivant.Name = "BtnSuivant";
            this.BtnSuivant.Size = new System.Drawing.Size(29, 28);
            this.BtnSuivant.Text = "toolStripButton3";
            this.BtnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // BtnDernier
            // 
            this.BtnDernier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BtnDernier.Image = ((System.Drawing.Image)(resources.GetObject("BtnDernier.Image")));
            this.BtnDernier.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnDernier.Name = "BtnDernier";
            this.BtnDernier.Size = new System.Drawing.Size(29, 28);
            this.BtnDernier.Text = "toolStripButton4";
            this.BtnDernier.Click += new System.EventHandler(this.BtnDernier_Click);
            // 
            // txtIdAbonne
            // 
            this.txtIdAbonne.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "IdAbonnement", true));
            this.txtIdAbonne.Location = new System.Drawing.Point(604, 436);
            this.txtIdAbonne.Name = "txtIdAbonne";
            this.txtIdAbonne.Size = new System.Drawing.Size(100, 24);
            this.txtIdAbonne.TabIndex = 69;
            // 
            // txtNoEmp
            // 
            this.txtNoEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Services.Employes.No", true));
            this.txtNoEmp.Location = new System.Drawing.Point(498, 436);
            this.txtNoEmp.Name = "txtNoEmp";
            this.txtNoEmp.Size = new System.Drawing.Size(100, 24);
            this.txtNoEmp.TabIndex = 70;
            // 
            // partiesJoueesBindingSource
            // 
            this.partiesJoueesBindingSource.DataSource = typeof(ProjetFinal.PartiesJouees);
            // 
            // lblDatePartie
            // 
            this.lblDatePartie.AutoSize = true;
            this.lblDatePartie.Location = new System.Drawing.Point(395, 320);
            this.lblDatePartie.Name = "lblDatePartie";
            this.lblDatePartie.Size = new System.Drawing.Size(97, 18);
            this.lblDatePartie.TabIndex = 70;
            this.lblDatePartie.Text = "Date Partie:";
            this.lblDatePartie.Visible = false;
            // 
            // datePartieDateTimePicker
            // 
            this.datePartieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesJoueesBindingSource, "DatePartie", true));
            this.datePartieDateTimePicker.Location = new System.Drawing.Point(498, 320);
            this.datePartieDateTimePicker.Name = "datePartieDateTimePicker";
            this.datePartieDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.datePartieDateTimePicker.TabIndex = 71;
            this.datePartieDateTimePicker.Visible = false;
            // 
            // lblPointage
            // 
            this.lblPointage.AutoSize = true;
            this.lblPointage.Location = new System.Drawing.Point(16, 320);
            this.lblPointage.Name = "lblPointage";
            this.lblPointage.Size = new System.Drawing.Size(79, 18);
            this.lblPointage.TabIndex = 72;
            this.lblPointage.Text = "Pointage:";
            this.lblPointage.Visible = false;
            // 
            // nudPointage
            // 
            this.nudPointage.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesJoueesBindingSource, "Pointage", true));
            this.nudPointage.Location = new System.Drawing.Point(145, 318);
            this.nudPointage.Name = "nudPointage";
            this.nudPointage.ReadOnly = true;
            this.nudPointage.Size = new System.Drawing.Size(120, 24);
            this.nudPointage.TabIndex = 73;
            this.nudPointage.Visible = false;
            // 
            // lblTerrain
            // 
            this.lblTerrain.AutoSize = true;
            this.lblTerrain.Location = new System.Drawing.Point(395, 230);
            this.lblTerrain.Name = "lblTerrain";
            this.lblTerrain.Size = new System.Drawing.Size(66, 18);
            this.lblTerrain.TabIndex = 73;
            this.lblTerrain.Text = "Terrain:";
            this.lblTerrain.Visible = false;
            // 
            // txtTerrain
            // 
            this.txtTerrain.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "Terrains.Nom", true));
            this.txtTerrain.Location = new System.Drawing.Point(498, 227);
            this.txtTerrain.Name = "txtTerrain";
            this.txtTerrain.ReadOnly = true;
            this.txtTerrain.Size = new System.Drawing.Size(194, 24);
            this.txtTerrain.TabIndex = 74;
            this.txtTerrain.Visible = false;
            // 
            // txtIdAbonnementPartie
            // 
            this.txtIdAbonnementPartie.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "IdAbonnement", true));
            this.txtIdAbonnementPartie.Location = new System.Drawing.Point(392, 436);
            this.txtIdAbonnementPartie.Name = "txtIdAbonnementPartie";
            this.txtIdAbonnementPartie.Size = new System.Drawing.Size(100, 24);
            this.txtIdAbonnementPartie.TabIndex = 75;
            // 
            // frmRapports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 523);
            this.Controls.Add(this.txtIdAbonnementPartie);
            this.Controls.Add(this.lblTerrain);
            this.Controls.Add(this.txtTerrain);
            this.Controls.Add(this.lblPointage);
            this.Controls.Add(this.nudPointage);
            this.Controls.Add(this.lblDatePartie);
            this.Controls.Add(this.datePartieDateTimePicker);
            this.Controls.Add(this.txtNoEmp);
            this.Controls.Add(this.txtIdAbonne);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.lblAffiche);
            this.Controls.Add(this.txtNomAbonne);
            this.Controls.Add(this.lblNomAbonne);
            this.Controls.Add(this.lblTypeService);
            this.Controls.Add(this.txtTypeService);
            this.Controls.Add(this.dateDepenseDateTimePicker);
            this.Controls.Add(this.nudMontant);
            this.Controls.Add(this.txtNomEmploye);
            this.Controls.Add(this.lblNomEmploye);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.lblDateDepense);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRapports";
            this.Text = "frmRapports";
            this.Load += new System.EventHandler(this.frmRapports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPointage)).EndInit();
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
        private System.Windows.Forms.Label lblNomEmploye;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.Label lblDateDepense;
        private System.Windows.Forms.Label lblTypeService;
        private System.Windows.Forms.Label lblNomAbonne;
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.TextBox txtIdAbonne;
        private System.Windows.Forms.TextBox txtNoEmp;
        private System.Windows.Forms.BindingSource partiesJoueesBindingSource;
        private System.Windows.Forms.DateTimePicker datePartieDateTimePicker;
        private System.Windows.Forms.NumericUpDown nudPointage;
        private System.Windows.Forms.TextBox txtTerrain;
        private System.Windows.Forms.Label lblDatePartie;
        private System.Windows.Forms.Label lblPointage;
        private System.Windows.Forms.Label lblTerrain;
        private System.Windows.Forms.TextBox txtIdAbonnementPartie;
    }
}