using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace ManuelBelgrano.DataAccess
{
    internal class ConnectionHandler
    {
        private readonly string _connectionString;//los campos de solo lectura(readonly) sólo pueden asignarse en el constructor de la clase
        private SqlConnection _connection = null;
        private System.Data.OleDb.OleDbConnection _connectionOledb = null; 
        /// <summary>
        /// Constructor de la clase (new)
        /// </summary>
        public ConnectionHandler()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
        }

        /// <summary>
        /// Retorna una instancia de la conexión abierta
        /// </summary>
        /// <returns></returns>
        public SqlConnection GetOpenConnection()
        {
            //verifico si la conexion existe:
            if (_connection == null)
            {
                _connection = new SqlConnection(_connectionString);
            }
            //verifico el estado de la conexión
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
            return _connection;
        }

        /// <summary>
        /// Cierra la conexión activa
        /// </summary>
        public void CloseConnection()
        {
            if (_connection != null)
            {
                _connection.Close();
            }
        }

        public SqlCommand GetCommand()
        {
            return new SqlCommand();
        }
        public SqlCommand GetCommand(string query)
        {
            return new SqlCommand(query, GetOpenConnection());
        }

        public SqlDataAdapter GetDataAdpter()
        {
            return new SqlDataAdapter();
        }

        public SqlDataAdapter GetDataAdpter(string query)
        {
            var cmd = GetCommand(query);
            return new SqlDataAdapter(cmd);
        }


    }
}
