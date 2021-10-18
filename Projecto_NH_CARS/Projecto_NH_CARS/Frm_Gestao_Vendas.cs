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
    public partial class Frm_Gestao_Vendas : Form
    {
        public Frm_Gestao_Vendas()
        {
            InitializeComponent();
        }

        Form Frms;
        Cl_Vendas Dados_Vendas = new Cl_Vendas();

        private void Mostar_Tabela()
        {
            Dados_Vendas.Mostrar_Dados_Carro(true);
            Dgv_Vendas.DataSource = Cl_Conexao.Tabela;
            
            if (Cl_Auxiliar.Aux_4_Acesso==" Baixo")
            {
                Dgv_Vendas.Columns["Estado"].Width = 500;
            }
            else
            {
                Dgv_Vendas.Columns["Estado"].Width = 250;
            }
        }
        private void Frm_Gestao_Vendas_Load(object sender, EventArgs e)
        {
            try
            {
                if (Cl_Auxiliar.Aux_4_Acesso == " Baixo")
                {
                    btn_Visualizar_Vendas.Enabled = false;
                }
                Mostar_Tabela();
            }
            catch
            {

            }
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Vendas Vendas = new Frm_Vendas();
                Vendas.ShowDialog();
                Mostar_Tabela();
            }
            catch (Exception)
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }

        }
        string Estado = string.Empty;
        private void Dgv_Vendas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dados_Vendas.Id_Carro = Convert.ToInt32(Dgv_Vendas.Rows[e.RowIndex].Cells["Id_Carro"].Value);
                Cl_Auxiliar.Aux_1 = Dados_Vendas.Id_Carro.ToString();
                Dados_Vendas.Estado = Dgv_Vendas.Rows[Dgv_Vendas.CurrentRow.Index].Cells["Estado"].Value.ToString();

                if (Dados_Vendas.Estado == "Vendido")
                {
                    btn_Vender.Enabled = false;
                }
                else
                {
                    btn_Vender.Enabled = true;
                }

            }
            catch
            {
                btn_Vender.Enabled = false;
            }
        }

        private void btn_Visualizar_Vendas_Click(object sender, EventArgs e)
        {
            panel_visualizar.Controls.Clear();
            panel_visualizar.Controls.Clear();
            Frms = new Frm_Visualizar_Vendas { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            panel_visualizar.Controls.Add(Frms);
            Frms.Show();


            //Frm_Visualizar_Vendas Visualizar = new Frm_Visualizar_Vendas();
            //Visualizar.ShowDialog();
        }


    }
}
