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
    public partial class Frm_Vendas : Form
    {
        public Frm_Vendas()
        {
            InitializeComponent();
            Dados_Vendas.Id_Carro = Convert.ToInt32(Cl_Auxiliar.Aux_1);
            Usuario_Logado.Id_Ultimo_Login = Cl_Auxiliar.Aux_1_Id_Usuario_Logado;
        }

        Cl_Vendas Dados_Vendas = new Cl_Vendas();
        Cl_Clientes Dados_Clientes = new Cl_Clientes();
        Cl_Crud Crud_Vendas = new Cl_Crud();
        Cl_Usuario Usuario_Logado = new Cl_Usuario();

        char Genero;
        double Calcular = 0;
        private void Colocar()
        {
            Dados_Vendas.Buscar_Todos_Dados(Dados_Vendas.Id_Carro);
            txt_N_Seri.Text = Dados_Vendas.N_serie;
            txt_Referencia_Pneu.Text = Dados_Vendas.Tamanho_Pneu;
            txt_Preco.Text = Convert.ToDecimal(Dados_Vendas.Preco).ToString();

            Dados_Vendas.Buscar_Outros();
            comboBox_Cor.Text = Dados_Vendas.Cor;
            comboBox_Modelo.Text = Dados_Vendas.Modelo;

            Dados_Vendas.Buscar_Id_Marca_No_Modelo(true, comboBox_Modelo.Text);
            Dados_Vendas.Buscar_Marca(true, Dados_Vendas.Id_Marca);
            while (Cl_Conexao.Comando_Leitura.Read())
            {
                comboBox_Marca.Text = Cl_Conexao.Comando_Leitura["Marca"].ToString();
            }
        }

        private void Frm_Vendas_Load(object sender, EventArgs e)
        {
            Colocar();
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            Genero = 'M';
            btn_M.Enabled = false;
            btn_F.Enabled = true;

        }

        private void btn_F_Click(object sender, EventArgs e)
        {
            Genero = 'F';
            btn_F.Enabled = false;
            btn_M.Enabled = true;
        }

        private void btn_Vender_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nome_Cliente.Text == string.Empty)
                {
                    txt_Nome_Cliente.Focus(); return;
                }
                else if (txt_BI.Text == string.Empty)
                {
                    txt_BI.Focus();
                }
                else
                {
                    Crud_Vendas.Adicionar_Cliente(txt_Nome_Cliente.Text, Genero, txt_BI.Text);
                    Dados_Clientes.Buscar_Id_Cliente(txt_Nome_Cliente.Text);

                    double Valor_APagar = Convert.ToDouble(txt_Valor_Apagar.Text);
                    double Troco = Convert.ToDouble(txt_Troco.Text);

                    Crud_Vendas.Adicionar_Venda(Usuario_Logado.Id_Ultimo_Login, Dados_Clientes.Id_Cliente, Dados_Vendas.Id_Carro, Valor_APagar, Troco);
                    Crud_Vendas.Mudar_Estado_Do_Carro(Dados_Vendas.Id_Carro, 1);


                    Frm_Factura.Cliente = txt_Nome_Cliente.Text;
                    Frm_Factura.Marca = comboBox_Marca.Text;
                    Frm_Factura.Modelo = comboBox_Modelo.Text;
                    Frm_Factura.N_Serie = txt_N_Seri.Text;
                    Frm_Factura.Cor = comboBox_Cor.Text;
                    Frm_Factura.Preco = Convert.ToDouble(txt_Preco.Text);
                    Frm_Factura.Tamanho_Pneu = txt_Referencia_Pneu.Text;
                    Frm_Factura.Data = DateTime.Now.ToShortDateString();
                    Frm_Factura.Funcionario = Cl_Auxiliar.Aux_4;

                    Frm_Factura ver = new Frm_Factura();
                    ver.Show();

                }

            }
            catch
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void txt_Valor_Apagar_OnValueChanged(object sender, EventArgs e)
        {
            try
            {
                Calcular = Convert.ToDouble(txt_Valor_Apagar.Text) - Convert.ToDouble(txt_Preco.Text);
                if (Convert.ToDouble(txt_Valor_Apagar.Text) < Convert.ToDouble(txt_Preco.Text))
                {
                    txt_Troco.Text = string.Empty;
                }
                else if (Convert.ToDouble(txt_Valor_Apagar.Text) >= Convert.ToDouble(txt_Preco.Text))
                {
                    txt_Troco.Text = Convert.ToDouble(Calcular).ToString();
                    btn_Vender.Enabled = true;
                }

            }
            catch
            {
                txt_Troco.Text = string.Empty;
            }

        }

        private void txt_Valor_Apagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string NumValidos = "0123456789";
            if (!NumValidos.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;//Foi executado mas ignorado
            }
        }

        private void txt_Nome_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string Abecedario = "ABCDEFGHIJKLMNOPQRSTUVWXYZ abcdefghijklmnopqrstuvwxyzq çãÃâÂÇáéÁÉíÍõÕúÚóÓôÔ'";
            if (!Abecedario.Contains(e.KeyChar) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }


    }
}
