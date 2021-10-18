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
    public partial class Frms_Relatorio_1 : Form
    {
        public Frms_Relatorio_1()
        {
            InitializeComponent();
        }

        private void Frms_Relatorio_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nh_carsDataSet.Lista_de_Quantidades_de_Carro_Vendidos_Por_Modelos' table. You can move, or remove it, as needed.
            this.Lista_de_Quantidades_de_Carro_Vendidos_Por_ModelosTableAdapter.Fill(this.nh_carsDataSet.Lista_de_Quantidades_de_Carro_Vendidos_Por_Modelos);

            this.reportViewer1.RefreshReport();
        }
    }
}
