using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projecto_NH_CARS
{
    public static class Cl_Conexao
    {
        public static MySqlConnection Conexao = new MySqlConnection(@"server=localhost;user id=root;database=nh_cars");
        public static MySqlDataAdapter Adaptador;
        public static DataTable Tabela;
        public static MySqlCommand Comando;
        public static MySqlDataReader Comando_Leitura;



    }
}
