namespace Pokervereniging_All_In
{
    partial class ToernooiWinnersView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToernooiWinnersView));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1e = new System.Windows.Forms.ComboBox();
            this.comboBox2e = new System.Windows.Forms.ComboBox();
            this.comboBox3e = new System.Windows.Forms.ComboBox();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "2e Plaats";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "1e Plaats";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "3e Plaats";
            // 
            // comboBox1e
            // 
            this.comboBox1e.FormattingEnabled = true;
            this.comboBox1e.Location = new System.Drawing.Point(70, 9);
            this.comboBox1e.Name = "comboBox1e";
            this.comboBox1e.Size = new System.Drawing.Size(202, 21);
            this.comboBox1e.TabIndex = 3;
            // 
            // comboBox2e
            // 
            this.comboBox2e.FormattingEnabled = true;
            this.comboBox2e.Location = new System.Drawing.Point(70, 39);
            this.comboBox2e.Name = "comboBox2e";
            this.comboBox2e.Size = new System.Drawing.Size(202, 21);
            this.comboBox2e.TabIndex = 4;
            // 
            // comboBox3e
            // 
            this.comboBox3e.FormattingEnabled = true;
            this.comboBox3e.Location = new System.Drawing.Point(70, 69);
            this.comboBox3e.Name = "comboBox3e";
            this.comboBox3e.Size = new System.Drawing.Size(202, 21);
            this.comboBox3e.TabIndex = 5;
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Location = new System.Drawing.Point(15, 96);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(257, 23);
            this.BtnSubmit.TabIndex = 6;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // ToernooiWinnersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 129);
            this.Controls.Add(this.BtnSubmit);
            this.Controls.Add(this.comboBox3e);
            this.Controls.Add(this.comboBox2e);
            this.Controls.Add(this.comboBox1e);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToernooiWinnersView";
            this.Text = "ToernooiWinnersView";
            this.Load += new System.EventHandler(this.ToernooiWinnersView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1e;
        private System.Windows.Forms.ComboBox comboBox2e;
        private System.Windows.Forms.ComboBox comboBox3e;
        private System.Windows.Forms.Button BtnSubmit;
    }
}