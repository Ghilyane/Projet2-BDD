namespace ProjetFinal
{
    partial class AjoutPartiesDeGolf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AjoutPartiesDeGolf));
            this.nudComptage = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAbonnement = new System.Windows.Forms.ComboBox();
            this.cbTerrain = new System.Windows.Forms.ComboBox();
            this.txtRemarque = new System.Windows.Forms.TextBox();
            this.datePartie = new System.Windows.Forms.DateTimePicker();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.errMessage = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudComptage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).BeginInit();
            this.SuspendLayout();
            // 
            // nudComptage
            // 
            this.nudComptage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudComptage.Location = new System.Drawing.Point(226, 318);
            this.nudComptage.Margin = new System.Windows.Forms.Padding(4);
            this.nudComptage.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudComptage.Name = "nudComptage";
            this.nudComptage.Size = new System.Drawing.Size(180, 26);
            this.nudComptage.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(450, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ajout d\'une partie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(505, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Remarque:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(499, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date de la partie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(10, 208);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Terrain:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Cyan;
            this.label5.Location = new System.Drawing.Point(18, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Abonnement:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Cyan;
            this.label6.Location = new System.Drawing.Point(10, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Pointage:";
            // 
            // cbAbonnement
            // 
            this.cbAbonnement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAbonnement.FormattingEnabled = true;
            this.cbAbonnement.Location = new System.Drawing.Point(226, 112);
            this.cbAbonnement.Margin = new System.Windows.Forms.Padding(4);
            this.cbAbonnement.Name = "cbAbonnement";
            this.cbAbonnement.Size = new System.Drawing.Size(228, 28);
            this.cbAbonnement.TabIndex = 9;
            // 
            // cbTerrain
            // 
            this.cbTerrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerrain.FormattingEnabled = true;
            this.cbTerrain.Location = new System.Drawing.Point(226, 211);
            this.cbTerrain.Margin = new System.Windows.Forms.Padding(4);
            this.cbTerrain.Name = "cbTerrain";
            this.cbTerrain.Size = new System.Drawing.Size(228, 28);
            this.cbTerrain.TabIndex = 10;
            // 
            // txtRemarque
            // 
            this.txtRemarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarque.Location = new System.Drawing.Point(676, 270);
            this.txtRemarque.Margin = new System.Windows.Forms.Padding(4);
            this.txtRemarque.Name = "txtRemarque";
            this.txtRemarque.Size = new System.Drawing.Size(232, 26);
            this.txtRemarque.TabIndex = 11;
            // 
            // datePartie
            // 
            this.datePartie.Enabled = false;
            this.datePartie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePartie.Location = new System.Drawing.Point(676, 156);
            this.datePartie.Margin = new System.Windows.Forms.Padding(4);
            this.datePartie.Name = "datePartie";
            this.datePartie.Size = new System.Drawing.Size(298, 26);
            this.datePartie.TabIndex = 12;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(263, 442);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(191, 34);
            this.btnAjouter.TabIndex = 13;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(654, 442);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(194, 34);
            this.btnAnnuler.TabIndex = 14;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // errMessage
            // 
            this.errMessage.ContainerControl = this;
            // 
            // AjoutPartiesDeGolf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 512);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.datePartie);
            this.Controls.Add(this.txtRemarque);
            this.Controls.Add(this.cbTerrain);
            this.Controls.Add(this.cbAbonnement);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudComptage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AjoutPartiesDeGolf";
            this.Text = "AjoutPartiesDeGolf";
            this.Load += new System.EventHandler(this.AjoutPartiesDeGolf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudComptage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMessage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudComptage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAbonnement;
        private System.Windows.Forms.ComboBox cbTerrain;
        private System.Windows.Forms.TextBox txtRemarque;
        private System.Windows.Forms.DateTimePicker datePartie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.ErrorProvider errMessage;
    }
}