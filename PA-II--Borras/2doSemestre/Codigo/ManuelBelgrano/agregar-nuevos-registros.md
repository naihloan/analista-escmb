public void AddNewRecord(string nombre, int edad)
        {
            var cnnHandler = new ConnectionHandler();//Handler
            try
            {
                var query = $"Insert into Persona (nombre, edad) values ('{nombre}',{edad})";
                var cmd = cnnHandler.GetCommand();
                cmd.CommandText = query;
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
