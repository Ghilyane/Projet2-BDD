namespace ProjetFinal
{
    partial class frmConnnexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConnnexion));
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.lblMessageErreur = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rage Italic", 34.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 73);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenue!";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 405);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // tbMDP
            // 
            this.tbMDP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbMDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.tbMDP.Location = new System.Drawing.Point(48, 202);
            this.tbMDP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMDP.MinimumSize = new System.Drawing.Size(4, 22);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(304, 31);
            this.tbMDP.TabIndex = 8;
            this.tbMDP.UseSystemPasswordChar = true;
            this.tbMDP.Enter += new System.EventHandler(this.tbMDP_Enter);
            this.tbMDP.Leave += new System.EventHandler(this.tbMDP_Leave);
            // 
            // tbNom
            // 
            this.tbNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.2F);
            this.tbNom.Location = new System.Drawing.Point(48, 158);
            this.tbNom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNom.MinimumSize = new System.Drawing.Size(4, 22);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(304, 31);
            this.tbNom.TabIndex = 7;
            this.tbNom.Enter += new System.EventHandler(this.tbNom_Enter);
            this.tbNom.Leave += new System.EventHandler(this.tbNom_Leave);
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(111, 277);
            this.btnConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(161, 44);
            this.btnConnexion.TabIndex = 6;
            this.btnConnexion.Text = "Se connecter";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // lblMessageErreur
            // 
            this.lblMessageErreur.AutoSize = true;
            this.lblMessageErreur.Location = new System.Drawing.Point(45, 251);
            this.lblMessageErreur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessageErreur.Name = "lblMessageErreur";
            this.lblMessageErreur.Size = new System.Drawing.Size(0, 16);
            this.lblMessageErreur.TabIndex = 9;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(381, 71);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 319);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // frmConnnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 405);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblMessageErreur);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConnnexion";
            this.Text = "Connnexion";
            this.Load += new System.EventHandler(this.frmConnnexion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.Label lblMessageErreur;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}