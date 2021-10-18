using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Projecto_NH_CARS
{
    class Cl_Crud : Cl_Verficador
    {
        /**    Herdando O metodo de Conectar a Bd , Que Esta na Class Verficador     */
        public override void Conectar_Bd()
        {
            base.Conectar_Bd();
        }

        #region Crud Para Usuario Logado

        public Boolean Adicionario_Usuario_Logado(int Id_Usuario, DateTime Data_Entrada, bool Verf)
        {
            if (Verf == true)
            {
                string Data = Convert.ToDateTime(Data_Entrada).ToString();
                Conectar_Bd();
                Cl_Conexao.Comando = new MySqlCommand("Insert into Usuario_Logado (Id_Usuario, Data_Entrada) values ('" + Id_Usuario + "','" + Data + "')", Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();
            }

            return Verf;
        }

        public Boolean Atualizar_Hora_Saida(bool Verf, string Hora_Saida, int Id_Logado)
        {
            if (Verf == true)
            {
                Conectar_Bd();
                Cl_Conexao.Comando = new MySqlCommand("Update Usuario_Logado set Hora_Saida='" + Hora_Saida + "' where Id_Logado=" + Id_Logado, Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();
            }
            return Verf;
        }

        public Boolean Adicionar_Usuario(int Id_Funcionario, string Usuario, string Senha, int Id_Acesso)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Insert into Usuario (Id_Funcionario , Usuario , Senha , Id_Acesso) values('" + Id_Funcionario + "','" + Usuario + "','" + Senha + "','" + Id_Acesso + "')", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            MessageBox.Show("Usuario Cadastrado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verficador;
        }

        public Boolean Editar_Usuario(int Id_Funcionario, string Usuario, string Senha, int Id_Acesso, int Id_Usuario)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Update Usuario Set Id_Funcionario='" + Id_Funcionario + "',Usuario='" + Usuario + "',Senha='" + Senha + "',Id_Acesso='" + Id_Acesso + "' where Id_Usuario=" + Id_Usuario, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            MessageBox.Show("Dados Alterados ", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verficador;
        }
        #endregion

        #region Crud Para O Funcionario

        Cl_Funcionario Dados_Funcionario = new Cl_Funcionario();

        public Boolean Adicionar_Funcionario(bool verf, string Nome, char Genero, string BI, int Id_Cargo, int Telefone)
        {
            if (verf == true)
            {
                Cl_Conexao.Conexao.Close();
                Cl_Conexao.Conexao.Open();
                Cl_Conexao.Comando = new MySqlCommand("Insert into Funcionario (Nome , Genero , BI , Id_Cargo) values ('" + Nome + "','" + Genero + "','" + BI + "','" + Id_Cargo + "')", Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();

                Dados_Funcionario.Buscar_Id_Funcionario(Nome, verf);

                Cl_Conexao.Conexao.Close();
                Cl_Conexao.Conexao.Open();
                Cl_Conexao.Comando = new MySqlCommand("Insert into Telefone (Id_Funcionario , Telefone) values ('" + Dados_Funcionario.Id_Funcionario + "','" + Telefone + "')", Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();

                MessageBox.Show("Funcionario Cadastrado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            return verf;
        }

        public Boolean Alterar_Dados_Funcionario(bool verf, string Nome, char Genero, string BI, int Id_Cargo, int Telefone, int Id_Funcionario)
        {
            if (verf == true)
            {

                Conectar_Bd();

                Cl_Conexao.Comando = new MySqlCommand("Update Funcionario Set Nome='" + Nome + "',Genero='" + Genero + "', BI='" + BI + "',Id_Cargo='" + Id_Cargo + "' where Id_Funcionario=" + Id_Funcionario, Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();

                Conectar_Bd();

                Cl_Conexao.Conexao.Close();
                Cl_Conexao.Conexao.Open();

                Cl_Conexao.Comando = new MySqlCommand("Update Telefone set Telefone='" + Telefone + "' where Id_Funcionario=" + Id_Funcionario, Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();

                MessageBox.Show("Dados Alterado ", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            return verf;
        }

        public Boolean Eliminar_Funcionario(bool Verf, int Id_Funcionario)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Delete from Telefone where id_Funcionario=" + Id_Funcionario + "", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();

            Cl_Conexao.Comando = new MySqlCommand("Delete from funcionario where id_Funcionario=" + Id_Funcionario + "", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            return Verf;
        }

        #endregion

        #region Crud Para A Marca

        public Boolean Adicionar_Marcas(bool Verf, string Marca)
        {
            Verficador = Verf;
            if (Verficador == true)
            {
                Conectar_Bd();
                Cl_Conexao.Comando = new MySqlCommand("Insert into Marca (Marca) values('" + Marca + "')", Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();

                MessageBox.Show("Marca Cadastrado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return Verficador;
        }

        public Boolean Editar_Marca(bool Verf, int Id_Marca, string Marca)
        {
            Verficador = Verf;
            if (Verficador == true)
            {
                Conectar_Bd();

                Cl_Conexao.Comando = new MySqlCommand("Update Marca Set Marca='" + Marca + "' where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();
                MessageBox.Show("Dados Alterado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return Verficador;
        }

        public Boolean Eliminar_Marca(bool verf, int Id_Marca)
        {
            if (verf == true)
            {
                Conectar_Bd();
                Cl_Conexao.Comando = new MySqlCommand("Delete from Marca where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();
                MessageBox.Show("Marca Eliminada", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return verf;
        }

        public Boolean Eliminar_Todos_Modelos_Da_Mesma_Marca(int Id_Marca)
        {

            Conectar_Bd();
            if (Cl_Auxiliar.Aux_Verf_1 == true)
            {
                Cl_Conexao.Comando = new MySqlCommand("Delete from Modelos Where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
                Cl_Conexao.Comando.ExecuteNonQuery();

            }


            return Verficador;
        }

        #endregion

        #region Crud Para O Modelo

        public Boolean Adicionar_Modelo(bool Verf, int Id_Marca, string Modelo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Insert into Modelos (Id_Marca, Modelo) values ('" + Id_Marca + "','" + Modelo + "')", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            MessageBox.Show("Modelo Cadastrado ", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return Verf;
        }

        public Boolean Eliminar_Modelo(bool verf, int Id_Marca)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Delete from Modelos where Id_Modelo=" + Id_Marca, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();

            MessageBox.Show("Modelo Eliminado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return verf;
        }

        public Boolean Alterar_Dados_Modelo(bool Verf, int Id_Modelo, string Modelo, int Id_Marca)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Update Modelos set Id_Marca='" + Id_Marca + "', Modelo='" + Modelo + "' where Id_Modelo=" + Id_Modelo, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();

            MessageBox.Show("Dados Alterados", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verficador;
        }
        #endregion

        #region Crud Para Os Cargos

        public Boolean Adicionar_Cargos(bool Verf, string Cargo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Insert into Cargo (Cargo) values ('" + Cargo + "')", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();

            MessageBox.Show("Cargo Cadastrado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verf;
        }

        public Boolean Alterar_Cargo(bool Verf, string Cargo, Decimal Salario, int Id_Cargo)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Update Cargo set Cargo='" + Cargo + "', Salario='" + Salario + "' where Id_Cargo=" + Id_Cargo, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();

            MessageBox.Show("Dados Alterados", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verf;
        }

        public Boolean Eliminar_Cargo(bool Verf, int Id_Cargo)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Delete from Cargo where Id_Cargo=" + Id_Cargo, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            MessageBox.Show("Cargo Eliminado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verf;
        }

        #endregion

        #region Crud Para Os Carros

        public Boolean Adicionar_Carro(bool Verf, int Id_cor, int Id_Usuario_Logado, int Id_Modelo, int Id_Estado, string N_Serie, string Tamanho_Pneu, string Data_De_Fabrico, double Preço)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Insert into Carro (Id_cor,Id_Usuario_Logado , Id_Modelo , Id_Estado , N_Serie , Tamanho_Pneu , Data_De_Fabrico , Preco) values ('" + Id_cor + "','" + Id_Usuario_Logado + "','" + Id_Modelo + "','" + Id_Estado + "','" + N_Serie + "','" + Tamanho_Pneu + "','" + Data_De_Fabrico + "','" + Preço + "')", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();

            MessageBox.Show("Carro Cadastrado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verf;
        }

        public Boolean Editar_Carro(bool Verf, int Id_cor, int Id_Usuario_Logado, int Id_Modelo, int Id_Estado, string N_Serie, string Tamanho_Pneu, string Data_De_Fabrico, double Preço, int Id_Carro)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Update Carro Set Id_cor='" + Id_cor + "',Id_Usuario_Logado='" + Id_Usuario_Logado + "',Id_Modelo='" + Id_Modelo + "',N_Serie='" + N_Serie + "',Tamanho_Pneu='" + Tamanho_Pneu + "',Data_De_Fabrico='" + Data_De_Fabrico + "',Preco='" + Preço + "' Where Id_Carro=" + Id_Carro, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            MessageBox.Show("Dados Alterados", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return Verficador;
        }

        public Boolean Eliminar_Carro(int Id_Carro)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Delete from Carro where Id_carro=" + Id_Carro, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            MessageBox.Show("Carro Eliminado", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verficador;
        }
        #endregion

        #region Crud Para Venda de Carro

        public Boolean Adicionar_Cliente(string Nome, char Genero, string BI)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Insert into Clientes (Nome,Genero,Bi) values ('" + Nome + "','" + Genero + "','" + BI + "')", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            return Verficador;
        }

        public Boolean Adicionar_Venda(int Id_Usuario_Logado, int Id_Cliente, int Id_Carro, double Preço_APagar, double Troco)
        {
            string Data = DateTime.Now.ToShortDateString();
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Insert into Vendas (Id_Usuario_Logado,Id_Cliente,Id_Carro,Data_Venda,Valor_a_Pagar,Troco) Values('" + Id_Usuario_Logado + "','" + Id_Cliente + "','" + Id_Carro + "','" + Data + "','" + Preço_APagar + "','" + Troco + "')", Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();

            MessageBox.Show("Carro Vendido", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verficador;
        }

        public Boolean Eliminar_Venda(int Id_Venda)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Delete from Vendas where Id_venda=" + Id_Venda, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            MessageBox.Show("Venda Eliminada ", "NH CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return Verficador;
        }

        public Boolean Mudar_Estado_Do_Carro(int Id_Carro, int Id_Estado)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Update Carro Set Id_Estado='" + Id_Estado + "' where Id_Carro=" + Id_Carro, Cl_Conexao.Conexao);
            Cl_Conexao.Comando.ExecuteNonQuery();
            return Verficador;
        }

        #endregion
    }
}
