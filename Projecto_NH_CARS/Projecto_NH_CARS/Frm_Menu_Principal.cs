using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Projecto_NH_CARS
{
    public partial class Frm_Menu_Principal : Form
    {
        Cl_Usuario Dados_Usuario = new Cl_Usuario();
        Cl_Crud Crud = new Cl_Crud();

        private void PassarDados()
        {
            Dados_Usuario.Nome = Cl_Auxiliar.Aux_1;
            Dados_Usuario.Cargo = Cl_Auxiliar.Aux_2;
            Dados_Usuario.Id_Ultimo_Login = Convert.ToInt32(Cl_Auxiliar.Aux_3);
        }

        public Frm_Menu_Principal()
        {
            InitializeComponent();
            PassarDados();
            lbl_Nome_User.Text = Dados_Usuario.Nome;
            lbl_Nivel_Acesso.Text = Dados_Usuario.Cargo;

            Dados_User();
            Niveil_Acesso();
        }

        private void Niveil_Acesso()
        {
            if (Cl_Auxiliar.Aux_4_Acesso == " Baixo")
            {
                btn_Gestao.Enabled = false;
                btn_Ajuda.Enabled = false;
                btn_Clientes.Enabled = false;
                btn_Estatistica.Enabled = false;
                btn_Sobre_Software.Enabled = false;
                btn_Mudar_Usuario.Enabled = true;

                Panel_Principal.Controls.Clear();
                lbl_Texto.Text = "Gestão De Vendas";
                Panel_Principal.Controls.Clear();
                Frms = new Frm_Gestao_Vendas { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
                Panel_Principal.Controls.Add(Frms);
                Frms.Show();
            }
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        Form Frms;
        bool Verf = false;

        private void Dados_User()
        {
            panel_Gestao.Size = new Size(143, 627);
            this.WindowState = FormWindowState.Maximized;
        }

        private void Tirar_Panel()
        {
            panel_Gestao.Size = new Size(143, 627);
            Verf = false;
        }

        private void Adicionar_Hora_Saida_Usuario()
        {
            string Hora_Saida = DateTime.Now.ToShortTimeString();

            Crud.Atualizar_Hora_Saida(true, Hora_Saida, Dados_Usuario.Id_Ultimo_Login);
        }

        private void Tmr_Tempo_Tick(object sender, EventArgs e)
        {
            lbl_Tempo.Text = "  " + DateTime.Now.ToShortTimeString() + ":" + DateTime.Now.Second + "\n" + DateTime.Now.ToShortDateString();
        }

        private void btn_Gestao_Click(object sender, EventArgs e)
        {
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = string.Empty;

            if (Verf == false)
            {
                Verf = true;
                panel_Gestao.Size = new Size(339, 627);
            }
            else if (Verf == true)
            {
                Verf = false;
                panel_Gestao.Size = new Size(143, 627);
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            try
            {
                Adicionar_Hora_Saida_Usuario();
                Application.Exit();
            }
            catch (Exception)
            {

            }

        }

        bool Verificador = false;
        private void btn_MaxMizar_Click(object sender, EventArgs e)
        {
            if (Verificador == false)
            {
                Verificador = true;
                this.WindowState = FormWindowState.Normal;
            }
            else if (Verificador == true)
            {
                Verificador = false;
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void btn_MiniMizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void btn_Mudar_Usuario_Click(object sender, EventArgs e)
        {
            try
            {
                Adicionar_Hora_Saida_Usuario();
                Frm_Login Login = new Frm_Login();
                Login.Show();
                Hide();
            }
            catch (Exception)
            {
            }
            
        }

        #region Campo De Chamar Todos Os Forms

        private void btn_Gestao_Funcionario_Click(object sender, EventArgs e)
        {
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Gestão De Funcionários";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Gestao_Funcionarios { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Gestoa_Marcas_Click(object sender, EventArgs e)
        {

            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Gestão De Marcas";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Gestao_Marcas { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Gestoa_Modelos_Click(object sender, EventArgs e)
        {

            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Gestão De Modelos";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Gestao_Modelos { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Gestoa_Carros_Click(object sender, EventArgs e)
        {
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Gestão De Carros";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Gestao_Carros { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Gestoa_Vendas_Click(object sender, EventArgs e)
        {
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Gestão De Vendas";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Gestao_Vendas { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Gestoa_Usuarios_Click(object sender, EventArgs e)
        {
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Gestão De Usuarios";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Gestao_Usuarios { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Tirar_Panel();
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Clientes";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Clientes { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Estatistica_Click(object sender, EventArgs e)
        {
            Tirar_Panel();
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Estatística";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Estatisticas { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Ajuda_Click(object sender, EventArgs e)
        {
            Tirar_Panel();
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Ajuda";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Ajuda { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }

        private void btn_Sobre_Software_Click(object sender, EventArgs e)
        {
            Tirar_Panel();
            Panel_Principal.Controls.Clear();
            lbl_Texto.Text = "Sobre O Software";
            Panel_Principal.Controls.Clear();
            Frms = new Frm_Sobre_Software { TopLevel = false, FormBorderStyle = FormBorderStyle.None, Dock = DockStyle.Fill };
            Panel_Principal.Controls.Add(Frms);
            Frms.Show();
        }


        #endregion


    }
}
