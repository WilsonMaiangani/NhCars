using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
namespace Projecto_NH_CARS
{
    public partial class Frm_Login : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        public Frm_Login()
        {
            InitializeComponent();
        }



        #region Campo de Metodos



        #endregion

        #region Botão Logar

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Nome_Usuario.Text == string.Empty)
                {
                    txt_Nome_Usuario.Focus();
                    return;
                }
                else if (txt_Senha_Usuario.Text == string.Empty)
                {
                    txt_Senha_Usuario.Focus();
                    return;
                }
                else
                {
                    Cl_Usuario Dados_Usuario = new Cl_Usuario();

                    Dados_Usuario.Verficar_Usuario(true, txt_Nome_Usuario.Text.Trim(), txt_Senha_Usuario.Text.Trim());

                    Dados_Usuario.Buscar_Nivel_de_Acesso();
                    if (Dados_Usuario.Verficador == false)
                    {
                        txt_Nome_Usuario.Text = string.Empty;
                        txt_Nome_Usuario.Focus();
                    }
                    else if (Dados_Usuario.Senha == string.Empty)
                    {
                        txt_Senha_Usuario.Text = string.Empty;
                        txt_Senha_Usuario.Focus();
                    }
                    else if (Dados_Usuario.Verficador == true && txt_Senha_Usuario.Text == Dados_Usuario.Senha)
                    {

                        /*Guardado Alguns Dados Do Usuario Na Class Auxiliar */
                        Cl_Auxiliar.Aux_1 = txt_Nome_Usuario.Text; Cl_Auxiliar.Aux_2 = Dados_Usuario.Cargo;

                        /* Adicionando O Usuario Logado Na Tabela De ( Usuarios Logado ) */
                        Cl_Crud Crud = new Cl_Crud();
                        Crud.Adicionario_Usuario_Logado(Dados_Usuario.Id_Usuario, DateTime.Now, Dados_Usuario.Verficador);

                        /* Buscando O ID Do Ultimo Login Na Tabela ( Usuarios Logado ) */
                        Dados_Usuario.Buscar_Id_Ultimo_Login(Dados_Usuario.Verficador);
                        Cl_Auxiliar.Aux_3 = Convert.ToString(Dados_Usuario.Id_Ultimo_Login);

                        if (Cl_Auxiliar.Aux_4_Acesso == " Baixo")
                        {
                            Frm_Menu_Principal Menu = new Frm_Menu_Principal();
                            Menu.Show();
                            this.Hide();
                        }
                        else if (Cl_Auxiliar.Aux_4_Acesso == " Alto")
                        {
                            Frm_Menu_Principal Menu = new Frm_Menu_Principal();
                            Menu.Show();
                            this.Hide();
                        }


                    }


                }
            }
            catch (Exception m)
            {

                MessageBox.Show(m.Message);
            }

        }

        #endregion

        #region Inicio Do Formulario

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            try
            {



            }

            catch (Exception v) { MessageBox.Show(v.Message); }

            finally
            { //Cl_Conexao.Conexao.Close(); 
            }
        }

        #endregion

        #region Campo Para Pode Controlhar o Tempo Do Carro Andar

        int conta = 0;
        private void Tmr_Tempo_Tick(object sender, EventArgs e)
        {
            conta++;
            Ptb_Carro.Left += 10;
            if (conta == 28)
            {
                conta = 0;
                Tmr_Tempo.Enabled = false;
                txt_Nome_Usuario.Enabled = true;
                txt_Senha_Usuario.Enabled = true;
                txt_Nome_Usuario.Focus();
            }
        }

        #endregion

        #region Campo Para o Botão de Fechar/MiniMizar & Para Pode Mover o Form

        private void btn_MiniMizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Frm_Opcao Pergunta = new Frm_Opcao();
            Pergunta.ShowDialog();
        }

        private void statusStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
    }
}
