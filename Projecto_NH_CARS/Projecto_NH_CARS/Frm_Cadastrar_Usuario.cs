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
    public partial class Frm_Cadastrar_Usuario : Form
    {
        public Frm_Cadastrar_Usuario()
        {
            InitializeComponent();
            Dados_Funcionario.Id_Usuario = Convert.ToInt32(Cl_Auxiliar.Aux_1);
            Modo = Cl_Auxiliar.Aux_2;
        }
        Cl_Usuario Dados_Funcionario = new Cl_Usuario();
        Cl_Funcionario Buscar_Id_Funcionario = new Cl_Funcionario();
        Cl_Crud Crud_Usuario = new Cl_Crud();

        private void Limpar_Campos()
        {
            txt_Nome_Usuario.Text = string.Empty;
            txt_Senha.Text = string.Empty;
            comboBox_Funcionarios.Text = string.Empty;
            Rdb_Alto.Checked = false;
            Rdb_Baixo.Checked = false;
            Rdb_Medio.Checked = false;
            Rdb_Muito_Alto.Checked = false;
            txt_Nome_Usuario.Focus();
        }
        public string Modo;

        private void Dados_Editar()
        {
            if (Modo == "Alterar")
            {
                btn_Cadastrar.Text = "Editar";
                Dados_Funcionario.Buscar_Dados_Usuario(Dados_Funcionario.Id_Usuario);
                txt_Nome_Usuario.Text = Dados_Funcionario.Nome;
                txt_Senha.Text = Dados_Funcionario.Senha;
                lbl_Texto.Text = "Editar Usuario";
                Buscar_Id_Funcionario.Buscar_Funcionario(Dados_Funcionario.Id_Funcionario);
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    comboBox_Funcionarios.Text = Cl_Conexao.Comando_Leitura["Nome"].ToString();
                }
                comboBox_Funcionarios.Enabled = false;
                Dados_Funcionario.Buscar_Acesso(Dados_Funcionario.Id_Acesso);

                if (Dados_Funcionario.Acesso == " Muito Auto")
                { Rdb_Muito_Alto.Checked = true; }

                else if (Dados_Funcionario.Acesso == " Alto")
                { Rdb_Alto.Checked = true; }

                else if (Dados_Funcionario.Acesso == " Médio")
                { Rdb_Medio.Checked = true; }

                else if (Dados_Funcionario.Acesso == " Baixo")
                { Rdb_Baixo.Checked = true; }


            }
        }

        private void Frm_Cadastrar_Usuario_Load(object sender, EventArgs e)
        {
            try
            {
                if (Modo == "Cadastrar")
                {
                    Dados_Funcionario.Buscar_Todos_Funcionario();
                    while (Cl_Conexao.Comando_Leitura.Read())
                    {
                        comboBox_Funcionarios.Items.Add(Cl_Conexao.Comando_Leitura["Nome"].ToString());
                    }
                }
                else
                {
                    Dados_Editar();
                }

            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }

        }

        #region Nivel De Acesso
        private void Rdb_Muito_Alto_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Funcionario.Id_Acesso = 1;
        }

        private void Rdb_Alto_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Funcionario.Id_Acesso = 2;
        }

        private void Rdb_Medio_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Funcionario.Id_Acesso = 3;
        }

        private void Rdb_Baixo_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Funcionario.Id_Acesso = 4;
        }

        #endregion

        private void txt_Nome_Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyzq çãÃâÂÇáéÁÉíÍõÕúÚóÓôÔ'";
            if (!Abecedario.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox_Funcionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Buscar_Id_Funcionario.Buscar_Id_Funcionario(comboBox_Funcionarios.Text, true);
            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modo == "Cadastrar")
                {
                    Crud_Usuario.Adicionar_Usuario(Buscar_Id_Funcionario.Id_Funcionario, txt_Nome_Usuario.Text, txt_Senha.Text, Dados_Funcionario.Id_Acesso);
                    Limpar_Campos();
                }
                else if (Modo == "Alterar")
                {
                    Crud_Usuario.Editar_Usuario(Dados_Funcionario.Id_Funcionario, txt_Nome_Usuario.Text, txt_Senha.Text, Dados_Funcionario.Id_Acesso, Dados_Funcionario.Id_Usuario);
                    Limpar_Campos();
                }

            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }
    }
}
