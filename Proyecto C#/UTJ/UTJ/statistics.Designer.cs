namespace UTJ {
    partial class statistics {
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
            this.mainChart = new LiveCharts.WinForms.PieChart();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            this.mainChart.Location = new System.Drawing.Point(-1, -2);
            this.mainChart.Name = "mainChart";
            this.mainChart.Size = new System.Drawing.Size(862, 398);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "Estadisticas de proyectos (en general)";
            // 
            // statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 398);
            this.Controls.Add(this.mainChart);
            this.Name = "statistics";
            this.Text = "Estadisticas";
            this.ResumeLayout(false);

        }

        #endregion

        private LiveCharts.WinForms.PieChart mainChart;
    }
}