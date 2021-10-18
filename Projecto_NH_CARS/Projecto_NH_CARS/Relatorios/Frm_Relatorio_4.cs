using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_NH_CARS
{
    public partial class Frm_Relatorio_4 : Form
    {
        public Frm_Relatorio_4()
        {
            InitializeComponent();
        }

        private void Frm_Relatorio_4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nh_carsDataSet.Lista_De_Quantidades_De_Carros_Vendidos_Por__Funcionario_Do_Genero_Masculinos' table. You can move, or remove it, as needed.
            this.Lista_De_Quantidades_De_Carros_Vendidos_Por__Funcionario_Do_Genero_MasculinosTableAdapter.Fill(this.nh_carsDataSet.Lista_De_Quantidades_De_Carros_Vendidos_Por__Funcionario_Do_Genero_Masculinos);

            this.reportViewer1.RefreshReport();
        }
    }
}
