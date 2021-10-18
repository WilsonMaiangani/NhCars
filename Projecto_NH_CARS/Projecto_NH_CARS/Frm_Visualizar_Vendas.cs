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
    public partial class Frm_Visualizar_Vendas : Form
    {
        public Frm_Visualizar_Vendas()
        {
            InitializeComponent();
        }

        Cl_Vendas Visualizar_Vendas = new Cl_Vendas();
        Cl_Crud Crud_Dados_Venda = new Cl_Crud();

        private void Mostrar_Tabela()
        {
            Visualizar_Vendas.Visualizar_Vendas(true);
            Dgv_Visualizar_Vendas.DataSource = Cl_Conexao.Tabela;
            Dgv_Visualizar_Vendas.Columns["Usuario"].Width = 150;
        }
        private void Frm_Visualizar_Vendas_Load(object sender, EventArgs e)
        {
            try
            {
                Mostrar_Tabela();
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message);
            }
        }

        private void Dgv_Visualizar_Vendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                Visualizar_Vendas.Id_Venda = Convert.ToInt32(Dgv_Visualizar_Vendas.Rows[e.RowIndex].Cells["Id_Venda"].Value);
                btn_Editar.Enabled = true; btn_Eliminar.Enabled = true;
            }
            catch (Exception)
            {

                btn_Editar.Enabled = false; btn_Eliminar.Enabled = false;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desejas Eliminar Esta Venda?", "NH CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Crud_Dados_Venda.Eliminar_Venda(Visualizar_Vendas.Id_Venda);
                    Mostrar_Tabela();
                }

            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }

        }
    }
}
