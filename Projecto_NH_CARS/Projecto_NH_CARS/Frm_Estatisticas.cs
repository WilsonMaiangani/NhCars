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
    public partial class Frm_Estatisticas : Form
    {
        public Frm_Estatisticas()
        {
            InitializeComponent();
        }

        private void btn_Relatorio_1_Click(object sender, EventArgs e)
        {
            Frms_Relatorio_1 Relatorio_1 = new Frms_Relatorio_1();
            Relatorio_1.Show();
        }

        private void btn_Relatorio_2_Click(object sender, EventArgs e)
        {
            Frm_Relatorio_2 Relatorio_2 = new Frm_Relatorio_2();
            Relatorio_2.Show();
        }

        private void btn_Relatorio_3_Click(object sender, EventArgs e)
        {
            Frm_Relatorio_3 Relatorio_3 = new Frm_Relatorio_3();
            Relatorio_3.Show();
        }

        private void btn_Relatorio_4_Click(object sender, EventArgs e)
        {
            Frm_Relatorio_4 Relatorio_4 = new Frm_Relatorio_4();
            Relatorio_4.Show();
        }

        private void btn_Relatorio_5_Click(object sender, EventArgs e)
        {
            Frm_Relatorio_5 Relatorio_5 = new Frm_Relatorio_5();
            Relatorio_5.Show();
        }
    }
}
