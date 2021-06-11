function saludar() {
    alert("Hola Mundo");
}
function cargarDatos() {
    var txtNombre = document.getElementById("Nombre");
    txtNombre.value = "Mi Nombre";
    var chkEstaEstudiando = document.getElementById("Estudias");
    chkEstaEstudiando.checked = true;
    var textArea = document.getElementsByTagName("textarea");
    textArea[0].value = "Un texto muy largo";

}
function mostrarDatos() {
    var edad = document.getElementById("Edad");
    alert(edad.value);
}
/* <button id="boton2" onclick="javascript: mostrarDatos();">
Mostrar datos
</button> */

function cambiarEstilo() {
    var btn = document.getElementById("boton");
    btn.style.backgroundColor = "green";
    btn.style.color = "#FF6600";
}

function validar() {
    var nombre = document.getElementById("Nombre").value;

    if (nombre == "") {
        var mensaje = document.getElementById("alertaNombre");
        mensaje.style.display = "inline-block";
        return false;
    }
    else {
        var mensaje = document.getElementById("alertaNombre");
        mensaje.style.display = "none";
    }

    var edad = document.getElementById("Edad").value;
    if (edad == "") {
        var mensaje = document.getElementById("alertaEdad");
        mensaje.style.display = "inline-block";
        return false;
    }
    else {
        var mensaje = document.getElementById("alertaEdad");
        mensaje.style.display = "none";
    }

    return true;

}

function llenarTabla() {

    var esValido = validar();
    if (esValido == false) {
        return;
    }

    //obtengo el valor para nombre
    var nombre = document.getElementById("Nombre").value;
    //obtengo el valor para edad
    var edad = document.getElementById("Edad").value;
    var tabla = document.getElementById("tablaDatos");
    //genero una fila en la tabla en la posición segunda (indice 1)
    var row = tabla.insertRow(1);//<tr></tr>
    var celda1 = row.insertCell(0);//<td></td>
    var celda2 = row.insertCell(1);//<td></td>

    celda1.innerHTML = nombre; //<td>(mete el texto entre una etiqueta)</td>                          
    celda2.innerHTML = edad;
}