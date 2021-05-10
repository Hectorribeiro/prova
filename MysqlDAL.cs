using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

    namespace VirtualShop
{
    public class MysqlDAL
    {
        private static string server = "localhost";
        private static string database = "VirtualShop";
        private static string user = "root";
        private static string password = "";


       private string connection = "SERVER" + server + "; DATABASE = " + database + "; UID = "+ user + "; PWD = "+ password;

        public MySqlConnection conexao;


        //method for open "conexao"

        public void Conectar()
        {
            try
            {
                conexao = new MySqlConnection(stringConexao);
                conexao.Open();
            }
            catch (Exception  e )
            {
                throw new Exception("Was not possible conect to database. Error:" + e.Message); 
            }

        //Method without return

            public void ExecuteSql()
            {
                try
                {
                    MySqlCommand comand = new MySqlCommand(sql, conexao);
                    comand.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    throw new Exception("Was not possible execute the instruct on database. Error:"+ e.Message);
                }
                finally
                {
                    conexao.Close();
                }

            }

            //method with return

            public DataTable ExecuteConsulta(String sql)
            {
                try
                {
                    Conectar();
                    DataTable dt = new DataTable();
                    MySaqlDataAdapter dados = new MySaqlDataAdapter(sql, conexao);
                    dados.Fill(dt);
                    return dt;
                }
                catch (Exception e)
                {
                    throw new Exception("Was not possible execute the database. Error:"+ e.Message);
                }
                finally
                {
                    conexao.Close();
                }
            }





        }





    }

    
} 