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
    public partial class Frm_Cadastrar_Cargos : Form
    {
        public Frm_Cadastrar_Cargos()
        {
            InitializeComponent();
            Dados_Cargo.Id_Cargo = Convert.ToInt16(Cl_Auxiliar.Aux_1);
        }

        Cl_Cargos Dados_Cargo = new Cl_Cargos();
        Cl_Crud Crud_Cargo = new Cl_Crud();

        public string Modo = string.Empty;

        private void Colocar_Cargo_Cbb()
        {
            CbB_Cargos.Items.Clear();
            Dados_Cargo.Preencher_Cargos_CbB();
            foreach (string item in Dados_Cargo.Lista_Cargos)
            {
                CbB_Cargos.Items.Add(item);
            }
        }

        private void Alterar()
        {
            if (Modo == "Alterar")
            {
                Dados_Cargo.Verficar_cargo(true, Dados_Cargo.Id_Cargo);
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    txt_Cargo.Text = Cl_Conexao.Comando_Leitura["Cargo"].ToString();
                    txt_Salario.Text = Cl_Conexao.Comando_Leitura["Salario"].ToString();
                }
            }
        }

        private void txt_Cargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyzq çãÃâÂÇáéÁÉíÍõÕúÚóÓôÔ'";
            if (!Abecedario.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void Frm_Cadastrar_Cargos_Load(object sender, EventArgs e)
        {
            Colocar_Cargo_Cbb();
            Alterar();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Cargo.Text == string.Empty)
                {
                    txt_Cargo.Focus();
                    return;
                }
                else if (txt_Salario.Text == string.Empty)
                {
                    txt_Salario.Focus();
                    return;

                }
                else
                {
                    //if (Dados_Cargo.Lista_Cargos.Contains(txt_Cargo.Text))
                    //{
                    //    MessageBox.Show("Cargo Já Existente", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    txt_Cargo.Text = string.Empty;
                    //    txt_Cargo.Focus();
                    //    return;
                    //}

                    if (Modo == "Cadastrar")
                    {
                        Crud_Cargo.Adicionar_Cargos(true, txt_Cargo.Text);
                        Colocar_Cargo_Cbb();
                        txt_Cargo.Text = string.Empty;
                        CbB_Cargos.Text = string.Empty;
                        txt_Cargo.Focus();
                    }
                    else if (Modo == "Alterar")
                    {
                        Crud_Cargo.Alterar_Cargo(true, txt_Cargo.Text, Convert.ToDecimal(txt_Salario.Text), Dados_Cargo.Id_Cargo);
                        txt_Cargo.Text = string.Empty;
                        txt_Cargo.Focus();
                        Colocar_Cargo_Cbb();
                    }

                }


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

        private void txt_Cargo_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
