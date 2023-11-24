namespace ProjetFinal
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
            this.label1 = new System.Windows.Forms.Label();
            this.depensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDepenseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idAbonnementTextBox = new System.Windows.Forms.TextBox();
            this.montantTextBox = new System.Windows.Forms.TextBox();
            this.noTextBox = new System.Windows.Forms.TextBox();
            this.noServiceTextBox = new System.Windows.Forms.TextBox();
            this.remarqueTextBox = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            dateDepenseLabel = new System.Windows.Forms.Label();
            idAbonnementLabel = new System.Windows.Forms.Label();
            montantLabel = new System.Windows.Forms.Label();
            noLabel = new System.Windows.Forms.Label();
            noServiceLabel = new System.Windows.Forms.Label();
            remarqueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.depensesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(393, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dépenses";
            // 
            // depensesBindingSource
            // 
            this.depensesBindingSource.DataSource = typeof(ProjetFinal.Depenses);
            // 
            // dateDepenseLabel
            // 
            dateDepenseLabel.AutoSize = true;
            dateDepenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dateDepenseLabel.ForeColor = System.Drawing.Color.Aqua;
            dateDepenseLabel.Location = new System.Drawing.Point(69, 79);
            dateDepenseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dateDepenseLabel.Name = "dateDepenseLabel";
            dateDepenseLabel.Size = new System.Drawing.Size(119, 18);
            dateDepenseLabel.TabIndex = 3;
            dateDepenseLabel.Text = "Date Depense:";
            // 
            // dateDepenseDateTimePicker
            // 
            this.dateDepenseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.depensesBindingSource, "DateDepense", true));
            this.dateDepenseDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateDepenseDateTimePicker.Location = new System.Drawing.Point(245, 73);
            this.dateDepenseDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateDepenseDateTimePicker.Name = "dateDepenseDateTimePicker";
            this.dateDepenseDateTimePicker.Size = new System.Drawing.Size(348, 22);
            this.dateDepenseDateTimePicker.TabIndex = 4;
            // 
            // idAbonnementLabel
            // 
            idAbonnementLabel.AutoSize = true;
            idAbonnementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAbonnementLabel.ForeColor = System.Drawing.Color.Aqua;
            idAbonnementLabel.Location = new System.Drawing.Point(69, 181);
            idAbonnementLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idAbonnementLabel.Name = "idAbonnementLabel";
            idAbonnementLabel.Size = new System.Drawing.Size(110, 18);
            idAbonnementLabel.TabIndex = 4;
            idAbonnementLabel.Text = "Id Abonnement:";
            // 
            // idAbonnementTextBox
            // 
            this.idAbonnementTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "IdAbonnement", true));
            this.idAbonnementTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idAbonnementTextBox.Location = new System.Drawing.Point(245, 178);
            this.idAbonnementTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idAbonnementTextBox.Name = "idAbonnementTextBox";
            this.idAbonnementTextBox.Size = new System.Drawing.Size(215, 22);
            this.idAbonnementTextBox.TabIndex = 5;
            // 
            // montantLabel
            // 
            montantLabel.AutoSize = true;
            montantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            montantLabel.ForeColor = System.Drawing.Color.Aqua;
            montantLabel.Location = new System.Drawing.Point(73, 300);
            montantLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            montantLabel.Name = "montantLabel";
            montantLabel.Size = new System.Drawing.Size(66, 18);
            montantLabel.TabIndex = 5;
            montantLabel.Text = "Montant:";
            // 
            // montantTextBox
            // 
            this.montantTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Montant", true));
            this.montantTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantTextBox.Location = new System.Drawing.Point(245, 298);
            this.montantTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.montantTextBox.Name = "montantTextBox";
            this.montantTextBox.Size = new System.Drawing.Size(215, 22);
            this.montantTextBox.TabIndex = 6;
            // 
            // noLabel
            // 
            noLabel.AutoSize = true;
            noLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noLabel.ForeColor = System.Drawing.Color.Aqua;
            noLabel.Location = new System.Drawing.Point(538, 136);
            noLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noLabel.Name = "noLabel";
            noLabel.Size = new System.Drawing.Size(32, 18);
            noLabel.TabIndex = 7;
            noLabel.Text = "No:";
            // 
            // noTextBox
            // 
            this.noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "No", true));
            this.noTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noTextBox.Location = new System.Drawing.Point(635, 134);
            this.noTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noTextBox.Name = "noTextBox";
            this.noTextBox.Size = new System.Drawing.Size(151, 22);
            this.noTextBox.TabIndex = 8;
            // 
            // noServiceLabel
            // 
            noServiceLabel.AutoSize = true;
            noServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noServiceLabel.ForeColor = System.Drawing.Color.Aqua;
            noServiceLabel.Location = new System.Drawing.Point(533, 239);
            noServiceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            noServiceLabel.Name = "noServiceLabel";
            noServiceLabel.Size = new System.Drawing.Size(85, 18);
            noServiceLabel.TabIndex = 9;
            noServiceLabel.Text = "No Service:";
            // 
            // noServiceTextBox
            // 
            this.noServiceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "NoService", true));
            this.noServiceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noServiceTextBox.Location = new System.Drawing.Point(635, 238);
            this.noServiceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.noServiceTextBox.Name = "noServiceTextBox";
            this.noServiceTextBox.Size = new System.Drawing.Size(320, 22);
            this.noServiceTextBox.TabIndex = 10;
            // 
            // remarqueLabel
            // 
            remarqueLabel.AutoSize = true;
            remarqueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            remarqueLabel.ForeColor = System.Drawing.Color.Aqua;
            remarqueLabel.Location = new System.Drawing.Point(533, 355);
            remarqueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            remarqueLabel.Name = "remarqueLabel";
            remarqueLabel.Size = new System.Drawing.Size(81, 18);
            remarqueLabel.TabIndex = 11;
            remarqueLabel.Text = "Remarque:";
            // 
            // remarqueTextBox
            // 
            this.remarqueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.depensesBindingSource, "Remarque", true));
            this.remarqueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remarqueTextBox.Location = new System.Drawing.Point(635, 353);
            this.remarqueTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remarqueTextBox.Name = "remarqueTextBox";
            this.remarqueTextBox.Size = new System.Drawing.Size(215, 22);
            this.remarqueTextBox.TabIndex = 12;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(283, 439);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(335, 34);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter une dépense";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // frmDepenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 487);
            this.Controls.Add(this.btnAjouter);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDepenses";
            this.Text = "Depenses";
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
        private System.Windows.Forms.Button btnAjouter;
    }
}