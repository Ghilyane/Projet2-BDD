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
            this.label1 = new System.Windows.Forms.Label();
            this.partiesJoueesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.pointageNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.noTerrainTextBox = new System.Windows.Forms.TextBox();
            this.idAbonnementTextBox = new System.Windows.Forms.TextBox();
            this.datePartieDateTimePicker = new System.Windows.Forms.DateTimePicker();
            remarqueLabel = new System.Windows.Forms.Label();
            pointageLabel = new System.Windows.Forms.Label();
            noTerrainLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            datePartieLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.Location = new System.Drawing.Point(16, 292);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(85, 16);
            remarqueLabel.TabIndex = 3;
            remarqueLabel.Text = "Remarque:";
            // 
            // pointageLabel
            // 
            pointageLabel.AutoSize = true;
            pointageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pointageLabel.Location = new System.Drawing.Point(377, 254);
            pointageLabel.Name = "pointageLabel";
            pointageLabel.Size = new System.Drawing.Size(75, 16);
            pointageLabel.TabIndex = 4;
            pointageLabel.Text = "Pointage:";
            // 
            // noTerrainLabel
            // 
            noTerrainLabel.AutoSize = true;
            noTerrainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noTerrainLabel.Location = new System.Drawing.Point(369, 150);
            noTerrainLabel.Name = "noTerrainLabel";
            noTerrainLabel.Size = new System.Drawing.Size(88, 16);
            noTerrainLabel.TabIndex = 6;
            noTerrainLabel.Text = "No Terrain:";
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAbonnementLabel.Location = new System.Drawing.Point(11, 195);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(118, 16);
            idAbonnementLabel.TabIndex = 8;
            idAbonnementLabel.Text = "Id Abonnement:";
            // 
            // datePartieLabel
            // 
            datePartieLabel.AutoSize = true;
            datePartieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datePartieLabel.Location = new System.Drawing.Point(12, 88);
            datePartieLabel.Name = "datePartieLabel";
            datePartieLabel.Size = new System.Drawing.Size(93, 16);
            datePartieLabel.TabIndex = 10;
            datePartieLabel.Text = "Date Partie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
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
            this.remarqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(135, 289);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(100, 22);
            this.remarqueTextBox.TabIndex = 4;
            // 
            // pointageNumericUpDown
            // 
            this.pointageNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesJoueesBindingSource, "Pointage", true));
            this.pointageNumericUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointageNumericUpDown.Location = new System.Drawing.Point(475, 252);
            this.pointageNumericUpDown.Name = "pointageNumericUpDown";
            this.pointageNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.pointageNumericUpDown.TabIndex = 5;
            // 
            // noTerrainTextBox
            // 
            this.noTerrainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "NoTerrain", true));
            this.noTerrainTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTerrainTextBox.Location = new System.Drawing.Point(475, 147);
            this.noTerrainTextBox.Name = "noTerrainTextBox";
            this.noTerrainTextBox.Size = new System.Drawing.Size(100, 22);
            this.noTerrainTextBox.TabIndex = 7;
            // 
            // idAbonnementTextBox
            // 
            this.idAbonnementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.partiesJoueesBindingSource, "IdAbonnement", true));
            this.idAbonnementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAbonnementTextBox.Location = new System.Drawing.Point(135, 192);
            this.idAbonnementTextBox.Name = "idAbonnementTextBox";
            this.idAbonnementTextBox.Size = new System.Drawing.Size(100, 22);
            this.idAbonnementTextBox.TabIndex = 9;
            // 
            // datePartieDateTimePicker
            // 
            this.datePartieDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.partiesJoueesBindingSource, "DatePartie", true));
            this.datePartieDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePartieDateTimePicker.Location = new System.Drawing.Point(135, 83);
            this.datePartieDateTimePicker.Name = "datePartieDateTimePicker";
            this.datePartieDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.datePartieDateTimePicker.TabIndex = 11;
            // 
            // frmPartieGolf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 366);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPartieGolf";
            this.Text = "frmPartieGolf";
            this.Load += new System.EventHandler(this.frmPartieGolf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partiesJoueesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointageNumericUpDown)).EndInit();
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
    }
}