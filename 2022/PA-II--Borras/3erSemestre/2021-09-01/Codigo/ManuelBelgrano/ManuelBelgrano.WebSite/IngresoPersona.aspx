<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    public void Page_Load(object sender, EventArgs e)
    {
        if (HttpContext.Current.Request.HttpMethod == "POST")
        {
            var nombre = HttpContext.Current.Request.Form["Nombre"];
            var edad = HttpContext.Current.Request.Form["Edad"];
            var repo = new ManuelBelgrano.DataAccess.PersonaRepository();
            var persona = new ManuelBelgrano.Entities.Persona(nombre, Convert.ToInt32(edad));

            repo.UpdateRecord(persona);
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
    <form id="form1" runat="server">
        <div>
            <label for="Nombre">Nombre:</label>
            <input type="text" id="Nombre" name="Nombre" />
        </div>
        <div>
            <label for="Edad">Edad:</label>
            <input type="number" id="Edad" name="Edad" min="1" max="150" />
        </div>
        <div>
            <input type="submit" />
        </div>
    </form>
</body>
</html>
