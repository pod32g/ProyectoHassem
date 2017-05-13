namespace UTJ {
    partial class deleteProject {
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObjective = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 422);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "Resultados:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(35, 455);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(266, 135);
            this.txtResult.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Estatus:";
            // 
            // statusBox
            // 
            this.statusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "En proceso",
            "Suspendido",
            "Cancelado",
            "Completado"});
            this.statusBox.Location = new System.Drawing.Point(413, 192);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(121, 21);
            this.statusBox.TabIndex = 48;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(407, 336);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(266, 20);
            this.txtTeacher.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Profesor encargado (codigo):";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(410, 256);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(266, 20);
            this.txtStudent.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Alumno encargado (matricula):";
            // 
            // txtObjective
            // 
            this.txtObjective.Location = new System.Drawing.Point(32, 230);
            this.txtObjective.Multiline = true;
            this.txtObjective.Name = "txtObjective";
            this.txtObjective.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObjective.Size = new System.Drawing.Size(266, 135);
            this.txtObjective.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "Objetivo:";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(413, 111);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 41;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(35, 111);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(410, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Fecha de finalizacion:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(413, 38);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(266, 20);
            this.txtCompany.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(410, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Empresa que lo pide:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Fecha de inicio:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 20);
            this.txtName.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Nombre del proyecto:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(477, 577);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(105, 23);
            this.btnSearch.TabIndex = 53;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(588, 577);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 23);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "Eliminar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // deleteProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 612);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.statusBox);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObjective);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "deleteProject";
            this.Text = "Eliminar Proyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObjective;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnSave;
    }
}