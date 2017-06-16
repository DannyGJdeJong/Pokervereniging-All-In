namespace Pokervereniging_All_In
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnToernooi = new System.Windows.Forms.Button();
            this.btnMasterclass = new System.Windows.Forms.Button();
            this.btnSpeler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToernooi
            // 
            this.btnToernooi.Location = new System.Drawing.Point(12, 12);
            this.btnToernooi.Name = "btnToernooi";
            this.btnToernooi.Size = new System.Drawing.Size(75, 23);
            this.btnToernooi.TabIndex = 3;
            this.btnToernooi.Text = "Toernooi";
            this.btnToernooi.UseVisualStyleBackColor = true;
            this.btnToernooi.Click += new System.EventHandler(this.btnToernooi_Click);
            // 
            // btnMasterclass
            // 
            this.btnMasterclass.Location = new System.Drawing.Point(93, 12);
            this.btnMasterclass.Name = "btnMasterclass";
            this.btnMasterclass.Size = new System.Drawing.Size(75, 23);
            this.btnMasterclass.TabIndex = 4;
            this.btnMasterclass.Text = "Masterclass";
            this.btnMasterclass.UseVisualStyleBackColor = true;
            this.btnMasterclass.Click += new System.EventHandler(this.btnMasterclass_Click);
            // 
            // btnSpeler
            // 
            this.btnSpeler.Location = new System.Drawing.Point(174, 12);
            this.btnSpeler.Name = "btnSpeler";
            this.btnSpeler.Size = new System.Drawing.Size(75, 23);
            this.btnSpeler.TabIndex = 5;
            this.btnSpeler.Text = "Speler";
            this.btnSpeler.UseVisualStyleBackColor = true;
            this.btnSpeler.Click += new System.EventHandler(this.btnSpeler_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 47);
            this.Controls.Add(this.btnSpeler);
            this.Controls.Add(this.btnMasterclass);
            this.Controls.Add(this.btnToernooi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pokervereniging All-In";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnToernooi;
        private System.Windows.Forms.Button btnMasterclass;
        private System.Windows.Forms.Button btnSpeler;
    }
}

