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
    public partial class Frm_Gestao_Usuarios : Form
    {
        public Frm_Gestao_Usuarios()
        {
            InitializeComponent();
        }

        Form Frms;

        Cl_Usuario Dados_Usuario = new Cl_Usuario();
        private void Frm_Gestao_Usuarios_Load(object sender, EventArgs e)
        {
            try
            {
                Dados_Usuario.Mostar_Todos_Usuarios("Usuarios", "");
                Dgv_Usuario.DataSource = Cl_Conexao.Tabela;
                Dgv_Usuario.Columns["Nome"].Width = 330;
                Dgv_Usuario.Columns["Usuario"].Width = 150;
                Dgv_Usuario.Columns["Senha"].Width = 150;
                Dgv_Usuario.Columns["Acesso"].Width = 300;
            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Ver_Usuarios_Logados_Click(object sender, EventArgs e)
        {
            Panel_Principal.Controls.Clear();
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Visualizar_Usuario_Logados { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Cl_Auxiliar.Aux_2 = "Cadastrar";
            Panel_Principal.Controls.Clear();
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Cadastrar_Usuario { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_Auxiliar.Aux_2 = "Alterar";
                Cl_Auxiliar.Aux_3 = "Alterar";
                Panel_Principal.Controls.Clear();
                Panel_Principal.Controls.Clear();
                Frms = new Frm_Cadastrar_Usuario { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                Panel_Principal.Controls.Add(Frms);
                Frms.Show();
            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void Dgv_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dados_Usuario.Id_Usuario = Convert.ToInt32(Dgv_Usuario.Rows[e.RowIndex].Cells["Id_Usuario"].Value);
                Cl_Auxiliar.Aux_1 = Dados_Usuario.Id_Usuario.ToString();
                btn_Editar.Enabled = true;
            }
            catch (Exception)
            {
                btn_Editar.Enabled = false;
            }
        }
    }
}
