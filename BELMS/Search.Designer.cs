namespace BELMS
{
    partial class formSearch
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
            this.gridBookSearch = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comboBy = new System.Windows.Forms.ComboBox();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            this.comboSection = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridBookSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // gridBookSearch
            // 
            this.gridBookSearch.AllowUserToAddRows = false;
            this.gridBookSearch.AllowUserToDeleteRows = false;
            this.gridBookSearch.AllowUserToResizeColumns = false;
            this.gridBookSearch.AllowUserToResizeRows = false;
            this.gridBookSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBookSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBookSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.gridBookSearch.Location = new System.Drawing.Point(12, 106);
            this.gridBookSearch.Name = "gridBookSearch";
            this.gridBookSearch.ReadOnly = true;
            this.gridBookSearch.RowHeadersVisible = false;
            this.gridBookSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBookSearch.Size = new System.Drawing.Size(926, 537);
            this.gridBookSearch.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(540, 43);
            this.txtSearch.TabIndex = 1;
            // 
            // comboBy
            // 
            this.comboBy.AutoCompleteCustomSource.AddRange(new string[] {
            "By Title",
            "By Author",
            "By Year"});
            this.comboBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBy.FormattingEnabled = true;
            this.comboBy.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Copyright"});
            this.comboBy.Location = new System.Drawing.Point(558, 37);
            this.comboBy.Name = "comboBy";
            this.comboBy.Size = new System.Drawing.Size(187, 29);
            this.comboBy.TabIndex = 2;
            // 
            // comboCategory
            // 
            this.comboCategory.AutoCompleteCustomSource.AddRange(new string[] {
            "0-99",
            "100-199",
            "200-299",
            "300-399",
            "400-499",
            "500-599",
            "600-699",
            "700-799",
            "800-899"});
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.FormattingEnabled = true;
            this.comboCategory.Location = new System.Drawing.Point(751, 54);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(187, 29);
            this.comboCategory.TabIndex = 3;
            // 
            // comboSection
            // 
            this.comboSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSection.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSection.FormattingEnabled = true;
            this.comboSection.Items.AddRange(new object[] {
            "SHS"});
            this.comboSection.Location = new System.Drawing.Point(751, 19);
            this.comboSection.Name = "comboSection";
            this.comboSection.Size = new System.Drawing.Size(187, 29);
            this.comboSection.TabIndex = 5;
            // 
            // formSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 655);
            this.Controls.Add(this.comboSection);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(this.comboBy);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gridBookSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formSearch";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.formSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBookSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridBookSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comboBy;
        private System.Windows.Forms.ComboBox comboCategory;
        private System.Windows.Forms.ComboBox comboSection;
    }
}