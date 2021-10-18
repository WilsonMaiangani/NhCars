using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
namespace Projecto_NH_CARS
{
    public partial class Frm_Factura : Form
    {
        public  static string  Cliente, Funcionario, Marca, Modelo, N_Serie, Cor, Tamanho_Pneu, Data;
        public static double Preco;
        public Frm_Factura()
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Cliente", Cliente));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Marca", Marca));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Modelo", Modelo));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("N_Serie", N_Serie));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Cor", Cor));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Tamanho_Pneu", Tamanho_Pneu));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Preco", Convert.ToDouble(Preco).ToString()));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Nome", Funcionario));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("Data", Data));
        }


        private void Frm_Factura_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nh_carsDataSet.Factura' table. You can move, or remove it, as needed.
            this.FacturaTableAdapter.Fill(this.nh_carsDataSet.Factura);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void Frm_Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            reportViewer1.LocalReport.ReleaseSandboxAppDomain();
        }
    }
}
