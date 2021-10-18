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
    public partial class Frm_Cadastrar_Carro : Form
    {
        Cl_Carro Dados_Carro = new Cl_Carro();
        Cl_Crud Crud_Dados_Carro = new Cl_Crud();


        public Frm_Cadastrar_Carro()
        {
            InitializeComponent();
            Dados_Carro.Id_Carro = Convert.ToInt32(Cl_Auxiliar.Aux_1);
            Dados_Carro.Id_Usuario_Logado = Cl_Auxiliar.Aux_1_Id_Usuario_Logado;
        }

        private void Limpar_Campos()
        {
            comboBox_Modelo.Text = string.Empty;
            comboBox_Marca.Text = string.Empty;
            comboBox_Cor.Text = string.Empty;
            txt_N_Seri.Text = string.Empty;
            txt_Preco.Text = string.Empty;
            txt_Referencia_Pneu.Text = string.Empty;
            radioButton_Estado.Checked = false;
            comboBox_Modelo.Focus();
        }

        public string Modo = string.Empty;

        private void Alterar()
        {
            if (Modo == "Alterar")
            {
                Dados_Carro.Buscar_Todos_Dados(Dados_Carro.Id_Carro);
                txt_N_Seri.Text = Dados_Carro.N_serie;
                txt_Referencia_Pneu.Text = Dados_Carro.Tamanho_Pneu;
                Dtp_Data_Fabrico.Value = Convert.ToDateTime(Dados_Carro.Data);
                txt_Preco.Text = Convert.ToDecimal(Dados_Carro.Preco).ToString();

                Dados_Carro.Buscar_Outros();
                comboBox_Cor.Text = Dados_Carro.Cor;
                comboBox_Modelo.Text = Dados_Carro.Modelo;

                Dados_Carro.Buscar_Id_Marca_No_Modelo(true, comboBox_Modelo.Text);
                Dados_Carro.Buscar_Marca(true, Dados_Carro.Id_Marca);
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    comboBox_Marca.Text = Cl_Conexao.Comando_Leitura["Marca"].ToString();
                }
            }
        }
        private void Frm_Cadastrar_Carro_Load(object sender, EventArgs e)
        {
            try
            {
                Alterar();
                Dados_Carro.Buscar_Modelos(true);
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    comboBox_Modelo.Items.Add(Cl_Conexao.Comando_Leitura["Modelo"]);
                }

                Dados_Carro.Buscar_Cor(true);
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    comboBox_Cor.Items.Add(Cl_Conexao.Comando_Leitura["Cor"]);
                }
            }
            catch
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void comboBox_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dados_Carro.Buscar_Id_Marca_No_Modelo(true, comboBox_Modelo.Text);
                Dados_Carro.Buscar_Marca(true, Dados_Carro.Id_Marca);
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    comboBox_Marca.Text = Cl_Conexao.Comando_Leitura["Marca"].ToString();
                }
            }
            catch
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void comboBox_Cor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dados_Carro.Buscar_Id_Cor(true, comboBox_Cor.Text);
            }
            catch
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void radioButton_Estado_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Dados_Carro.Buscar_Id_Estado(true, "Disponível");
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
                if (comboBox_Modelo.Text == string.Empty)
                {
                    comboBox_Modelo.Focus(); return;
                }
                else if (comboBox_Cor.Text == string.Empty)
                {
                    comboBox_Cor.Focus(); return;
                }
                else if (txt_N_Seri.Text == string.Empty)
                {
                    txt_N_Seri.Focus(); return;
                }
                else if (txt_Referencia_Pneu.Text == string.Empty)
                {
                    txt_Referencia_Pneu.Focus(); return;
                }
                else if (txt_Preco.Text == string.Empty)
                {
                    txt_Preco.Focus(); return;
                }
                else if (!radioButton_Estado.Checked)
                {
                    MessageBox.Show("Selecione o Estado Do Carro", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
                }
                else
                {
                    string Data = Dtp_Data_Fabrico.Value.ToShortDateString();
                    double Preco = Convert.ToDouble(txt_Preco.Text);
                    if (Modo == "Cadastrar")
                    {

                        Crud_Dados_Carro.Adicionar_Carro(true, Dados_Carro.Id_Cor, Dados_Carro.Id_Usuario_Logado, Dados_Carro.Id_Modelo, Dados_Carro.Id_Estado, txt_N_Seri.Text, txt_Referencia_Pneu.Text, Data, Preco);
                        Limpar_Campos();
                    }
                    else if (Modo == "Alterar")
                    {
                        Crud_Dados_Carro.Editar_Carro(true, Dados_Carro.Id_Cor, Dados_Carro.Id_Usuario_Logado, Dados_Carro.Id_Modelo, Dados_Carro.Id_Estado, txt_N_Seri.Text, txt_Referencia_Pneu.Text, Data, Preco, Dados_Carro.Id_Carro);
                        Limpar_Campos();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Número de Serie Já Existente", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_N_Seri.Text = string.Empty;
                txt_N_Seri.Focus();
            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
