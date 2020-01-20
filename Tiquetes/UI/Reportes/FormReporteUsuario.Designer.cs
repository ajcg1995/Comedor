namespace UI.Reportes
{
    partial class FormReporteUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReporteUsuario));
            this.spReporteAldiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetReporteDiario = new UI.Reportes.DataSetReporteDiario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.spReporteAldiaTableAdapter = new UI.Reportes.DataSetReporteDiarioTableAdapters.SpReporteAldiaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spReporteAldiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteDiario)).BeginInit();
            this.SuspendLayout();
            // 
            // spReporteAldiaBindingSource
            // 
            this.spReporteAldiaBindingSource.DataMember = "SpReporteAldia";
            this.spReporteAldiaBindingSource.DataSource = this.dataSetReporteDiario;
            // 
            // dataSetReporteDiario
            // 
            this.dataSetReporteDiario.DataSetName = "DataSetReporteDiario";
            this.dataSetReporteDiario.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.spReporteAldiaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "UI.Reportes.ReporteDiario.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(20, 21);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 365);
            this.reportViewer1.TabIndex = 0;
            // 
            // spReporteAldiaTableAdapter
            // 
            this.spReporteAldiaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(725, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 102);
            this.button1.TabIndex = 6;
            this.button1.Text = "Atrás";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormReporteUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(69)))), ((int)(((byte)(138)))));
            this.ClientSize = new System.Drawing.Size(808, 506);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReporteUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReporteUsuario";
            this.Load += new System.EventHandler(this.FormReporteUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spReporteAldiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetReporteDiario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource spReporteAldiaBindingSource;
        private DataSetReporteDiario dataSetReporteDiario;
        private DataSetReporteDiarioTableAdapters.SpReporteAldiaTableAdapter spReporteAldiaTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}