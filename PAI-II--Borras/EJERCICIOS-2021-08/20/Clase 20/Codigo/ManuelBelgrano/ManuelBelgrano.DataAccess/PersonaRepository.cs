using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ManuelBelgrano.Entities;
namespace ManuelBelgrano.DataAccess
{
    public class PersonaRepository
    {
        public void AddNewRecord(Persona persona)
        {
            var cnnHandler = new ConnectionHandler();//Handler
            try
            {
                var query = $"Insert into Persona (nombre, edad) values ('{persona.Nombre}',{persona.Edad})";
                var cmd = cnnHandler.GetCommand(query);
                cmd.ExecuteNonQuery();
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
        public DataTable GetAllRecords()
        {
            var cnnHandler = new ConnectionHandler();//Handler
            try
            {
                var query = $"select * from Persona";
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

        public Persona UpdateRecord(Persona persona) {
            var cnnHandler = new ConnectionHandler();//Handler
            try
            {
                var query = $"Update Persona set ";
                query += $" Nombre = '{persona.Nombre}' ";
                query += $" ,Edad = {persona.Edad} ";
                query += $" Where ";
                query += $" Id = {persona.Id}";
                var cmd = cnnHandler.GetCommand(query);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                cnnHandler.CloseConnection();
            }
            return persona;
        }
    }
}
