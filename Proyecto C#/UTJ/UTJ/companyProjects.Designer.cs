namespace UTJ {
    partial class companyProjects {
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
            this.dtgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dtgStatus,
            this.dtgEnd,
            this.dtgSee});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(546, 283);
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
            // dtgStatus
            // 
            this.dtgStatus.HeaderText = "Estatus";
            this.dtgStatus.Name = "dtgStatus";
            this.dtgStatus.ReadOnly = true;
            // 
            // dtgEnd
            // 
            this.dtgEnd.HeaderText = "FechaFin";
            this.dtgEnd.Name = "dtgEnd";
            this.dtgEnd.ReadOnly = true;
            // 
            // dtgSee
            // 
            this.dtgSee.HeaderText = "Proyecto";
            this.dtgSee.Name = "dtgSee";
            this.dtgSee.Text = "Ver";
            this.dtgSee.ToolTipText = "Ver";
            this.dtgSee.UseColumnTextForButtonValue = true;
            // 
            // companyProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 282);
            this.Controls.Add(this.dataGridView1);
            this.Name = "companyProjects";
            this.Text = "Proyectos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtgEnd;
        private System.Windows.Forms.DataGridViewButtonColumn dtgSee;
    }
}