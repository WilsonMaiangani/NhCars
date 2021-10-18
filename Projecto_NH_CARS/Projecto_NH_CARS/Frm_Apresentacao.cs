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
namespace Projecto_NH_CARS
{
    public partial class Frm_Apresentacao : Form
    {
        public Frm_Apresentacao()
        {
            InitializeComponent();
        }

      

        int conta = 0;
        private void Tmr_Tempo_Tick(object sender, EventArgs e)
        {
            conta++;
            Ptb_Carro.Left += 10;
           
            if (conta == 70)
            {
                conta = 0;
                Tmr_Tempo.Enabled = false;
                Frm_Login Login = new Frm_Login();
                Login.Show();
                this.Hide();
                Ptb_Carro.Location = new Point(1, 158);
            }

        }
    }
}
