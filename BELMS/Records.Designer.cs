namespace BELMS
{
    partial class formRecords
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
            this.dataBorrowed = new System.Windows.Forms.DataGridView();
            this.btnMark = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrowed)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBorrowed
            // 
            this.dataBorrowed.AllowUserToAddRows = false;
            this.dataBorrowed.AllowUserToDeleteRows = false;
            this.dataBorrowed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataBorrowed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBorrowed.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataBorrowed.Location = new System.Drawing.Point(12, 12);
            this.dataBorrowed.Name = "dataBorrowed";
            this.dataBorrowed.RowHeadersVisible = false;
            this.dataBorrowed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataBorrowed.Size = new System.Drawing.Size(926, 540);
            this.dataBorrowed.TabIndex = 0;
            // 
            // btnMark
            // 
            this.btnMark.BackColor = System.Drawing.Color.PaleGreen;
            this.btnMark.FlatAppearance.BorderSize = 0;
            this.btnMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMark.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMark.Location = new System.Drawing.Point(751, 583);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(178, 41);
            this.btnMark.TabIndex = 9;
            this.btnMark.Text = "MARK AS RETURNED";
            this.btnMark.UseVisualStyleBackColor = false;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // formRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 655);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.dataBorrowed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRecords";
            this.Text = "Records";
            this.Load += new System.EventHandler(this.formRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataBorrowed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataBorrowed;
        private System.Windows.Forms.Button btnMark;
    }
}