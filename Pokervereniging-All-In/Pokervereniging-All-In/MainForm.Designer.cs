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
            this.btnGetSpelers = new System.Windows.Forms.Button();
            this.lstSpelers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetSpelers
            // 
            this.btnGetSpelers.Location = new System.Drawing.Point(13, 13);
            this.btnGetSpelers.Name = "btnGetSpelers";
            this.btnGetSpelers.Size = new System.Drawing.Size(75, 23);
            this.btnGetSpelers.TabIndex = 0;
            this.btnGetSpelers.Text = "Get Spelers";
            this.btnGetSpelers.UseVisualStyleBackColor = true;
            this.btnGetSpelers.Click += new System.EventHandler(this.btnGetSpelers_Click);
            // 
            // lstSpelers
            // 
            this.lstSpelers.FormattingEnabled = true;
            this.lstSpelers.Location = new System.Drawing.Point(13, 43);
            this.lstSpelers.Name = "lstSpelers";
            this.lstSpelers.Size = new System.Drawing.Size(259, 212);
            this.lstSpelers.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lstSpelers);
            this.Controls.Add(this.btnGetSpelers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pokervereniging All-In";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSpelers;
        private System.Windows.Forms.ListBox lstSpelers;
    }
}

