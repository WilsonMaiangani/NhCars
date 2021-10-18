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
    public partial class Frm_Gestao_Modelos : Form
    {
        public Frm_Gestao_Modelos()
        {
            InitializeComponent();
        }

        Cl_Modelo Dados_Modelo = new Cl_Modelo();
        Cl_Crud Crud_dados_Modelo = new Cl_Crud();


        private void Frm_Gestao_Modelos_Load(object sender, EventArgs e)
        {
            Dados_Modelo.Mostrar_Dados_Modelo();
            Dgv_Modelo.DataSource = Cl_Conexao.Tabela;

            Dgv_Modelo.Columns["Id_Modelo"].Width = 300;
            Dgv_Modelo.Columns["Marca"].Width = 300;
            Dgv_Modelo.Columns["Modelo"].Width = 800;
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Modelo Cad = new Frm_Cadastrar_Modelo();
            Cad.Modo = "Cadastrar";
            Cad.ShowDialog();
        }

        private void radioButton_cadastrar_CheckedChanged(object sender, EventArgs e)
        {
            btn_Cadastrar.Enabled = true;

            btn_Pesquisar.Enabled = false;
            txt_Pesquisar.Enabled = false;
        }

        private void radioButton_Pesquisar_CheckedChanged(object sender, EventArgs e)
        {
            btn_Pesquisar.Enabled = true;
            txt_Pesquisar.Enabled = true;
            txt_Pesquisar.Focus();
        }

        private void radioButton_Todos_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Modelo.Mostrar_Dados_Modelo();
            Dgv_Modelo.DataSource = Cl_Conexao.Tabela;

            btn_Pesquisar.Enabled = false;
            txt_Pesquisar.Enabled = false;
            btn_Cadastrar.Enabled = false;
        }

        private void Dgv_Modelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dados_Modelo.Id_Modelo = Convert.ToInt32(Dgv_Modelo.Rows[e.RowIndex].Cells["Id_Modelo"].Value);
                Cl_Auxiliar.Aux_1 = Dados_Modelo.Id_Modelo.ToString();
                btn_Eliminar.Enabled = true; btn_Editar.Enabled = true;
            }
            catch
            {
                btn_Eliminar.Enabled = false; btn_Editar.Enabled = false;

            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desejas Eliminar Este Modelo?", "NH CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Crud_dados_Modelo.Eliminar_Modelo(true, Dados_Modelo.Id_Modelo);

                    Dados_Modelo.Mostrar_Dados_Modelo();
                    Dgv_Modelo.DataSource = Cl_Conexao.Tabela;
                }
                else
                {
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Não é Possivel Efectuar Esta Operação", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Modelo Cad = new Frm_Cadastrar_Modelo();
            Cad.Modo = "Alterar";
            Cad.ShowDialog();
        }
    }
}
