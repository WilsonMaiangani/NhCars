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
    public partial class Frm_Gestao_Marcas : Form
    {
        public Frm_Gestao_Marcas()
        {
            InitializeComponent();
        }

        Cl_Marca Dados_Marca = new Cl_Marca();
        Cl_Crud Crud_Marca = new Cl_Crud();

        private void Limpar_Campos()
        {
        }

        private void Frm_Gestao_Marcas_Load(object sender, EventArgs e)
        {
            try
            {
                #region Mostrar Todas As Marca Na Dgv
                Dados_Marca.Mostrar_Todos_Marcas(true, "Tabela", "", "");
                Dgv_Marca.DataSource = Cl_Conexao.Tabela;

                Dgv_Marca.Columns["Id_Marca"].Width = 300;
                Dgv_Marca.Columns["Marca"].Width = 800;
                #endregion
            }

            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desejas Eliminar Esta Marca?", "NH CARS", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Crud_Marca.Eliminar_Marca(true, Dados_Marca.Id_Marca);
                    Dados_Marca.Mostrar_Todos_Marcas(true, "Tabela", "", "");
                }
                
            }
            catch
            {
                MessageBox.Show("Não é Possivel Efectuar Esta Operação", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Dados_Marca.Verficar_Id_Marca_Tabela_Modelo(Dados_Marca.Id_Marca);
                
                //Crud_Marca.Eliminar_Todos_Modelos_Da_Mesma_Marca(Dados_Marca.Id_Marca);

                //Crud_Marca.Eliminar_Marca(true, Dados_Marca.Id_Marca);
                //Dados_Marca.Mostrar_Todos_Marcas(true, "Tabela", "", "");
            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Marca.Text == string.Empty)
                {
                    txt_Marca.Focus();
                }
                else
                {
                    Dados_Marca.Verficar_Marca(true, txt_Marca.Text);

                    if (Dados_Marca.Verficador == true)
                    {
                        MessageBox.Show("Marca Já Existente", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txt_Marca.Text = string.Empty;
                        txt_Marca.Focus();
                        return;
                    }
                    else
                    {
                        Crud_Marca.Adicionar_Marcas(true, txt_Marca.Text);
                        Dados_Marca.Mostrar_Todos_Marcas(true, "Tabela", "", "");
                        txt_Marca.Text = string.Empty;
                        txt_Marca.Focus();
                    }

                }

            }
            catch
            {

            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void Dgv_Marca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dados_Marca.Id_Marca = Convert.ToInt32(Dgv_Marca.Rows[e.RowIndex].Cells["Id_Marca"].Value);
                Dados_Marca.Buscar_Marca(true, Dados_Marca.Id_Marca);
                txt_Editar.Text = Dados_Marca.Marca;

                btn_Editar.Enabled = true;
                btn_Eliminar.Enabled = true;
                txt_Editar.Enabled = true;

            }
            catch
            {
                txt_Editar.Enabled = false;
                txt_Editar.Text = string.Empty;
                btn_Editar.Enabled = false;
                btn_Eliminar.Enabled = false;
            }
            finally { Cl_Conexao.Conexao.Close(); }


        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Editar.Text == string.Empty)
                {
                    txt_Editar.Focus(); return;
                }
                else
                {
                    //Dados_Marca.Verficar_Marca(true, txt_Pesquisar.Text);

                    //if (Dados_Marca.Verficador == true)
                    //{
                    //    MessageBox.Show("Marca Já Existente", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //   txt_Pesquisar. Text = string.Empty;
                    //   txt_Pesquisar.Focus();
                    //    return;
                    //}
                    Crud_Marca.Editar_Marca(true, Dados_Marca.Id_Marca, txt_Editar.Text);
                    Dados_Marca.Mostrar_Todos_Marcas(true, "Tabela", "", "");
                    Dgv_Marca.DataSource = Cl_Conexao.Tabela;
                    txt_Editar.Text = string.Empty;
                    //else
                    //{

                    //}


                }

            }
            catch
            {


            }
            finally { Cl_Conexao.Conexao.Close(); }
        }

        private void radioButton_cadastrar_CheckedChanged(object sender, EventArgs e)
        {
            txt_Marca.Enabled = true;
            btn_Cadastrar.Enabled = true;
            txt_Marca.Focus();

            txt_Pesquisar.Enabled = false;
            btn_Pesquisar.Enabled = false;
        }

        private void radioButton_Pesquisar_CheckedChanged(object sender, EventArgs e)
        {
            txt_Pesquisar.Enabled = true;
            btn_Pesquisar.Enabled = true;
            txt_Pesquisar.Focus();

            txt_Marca.Enabled = false;
            btn_Cadastrar.Enabled = false;
        }

        private void btn_Pesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Pesquisar.Text == string.Empty)
                {
                    txt_Pesquisar.Focus();
                    return;
                }
                else
                {
                    Dados_Marca.Mostrar_Todos_Marcas(true, "", "Pesquisar", txt_Pesquisar.Text);
                    Dgv_Marca.DataSource = Cl_Conexao.Tabela;
                }

            }
            catch
            {


            }

        }

        private void radioButton_Todos_CheckedChanged(object sender, EventArgs e)
        {
            Dados_Marca.Mostrar_Todos_Marcas(true, "Tabela", "", "");
            Dgv_Marca.DataSource = Cl_Conexao.Tabela;
        }
    }
}
