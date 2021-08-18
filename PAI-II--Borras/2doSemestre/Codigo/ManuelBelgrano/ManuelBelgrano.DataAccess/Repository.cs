using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ManuelBelgrano.DataAccess
{
    public class Repository
    {
        public DataTable GetAllRecords(string tableName)
        {
            var cnnHandler = new ConnectionHandler();//Handler
            try
            {
                var query = $"select * from {tableName}";
                //seteo el data adapter
                var da = cnnHandler.GetDataAdpter(query);
                var dataTable = new DataTable();
                da.Fill(dataTable);

                return dataTable;
            }
            catch
            {
                throw;
            }
            finally
            {
                cnnHandler.CloseConnection();
            }


        }
    }
}
