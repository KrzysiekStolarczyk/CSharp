using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektNaZaliczenie
{
    public partial class ConnectingString
    {
        public SqlConnection connect;
        public ConnectingString localDbConnection;

        public ConnectingString()
        {

            init();
        }

        public void init()
        {
            localDbConnection = new ConnectingString("31.41.178.89", "DotNet", "DotNet", "12345");
        }

        public ConnectingString(string instance, string dbdir, string user, string password)
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=" + instance + ";" + "Trusted_Connection = no;" + "Initial Catalog=" + dbdir + ";" + "connection timeout = 3;Integrated Security=false; user id=" + user + ";password=" + password;
        }

        public DataTable ExecuteSqlQuery(string query)
        {
            connect.Open();
            DataTable dataTable = new DataTable();
            SqlDataReader rader;

            SqlCommand cmd = new SqlCommand(query);
            cmd.Connection = connect;
            rader = cmd.ExecuteReader();
            dataTable.Load(rader);
            connect.Close();
            return dataTable;
        }

        public DataTable ExecuteQueryWithParametersStok(string procedureName, Stack<string> nazwaZmiennej, Stack<SqlDbType> typ, Stack<string> value)
        {

            {
                SqlCommand cmd = connect.CreateCommand();
                cmd.CommandText = procedureName;
                cmd.CommandType = CommandType.StoredProcedure;
                while (nazwaZmiennej.Count > 0)
                {
                    cmd.Parameters.Add(nazwaZmiennej.Pop(), typ.Pop()).Value = value.Pop();
                }

                DataTable dataTable = new DataTable();
                SqlDataReader rader;
                connect.Open();
                rader = cmd.ExecuteReader();
                dataTable.Load(rader);
                connect.Close();

                return dataTable;
            }
        }

        public int ExecuteQueryWithParametersStokScalar(string procedureName, Stack<string> nazwaZmiennej, Stack<SqlDbType> typ, Stack<string> value)
        {
            SqlCommand cmd = connect.CreateCommand();
            cmd.CommandText = procedureName;
            cmd.CommandType = CommandType.StoredProcedure;
            while (nazwaZmiennej.Count > 0)
            {
                cmd.Parameters.Add(nazwaZmiennej.Pop(), typ.Pop()).Value = value.Pop();
            }
            connect.Open();

            int ret = (int)cmd.ExecuteScalar();
            connect.Close();
            return ret;
        }

    }
}


