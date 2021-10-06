<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    string nombre = "";
    string edad = "15";
    bool aceptaTyC = false;
    
    private bool Validar(string nombre, string edad, bool aceptaTyC)
    {
        var pasoValidacion = true;
        if (string.IsNullOrWhiteSpace(nombre) == true) {
            pasoValidacion = false;
        }
        if (string.IsNullOrWhiteSpace(edad) == true) {
            pasoValidacion = false;
        }

        if (aceptaTyC == false) {
            pasoValidacion = false;
        }
        return pasoValidacion;
    }

    public void Page_Load(object sender, EventArgs e)
    {
        
        if (HttpContext.Current.Request.HttpMethod == "POST")
        {
            nombre = HttpContext.Current.Request.Form["Nombre"];
            edad = HttpContext.Current.Request.Form["Edad"];
            aceptaTyC = Convert.ToBoolean(Request.Form["AceptaTyC"]);
            var isValid = Validar(nombre, edad, aceptaTyC);
            if (isValid == false) {
                HttpContext.Current.Response.Redirect("ErrorPage.html");
            }
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

    <script type="text/javascript">
        function validar() {

            var pasoLaValidacion = true;

            var nombre = $("#Nombre").val();
            if (nombre == "") {
                $("#alertaNombre").show();
                pasoLaValidacion = false;
            }
            else {
                $("#alertaNombre").hide();
            }

            var edad = $("#Edad").val();
            if (edad == "") {
                $("#alertaEdad").show();
                pasoLaValidacion = false;
            }
            else {
                $("#alertaEdad").hide();
            }

            var aceptaTyC = $("#AceptaTyC").is(":checked");
            if (aceptaTyC == false) {
                $("#alertaAceptaTyC").show();
                pasoLaValidacion = false;
            }
            else {
                $("#alertaAceptaTyC").hide();
            }


            return pasoLaValidacion;
            //agregar la validación para el campo Edad
        }

        function enviarFormulario() {
            if (validar() == true) {
                $("#form1").submit();
            }
        }

        var inicializar = function () {
            $("#alertaNombre").hide();
            $("#alertaEdad").hide();
            $("#alertaAceptaTyC").hide();
        }

        $(document).ready(inicializar);

    </script>
</head>
<body>
    <form id="form1" method="post">
        <!--borrar atributo run at="server"-->
        <div>
            <div class="titulo">
                <h1>Cargar Datos de una Persona</h1>
            </div>

            <div class="row">
                <div class="col-6">
                    <label for="Nombre">Nombre:</label>
                    <input type="text" id="Nombre" name="Nombre" value="<%= nombre %>" />
                    <span class="alert-danger" id="alertaNombre">* Este Campo es Obligatorio</span>
                </div>
                <div class="col-6">
                    <label for="Edad">Edad:</label>
                    <input type="number" id="Edad" name="Edad" min="1" max="150" value="<%= edad %>" />
                    <span class="alert-danger" id="alertaEdad">* Este Campo es Obligatorio</span>
                </div>
            </div>
        </div>
        <input type="checkbox" value="true" id="AceptaTyC" name="AceptaTyC" /><label for="AceptaTyC">Acepto Términos y Condiciones </label>
        <span class="alert-danger" id="alertaAceptaTyC">* Este Campo es Obligatorio</span>
        <div class="row">
            <div class="col-12 align-content-center">
                <input type="button" value="Enviar" onclick="enviarFormulario()" />
            </div>
        </div>

        <div class="row">
            <div class="col-12">
               <a href="Listado.aspx">Ver listado</a> 
            </div>
        </div>
    </form>
</body>
</html>

