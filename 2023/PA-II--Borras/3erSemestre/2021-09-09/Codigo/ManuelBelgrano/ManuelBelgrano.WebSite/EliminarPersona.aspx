<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    public void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.HttpMethod == "POST")
        {
            var nombre = HttpContext.Current.Request.Form["Nombre"];
            var edad = HttpContext.Current.Request.Form["Edad"];
            var id = HttpContext.Current.Request.Form["id"];
            var repo = new ManuelBelgrano.DataAccess.PersonaRepository();
            var persona = new ManuelBelgrano.Entities.Persona(nombre, Convert.ToInt32(edad), Convert.ToInt32(id));
            repo.Delete(persona);
            Response.Redirect("Listado.aspx");
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server" onsubmit="return  window.confirm('Confirma eliminar?');">
        <input type="hidden" name="Id" value="<%= Request.QueryString["Id"] %>" />
        <div>
            <label for="Nombre">Nombre:</label>
            <input disabled="disabled" type="text" id="Nombre" name="Nombre" value="<%= Request.QueryString["Nombre"] %>" />
        </div>
        <div>
            <label for="Edad">Edad:</label>
            <input disabled="disabled" type="number" id="Edad" name="Edad" min="1" max="150" value="<%= Request.QueryString["Edad"] %>" />
        </div>
        <div>
            <input type="submit"  />
        </div>
    </form>
</body>
</html>
