namespace Pokervereniging_All_In
{
    partial class ToernooiView
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
            this.lstToernooi = new System.Windows.Forms.ListView();
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Locatie = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.inleggeld = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.minDeelnemers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstToernooi
            // 
            this.lstToernooi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Datum,
            this.inleggeld,
            this.minDeelnemers,
            this.Locatie});
            this.lstToernooi.FullRowSelect = true;
            this.lstToernooi.GridLines = true;
            this.lstToernooi.Location = new System.Drawing.Point(11, 11);
            this.lstToernooi.Margin = new System.Windows.Forms.Padding(2);
            this.lstToernooi.MultiSelect = false;
            this.lstToernooi.Name = "lstToernooi";
            this.lstToernooi.Size = new System.Drawing.Size(592, 246);
            this.lstToernooi.TabIndex = 1;
            this.lstToernooi.UseCompatibleStateImageBehavior = false;
            this.lstToernooi.View = System.Windows.Forms.View.Details;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.Width = 175;
            // 
            // Locatie
            // 
            this.Locatie.Text = "Locatie";
            this.Locatie.Width = 163;
            // 
            // inleggeld
            // 
            this.inleggeld.Text = "Inleggeld";
            this.inleggeld.Width = 124;
            // 
            // minDeelnemers
            // 
            this.minDeelnemers.Text = "Min. Deelnemers";
            this.minDeelnemers.Width = 125;
            // 
            // ToernooiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 336);
            this.Controls.Add(this.lstToernooi);
            this.Name = "ToernooiView";
            this.Text = "ToernooiView";
            this.Activated += new System.EventHandler(this.ToernooiView_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstToernooi;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Locatie;
        private System.Windows.Forms.ColumnHeader inleggeld;
        private System.Windows.Forms.ColumnHeader minDeelnemers;
    }
}