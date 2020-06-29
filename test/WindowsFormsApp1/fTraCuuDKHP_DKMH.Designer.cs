namespace WindowsFormsApp1
{
    partial class fTraCuuDKHP_DKMH
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
            this.gbDSMHM = new System.Windows.Forms.GroupBox();
            this.dgvDSMHM = new System.Windows.Forms.DataGridView();
            this.gbDSMHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHM)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDSMHM
            // 
            this.gbDSMHM.Controls.Add(this.dgvDSMHM);
            this.gbDSMHM.Location = new System.Drawing.Point(1, 3);
            this.gbDSMHM.Name = "gbDSMHM";
            this.gbDSMHM.Size = new System.Drawing.Size(365, 550);
            this.gbDSMHM.TabIndex = 7;
            this.gbDSMHM.TabStop = false;
            this.gbDSMHM.Text = "Danh sách môn học mở";
            // 
            // dgvDSMHM
            // 
            this.dgvDSMHM.AllowUserToAddRows = false;
            this.dgvDSMHM.AllowUserToDeleteRows = false;
            this.dgvDSMHM.AllowUserToResizeColumns = false;
            this.dgvDSMHM.AllowUserToResizeRows = false;
            this.dgvDSMHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHM.Location = new System.Drawing.Point(11, 13);
            this.dgvDSMHM.Name = "dgvDSMHM";
            this.dgvDSMHM.ReadOnly = true;
            this.dgvDSMHM.RowHeadersVisible = false;
            this.dgvDSMHM.RowHeadersWidth = 62;
            this.dgvDSMHM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHM.Size = new System.Drawing.Size(348, 531);
            this.dgvDSMHM.TabIndex = 0;
            this.dgvDSMHM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMHM_CellContentClick);
            this.dgvDSMHM.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSMHM_CellDoubleClick);
            // 
            // fTraCuuDKHP_DKMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 559);
            this.Controls.Add(this.gbDSMHM);
            this.Name = "fTraCuuDKHP_DKMH";
            this.Text = "fTraCuuDKHP_DKMH";
            this.gbDSMHM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDSMHM;
        private System.Windows.Forms.DataGridView dgvDSMHM;
    }
}