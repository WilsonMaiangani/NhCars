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
    public partial class Frm_Cargos : Form
    {
        public Frm_Cargos()
        {
            InitializeComponent();
        }

        Cl_Cargos Dados_Cargos = new Cl_Cargos();
        Cl_Crud Crud_Dados_Carro = new Cl_Crud();

        private void Mostar_Dados()
        {
            Dados_Cargos.Buscar_Cargos();
            Dgv_Cargos.DataSource = Cl_Conexao.Tabela;

            Dgv_Cargos.Columns["Id_cargo"].Width = 200;
            Dgv_Cargos.Columns["cargo"].Width = 400;
            Dgv_Cargos.Columns["Salario"].Width = 300;
        }



        private void Frm_Cargos_Load(object sender, EventArgs e)
        {
            try
            {
                Mostar_Dados();
            }
            catch
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Cargos Cad = new Frm_Cadastrar_Cargos();
            Cad.Modo = "Cadastrar";
            Cad.ShowDialog();
            Mostar_Dados();
        }

        private void Dgv_Cargos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dados_Cargos.Id_Cargo = Convert.ToInt32(Dgv_Cargos.Rows[e.RowIndex].Cells["Id_Cargo"].Value);
                Cl_Auxiliar.Aux_1 = Dados_Cargos.Id_Cargo.ToString();
                btn_Editar.Enabled = true; btn_Eliminar.Enabled = true;
            }
            catch
            {
                btn_Editar.Enabled = false; btn_Eliminar.Enabled = false;
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Cargos Cad = new Frm_Cadastrar_Cargos();
            Cad.Modo = "Alterar";
            Cad.ShowDialog();

            Mostar_Dados();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desejas Eliminar Este Cargo?", "NH CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Crud_Dados_Carro.Eliminar_Cargo(true, Dados_Cargos.Id_Cargo);
                    Mostar_Dados();
                }
                else
                {
                    return;
                }
                
            }
            catch
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }
        }
    }
}
