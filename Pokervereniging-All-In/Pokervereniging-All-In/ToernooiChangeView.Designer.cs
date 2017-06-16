namespace Pokervereniging_All_In
{
    partial class ToernooiChangeView
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
            this.label3 = new System.Windows.Forms.Label();
            this.BSubmit = new System.Windows.Forms.Button();
            this.TxtMinDeelnemers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtInleggeld = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxLocatie = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Inleggeld";
            // 
            // BSubmit
            // 
            this.BSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BSubmit.Location = new System.Drawing.Point(106, 175);
            this.BSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(82, 23);
            this.BSubmit.TabIndex = 14;
            this.BSubmit.Text = "Submit";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.BSubmit_Click);
            // 
            // TxtMinDeelnemers
            // 
            this.TxtMinDeelnemers.Location = new System.Drawing.Point(105, 65);
            this.TxtMinDeelnemers.Margin = new System.Windows.Forms.Padding(2);
            this.TxtMinDeelnemers.Name = "TxtMinDeelnemers";
            this.TxtMinDeelnemers.Size = new System.Drawing.Size(168, 20);
            this.TxtMinDeelnemers.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Minimum deelnemers";
            // 
            // TxtInleggeld
            // 
            this.TxtInleggeld.Location = new System.Drawing.Point(105, 90);
            this.TxtInleggeld.Margin = new System.Windows.Forms.Padding(2);
            this.TxtInleggeld.Name = "TxtInleggeld";
            this.TxtInleggeld.Size = new System.Drawing.Size(168, 20);
            this.TxtInleggeld.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Datum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(168, 20);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Locatie";
            // 
            // comboBoxLocatie
            // 
            this.comboBoxLocatie.FormattingEnabled = true;
            this.comboBoxLocatie.Location = new System.Drawing.Point(106, 144);
            this.comboBoxLocatie.Name = "comboBoxLocatie";
            this.comboBoxLocatie.Size = new System.Drawing.Size(166, 21);
            this.comboBoxLocatie.TabIndex = 21;
            // 
            // ToernooiChangeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.comboBoxLocatie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtInleggeld);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.TxtMinDeelnemers);
            this.Controls.Add(this.label1);
            this.Name = "ToernooiChangeView";
            this.Text = "ToernooiChangeView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.TextBox TxtMinDeelnemers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtInleggeld;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxLocatie;
    }
}