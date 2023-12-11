namespace ProjetFinal
{
    partial class frmPartieGolf
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
            System.Windows.Forms.Label remarqueLabel;
            System.Windows.Forms.Label pointageLabel;
            System.Windows.Forms.Label noTerrainLabel;
            System.Windows.Forms.Label idAbonnementLabel;
            System.Windows.Forms.Label datePartieLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartieGolf));
            this.label1 = new System.Windows.Forms.Label();
            this.partiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.pointageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noTerrainTextBox = new System.Windows.Forms.TextBox();
            this.idAbonnementTextBox = new System.Windows.Forms.TextBox();
            this.datePartieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnPremier = new System.Windows.Forms.ToolStripButton();
            this.BtnPrecedent = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tbIndex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLblTotal = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BtnSuivant = new System.Windows.Forms.ToolStripButton();
            this.BtnDernier = new System.Windows.Forms.ToolStripButton();
            remarqueLabel = new System.Windows.Forms.Label();
            pointageLabel = new System.Windows.Forms.Label();
            noTerrainLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            datePartieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageNumericUpDown)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.BackColor = System.Drawing.Color.Transparent;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.ForeColor = System.Drawing.Color.Aqua;
            remarqueLabel.Location = new System.Drawing.Point(56, 360);
            remarqueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(100, 20);
            remarqueLabel.TabIndex = 3;
            remarqueLabel.Text = "Remarque:";
            // 
            // pointageLabel
            // 
            pointageLabel.AutoSize = true;
            pointageLabel.BackColor = System.Drawing.Color.Transparent;
            pointageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pointageLabel.ForeColor = System.Drawing.Color.Aqua;
            pointageLabel.Location = new System.Drawing.Point(538, 314);
            pointageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pointageLabel.Name = "pointageLabel";
            pointageLabel.Size = new System.Drawing.Size(88, 20);
            pointageLabel.TabIndex = 4;
            pointageLabel.Text = "Pointage:";
            // 
            // noTerrainLabel
            // 
            noTerrainLabel.AutoSize = true;
            noTerrainLabel.BackColor = System.Drawing.Color.Transparent;
            noTerrainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTerrainLabel.ForeColor = System.Drawing.Color.Aqua;
            noTerrainLabel.Location = new System.Drawing.Point(527, 186);
            noTerrainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noTerrainLabel.Name = "noTerrainLabel";
            noTerrainLabel.Size = new System.Drawing.Size(104, 20);
            noTerrainLabel.TabIndex = 6;
            noTerrainLabel.Text = "No Terrain:";
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.BackColor = System.Drawing.Color.Transparent;
            idAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAbonnementLabel.ForeColor = System.Drawing.Color.Aqua;
            idAbonnementLabel.Location = new System.Drawing.Point(50, 241);
            idAbonnementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(139, 20);
            idAbonnementLabel.TabIndex = 8;
            idAbonnementLabel.Text = "Id Abonnement:";
            // 
            // datePartieLabel
            // 
            datePartieLabel.AutoSize = true;
            datePartieLabel.BackColor = System.Drawing.Color.Transparent;
            datePartieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePartieLabel.ForeColor = System.Drawing.Color.Aqua;
            datePartieLabel.Location = new System.Drawing.Point(51, 109);
            datePartieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            datePartieLabel.Name = "datePartieLabel";
            datePartieLabel.Size = new System.Drawing.Size(111, 20);
            datePartieLabel.TabIndex = 10;
            datePartieLabel.Text = "Date Partie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(377, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parties jouées";
            // 
            // partiesJoueesBindingSource
            // 
            this.partiesJoueesBindingSource.DataSource = typeof(ProjetFinal.PartiesJouees);
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "Remarque", true));
            this.remarqueTextBox.Enabled = false;
            this.remarqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(215, 357);
            this.remarqueTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(294, 26);
            this.remarqueTextBox.TabIndex = 4;
            // 
            // pointageNumericUpDown
            // 
            this.pointageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesJoueesBindingSource, "Pointage", true));
            this.pointageNumericUpDown.Enabled = false;
            this.pointageNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointageNumericUpDown.Location = new System.Drawing.Point(668, 311);
            this.pointageNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.pointageNumericUpDown.Name = "pointageNumericUpDown";
            this.pointageNumericUpDown.Size = new System.Drawing.Size(160, 26);
            this.pointageNumericUpDown.TabIndex = 5;
            // 
            // noTerrainTextBox
            // 
            this.noTerrainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "NoTerrain", true));
            this.noTerrainTextBox.Enabled = false;
            this.noTerrainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTerrainTextBox.Location = new System.Drawing.Point(668, 182);
            this.noTerrainTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.noTerrainTextBox.Name = "noTerrainTextBox";
            this.noTerrainTextBox.Size = new System.Drawing.Size(132, 26);
            this.noTerrainTextBox.TabIndex = 7;
            // 
            // idAbonnementTextBox
            // 
            this.idAbonnementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "IdAbonnement", true));
            this.idAbonnementTextBox.Enabled = false;
            this.idAbonnementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAbonnementTextBox.Location = new System.Drawing.Point(215, 237);
            this.idAbonnementTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idAbonnementTextBox.Name = "idAbonnementTextBox";
            this.idAbonnementTextBox.Size = new System.Drawing.Size(132, 26);
            this.idAbonnementTextBox.TabIndex = 9;
            this.idAbonnementTextBox.TextChanged += new System.EventHandler(this.idAbonnementTextBox_TextChanged);
            // 
            // datePartieDateTimePicker
            // 
            this.datePartieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesJoueesBindingSource, "DatePartie", true));
            this.datePartieDateTimePicker.Enabled = false;
            this.datePartieDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePartieDateTimePicker.Location = new System.Drawing.Point(215, 103);
            this.datePartieDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.datePartieDateTimePicker.Name = "datePartieDateTimePicker";
            this.datePartieDateTimePicker.Size = new System.Drawing.Size(265, 26);
            this.datePartieDateTimePicker.TabIndex = 11;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(322, 486);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(335, 34);
            this.btnAjouter.TabIndex = 14;
            this.btnAjouter.Text = "Ajouter une partie";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
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
            this.toolStrip1.Location = new System.Drawing.Point(0, 577);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(851, 31);
            this.toolStrip1.TabIndex = 35;
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
            this.tbIndex.Size = new System.Drawing.Size(132, 31);
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
            // frmPartieGolf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(851, 608);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(datePartieLabel);
            this.Controls.Add(this.datePartieDateTimePicker);
            this.Controls.Add(idAbonnementLabel);
            this.Controls.Add(this.idAbonnementTextBox);
            this.Controls.Add(noTerrainLabel);
            this.Controls.Add(this.noTerrainTextBox);
            this.Controls.Add(pointageLabel);
            this.Controls.Add(this.pointageNumericUpDown);
            this.Controls.Add(remarqueLabel);
            this.Controls.Add(this.remarqueTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPartieGolf";
            this.Text = "frmPartieGolf";
            this.Load += new System.EventHandler(this.frmPartieGolf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageNumericUpDown)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource partiesJoueesBindingSource;
        private System.Windows.Forms.TextBox remarqueTextBox;
        private System.Windows.Forms.NumericUpDown pointageNumericUpDown;
        private System.Windows.Forms.TextBox noTerrainTextBox;
        private System.Windows.Forms.TextBox idAbonnementTextBox;
        private System.Windows.Forms.DateTimePicker datePartieDateTimePicker;
        private System.Windows.Forms.Button btnAjouter;
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