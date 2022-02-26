function saludar() {
    var texto = $("#nombre").val();
    if (texto == "") {
        document.getElementById("nombre").style.background = "green";
        alert("Hola: " + texto);
    }
    else {
        document.getElementById("nombre").style.background = "red";
        //alert("Hola: " + texto);
    }
}
