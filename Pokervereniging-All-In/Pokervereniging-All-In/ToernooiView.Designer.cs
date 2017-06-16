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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToernooiView));
            this.lblInleggeld = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInleggeld = new System.Windows.Forms.TextBox();
            this.txtMinDeelnemers = new System.Windows.Forms.TextBox();
            this.cbbLocatie = new System.Windows.Forms.ComboBox();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.numTafels = new System.Windows.Forms.NumericUpDown();
            this.lblText1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTafelindeling = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTafels)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInleggeld
            // 
            this.lblInleggeld.AutoSize = true;
            this.lblInleggeld.Location = new System.Drawing.Point(700, 15);
            this.lblInleggeld.Name = "lblInleggeld";
            this.lblInleggeld.Size = new System.Drawing.Size(50, 13);
            this.lblInleggeld.TabIndex = 0;
            this.lblInleggeld.Text = "Inleggeld";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(643, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Minimum Deelnemers";
            // 
            // txtInleggeld
            // 
            this.txtInleggeld.Location = new System.Drawing.Point(756, 12);
            this.txtInleggeld.Name = "txtInleggeld";
            this.txtInleggeld.Size = new System.Drawing.Size(121, 20);
            this.txtInleggeld.TabIndex = 2;
            // 
            // txtMinDeelnemers
            // 
            this.txtMinDeelnemers.Location = new System.Drawing.Point(756, 38);
            this.txtMinDeelnemers.Name = "txtMinDeelnemers";
            this.txtMinDeelnemers.Size = new System.Drawing.Size(121, 20);
            this.txtMinDeelnemers.TabIndex = 3;
            // 
            // cbbLocatie
            // 
            this.cbbLocatie.FormattingEnabled = true;
            this.cbbLocatie.Location = new System.Drawing.Point(756, 64);
            this.cbbLocatie.Name = "cbbLocatie";
            this.cbbLocatie.Size = new System.Drawing.Size(121, 21);
            this.cbbLocatie.TabIndex = 4;
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(708, 67);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(42, 13);
            this.lblLocatie.TabIndex = 5;
            this.lblLocatie.Text = "Locatie";
            // 
            // numTafels
            // 
            this.numTafels.Location = new System.Drawing.Point(664, 535);
            this.numTafels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numTafels.Name = "numTafels";
            this.numTafels.Size = new System.Drawing.Size(30, 20);
            this.numTafels.TabIndex = 8;
            this.numTafels.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(571, 537);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(87, 13);
            this.lblText1.TabIndex = 9;
            this.lblText1.Text = "Een toernooi met";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 537);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "tafel(s) geeft [X] (of [Y]) spelers per tafel";
            // 
            // btnTafelindeling
            // 
            this.btnTafelindeling.Location = new System.Drawing.Point(756, 511);
            this.btnTafelindeling.Name = "btnTafelindeling";
            this.btnTafelindeling.Size = new System.Drawing.Size(121, 23);
            this.btnTafelindeling.TabIndex = 11;
            this.btnTafelindeling.Text = "Maak tafelindeling";
            this.btnTafelindeling.UseVisualStyleBackColor = true;
            this.btnTafelindeling.Click += new System.EventHandler(this.btnTafelindeling_Click);
            // 
            // ToernooiView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 559);
            this.Controls.Add(this.btnTafelindeling);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.numTafels);
            this.Controls.Add(this.lblLocatie);
            this.Controls.Add(this.cbbLocatie);
            this.Controls.Add(this.txtMinDeelnemers);
            this.Controls.Add(this.txtInleggeld);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInleggeld);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToernooiView";
            this.Text = " ";
            this.Activated += new System.EventHandler(this.ToernooiView_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.numTafels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInleggeld;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInleggeld;
        private System.Windows.Forms.TextBox txtMinDeelnemers;
        private System.Windows.Forms.ComboBox cbbLocatie;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.NumericUpDown numTafels;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTafelindeling;
    }
}