namespace Projecto_NH_CARS
{
    partial class Frm_Relatorio_2
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
            this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nh_carsDataSet = new Projecto_NH_CARS.nh_carsDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter = new Projecto_NH_CARS.nh_carsDataSetTableAdapters.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter();
            this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosTableAdapter = new Projecto_NH_CARS.nh_carsDataSetTableAdapters.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh_carsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource
            // 
            this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource.DataMember = "Lista De Quantidades De Carros Vendidos Por Generos";
            this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource.DataSource = this.nh_carsDataSet;
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
            reportDataSource1.Value = this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Projecto_NH_CARS.Relatorios.Folha_2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(460, 399);
            this.reportViewer1.TabIndex = 0;
            // 
            // Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource
            // 
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource.DataMember = "Lista de Quantidades de Carro Vendidos Por Modelos";
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource.DataSource = this.nh_carsDataSet;
            // 
            // Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter
            // 
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter.ClearBeforeFill = true;
            // 
            // Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosTableAdapter
            // 
            this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_Relatorio_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 399);
            this.Controls.Add(this.reportViewer1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Relatorio_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Frm_Relatorio_2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nh_carsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosBindingSource;
        private nh_carsDataSet nh_carsDataSet;
        private nh_carsDataSetTableAdapters.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter;
        private System.Windows.Forms.BindingSource Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosBindingSource;
        private nh_carsDataSetTableAdapters.Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosTableAdapter Lista_De_Quantidades_De_Carros_Vendidos_Por_GenerosTableAdapter;
    }
}