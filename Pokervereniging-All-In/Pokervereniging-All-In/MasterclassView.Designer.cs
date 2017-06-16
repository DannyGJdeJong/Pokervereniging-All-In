namespace Pokervereniging_All_In.Database
{
    partial class MasterclassView
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
            this.MasterView = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Min_rating = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BekendeSpeler = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Locatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.E_code = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.BtUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MasterView
            // 
            this.MasterView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Datum,
            this.Min_rating,
            this.BekendeSpeler,
            this.Locatie,
            this.E_code});
            this.MasterView.FullRowSelect = true;
            this.MasterView.GridLines = true;
            this.MasterView.Location = new System.Drawing.Point(24, 12);
            this.MasterView.MultiSelect = false;
            this.MasterView.Name = "MasterView";
            this.MasterView.Size = new System.Drawing.Size(1386, 470);
            this.MasterView.TabIndex = 0;
            this.MasterView.UseCompatibleStateImageBehavior = false;
            this.MasterView.View = System.Windows.Forms.View.Details;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 100;
            // 
            // Min_rating
            // 
            this.Min_rating.Text = "Minimale_rating";
            this.Min_rating.Width = 175;
            // 
            // BekendeSpeler
            // 
            this.BekendeSpeler.Text = "Bekende_speler";
            this.BekendeSpeler.Width = 175;
            // 
            // Locatie
            // 
            this.Locatie.Text = "Locatie";
            this.Locatie.Width = 120;
            // 
            // E_code
            // 
            this.E_code.Text = "E_code";
            this.E_code.Width = 100;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Toevoegen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtUpdate
            // 
            this.BtUpdate.Location = new System.Drawing.Point(178, 497);
            this.BtUpdate.Name = "BtUpdate";
            this.BtUpdate.Size = new System.Drawing.Size(135, 50);
            this.BtUpdate.TabIndex = 3;
            this.BtUpdate.Text = "Wijzigen";
            this.BtUpdate.UseVisualStyleBackColor = true;
            this.BtUpdate.Click += new System.EventHandler(this.BtUpdate_Click);
            // 
            // MasterclassView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 565);
            this.Controls.Add(this.BtUpdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MasterView);
            this.Name = "MasterclassView";
            this.Text = "MasterclassView";
            this.Activated += new System.EventHandler(this.MasterclassView_Activated);
            this.Load += new System.EventHandler(this.MasterclassView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MasterView;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Min_rating;
        private System.Windows.Forms.ColumnHeader BekendeSpeler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtUpdate;
        private System.Windows.Forms.ColumnHeader Locatie;
        private System.Windows.Forms.ColumnHeader E_code;
    }
}