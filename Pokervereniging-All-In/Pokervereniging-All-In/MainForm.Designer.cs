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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnGetSpelers = new System.Windows.Forms.Button();
            this.tbcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstSpelers = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voorlettersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roepnaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tussenvoegselsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.achternaamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.straatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.huisnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.woonplaatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.geslachtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailadresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staatOpBlacklistDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.iBANnummerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetSpelers
            // 
            this.btnGetSpelers.Location = new System.Drawing.Point(12, 12);
            this.btnGetSpelers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGetSpelers.Name = "btnGetSpelers";
            this.btnGetSpelers.Size = new System.Drawing.Size(150, 44);
            this.btnGetSpelers.TabIndex = 0;
            this.btnGetSpelers.Text = "Verversen";
            this.btnGetSpelers.UseVisualStyleBackColor = true;
            this.btnGetSpelers.Click += new System.EventHandler(this.btnGetSpelers_Click);
            // 
            // tbcMain
            // 
            this.tbcMain.Controls.Add(this.tabPage1);
            this.tbcMain.Controls.Add(this.tabPage2);
            this.tbcMain.Controls.Add(this.tabPage3);
            this.tbcMain.Location = new System.Drawing.Point(24, 23);
            this.tbcMain.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tbcMain.Name = "tbcMain";
            this.tbcMain.SelectedIndex = 0;
            this.tbcMain.Size = new System.Drawing.Size(1728, 967);
            this.tbcMain.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnGetSpelers);
            this.tabPage1.Controls.Add(this.lstSpelers);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage1.Size = new System.Drawing.Size(1712, 920);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Speler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pCodeDataGridViewTextBoxColumn,
            this.voorlettersDataGridViewTextBoxColumn,
            this.roepnaamDataGridViewTextBoxColumn,
            this.tussenvoegselsDataGridViewTextBoxColumn,
            this.achternaamDataGridViewTextBoxColumn,
            this.postcodeDataGridViewTextBoxColumn,
            this.straatDataGridViewTextBoxColumn,
            this.huisnummerDataGridViewTextBoxColumn,
            this.woonplaatsDataGridViewTextBoxColumn,
            this.geslachtDataGridViewTextBoxColumn,
            this.emailadresDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.staatOpBlacklistDataGridViewCheckBoxColumn,
            this.iBANnummerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.spelerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1688, 419);
            this.dataGridView1.TabIndex = 2;
            // 
            // lstSpelers
            // 
            this.lstSpelers.FormattingEnabled = true;
            this.lstSpelers.ItemHeight = 25;
            this.lstSpelers.Location = new System.Drawing.Point(12, 498);
            this.lstSpelers.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lstSpelers.Name = "lstSpelers";
            this.lstSpelers.Size = new System.Drawing.Size(514, 404);
            this.lstSpelers.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage2.Size = new System.Drawing.Size(1712, 920);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabPage3.Size = new System.Drawing.Size(1712, 920);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pCodeDataGridViewTextBoxColumn
            // 
            this.pCodeDataGridViewTextBoxColumn.DataPropertyName = "P_Code";
            this.pCodeDataGridViewTextBoxColumn.HeaderText = "P_Code";
            this.pCodeDataGridViewTextBoxColumn.Name = "pCodeDataGridViewTextBoxColumn";
            this.pCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pCodeDataGridViewTextBoxColumn.Width = 134;
            // 
            // voorlettersDataGridViewTextBoxColumn
            // 
            this.voorlettersDataGridViewTextBoxColumn.DataPropertyName = "Voorletters";
            this.voorlettersDataGridViewTextBoxColumn.HeaderText = "Voorletters";
            this.voorlettersDataGridViewTextBoxColumn.Name = "voorlettersDataGridViewTextBoxColumn";
            this.voorlettersDataGridViewTextBoxColumn.ReadOnly = true;
            this.voorlettersDataGridViewTextBoxColumn.Width = 161;
            // 
            // roepnaamDataGridViewTextBoxColumn
            // 
            this.roepnaamDataGridViewTextBoxColumn.DataPropertyName = "Roepnaam";
            this.roepnaamDataGridViewTextBoxColumn.HeaderText = "Roepnaam";
            this.roepnaamDataGridViewTextBoxColumn.Name = "roepnaamDataGridViewTextBoxColumn";
            this.roepnaamDataGridViewTextBoxColumn.ReadOnly = true;
            this.roepnaamDataGridViewTextBoxColumn.Width = 161;
            // 
            // tussenvoegselsDataGridViewTextBoxColumn
            // 
            this.tussenvoegselsDataGridViewTextBoxColumn.DataPropertyName = "Tussenvoegsels";
            this.tussenvoegselsDataGridViewTextBoxColumn.HeaderText = "Tussenvoegsels";
            this.tussenvoegselsDataGridViewTextBoxColumn.Name = "tussenvoegselsDataGridViewTextBoxColumn";
            this.tussenvoegselsDataGridViewTextBoxColumn.ReadOnly = true;
            this.tussenvoegselsDataGridViewTextBoxColumn.Width = 214;
            // 
            // achternaamDataGridViewTextBoxColumn
            // 
            this.achternaamDataGridViewTextBoxColumn.DataPropertyName = "Achternaam";
            this.achternaamDataGridViewTextBoxColumn.HeaderText = "Achternaam";
            this.achternaamDataGridViewTextBoxColumn.Name = "achternaamDataGridViewTextBoxColumn";
            this.achternaamDataGridViewTextBoxColumn.ReadOnly = true;
            this.achternaamDataGridViewTextBoxColumn.Width = 172;
            // 
            // postcodeDataGridViewTextBoxColumn
            // 
            this.postcodeDataGridViewTextBoxColumn.DataPropertyName = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.HeaderText = "Postcode";
            this.postcodeDataGridViewTextBoxColumn.Name = "postcodeDataGridViewTextBoxColumn";
            this.postcodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.postcodeDataGridViewTextBoxColumn.Width = 147;
            // 
            // straatDataGridViewTextBoxColumn
            // 
            this.straatDataGridViewTextBoxColumn.DataPropertyName = "Straat";
            this.straatDataGridViewTextBoxColumn.HeaderText = "Straat";
            this.straatDataGridViewTextBoxColumn.Name = "straatDataGridViewTextBoxColumn";
            this.straatDataGridViewTextBoxColumn.ReadOnly = true;
            this.straatDataGridViewTextBoxColumn.Width = 114;
            // 
            // huisnummerDataGridViewTextBoxColumn
            // 
            this.huisnummerDataGridViewTextBoxColumn.DataPropertyName = "Huisnummer";
            this.huisnummerDataGridViewTextBoxColumn.HeaderText = "Huisnummer";
            this.huisnummerDataGridViewTextBoxColumn.Name = "huisnummerDataGridViewTextBoxColumn";
            this.huisnummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.huisnummerDataGridViewTextBoxColumn.Width = 177;
            // 
            // woonplaatsDataGridViewTextBoxColumn
            // 
            this.woonplaatsDataGridViewTextBoxColumn.DataPropertyName = "Woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.HeaderText = "Woonplaats";
            this.woonplaatsDataGridViewTextBoxColumn.Name = "woonplaatsDataGridViewTextBoxColumn";
            this.woonplaatsDataGridViewTextBoxColumn.ReadOnly = true;
            this.woonplaatsDataGridViewTextBoxColumn.Width = 171;
            // 
            // geslachtDataGridViewTextBoxColumn
            // 
            this.geslachtDataGridViewTextBoxColumn.DataPropertyName = "Geslacht";
            this.geslachtDataGridViewTextBoxColumn.HeaderText = "Geslacht";
            this.geslachtDataGridViewTextBoxColumn.Name = "geslachtDataGridViewTextBoxColumn";
            this.geslachtDataGridViewTextBoxColumn.ReadOnly = true;
            this.geslachtDataGridViewTextBoxColumn.Width = 142;
            // 
            // emailadresDataGridViewTextBoxColumn
            // 
            this.emailadresDataGridViewTextBoxColumn.DataPropertyName = "Emailadres";
            this.emailadresDataGridViewTextBoxColumn.HeaderText = "Emailadres";
            this.emailadresDataGridViewTextBoxColumn.Name = "emailadresDataGridViewTextBoxColumn";
            this.emailadresDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailadresDataGridViewTextBoxColumn.Width = 164;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            this.ratingDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingDataGridViewTextBoxColumn.Width = 119;
            // 
            // staatOpBlacklistDataGridViewCheckBoxColumn
            // 
            this.staatOpBlacklistDataGridViewCheckBoxColumn.DataPropertyName = "StaatOpBlacklist";
            this.staatOpBlacklistDataGridViewCheckBoxColumn.HeaderText = "StaatOpBlacklist";
            this.staatOpBlacklistDataGridViewCheckBoxColumn.Name = "staatOpBlacklistDataGridViewCheckBoxColumn";
            this.staatOpBlacklistDataGridViewCheckBoxColumn.ReadOnly = true;
            this.staatOpBlacklistDataGridViewCheckBoxColumn.Width = 176;
            // 
            // iBANnummerDataGridViewTextBoxColumn
            // 
            this.iBANnummerDataGridViewTextBoxColumn.DataPropertyName = "IBANnummer";
            this.iBANnummerDataGridViewTextBoxColumn.HeaderText = "IBANnummer";
            this.iBANnummerDataGridViewTextBoxColumn.Name = "iBANnummerDataGridViewTextBoxColumn";
            this.iBANnummerDataGridViewTextBoxColumn.ReadOnly = true;
            this.iBANnummerDataGridViewTextBoxColumn.Width = 182;
            // 
            // spelerBindingSource
            // 
            this.spelerBindingSource.DataSource = typeof(Pokervereniging_All_In.Models.Speler);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1776, 1013);
            this.Controls.Add(this.tbcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Pokervereniging All-In";
            this.tbcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spelerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetSpelers;
        private System.Windows.Forms.TabControl tbcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource spelerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voorlettersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roepnaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tussenvoegselsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn achternaamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn postcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn straatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn huisnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn woonplaatsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn geslachtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailadresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn staatOpBlacklistDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iBANnummerDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox lstSpelers;
    }
}

