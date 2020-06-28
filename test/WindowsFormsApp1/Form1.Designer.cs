namespace WindowsFormsApp1
{
    partial class fTraCuuDKHP_2
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbDSMHM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHM)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDSMHM
            // 
            this.gbDSMHM.Controls.Add(this.dgvDSMHM);
            this.gbDSMHM.Location = new System.Drawing.Point(12, 31);
            this.gbDSMHM.Name = "gbDSMHM";
            this.gbDSMHM.Size = new System.Drawing.Size(373, 558);
            this.gbDSMHM.TabIndex = 7;
            this.gbDSMHM.TabStop = false;
            // 
            // dgvDSMHM
            // 
            this.dgvDSMHM.AllowUserToAddRows = false;
            this.dgvDSMHM.AllowUserToDeleteRows = false;
            this.dgvDSMHM.AllowUserToResizeColumns = false;
            this.dgvDSMHM.AllowUserToResizeRows = false;
            this.dgvDSMHM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSMHM.Location = new System.Drawing.Point(6, 19);
            this.dgvDSMHM.Name = "dgvDSMHM";
            this.dgvDSMHM.ReadOnly = true;
            this.dgvDSMHM.RowHeadersVisible = false;
            this.dgvDSMHM.RowHeadersWidth = 62;
            this.dgvDSMHM.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSMHM.Size = new System.Drawing.Size(361, 533);
            this.dgvDSMHM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Danh sách môn học có thể đăng ký";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fTraCuuDKHP_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 592);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDSMHM);
            this.Name = "fTraCuuDKHP_2";
            this.Text = "Form1";
            this.gbDSMHM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSMHM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDSMHM;
        private System.Windows.Forms.DataGridView dgvDSMHM;
        private System.Windows.Forms.Label label1;
    }
}