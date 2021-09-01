<%@ Page Language="C#" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Configuration" %>
<%@ Import Namespace="ManuelBelgrano.Entities" %>
<!DOCTYPE html>

<script runat="server">

    public List<Persona> GetTable()
    {
        var repo = new ManuelBelgrano.DataAccess.PersonaRepository();
        return repo.GetAllRecords();
    }


    public void Page_Load(object sender, EventArgs e)
    {



    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <center>
                <table border="1" style="width: 800px">
                    <tr>
                        <th>Acciones</th>
                        <th>Edad</th>
                        <th>Nombre</th>
                    </tr>
                    <% 
                        var listadoPersonas = GetTable();
                        
                        for (int i = 0; i < listadoPersonas.Count; i++)
                        {
                    %>
                    <tr>
                        <td>
 <a href="ActualizarPersona.aspx?id=<%= listadoPersonas[i].Id %>&Nombre=<%= listadoPersonas[i].Nombre %>&Edad=<%= listadoPersonas[i].Edad %>">Actualizar</a>
 %nbsp;
 <a href="EliminarPersona.aspx?id=<%= listadoPersonas[i].Id %>&Nombre=<%= listadoPersonas[i].Nombre %>&Edad=<%= listadoPersonas[i].Edad %>">Eliminar</a>
                        </td>
                        <td><%= listadoPersonas[i].Edad %></td>
                        <td><%= listadoPersonas[i].Nombre %></td>
                    </tr>
                    <% 
                        }//cierra la llave del for 
                    %>
                </table>
            </center>
        </div>
    </form>
    <center>
        <a href="IngresoPersona.aspx">Cargar Persona</a>
    </center>
</body>
</html>
