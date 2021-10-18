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
    public partial class Frm_Visualizar_Usuario_Logados : Form
    {
        public Frm_Visualizar_Usuario_Logados()
        {
            InitializeComponent();
        }
        Cl_Usuario Dados_Usuario = new Cl_Usuario();
        private void Frm_Visualizar_Usuario_Logados_Load(object sender, EventArgs e)
        {
            try
            {
                Dados_Usuario.Mostar_Todos_Usuarios("", "Usuarios Logados");
                Dgv_Usuario_Logados. DataSource = Cl_Conexao.Tabela;
                Dgv_Usuario_Logados.Columns["Usuario"].Width = 400;
                Dgv_Usuario_Logados.Columns["Data_Entrada"].Width = 200;
                Dgv_Usuario_Logados.Columns["Hora_Saida"].Width = 330;
            }
            catch (Exception)
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }
    }
}
