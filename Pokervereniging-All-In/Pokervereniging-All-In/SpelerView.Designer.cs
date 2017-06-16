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
            this.lstToernooi = new System.Windows.Forms.ListView();
            this.naam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.adres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.emailadres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstToernooi
            // 
            this.lstToernooi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.naam,
            this.adres,
            this.emailadres});
            this.lstToernooi.FullRowSelect = true;
            this.lstToernooi.GridLines = true;
            this.lstToernooi.Location = new System.Drawing.Point(11, 11);
            this.lstToernooi.Margin = new System.Windows.Forms.Padding(2);
            this.lstToernooi.MultiSelect = false;
            this.lstToernooi.Name = "lstToernooi";
            this.lstToernooi.Size = new System.Drawing.Size(604, 318);
            this.lstToernooi.TabIndex = 2;
            this.lstToernooi.UseCompatibleStateImageBehavior = false;
            this.lstToernooi.View = System.Windows.Forms.View.Details;
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
            // SpelerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 375);
            this.Controls.Add(this.lstToernooi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SpelerView";
            this.Text = "SpelerView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstToernooi;
        private System.Windows.Forms.ColumnHeader naam;
        private System.Windows.Forms.ColumnHeader adres;
        private System.Windows.Forms.ColumnHeader emailadres;
    }
}