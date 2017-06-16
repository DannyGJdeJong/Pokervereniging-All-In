namespace Pokervereniging_All_In
{
    partial class MasterclassAddView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterclassAddView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRating = new System.Windows.Forms.TextBox();
            this.BSubmit = new System.Windows.Forms.Button();
            this.CBLocatie = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CBAdd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DtPicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimale rating";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Locatie";
            // 
            // TxtRating
            // 
            this.TxtRating.Location = new System.Drawing.Point(104, 17);
            this.TxtRating.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtRating.Name = "TxtRating";
            this.TxtRating.Size = new System.Drawing.Size(168, 20);
            this.TxtRating.TabIndex = 2;
            // 
            // BSubmit
            // 
            this.BSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BSubmit.Location = new System.Drawing.Point(104, 124);
            this.BSubmit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BSubmit.Name = "BSubmit";
            this.BSubmit.Size = new System.Drawing.Size(82, 23);
            this.BSubmit.TabIndex = 4;
            this.BSubmit.Text = "Toevoegen";
            this.BSubmit.UseVisualStyleBackColor = true;
            this.BSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // CBLocatie
            // 
            this.CBLocatie.FormattingEnabled = true;
            this.CBLocatie.Location = new System.Drawing.Point(104, 96);
            this.CBLocatie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBLocatie.Name = "CBLocatie";
            this.CBLocatie.Size = new System.Drawing.Size(168, 21);
            this.CBLocatie.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datum";
            // 
            // CBAdd
            // 
            this.CBAdd.FormattingEnabled = true;
            this.CBAdd.Location = new System.Drawing.Point(104, 69);
            this.CBAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CBAdd.Name = "CBAdd";
            this.CBAdd.Size = new System.Drawing.Size(168, 21);
            this.CBAdd.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Bekende speler";
            // 
            // DtPicker
            // 
            this.DtPicker.Location = new System.Drawing.Point(104, 42);
            this.DtPicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DtPicker.Name = "DtPicker";
            this.DtPicker.Size = new System.Drawing.Size(168, 20);
            this.DtPicker.TabIndex = 10;
            // 
            // MasterclassAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 174);
            this.Controls.Add(this.DtPicker);
            this.Controls.Add(this.CBAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBLocatie);
            this.Controls.Add(this.BSubmit);
            this.Controls.Add(this.TxtRating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MasterclassAddView";
            this.Text = "AddView";
            this.Load += new System.EventHandler(this.AddView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRating;
        private System.Windows.Forms.Button BSubmit;
        private System.Windows.Forms.ComboBox CBLocatie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DtPicker;
    }
}