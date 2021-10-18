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
    public partial class Frm_Pesquisas_Carro : Form
    {
        public Frm_Pesquisas_Carro()
        {
            InitializeComponent();
        }
        Cl_Carro Pesquisas_Carro = new Cl_Carro();
        string op;
        private void Desbloquear(string Texto)
        {
            txt_Pesquisa.Text = string.Empty;
            lbl_Texto.Text = "Pesquisas/" + Texto;

            btn_Pesquisar.Enabled = true; txt_Pesquisa.Enabled = true;
            txt_Pesquisa.Focus();
        }
        private void Frm_Pesquisas_Carro_Load(object sender, EventArgs e)
        {

        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                Pesquisas_Carro.Trazer_Pesquisa(txt_Pesquisa.Text, op);
                Dgv_Pesquisas.DataSource = Cl_Conexao.Tabela;
            }
            catch (Exception)
            {


            }
        }

        private void Rdb_Carros_Vendidos_CheckedChanged(object sender, EventArgs e)
        {
            Desbloquear("Listar Carros Vendidos");
            op = "Vendido";
        }

        private void Rdb_Carros_Disponiveis_CheckedChanged(object sender, EventArgs e)
        {
            Desbloquear("Listar Carros Disponiveis");
            op = "Disponivel";
        }

        private void Rdb_Carros_Por_Marcas_CheckedChanged(object sender, EventArgs e)
        {
            Desbloquear("Listar Carros Por Marcas");
            op = "Marca";
        }

        private void Rdb_Carros_Por_Modelos_CheckedChanged(object sender, EventArgs e)
        {
            Desbloquear("Listar Carros Por Modelos");
            op = "Modelos";
        }

        private void Rdb_Modelos_CheckedChanged(object sender, EventArgs e)
        {
            Desbloquear("Listar Modelos");
            op = "So Modelos";

        }


    }
}
