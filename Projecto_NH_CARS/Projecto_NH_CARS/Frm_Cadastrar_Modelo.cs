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
    public partial class Frm_Cadastrar_Modelo : Form
    {
        public Frm_Cadastrar_Modelo()
        {
            InitializeComponent();
            Dados_Modelos.Id_Modelo = Convert.ToInt32(Cl_Auxiliar.Aux_1);
        }

        Cl_Modelo Dados_Modelos = new Cl_Modelo();
        Cl_Crud Crud_Dados_Modelo = new Cl_Crud();


        public string Modo = string.Empty;
        private void Limpar_Campos()
        {
            txt_Modelo.Text = string.Empty;
            txt_Modelo.Focus();
            comboBox_Marcas.Text = string.Empty;
        }

        private void Colocar_Marcas_Na_CbB()
        {
            Dados_Modelos.Carregar_Marcas();
            comboBox_Marcas.Items.Clear();
            while (Cl_Conexao.Comando_Leitura.Read())
            {
                comboBox_Marcas.Items.Add(Cl_Conexao.Comando_Leitura["Marca"]);
            }
        }

        private void Colocar_dados_nos_Campo()
        {
            if (Modo == "Alterar")
            {
                Dados_Modelos.Buscar_dados_Para_Alterar(true);
                txt_Modelo.Text = Dados_Modelos.Modelo;

                Dados_Modelos.Buscar_Marca();
                comboBox_Marcas.Text = Dados_Modelos.Marca;
            }

        }
        private void Frm_Cadastrar_Modelo_Load(object sender, EventArgs e)
        {
            try
            {
                Colocar_dados_nos_Campo();
                Colocar_Marcas_Na_CbB();


            }
            finally { Cl_Conexao.Conexao.Clone(); }

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Modelo.Text == string.Empty)
                {
                    txt_Modelo.Focus();
                    return;
                }
                else if (comboBox_Marcas.Text == string.Empty)
                {
                    comboBox_Marcas.Focus();
                    return;
                }
                else
                {
                    if (Modo == "Cadastrar")
                    {
                        Dados_Modelos.Verficar_Modelo(txt_Modelo.Text);

                        if (Dados_Modelos.Verficador == true)
                        {
                            MessageBox.Show("Modelo Já Existente", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txt_Modelo.Text = string.Empty;
                            txt_Modelo.Focus();
                            return;
                        }
                        else
                        {
                            Crud_Dados_Modelo.Adicionar_Modelo(true, Dados_Modelos.Id_Marca, txt_Modelo.Text);
                            Colocar_Marcas_Na_CbB();
                            Limpar_Campos();
                        }
                    }


                    else if (Modo == "Alterar")
                    {
                        Crud_Dados_Modelo.Alterar_Dados_Modelo(true, Dados_Modelos.Id_Modelo, txt_Modelo.Text, Dados_Modelos.Id_Marca);
                        Limpar_Campos();
                    }







                }

            }
            finally { Cl_Conexao.Conexao.Clone(); }
        }

        private void comboBox_Marcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Dados_Modelos.Buscar_Id_Marca(true, comboBox_Marcas.Text);
            }
            finally { Cl_Conexao.Conexao.Clone(); }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
