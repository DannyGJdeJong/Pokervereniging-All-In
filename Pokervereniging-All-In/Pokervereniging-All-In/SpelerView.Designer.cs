namespace Pokervereniging_All_In
{
    partial class SpelerView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpelerView));
            this.lstSpeler = new System.Windows.Forms.ListView();
            this.naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddSpeler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSpeler
            // 
            this.lstSpeler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naam,
            this.adres,
            this.emailadres});
            this.lstSpeler.FullRowSelect = true;
            this.lstSpeler.GridLines = true;
            this.lstSpeler.Location = new System.Drawing.Point(11, 11);
            this.lstSpeler.Margin = new System.Windows.Forms.Padding(2);
            this.lstSpeler.MultiSelect = false;
            this.lstSpeler.Name = "lstSpeler";
            this.lstSpeler.Size = new System.Drawing.Size(604, 318);
            this.lstSpeler.TabIndex = 2;
            this.lstSpeler.UseCompatibleStateImageBehavior = false;
            this.lstSpeler.View = System.Windows.Forms.View.Details;
            this.lstSpeler.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSpeler_MouseDoubleClick);
            // 
            // naam
            // 
            this.naam.Text = "Naam";
            this.naam.Width = 156;
            // 
            // adres
            // 
            this.adres.Text = "Adres";
            this.adres.Width = 231;
            // 
            // emailadres
            // 
            this.emailadres.Text = "Emailadres";
            this.emailadres.Width = 213;
            // 
            // btnAddSpeler
            // 
            this.btnAddSpeler.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddSpeler.Location = new System.Drawing.Point(11, 340);
            this.btnAddSpeler.Name = "btnAddSpeler";
            this.btnAddSpeler.Size = new System.Drawing.Size(105, 23);
            this.btnAddSpeler.TabIndex = 3;
            this.btnAddSpeler.Text = "Voeg Speler Toe";
            this.btnAddSpeler.UseVisualStyleBackColor = true;
            this.btnAddSpeler.Click += new System.EventHandler(this.btnAddSpeler_Click);
            // 
            // SpelerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 375);
            this.Controls.Add(this.btnAddSpeler);
            this.Controls.Add(this.lstSpeler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpelerView";
            this.Text = "SpelerView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstSpeler;
        private System.Windows.Forms.ColumnHeader naam;
        private System.Windows.Forms.ColumnHeader adres;
        private System.Windows.Forms.ColumnHeader emailadres;
        private System.Windows.Forms.Button btnAddSpeler;
    }
}