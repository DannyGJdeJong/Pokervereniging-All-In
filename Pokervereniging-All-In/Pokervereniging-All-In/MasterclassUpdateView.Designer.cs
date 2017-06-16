namespace Pokervereniging_All_In
{
    partial class MasterclassUpdateView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterclassUpdateView));
            this.DtUpdatePicker = new System.Windows.Forms.DateTimePicker();
            this.CBUpdateSpeler = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBUpdateLocatie = new System.Windows.Forms.ComboBox();
            this.BSubmit = new System.Windows.Forms.Button();
            this.TxtUpdateRating = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtUpdateEcode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DtUpdatePicker
            // 
            this.DtUpdatePicker.Location = new System.Drawing.Point(108, 61);
            this.DtUpdatePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtUpdatePicker.Name = "DtUpdatePicker";
            this.DtUpdatePicker.Size = new System.Drawing.Size(168, 20);
            this.DtUpdatePicker.TabIndex = 19;
            // 
            // CBUpdateSpeler
            // 
            this.CBUpdateSpeler.FormattingEnabled = true;
            this.CBUpdateSpeler.Location = new System.Drawing.Point(108, 88);
            this.CBUpdateSpeler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBUpdateSpeler.Name = "CBUpdateSpeler";
            this.CBUpdateSpeler.Size = new System.Drawing.Size(168, 21);
            this.CBUpdateSpeler.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Bekende speler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Datum";
            // 
            // CBUpdateLocatie
            // 
            this.CBUpdateLocatie.FormattingEnabled = true;
            this.CBUpdateLocatie.Location = new System.Drawing.Point(108, 115);
            this.CBUpdateLocatie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBUpdateLocatie.Name = "CBUpdateLocatie";
            this.CBUpdateLocatie.Size = new System.Drawing.Size(168, 21);
            this.CBUpdateLocatie.TabIndex = 15;
            // 
            // BSubmit
            // 
            this.BSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BSubmit.Location = new System.Drawing.Point(108, 143);
            this.BSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(82, 23);
            this.BSubmit.TabIndex = 14;
            this.BSubmit.Text = "Wijzigen";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // TxtUpdateRating
            // 
            this.TxtUpdateRating.Location = new System.Drawing.Point(108, 36);
            this.TxtUpdateRating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUpdateRating.Name = "TxtUpdateRating";
            this.TxtUpdateRating.Size = new System.Drawing.Size(168, 20);
            this.TxtUpdateRating.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Locatie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Minimale rating";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "E_Code";
            // 
            // TxtUpdateEcode
            // 
            this.TxtUpdateEcode.Enabled = false;
            this.TxtUpdateEcode.Location = new System.Drawing.Point(108, 12);
            this.TxtUpdateEcode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtUpdateEcode.Name = "TxtUpdateEcode";
            this.TxtUpdateEcode.Size = new System.Drawing.Size(168, 20);
            this.TxtUpdateEcode.TabIndex = 21;
            // 
            // MasterclassUpdateView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.TxtUpdateEcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtUpdatePicker);
            this.Controls.Add(this.CBUpdateSpeler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBUpdateLocatie);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.TxtUpdateRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MasterclassUpdateView";
            this.Text = "MasterclassUpdateView";
            this.Load += new System.EventHandler(this.MasterclassUpdateView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox TxtUpdateRating;
        protected internal System.Windows.Forms.TextBox TxtUpdateEcode;
        protected internal System.Windows.Forms.DateTimePicker DtUpdatePicker;
        protected internal System.Windows.Forms.ComboBox CBUpdateSpeler;
        protected internal System.Windows.Forms.ComboBox CBUpdateLocatie;
    }
}