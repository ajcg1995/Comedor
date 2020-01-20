namespace UI.Reportes
{
    partial class FormReportesRangoFechas
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReportesRangoFechas));
            this.SpReporteAlPorFechaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporteRangoFecha = new UI.Reportes.DataSetReporteRangoFecha();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DpDesde = new System.Windows.Forms.DateTimePicker();
            this.DpHasta = new System.Windows.Forms.DateTimePicker();
            this.SpReporteAlPorFechaTableAdapter = new UI.Reportes.DataSetReporteRangoFechaTableAdapters.SpReporteAlPorFechaTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SpReporteAlPorFechaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteRangoFecha)).BeginInit();
            this.SuspendLayout();
            // 
            // SpReporteAlPorFechaBindingSource
            // 
            this.SpReporteAlPorFechaBindingSource.DataMember = "SpReporteAlPorFecha";
            this.SpReporteAlPorFechaBindingSource.DataSource = this.DataSetReporteRangoFecha;
            // 
            // DataSetReporteRangoFecha
            // 
            this.DataSetReporteRangoFecha.DataSetName = "DataSetReporteRangoFecha";
            this.DataSetReporteRangoFecha.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "RangoFechas";
            reportDataSource1.Value = this.SpReporteAlPorFechaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reportes.ReporteRangoFechas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(22, 102);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(833, 356);
            this.reportViewer1.TabIndex = 0;
            // 
            // DpDesde
            // 
            this.DpDesde.Location = new System.Drawing.Point(87, 37);
            this.DpDesde.Name = "DpDesde";
            this.DpDesde.Size = new System.Drawing.Size(283, 20);
            this.DpDesde.TabIndex = 2;
            // 
            // DpHasta
            // 
            this.DpHasta.Location = new System.Drawing.Point(489, 37);
            this.DpHasta.Name = "DpHasta";
            this.DpHasta.Size = new System.Drawing.Size(224, 20);
            this.DpHasta.TabIndex = 3;
            // 
            // SpReporteAlPorFechaTableAdapter
            // 
            this.SpReporteAlPorFechaTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(783, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 102);
            this.button3.TabIndex = 5;
            this.button3.Text = "Atrás";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(752, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 93);
            this.button2.TabIndex = 6;
            this.button2.Text = "  Generar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(435, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Final";
            // 
            // FormReportesRangoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(69)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(883, 584);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.DpHasta);
            this.Controls.Add(this.DpDesde);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportesRangoFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReportesRangoFechas";
            this.Load += new System.EventHandler(this.FormReportesRangoFechas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpReporteAlPorFechaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporteRangoFecha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SpReporteAlPorFechaBindingSource;
        private DataSetReporteRangoFecha DataSetReporteRangoFecha;
        private DataSetReporteRangoFechaTableAdapters.SpReporteAlPorFechaTableAdapter SpReporteAlPorFechaTableAdapter;
        private System.Windows.Forms.DateTimePicker DpDesde;
        private System.Windows.Forms.DateTimePicker DpHasta;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}