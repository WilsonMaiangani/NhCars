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
    public partial class Frm_Cadastrar_Funcionarios : Form
    {
        public Frm_Cadastrar_Funcionarios()
        {
            InitializeComponent();
            Dados_Funcionario.Id_Funcionario = Convert.ToInt32(Cl_Auxiliar.Aux_1);
        }

        Cl_Funcionario Dados_Funcionario = new Cl_Funcionario();
        Cl_Crud Crud = new Cl_Crud();

        public string Modo = string.Empty;

        private void Limpar_Campos()
        {
            txt_Nome.Text = string.Empty;
            txt_N_BI.Text = string.Empty;
            txt_Telefone.Text = string.Empty;
            CbB_Cargos.Text = string.Empty;
            radioButton_Femenino.Checked = false;
            radioButton_Masculino.Checked = false;
            txt_Nome.Focus();
        }

        public void Colocar_Dados_Funcionario_Nos_Campo()
        {
            if (Modo == "Alterar")
            {
                Dados_Funcionario.Buscar_Todos_Dados_Funcionario(true, Dados_Funcionario.Id_Funcionario);
                txt_Nome.Text = Dados_Funcionario.Nome;
                txt_N_BI.Text = Dados_Funcionario.BI;

                if (Dados_Funcionario.Genero == 'M')
                {
                    radioButton_Masculino.Checked = true;
                }
                else if (Dados_Funcionario.Genero == 'F')
                {
                    radioButton_Femenino.Checked = true;
                }

                Dados_Funcionario.Buscar_Cargo_Funcionario();
                Dados_Funcionario.Buscar_Telefone_Funcionario();

                CbB_Cargos.Text = Dados_Funcionario.Cargo;
                txt_Telefone.Text = Convert.ToString(Dados_Funcionario.Telefone);
            }
        }

        private void Frm_Cadastrar_Funcionarios_Load(object sender, EventArgs e)
        {
            try
            {
                Dados_Funcionario.Conectar_Bd();
                Colocar_Dados_Funcionario_Nos_Campo();

                #region Colocar Todos Os Cargos Na ComboBox


                Dados_Funcionario.Preencher_Cargos_CbB();
                foreach (string Cargos in Dados_Funcionario.Lista_Cargos)
                {
                    CbB_Cargos.Items.Add(Cargos);
                }
                #endregion



            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void CbB_Cargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Cl_Conexao.Conexao.Open();

                Dados_Funcionario.Buscar_Id_Cargo(CbB_Cargos.Text);

            }
            finally
            { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nome.Text == string.Empty)
                {
                    txt_Nome.Focus();
                    return;
                }
                else if (txt_N_BI.Text == string.Empty)
                {
                    txt_N_BI.Focus();
                    return;
                }
                else if (!radioButton_Masculino.Checked && !radioButton_Femenino.Checked)
                {
                    MessageBox.Show("Selecione O Genero", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (CbB_Cargos.Text == string.Empty)
                {
                    CbB_Cargos.Focus();
                    return;
                }
                else
                {
                    Dados_Funcionario.Conectar_Bd();

                    if (Modo == "Cadastrar")
                    {
                        Crud.Adicionar_Funcionario(true, txt_Nome.Text, Dados_Funcionario.Genero, txt_N_BI.Text, Dados_Funcionario.Id_Cargo, Convert.ToInt32(txt_Telefone.Text));
                        Limpar_Campos();
                    }
                    else if (Modo == "Alterar")
                    {
                        Crud.Alterar_Dados_Funcionario(true, txt_Nome.Text, Dados_Funcionario.Genero, txt_N_BI.Text, Dados_Funcionario.Id_Cargo, Convert.ToInt32(txt_Telefone.Text), Dados_Funcionario.Id_Funcionario);
                        Limpar_Campos();
                    }

                }
            }
            catch (Exception )
            {
                MessageBox.Show("Numero Do BI Já Existente", "NH", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_N_BI.Text = string.Empty; txt_N_BI.Focus();
            }
            finally
            { Cl_Conexao.Conexao.Close(); }
        }

        private void radioButton_Masculino_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Funcionario.Genero = 'M';
        }

        private void radioButton_Femenino_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Funcionario.Genero = 'F';
        }

        private void txt_Nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyzq çãÃâÂÇáéÁÉíÍõÕúÚóÓôÔ'";
            if (!Abecedario.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            string NumValidos = "0123456789,";
            if (!NumValidos.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;//Foi executado mas ignorado
            }
        }
    }
}
