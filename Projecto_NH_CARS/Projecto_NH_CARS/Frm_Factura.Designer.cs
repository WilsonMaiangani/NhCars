namespace Projecto_NH_CARS
{
    partial class Frm_Factura
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.nh_carsDataSet = new Projecto_NH_CARS.nh_carsDataSet();
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FacturaTableAdapter = new Projecto_NH_CARS.nh_carsDataSetTableAdapters.FacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.nh_carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.FacturaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projecto_NH_CARS.Folha_Factura.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(819, 330);
            this.reportViewer1.TabIndex = 0;
            // 
            // nh_carsDataSet
            // 
            this.nh_carsDataSet.DataSetName = "nh_carsDataSet";
            this.nh_carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.nh_carsDataSet;
            // 
            // FacturaTableAdapter
            // 
            this.FacturaTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 330);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Frm_Factura";
            this.Text = "Frm_Factura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Factura_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nh_carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private nh_carsDataSet nh_carsDataSet;
        private nh_carsDataSetTableAdapters.FacturaTableAdapter FacturaTableAdapter;

    }
}