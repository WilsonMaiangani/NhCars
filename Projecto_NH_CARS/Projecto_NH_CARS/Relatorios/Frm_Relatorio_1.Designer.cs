namespace Projecto_NH_CARS
{
    partial class Frms_Relatorio_1
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
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nh_carsDataSet = new Projecto_NH_CARS.nh_carsDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter = new Projecto_NH_CARS.nh_carsDataSetTableAdapters.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh_carsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource
            // 
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource.DataMember = "Lista de Quantidades de Carro Vendidos Por Modelos";
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource.DataSource = this.nh_carsDataSet;
            // 
            // nh_carsDataSet
            // 
            this.nh_carsDataSet.DataSetName = "nh_carsDataSet";
            this.nh_carsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projecto_NH_CARS.Relatorios.Folha_1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(650, 432);
            this.reportViewer1.TabIndex = 0;
            // 
            // Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter
            // 
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter.ClearBeforeFill = true;
            // 
            // Frms_Relatorio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 432);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frms_Relatorio_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frms_Relatorio_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh_carsDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource;
        private nh_carsDataSet nh_carsDataSet;
        private nh_carsDataSetTableAdapters.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter;
    }
}