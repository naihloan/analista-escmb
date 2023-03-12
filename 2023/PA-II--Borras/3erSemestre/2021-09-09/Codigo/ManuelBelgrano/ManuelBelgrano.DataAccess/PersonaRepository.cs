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
         
        public List<Persona> GetByNombre(string filtro)
        {
            List<Persona> personas = GetAllRecords();
            List<Persona> personasFiltradas = new List<Persona>();
            
            personasFiltradas = personas.Where(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) ).ToList();           
            return personasFiltradas.OrderBy(p => p.Nombre).ThenByDescending(p => p.Edad).ThenBy(z => z.Id).ToList();
        }

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
        public List<Persona> GetAllRecords()
        {
            var cnnHandler = new ConnectionHandler();//Handler
            try
            {
                var query = $"select * from Persona";
                //seteo el data adapter
                var da = cnnHandler.GetDataAdpter(query);
                var dataTable = new DataTable();
                var dataSet = new DataSet();
                da.Fill(dataSet);
                dataTable = dataSet.Tables[0];

                var listado = new List<Persona>();

                if (dataTable != null && dataTable.Rows.Count > 0)
                {
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        var nombre = dataTable.Rows[i]["Nombre"] as string;
                        int edad = Convert.ToInt32(dataTable.Rows[i]["Edad"]);
                        var id = Convert.ToInt32(dataTable.Rows[i]["Id"]);
                        var persona = new Persona(nombre, edad, id);
                        listado.Add(persona);
                    }

                }

                return listado;
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
        public void Delete(Persona persona)
        {
            var cnnHandler = new ConnectionHandler();//Handler
            try
            {
                var query = $"Delete from Persona";
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
        }
        public Persona UpdateRecord(Persona persona)
        {
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
