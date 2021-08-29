<%@ Page Language="C#" %>
<%@ Import Namespace="System.Data" %>
<%@ Import Namespace="System.Data.SqlClient" %>
<%@ Import Namespace="System.Configuration" %>

<!DOCTYPE html>

<script runat="server">

    public DataTable GetTable(){

        var cadena = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;// guarda los valores de connection string donde se va a conectar
        var conexion =new SqlConnection(cadena);//abre la comunicacion esntre mi programa y la base de datos
        var estado = conexion.State;
        conexion.Open();

        var command= new SqlCommand();//cmd es por "comando" cmd heresa de la clase SqlCommand pare trabajar los comando queusaremos
        command.Connection = conexion;
        command.CommandType = CommandType.Text;
        command.CommandText = "Select* from Persona";

        var adapter = new SqlDataAdapter();
        adapter.SelectCommand = command;

        var tablaDatos = new DataTable();

        //mediante la instruccion fiil se llena el objeto con los datos obtenidos por la ejecucon del select
        adapter.Fill(tablaDatos);


        conexion.Close();
        return tablaDatos;
    }

   
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>


<body>
    <form id="form1" runat="server">
        <div>
            <table border="1">
                <tr>
                    <th>Nombre</th>
                    <th>Edad</th>
                 </tr>
                <%
                    var tablaDatos = GetTable();
                    var cantidadDeFilas = tablaDatos.Rows.Count;
                    for (int i = 0; i < cantidadDeFilas; i++)
                    {
                %>
                <tr>
                    <td><%= tablaDatos.Rows[i]["Nombre"]%></td>
                    <td><%= tablaDatos.Rows[i]["Edad"] %></td>
                </tr>
    
                    <%} %>
            </table>

       </div>
    </form>
</body>
</html>
