﻿using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace projetomvc3b115.DAL
{
    public class DALMVC
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info = false; " +
                                        "server = localhost; " +
                                        "database = projetomvcb09; " +
                                        "user = root ; pwd=;";
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas ao conectar com o banco de dados. \nErro: " + e.Message);
            }

        }

        public DataTable executarConsulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conexao);
                dados.Fill(dt);
                return dt;
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel selecionar os registros no Banco de Dados. \nErro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        public void executarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possivel executar o comando no Banco de Dados. \nErro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

    }
}
