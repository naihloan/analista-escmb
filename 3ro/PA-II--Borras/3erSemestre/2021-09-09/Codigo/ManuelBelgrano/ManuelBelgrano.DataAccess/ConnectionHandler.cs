using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace ManuelBelgrano.DataAccess
{
    internal class ConnectionHandler
    {
        private readonly string _connectionString;//los campos de solo lectura(readonly) sólo pueden asignarse en el constructor de la clase
        private IDbConnection _connection = null;
        
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
        public IDbConnection GetOpenConnection()
        {
            //verifico si la conexion existe:
            if (_connection == null)
            {
                _connection = new OleDbConnection(_connectionString);
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

        public IDbCommand GetCommand()
        {
            var cnn = GetOpenConnection();//obtengo la conexión actual
            var cmd = cnn.CreateCommand();//invoco al método CreateCommand definido en IDbConnection
            return cmd;
        }
        public IDbCommand GetCommand(string query)
        {
            var cmd = GetCommand();//obtengo el comando
            cmd.CommandText = query;//le asigno la query
            return cmd;//retorno el objecto IDbCommand            
        }

        public IDbDataAdapter GetDataAdpter()
        {
            IDbDataAdapter dbDataAdapter;
            var cnn = GetOpenConnection();//obtengo la conexión actual
            Type connectionDataType = cnn.GetType();
            switch (connectionDataType.Name)
            {
                case "SqlConnection":
                    dbDataAdapter = new SqlDataAdapter();//le asigno el adaptador correspondiente
                    break;
                case "OleDbConnection":
                    dbDataAdapter = new OleDbDataAdapter();
                    break;
                default:
                    throw new Exception("Conexion desconocida");                    
            }
            return dbDataAdapter;
        }

        public IDbDataAdapter GetDataAdpter(string query)
        {
            var cmd = GetCommand(query);//obtengo el comando             
            var dataAdapter = GetDataAdpter();//obtengo el data adapter
            dataAdapter.SelectCommand = cmd;//le asingo el comando correspondienta
            return dataAdapter;
        }


    }
}
