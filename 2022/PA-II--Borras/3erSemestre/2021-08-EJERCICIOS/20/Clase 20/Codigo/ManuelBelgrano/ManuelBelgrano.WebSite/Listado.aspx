<%@ Page Language="C#" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Configuration" %>
<!DOCTYPE html>

<script runat="server">

    public DataTable GetTable()
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
                        var tablaDatos = GetTable();
                        var cantidadDeFilas = tablaDatos.Rows.Count;
                        for (int i = 0; i < cantidadDeFilas; i++)
                        {
                    %>
                    <tr>
                        <td>
                            <a href="ActualizarPersona.aspx?id=<%= tablaDatos.Rows[i]["Id"] %>&Nombre=<%= tablaDatos.Rows[i]["Nombre"] %>&Edad=<%= tablaDatos.Rows[i]["Edad"] %>">Actualizar</a>
                        </td>
                        <td><%= tablaDatos.Rows[i]["Edad"] %></td>
                        <td><%= tablaDatos.Rows[i]["Nombre"] %></td>
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
