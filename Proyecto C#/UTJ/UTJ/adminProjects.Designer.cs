namespace UTJ {
    partial class adminProjects {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtgId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgModify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dtgSee = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtgId,
            this.dtgName,
            this.dtgCompany,
            this.dtgStatus,
            this.dtgDelete,
            this.dtgModify,
            this.dtgSee});
            this.dataGridView1.Location = new System.Drawing.Point(0, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(743, 330);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dtgId
            // 
            this.dtgId.HeaderText = "ID";
            this.dtgId.Name = "dtgId";
            this.dtgId.ReadOnly = true;
            // 
            // dtgName
            // 
            this.dtgName.HeaderText = "Nombre";
            this.dtgName.Name = "dtgName";
            this.dtgName.ReadOnly = true;
            // 
            // dtgCompany
            // 
            this.dtgCompany.HeaderText = "Empresa";
            this.dtgCompany.Name = "dtgCompany";
            this.dtgCompany.ReadOnly = true;
            // 
            // dtgStatus
            // 
            this.dtgStatus.HeaderText = "Estatus";
            this.dtgStatus.Name = "dtgStatus";
            this.dtgStatus.ReadOnly = true;
            // 
            // dtgDelete
            // 
            this.dtgDelete.HeaderText = "Proyecto";
            this.dtgDelete.Name = "dtgDelete";
            this.dtgDelete.Text = "Borrar";
            this.dtgDelete.ToolTipText = "Borrar";
            this.dtgDelete.UseColumnTextForButtonValue = true;
            // 
            // dtgModify
            // 
            this.dtgModify.HeaderText = "Proyecto";
            this.dtgModify.Name = "dtgModify";
            this.dtgModify.Text = "Modificar";
            this.dtgModify.ToolTipText = "Modificar";
            this.dtgModify.UseColumnTextForButtonValue = true;
            // 
            // dtgSee
            // 
            this.dtgSee.HeaderText = "Proyecto";
            this.dtgSee.Name = "dtgSee";
            this.dtgSee.Text = "Ver";
            this.dtgSee.ToolTipText = "Ver";
            this.dtgSee.UseColumnTextForButtonValue = true;
            // 
            // adminProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 331);
            this.Controls.Add(this.dataGridView1);
            this.Name = "adminProjects";
            this.Text = "Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgStatus;
        private System.Windows.Forms.DataGridViewButtonColumn dtgDelete;
        private System.Windows.Forms.DataGridViewButtonColumn dtgModify;
        private System.Windows.Forms.DataGridViewButtonColumn dtgSee;
    }
}