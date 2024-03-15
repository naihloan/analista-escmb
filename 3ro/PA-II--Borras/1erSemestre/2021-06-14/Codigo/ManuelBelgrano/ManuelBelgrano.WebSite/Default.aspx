<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    string nombre = "";
    string edad = "15";
    public void Page_Load(object sender, EventArgs e) {
        if (IsPostBack) {
            nombre = Request.Form["Nombre"];
            edad = Request.Form["Edad"];
        }
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"
        integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous" />
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js" integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js" integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js" integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>

    <link href="css/ManuelBelgranoSite.css" rel="stylesheet" />
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Datos</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="titulo">
                <h1>Cargar Datos de una Persona</h1>
            </div>

            <div class="row">
                <div class="col-6">
                    <label for="Nombre">Nombre:</label>
                    <input type="text" id="Nombre" name="Nombre" value="<%= nombre %>" />
                    <span class="letrasRojas" id="alertaNombre" style="display: none">
                        * Este Campo es Obligatorio</span>
                </div>
                <div class="col-6">
                    <label for="Edad">Edad:</label>
                    <input type="number" id="Edad" name="Edad" min="1" max="150" value="<%= edad %>" />
                    <span class="letrasRojas" id="alertaEdad" style="display: none">
                        * Este Campo es Obligatorio</span>
                </div>
            </div> 
        </div>
        <div class="row">
            <div class="col-12 align-content-center">
                <input type="submit" />
            </div>
        </div>
    </form>
</body>
</html>

