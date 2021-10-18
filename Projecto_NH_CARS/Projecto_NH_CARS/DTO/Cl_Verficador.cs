using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace Projecto_NH_CARS
{
    abstract class Cl_Verficador
    {
        public Boolean Verficador = false;

        public List<string> Lista_Cargos = new List<string> { };

        public virtual void Conectar_Bd()
        {
            Cl_Conexao.Conexao.Close();
            Cl_Conexao.Conexao.Open();
        }


        public void Preencher_Cargos_CbB()
        {
            Lista_Cargos.Clear();
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Cargo from Cargo", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {

                Lista_Cargos.Add(Cl_Conexao.Comando_Leitura["Cargo"].ToString());
            }
        }
    }

    /* --------------------------------------------------------------------------------------------- */

    class Cl_Usuario : Cl_Verficador
    {
        public string Nome = string.Empty, Senha = string.Empty, Cargo = string.Empty, Acesso = string.Empty;
        public int Id_Funcionario = 0, Id_Cargo = 0, Id_Usuario = 0, Id_Ultimo_Login = 0, Id_Acesso;

        /**    Herdando O metodo de Conectar a Bd , Que Esta na Class Verficador     */
        public override void Conectar_Bd()
        {
            Cl_Conexao.Conexao.Close();
            Cl_Conexao.Conexao.Open();
        }


        #region Consulta Para o Login do Usuario

        public Boolean Verficar_Usuario(bool verf, string Nome, string Passwor)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select  Id_Acesso, Id_Usuario, Id_Funcionario , Usuario , Senha from Usuario where Usuario='" + Nome + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Verficador = true;
                Cl_Auxiliar.Aux_2 = Convert.ToString(Cl_Conexao.Comando_Leitura["Id_Acesso"]);
                Nome = Cl_Conexao.Comando_Leitura["Usuario"].ToString();
                Senha = Cl_Conexao.Comando_Leitura["Senha"].ToString();
                Id_Funcionario = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Funcionario"].ToString());
                Id_Usuario = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Usuario"].ToString());
            }
            Cl_Auxiliar.Aux_4 = Nome;
            if (Verficador == false)
            {
                MessageBox.Show("Usuario Não Existente", "NH-CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return Verficador;
            }
            else if (Passwor != Senha)
            {
                Senha = string.Empty;
                MessageBox.Show("Senha Incorreta", "NH-CARS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            #region Buscar o Id_Cargo & o Cargo Do Usuario

            if (Verficador == true)
            {
                /* Buscando O Id Do Cargo Do usuario Na Tabela De Funcionario*/
                Conectar_Bd();
                Cl_Conexao.Comando = new MySqlCommand("Select Id_Cargo from Funcionario where Id_Funcionario=" + Id_Funcionario + " ", Cl_Conexao.Conexao);
                Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    Id_Cargo = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Cargo"].ToString());
                }

                /* Buscando O Cargo Do Funcionario(Usuario) Na Tabela De Cargo*/
                Conectar_Bd();
                Cl_Conexao.Comando = new MySqlCommand("Select Cargo from Cargo where Id_Cargo=" + Id_Cargo + " ", Cl_Conexao.Conexao);
                Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    Cargo = Cl_Conexao.Comando_Leitura["Cargo"].ToString();
                }
            }

            #endregion

            return verf;
        }
        public Boolean Buscar_Nivel_de_Acesso()
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Acesso from Acesso where Id_Acesso=" + Cl_Auxiliar.Aux_2, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Cl_Auxiliar.Aux_4_Acesso = Cl_Conexao.Comando_Leitura["Acesso"].ToString();
            }
            return Verficador;
        }

        #region Buscando O Id Do Ultimo Loin Do Usuario

        /* Buscando O Id Do Ultimo Loin Do Usuario */
        public Boolean Buscar_Id_Ultimo_Login(bool Verf)
        {
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();
            if (Verf == true)
            {
                Cl_Conexao.Conexao.Close();
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("Select Id_Logado from Usuario_Logado", Cl_Conexao.Conexao);
                Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);
                Id_Ultimo_Login = Convert.ToInt32(Cl_Conexao.Tabela.Rows.Count);
                Cl_Auxiliar.Aux_1_Id_Usuario_Logado = Id_Ultimo_Login;
            }
            return Verf;
        }

        #endregion

        #endregion

        public Boolean Mostar_Todos_Usuarios(string Usuarios, string Usuarios_Logados)
        {
            Conectar_Bd();
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();

            Cl_Conexao.Tabela.Clear();

            if (Usuarios == "Usuarios")
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Usuario.Id_Usuario,Funcionario.Nome,Usuario.Usuario,Usuario.Senha, Acesso.Acesso from Usuario inner join Funcionario on Usuario.Id_Funcionario=Funcionario.Id_Funcionario inner join Acesso on Usuario.Id_Acesso=Acesso.Id_Acesso;", Cl_Conexao.Conexao);
            }
            else if (Usuarios_Logados == "Usuarios Logados")
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Usuario_Logado.Id_Logado, Usuario.Usuario ,Usuario_Logado.Data_Entrada,Usuario_Logado.Hora_Saida from Usuario_Logado inner join Usuario on Usuario_Logado.Id_Usuario=Usuario.Id_Usuario;", Cl_Conexao.Conexao);
            }
            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);
            return Verficador;
        }

        public Boolean Buscar_Todos_Funcionario()
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("select Funcionario.Nome from Funcionario", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            return Verficador;
        }

        public Boolean Buscar_Dados_Usuario(int Id_Usuario)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Funcionario , Usuario, Senha, Id_Acesso from Usuario where Id_Usuario=" + Id_Usuario, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Funcionario = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Funcionario"]);
                Nome = Cl_Conexao.Comando_Leitura["Usuario"].ToString();
                Senha = Cl_Conexao.Comando_Leitura["Senha"].ToString();
                Id_Acesso = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Acesso"]);
            }
            return Verficador;
        }

        public Boolean Buscar_Acesso(int Id_Acesso)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Acesso from Acesso where Id_acesso=" + Id_Acesso, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Acesso = Cl_Conexao.Comando_Leitura["Acesso"].ToString();
            }
            return Verficador;
        }
    }

    class Cl_Funcionario : Cl_Verficador
    {
        public int Id_Funcionario = 0, Id_Cargo = 0, Telefone = 0;
        public char Genero;
        public string Nome = string.Empty, BI = string.Empty, Cargo = string.Empty;

        public Boolean Mostar_Funcionarios(string Todos, char Masculino, char Femenino, string Pesquisar, string Nome)
        {
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();

            Cl_Conexao.Tabela.Clear();
            if (Todos == "Todos")
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Funcionario inner join Cargo on Funcionario.Id_Cargo= Cargo.Id_Cargo;", Cl_Conexao.Conexao);
            }
            else if (Masculino == 'M')
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Cargo inner join Funcionario on Cargo.Id_Cargo= Funcionario.Id_Cargo where Genero='" + Masculino + "';", Cl_Conexao.Conexao);
            }
            else if (Femenino == 'F')
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Cargo inner join Funcionario on Cargo.Id_Cargo= Funcionario.Id_Cargo where Genero='" + Femenino + "';", Cl_Conexao.Conexao);
            }
            else if (Pesquisar == "Pesquisar")
            {
                Cl_Conexao.Tabela.Clear();
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Funcionario.Id_Funcionario,Funcionario.Nome,Funcionario.Genero,Funcionario.BI,Cargo.Cargo,Cargo.Salario from Cargo inner join Funcionario on Cargo.Id_Cargo= Funcionario.Id_Cargo where Nome='" + Nome + "';", Cl_Conexao.Conexao);
            }
            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);

            return Verficador;
        }

        /*  Buscando O Id Do Funcionario  */
        public Boolean Buscar_Id_Funcionario(string Nome, bool Verf)
        {
            if (Verf == true)
            {
                Cl_Conexao.Conexao.Close();
                Cl_Conexao.Conexao.Open();
                Cl_Conexao.Comando = new MySqlCommand("Select Id_Funcionario From Funcionario where Nome ='" + Nome + "'", Cl_Conexao.Conexao);
                Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

                while (Cl_Conexao.Comando_Leitura.Read())
                {
                    Id_Funcionario = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Funcionario"]);
                }
            }

            return Verficador;
        }

        /*  Buscando O Id Do Cargo Do Funcionario */
        public void Buscar_Id_Cargo(string Cargo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Cargo from Cargo where Cargo='" + Cargo + "'", Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Cargo = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Cargo"]);
            }
        }

        /*  Buscando O Cargo Do Funcionario */
        public void Buscar_Cargo_Funcionario()
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Cargo from Cargo where Id_Cargo=" + Id_Cargo, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Cargo = Cl_Conexao.Comando_Leitura["Cargo"].ToString();
            }
        }

        /*  Buscando O Telefone Do Funcionario */
        public void Buscar_Telefone_Funcionario()
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Telefone from Telefone where Id_Funcionario=" + Id_Funcionario, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Telefone = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Telefone"]);
            }
        }

        public Boolean Buscar_Todos_Dados_Funcionario(bool Verf, int Id_Funcionario)
        {
            Cl_Conexao.Conexao.Close();
            Cl_Conexao.Conexao.Open();
            Cl_Conexao.Comando = new MySqlCommand("Select Nome , Genero , BI , Id_Cargo from Funcionario where Id_Funcionario=" + Id_Funcionario, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Nome = Cl_Conexao.Comando_Leitura["Nome"].ToString();
                Genero = Convert.ToChar(Cl_Conexao.Comando_Leitura["Genero"]);
                BI = Cl_Conexao.Comando_Leitura["Bi"].ToString();
                Id_Cargo = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Cargo"]);
            }

            return Verf;
        }

        public Boolean Buscar_Funcionario(int Id_Funcionario)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Nome from Funcionario where Id_Funcionario=" + Id_Funcionario, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            return Verficador;
        }
    }

    class Cl_Marca : Cl_Verficador
    {
        public int Id_Marca = 0;
        public string Marca = string.Empty;

        public Boolean Mostrar_Todos_Marcas(bool Verf, string Tabela, string Pesquisar, string Marca)
        {

            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();
            Cl_Conexao.Tabela.Clear();

            if (Verf == true)
            {
                if (Tabela == "Tabela")
                {
                    Cl_Conexao.Tabela.Clear();
                    Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("Select *from Marca", Cl_Conexao.Conexao);
                }
                else if (Pesquisar == "Pesquisar")
                {
                    Cl_Conexao.Tabela.Clear();
                    Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("Select *from Marca where Marca='" + Marca + "'", Cl_Conexao.Conexao);

                }
                Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);
            }


            return Verficador;
        }

        public Boolean Buscar_Marca(bool Verf, int Id_Marca)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Marca from Marca where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {

                Marca = Cl_Conexao.Comando_Leitura["Marca"].ToString();
            }

            return Verficador;
        }

        public Boolean Verficar_Marca(bool Verf, string Marca)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Marca from Marca where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Verficador = false;
            }

            return Verficador;
        }

        public Boolean Verficar_Id_Marca_Tabela_Modelo(int Id_Marcas)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Marca from Modelos where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Cl_Auxiliar.Aux_Verf_1 = true;
                Verficador = true;
            }


            return Verficador;
        }
    }

    class Cl_Modelo : Cl_Verficador
    {
        public int Id_Marca = 0, Id_Modelo;
        public string Modelo = string.Empty, Marca;

        public Boolean Mostrar_Dados_Modelo()
        {
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();

            Cl_Conexao.Conexao.Close();
            Cl_Conexao.Tabela.Clear();
            Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("Select Modelos.Id_Modelo,Marca.Marca,Modelos.Modelo from Marca inner join Modelos on Marca.Id_Marca=Modelos.Id_Marca;", Cl_Conexao.Conexao);
            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);

            return Verficador;
        }

        public Boolean Carregar_Marcas()
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Marca from Marca", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            return Verficador;
        }

        //public Boolean Verficar_Marca(string Marca)
        //{
        //    Conectar_Bd();
        //    Cl_Conexao.Comando = new MySqlCommand("Select Marca from Marca where Marca='" + Marca + "'", Cl_Conexao.Conexao);
        //    Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

        //    while (Cl_Conexao.Comando_Leitura.Read())
        //    {
        //        Cl_Auxiliar.Aux_Verf_1 = true;
        //    }
        //    return Verficador;
        //}

        public Boolean Verficar_Modelo(string Modelo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Modelo from Modelos where Modelo='" + Modelo + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Verficador = true;
            }
            return Verficador;
        }

        public Boolean Buscar_Id_Marca(bool Verf, string Marca)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Marca from Marca where Marca='" + Marca + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Marca = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Marca"]);
            }
            return Verficador;
        }

        public Boolean Buscar_dados_Para_Alterar(bool Verf)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Marca , Modelo from Modelos where Id_Modelo=" + Id_Modelo, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Marca = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Marca"]);
                Modelo = Cl_Conexao.Comando_Leitura["Modelo"].ToString();
            }
            return Verf;
        }

        public Boolean Buscar_Marca()
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Marca from Marca where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Marca = Cl_Conexao.Comando_Leitura["Marca"].ToString();
            }
            return Verficador;
        }
    }

    class Cl_Cargos : Cl_Verficador
    {
        public int Id_Cargo = 0;
        public string Cargo = string.Empty;
        public Boolean Buscar_Cargos()
        {
            Conectar_Bd();
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();
            Cl_Conexao.Tabela.Clear();
            Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("Select *from Cargo", Cl_Conexao.Conexao);

            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);
            return Verficador;
        }

        public Boolean Verficar_cargo(bool Verf, string Cargo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Cargo from Cargo where Cargo='" + Cargo + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Verficador = true;
            }
            return Verf;
        }

        public Boolean Verficar_cargo(bool Verf, int Id_Cargo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Cargo , Salario from Cargo where Id_Cargo=" + Id_Cargo, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            return Verf;
        }
    }

    class Cl_Carro : Cl_Verficador
    {
        public int Id_Marca = 0, Id_Cor = 0, Id_Estado = 0, Id_Modelo = 0, Id_Carro, Id_Usuario_Logado;

        public string N_serie, Tamanho_Pneu, Data,Estado;
        public Decimal Preco;

        public Boolean Buscar_Modelos(bool Verf)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select *from Modelos", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            return Verf;
        }

        public Boolean Buscar_Cor(bool Verf)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Cor from Cor", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            return Verf;
        }

        public Boolean Buscar_Id_Cor(bool Verf, string Cor)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Cor from Cor where Cor='" + Cor + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Cor = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Cor"]);
            }

            return Verf;
        }

        public Boolean Buscar_Id_Marca_No_Modelo(bool Verf, string Modelo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Marca,Id_Modelo from Modelos where Modelo='" + Modelo + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Marca = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Marca"]);
                Id_Modelo = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Modelo"]);
            }

            return Verf;
        }

        public Boolean Buscar_Marca(bool Verf, int Id_Marca)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Marca from Marca where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            return Verf;
        }

        public Boolean Buscar_Id_Estado(bool Verf, string Estado)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_estado from Estados where Estado='" + Estado + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Estado = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Estado"]);
            }

            return Verf;
        }

        public Boolean Mostrar_Dados_Carro(bool Verf)
        {
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();

            Cl_Conexao.Tabela.Clear();

            Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Carro.Id_carro, Usuario.Usuario ,Marca.Marca,Modelos.Modelo,Cor.Cor,Carro.N_serie,Carro.Tamanho_Pneu ,Carro.Data_De_Fabrico, Carro.Preco,Estados.Estado from Cor inner join (Marca inner join ( Modelos inner join Carro on Modelos.Id_Modelo=carro.Id_Modelo) on Marca.Id_Marca=Modelos.Id_Marca inner join Usuario on (Usuario.Id_Usuario=Carro.Id_Usuario_Logado) inner join Estados on Estados.Id_Estado=Carro.Id_Estado) on Cor.Id_Cor=Carro.Id_Cor; ", Cl_Conexao.Conexao);
            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);


            return Verf;
        }

        public Boolean Buscar_Todos_Dados(int Id_Carro)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Select Id_Cor , Id_Usuario_Logado , Id_Modelo , Id_Estado , N_Serie , Tamanho_Pneu , Data_De_Fabrico , Preco from Carro where Id_Carro=" + Id_Carro, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();


            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Cor = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Cor"]);
                Id_Usuario_Logado = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Usuario_Logado"]);
                Id_Modelo = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Modelo"]);
                Id_Estado = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Estado"]);
                N_serie = Cl_Conexao.Comando_Leitura["N_Serie"].ToString();
                Tamanho_Pneu = Cl_Conexao.Comando_Leitura["Tamanho_Pneu"].ToString();
                Data = Cl_Conexao.Comando_Leitura["Data_De_Fabrico"].ToString();
                Preco = Convert.ToDecimal(Cl_Conexao.Comando_Leitura["Preco"]);
            }

            return Verficador;
        }

        public string Cor, Modelo;

        public Boolean Buscar_Outros()
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Select Cor from Cor where id_Cor=" + Id_Cor, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();


            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Cor = Cl_Conexao.Comando_Leitura["Cor"].ToString();
            }

            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Select Modelo from Modelos where Id_Modelo=" + Id_Modelo, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();


            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Modelo = Cl_Conexao.Comando_Leitura["Modelo"].ToString();
            }


            return Verficador;
        }

        public Boolean Verficar_N_seri_Existente(string N_serie)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select N_serie from Carro where N_Serie='" + N_serie + "'", Cl_Conexao.Conexao);
            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Cl_Auxiliar.Aux_Verf_1 = true;
            }
            return Verficador;
        }

        public Boolean Trazer_Pesquisa(string Pesquisa, string OP)
        {
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();

            Cl_Conexao.Tabela.Clear();

            if (OP == "Vendido" || OP == "Disponivel")
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado where Estados.Estado='" + Pesquisa + "'; ", Cl_Conexao.Conexao);
            }
            else if (OP == "Marca")
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado where Marca.Marca ='" + Pesquisa + "'; ", Cl_Conexao.Conexao);
            }
            else if (OP == "Modelos")
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Marca.Marca,Modelos.Modelo,Carro.N_Serie,Cor.Cor,Carro.Tamanho_Pneu,Carro.Data_De_Fabrico,Carro.Preco,Estados.Estado from Carro inner join  Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_Cor=Cor.Id_Cor inner join Estados on Carro.Id_Estado=Estados.Id_Estado where Modelos.Modelo='" + Pesquisa + "'; ", Cl_Conexao.Conexao);
            }
            else if (OP == "So Modelos")
            {
                Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Modelos.Modelo from Modelos;", Cl_Conexao.Conexao);
            }



            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);
            return Verficador;
        }
    }

    class Cl_Vendas : Cl_Verficador
    {
        public int Id_Marca = 0, Id_Cor = 0, Id_Estado = 0, Id_Modelo = 0, Id_Carro, Id_Usuario_Logado, Id_Venda = 0;
        public string Cor, Modelo, N_serie, Tamanho_Pneu, Data, Estado;
        public double Preco;

        public Boolean Buscar_Marca(bool Verf, int Id_Marca)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Marca from Marca where Id_Marca=" + Id_Marca, Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();
            return Verf;
        }

        public Boolean Buscar_Id_Marca_No_Modelo(bool Verf, string Modelo)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Marca,Id_Modelo from Modelos where Modelo='" + Modelo + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Marca = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Marca"]);
                Id_Modelo = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Modelo"]);
            }

            return Verf;
        }

        public Boolean Mostrar_Dados_Carro(bool Verf)
        {
            Conectar_Bd();
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();

            Cl_Conexao.Tabela.Clear();

            Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("select Carro.Id_carro ,Marca.Marca,Modelos.Modelo,Cor.Cor,Carro.N_serie,Carro.Tamanho_Pneu ,Carro.Data_De_Fabrico, Carro.Preco,Estados.Estado from Cor inner join (Marca inner join ( Modelos inner join Carro on Modelos.Id_Modelo=carro.Id_Modelo) on Marca.Id_Marca=Modelos.Id_Marca  inner join Estados on Estados.Id_Estado=Carro.Id_Estado) on Cor.Id_Cor=Carro.Id_Cor where Estados.Estado='Disponível'; ", Cl_Conexao.Conexao);
            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);
            return Verf;
        }

        public Boolean Buscar_Todos_Dados(int Id_Carro)
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Select Id_Cor , Id_Usuario_Logado , Id_Modelo , Id_Estado , N_Serie , Tamanho_Pneu , Data_De_Fabrico , Preco from Carro where Id_Carro=" + Id_Carro, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();


            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Cor = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Cor"]);
                Id_Usuario_Logado = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Usuario_Logado"]);
                Id_Modelo = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Modelo"]);
                Id_Estado = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Estado"]);
                N_serie = Cl_Conexao.Comando_Leitura["N_Serie"].ToString();
                Tamanho_Pneu = Cl_Conexao.Comando_Leitura["Tamanho_Pneu"].ToString();
                Data = Cl_Conexao.Comando_Leitura["Data_De_Fabrico"].ToString();
                Preco = Convert.ToDouble(Cl_Conexao.Comando_Leitura["Preco"]);
            }

            return Verficador;
        }

        public Boolean Buscar_Outros()
        {
            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Select Cor from Cor where id_Cor=" + Id_Cor, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();


            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Cor = Cl_Conexao.Comando_Leitura["Cor"].ToString();
            }

            Conectar_Bd();

            Cl_Conexao.Comando = new MySqlCommand("Select Modelo from Modelos where Id_Modelo=" + Id_Modelo, Cl_Conexao.Conexao);

            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();


            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Modelo = Cl_Conexao.Comando_Leitura["Modelo"].ToString();
            }


            return Verficador;
        }

        public Boolean Visualizar_Vendas(bool Verf)
        {
            Cl_Conexao.Adaptador = new MySqlDataAdapter();
            Cl_Conexao.Tabela = new System.Data.DataTable();

            Cl_Conexao.Tabela.Clear();

            Cl_Conexao.Adaptador.SelectCommand = new MySqlCommand("Select Vendas.Id_Venda, Usuario.Usuario,Clientes.nome,Marca.Marca,Modelos.Modelo,Carro.N_serie,Cor.Cor , Vendas.Valor_A_Pagar,Vendas.Troco,Vendas.Data_Venda  from Vendas inner join Usuario_Logado on Vendas.Id_Usuario_Logado = Usuario_Logado.Id_Logado inner Join Usuario on Usuario_Logado.Id_Usuario=Usuario.Id_Usuario inner join Clientes on Vendas.Id_Cliente=Clientes.Id_Cliente inner join Carro on Vendas.Id_Carro=Carro.Id_Carro inner join Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_cor=Cor.Id_Cor;", Cl_Conexao.Conexao);

            Cl_Conexao.Adaptador.Fill(Cl_Conexao.Tabela);
            return Verf;
        }

        public Boolean Factuar(int Id_Venda)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("select Clientes.nome,Marca.Marca,Modelos.Modelo,Carro.N_serie,cor.cor,Carro.Tamanho_Pneu,Carro.Preco from Vendas  inner join Carro on Vendas.Id_Carro=Carro.Id_Carro inner join Modelos on Carro.Id_Modelo=Modelos.Id_Modelo inner join Marca on Modelos.Id_Marca=Marca.Id_Marca inner join Cor on Carro.Id_cor=Cor.Id_Cor inner join Clientes on Vendas.Id_Cliente=Clientes.Id_cliente where Vendas.Id_Venda=" + Id_Venda + ";", Cl_Conexao.Conexao);
         
            return Verficador;
        }
    }

    class Cl_Clientes : Cl_Verficador
    {
        public int Id_Cliente = 0;
        public Boolean Buscar_Id_Cliente(string Nome_Cliente)
        {
            Conectar_Bd();
            Cl_Conexao.Comando = new MySqlCommand("Select Id_Cliente from Clientes where Nome='" + Nome_Cliente + "'", Cl_Conexao.Conexao);
            Cl_Conexao.Comando_Leitura = Cl_Conexao.Comando.ExecuteReader();

            while (Cl_Conexao.Comando_Leitura.Read())
            {
                Id_Cliente = Convert.ToInt32(Cl_Conexao.Comando_Leitura["Id_Cliente"]);
            }

            return Verficador;
        }
    }
}
