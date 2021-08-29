function saludar() {
    var nombre = document.getElementById("nombre").value

    if (nombre == "") {
        var colorRojo = document.getElementById("nombre").style.background = "red";
    }
    else {
        var colorVerde = document.getElementById("nombre").style.background = "green";
        alert("Hola: " + nombre);
    }
}