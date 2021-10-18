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
    public partial class Frm_Gestao_Funcionarios : Form
    {
        public Frm_Gestao_Funcionarios()
        {
            InitializeComponent();
        }

        Cl_Funcionario Dados_Funcionario = new Cl_Funcionario();
        Cl_Crud Crud = new Cl_Crud();

        private void Mostar_Tabele()
        {
            if (radioButton_Masculinos.Checked == true)
            {
                Cl_Conexao.Tabela.Clear();
                Dados_Funcionario.Mostar_Funcionarios(" ", 'M', ' ', "", "");
                Dgv_Funcionarios.DataSource = Cl_Conexao.Tabela;
            }
            else if (radioButton_Femeninos.Checked == true)
            {
                Cl_Conexao.Tabela.Clear();
                Dados_Funcionario.Mostar_Funcionarios(" ", ' ', 'F', " ", "");
                Dgv_Funcionarios.DataSource = Cl_Conexao.Tabela;
            }
            else if (radioButton_Ver_Todos.Checked == true)
            {
                Cl_Conexao.Tabela.Clear();
                Dados_Funcionario.Mostar_Funcionarios("Todos", ' ', ' ', "", "");
                Dgv_Funcionarios.DataSource = Cl_Conexao.Tabela;
            }

        }

        private void Aumentar_Dgv()
        {
            Dgv_Funcionarios.Columns["Id_Funcionario"].Width = 100;
            Dgv_Funcionarios.Columns["Nome"].Width = 270;
            Dgv_Funcionarios.Columns["Genero"].Width = 100;
            Dgv_Funcionarios.Columns["BI"].Width = 150;
            Dgv_Funcionarios.Columns["Cargo"].Width = 200;
            Dgv_Funcionarios.Columns["Salario"].Width = 200;
        }

      

        private void radioButton_Ver_Todos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Dados_Funcionario.Mostar_Funcionarios("Todos", ' ', ' ', "", "");
                Dgv_Funcionarios.DataSource = Cl_Conexao.Tabela;

                Aumentar_Dgv();
            }
            catch (Exception v)
            {
                MessageBox.Show(v.Message);
            }
            finally
            { }

        }

        private void radioButton_Femeninos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Dados_Funcionario.Mostar_Funcionarios(" ", ' ', 'F', "", "");
                Dgv_Funcionarios.DataSource = Cl_Conexao.Tabela;

                Mostar_Tabele();
                Aumentar_Dgv();
            }

            finally
            { }
        }

        private void radioButton_Masculinos_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Dados_Funcionario.Mostar_Funcionarios(" ", 'M', ' ', "", "");
                Dgv_Funcionarios.DataSource = Cl_Conexao.Tabela;
                Aumentar_Dgv();
            }

            finally
            { }

        }

        private void Dgv_Funcionarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dados_Funcionario.Id_Funcionario = Convert.ToInt32(Dgv_Funcionarios.Rows[e.RowIndex].Cells["Id_Funcionario"].Value);
                Cl_Auxiliar.Aux_1 = Convert.ToString(Dados_Funcionario.Id_Funcionario);
                btn_Editar. Enabled = true; btn_Eliminar.Enabled = true;
            }
            catch
            {
                btn_Editar.Enabled = false; btn_Eliminar.Enabled = false;
                Dados_Funcionario.Id_Funcionario = 0;
            }
        }

     

    

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                radioButton_Femeninos.Checked = false;
                radioButton_Masculinos.Checked = false;
                radioButton_Ver_Todos.Checked = false;
                //Cl_Conexao.Tabela.Clear();
                Dados_Funcionario.Mostar_Funcionarios(" ", ' ', ' ', "Pesquisar", txt_Texto.Text);
                Dgv_Funcionarios.DataSource = Cl_Conexao.Tabela;

                Mostar_Tabele();
                Aumentar_Dgv();
            }

            finally
            { }
        }

        private void btn_Eliminar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desejas Eliminar Este Funcionario?", "NH-CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Crud.Eliminar_Funcionario(true, Dados_Funcionario.Id_Funcionario);
                    Mostar_Tabele();
                }
                else
                {
                    return;
                }


            }
            catch 
            {
                MessageBox.Show("Não é Possivel Efectuar Esta Operação","NH CARS",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_Cadastrar_Funcionarios Cadastrado = new Frm_Cadastrar_Funcionarios();
                Cadastrado.Modo = "Alterar";
                Cadastrado.ShowDialog();

                Mostar_Tabele();

            }
            catch (Exception gg)
            {
                MessageBox.Show(gg.Message);
            }
            finally { }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Funcionarios Cadastrar = new Frm_Cadastrar_Funcionarios();
            Cadastrar.Modo = "Cadastrar";
            Cadastrar.ShowDialog();
            Mostar_Tabele();
        }

        private void btn_Cargos_Click(object sender, EventArgs e)
        {
            Frm_Cargos Cargos = new Frm_Cargos();
            Cargos.ShowDialog();

     
        }

        private void Frm_Gestao_Funcionarios_Load(object sender, EventArgs e)
        {

        }

       


    }
}
