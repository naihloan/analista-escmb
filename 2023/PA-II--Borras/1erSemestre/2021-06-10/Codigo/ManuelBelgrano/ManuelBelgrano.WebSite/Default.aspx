<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <script src="https://code.jquery.com/jquery-3.2.1.slim.min.js%22 integrity="sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js%22 integrity="sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q" crossorigin="anonymous"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js%22 integrity="sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl" crossorigin="anonymous"></script>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css%22
    integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    </form>
    <div>
        <div class="titulo">
            <h1>Cargar Datos de una Persona</h1>
        </div>
        <div>
            <label for="Nombre">Nombre:</label>
            <input type="text" id="Nombre" name="Nombre" />
            <span class="letrasRojas" id="alertaNombre" style="display: none">* Este Campo es Obligatorio</span>
        </div>
        <div></div>
        <div>
            <label for="Edad">Edad:</label>
            <input type="number" id="Edad" min="1" max="150" />
            <span class="letrasRojas" id="alertaEdad" style="display: none">* Este Campo es Obligatorio</span>
        </div>
    </div>
</body>
</html>
