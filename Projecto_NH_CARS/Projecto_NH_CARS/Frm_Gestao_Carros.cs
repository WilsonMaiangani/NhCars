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
    public partial class Frm_Gestao_Carros : Form
    {
        public Frm_Gestao_Carros()
        {
            InitializeComponent();
        }
        Form Frms;

        Cl_Carro Dados_Carro = new Cl_Carro();
        Cl_Crud Crud_Dados_carro = new Cl_Crud();

        private void Mostrar()
        {
            Dados_Carro.Mostrar_Dados_Carro(true);
            Dgv_Carros.DataSource = Cl_Conexao.Tabela;

            Dgv_Carros.Columns["Estado"].Width = 250;
        }

        private void Frm_Gestao_Carros_Load(object sender, EventArgs e)
        {
            try
            {
                Mostrar();

            }
            catch
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Cadastrar_Carro Cad = new Frm_Cadastrar_Carro();
                Cad.Modo = "Cadastrar";
                Cad.ShowDialog();
                Mostrar();
            }
            catch (Exception)
            {

            }

        }

        private void Dgv_Carros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dados_Carro.Id_Carro = Convert.ToInt32(Dgv_Carros.Rows[e.RowIndex].Cells["Id_Carro"].Value);
                Cl_Auxiliar.Aux_1 = Dados_Carro.Id_Carro.ToString();
                Dados_Carro.Estado = Dgv_Carros.Rows[Dgv_Carros.CurrentRow.Index].Cells["Estado"].Value.ToString();

                if (Dados_Carro.Estado == "Vendido")
                {
                    btn_Eliminar.Enabled = false;
                    btn_Editar.Enabled = false;
                }
                else
                {
                    btn_Eliminar.Enabled = true;
                    btn_Editar.Enabled = true;
                }

            }
            catch
            {
                btn_Editar.Enabled = false; btn_Eliminar.Enabled = false;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Cadastrar_Carro Cad = new Frm_Cadastrar_Carro();
                Cad.Modo = "Alterar";
                Cad.lbl_Texto.Text = "Editar Carro";
                Cad.btn_Cadastrar.Text = "Editar";
                Cad.ShowDialog();
                Mostrar();
            }
            catch
            {
            }

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desejas Eliminar Este Carro?", "NH CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Crud_Dados_carro.Eliminar_Carro(Dados_Carro.Id_Carro);
                    Mostrar();
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Pesquisas_Carro { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }
    }
}
