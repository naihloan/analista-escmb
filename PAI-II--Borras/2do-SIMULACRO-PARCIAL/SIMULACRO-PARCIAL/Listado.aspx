<%@ Page Language="C#" %>

<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>

<!DOCTYPE html>

<script runat="server">
    public DataTable GetTable()
    {

        var cadena = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        var conexion = new SqlConnection(cadena);

        conexion.Open();

        var command = new SqlCommand();
        command.Connection = conexion;
        command.CommandType = CommandType.Text;
        command.CommandText = "select * from Persona";


        var adapter = new SqlDataAdapter();
        adapter.SelectCommand = command;

        var tablaDatos = new DataTable();


        adapter.Fill(tablaDatos);

        conexion.Close();

        return tablaDatos;
             
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
                <td><%=tablaDatos.Rows[i]["Edad"] %> </td>
                <td><%=tablaDatos.Rows[i]["Nombre"] %> </td>
            </tr>
            <%}%>
        </table>
            </center>
        </div>
  

    </form>
</body>
</html>
