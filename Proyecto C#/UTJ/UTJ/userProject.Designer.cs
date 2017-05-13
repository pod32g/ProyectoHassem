namespace UTJ {
    partial class userProject {
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
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 420);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Resultados:";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(18, 453);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResult.Size = new System.Drawing.Size(266, 135);
            this.txtResult.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 67;
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
            this.statusBox.Location = new System.Drawing.Point(396, 190);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(121, 21);
            this.statusBox.TabIndex = 66;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(390, 334);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.Size = new System.Drawing.Size(266, 20);
            this.txtTeacher.TabIndex = 65;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 308);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 13);
            this.label7.TabIndex = 64;
            this.label7.Text = "Profesor encargado (codigo):";
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(393, 254);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(266, 20);
            this.txtStudent.TabIndex = 63;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(393, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Alumno encargado (matricula):";
            // 
            // txtObjective
            // 
            this.txtObjective.Location = new System.Drawing.Point(15, 228);
            this.txtObjective.Multiline = true;
            this.txtObjective.Name = "txtObjective";
            this.txtObjective.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObjective.Size = new System.Drawing.Size(266, 135);
            this.txtObjective.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Objetivo:";
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(396, 109);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 59;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(18, 109);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(393, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Fecha de finalizacion:";
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(396, 36);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(266, 20);
            this.txtCompany.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Empresa que lo pide:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Fecha de inicio:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(266, 20);
            this.txtName.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Nombre del proyecto:";
            // 
            // userProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 644);
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
            this.Name = "userProject";
            this.Text = "Proyecto Actual";
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
    }
}