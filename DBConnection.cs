using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Data;

namespace MarketManager
{
    public class DBConnection
    {
        SqlConnection conn = new SqlConnection();
        private SqlConnection GetConnectionOpen()
        {
            string connString = @"Data Source=DESKTOP-HNGR6PQ\SQLEXPRESS;Initial Catalog=SUPERMARKET_V_02;Integrated Security=True;";
            SqlConnection conn = new SqlConnection(connString);
            OpenConn(conn);
            return conn;
        }
        private void OpenConn(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            else
            {
                conn.Close();
                OpenConn(conn);
            }
        }

        public DataTable DoQuerySelect(string qry)
        {
            SqlConnection conn = GetConnectionOpen();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = qry;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            conn.Close();

            return dt;
        }

        public void ExecuteNonQuery(string qry)
        {
            int esito;
            DataTable dt = new DataTable();

            SqlConnection conn = GetConnectionOpen();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = qry;

            esito = cmd.ExecuteNonQuery();
            conn.Close();
        }


    }
}