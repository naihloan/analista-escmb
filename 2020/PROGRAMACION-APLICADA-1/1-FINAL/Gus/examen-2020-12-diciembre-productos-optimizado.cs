class Program

{
    static void Main(string\[\] args)

    {
        int tamanioVector = 2;
        decimal ganancia = 0.15m;
        decimal iva = 0.21m;
        string\[\] productos = new string\[tamanioVector\];
        decimal\[\] precioCosto = new decimal\[tamanioVector\];
        decimal\[\] precioVenta = new decimal\[tamanioVector\];
        decimal\[\] montoIva = new decimal\[tamanioVector\];
        decimal\[\] precioFinal = new decimal\[tamanioVector\];
int ancho = 90;
string titulo = \"LISTA DE PRECIOS\";
string guiones = new string(\'-\', ancho);
string dobleLinea = new string(\'=\', ancho);
string cabecera1 = Helpers.Cabecera(\"Producto\", 38,\'d\');
string cabecera2 = Helpers.Cabecera(\"Precio Venta\",22);
string cabecera3 = Helpers.Cabecera(\"IVA\", 12);
string cabecera4 = Helpers.Cabecera(\"Precio Final\", 18);

for (int i = 0; i \< tamanioVector; i++)
{
var ingresoNombre = Helpers.IngresoString(\"Ingrese el nombre del
producto\");
productos\[i\] = ingresoNombre;
var ingresoCosto = Helpers.IngresoDecimal(0, decimal.MaxValue, \"Ingrese
el precio de costo\", true);
precioCosto\[i\] = ingresoCosto;
Console.Clear();
}

for (int i = 0; i \< tamanioVector; i++)
{
precioVenta\[i\] = precioCosto\[i\] \* (1 + ganancia);
montoIva\[i\] = precioVenta\[i\] \* iva;
precioFinal\[i\] = Math.Round(precioVenta\[i\] + montoIva\[i\], 2);
}

Console.WriteLine(dobleLinea);
Console.WriteLine((titulo.PadLeft((ancho + Math.Abs(titulo.Length)) /
2).PadRight(ancho)));
Console.WriteLine(dobleLinea);
Console.WriteLine(cabecera1 + cabecera2 + cabecera3 + cabecera4);
Console.WriteLine((guiones));

for (int i = 0; i \< tamanioVector; i++)
{
Console.Write( Helpers.Cabecera(productos\[i\], 39, \'d\'));
Console.Write(Helpers.Cabecera(\$\"{ precioVenta\[i\]:c2}\", 19));
Console.Write(Helpers.Cabecera(\$\"{ montoIva\[i\]:c2}\", 15));
Console.WriteLine(Helpers.Cabecera(\$\"{ precioFinal\[i\]:c2}\", 17));
}

Console.WriteLine(guiones);
Console.WriteLine(\$\"Cantidad de productos: {productos.Length}\");
Console.WriteLine(\"Presione enter para finalizar\");
Console.ReadLine();
}
}

// ### HELPERS

class Helpers

{
public static string Cabecera(string mensaje, int posicion, char lado)

{
//string Cabe = (lado == \'d\') ? mensaje.PadRight(posicion) :
mensaje.PadLeft (posicion);
string Cabe = mensaje.PadRight(posicion);
return Cabe;
}

public static string Cabecera(string mensaje, int posicion)
{
string Cabe = mensaje.PadLeft(posicion); //Cabecera(mensaje,
posicion,\'l\');
return Cabe;
}

public static string IngresoString(string mensaje)
{
string ingreso = null;

while (string.IsNullOrWhiteSpace(ingreso))
{
Console.WriteLine(mensaje);
ingreso = Console.ReadLine();
Console.Clear();
}

return ingreso;
}

public static decimal IngresoDecimal()
{
decimal salida;
salida = IngresoDecimal(\"Ingrese un número\");
return salida;
}

public static decimal IngresoDecimal(string mensaje)
{
decimal salida;
salida = IngresoDecimal(decimal.MinValue, decimal.MaxValue, mensaje);
return salida;
}

public static decimal IngresoDecimal(decimal valordesde, decimal
valorHasta)
{
decimal salida;
salida = IngresoDecimal(valordesde, valordesde, \$\"Ingrese un valor
entre {valordesde} y {valorHasta}\");
return salida;
}

public static decimal IngresoDecimal(decimal valordesde, decimal
valorHasta, string mensaje)
{
decimal salida;
salida = IngresoDecimal(valordesde, valorHasta, mensaje, false);
return salida;
}

public static decimal IngresoDecimal(decimal valordesde, decimal
valorHasta, string mensaje, bool limpiarPantalla)
{
decimal salida;

if (limpiarPantalla == true)
{
Console.Clear();
}

Console.WriteLine(mensaje);
string ingreso = Console.ReadLine();

while (decimal.TryParse(ingreso, out salida) == false \|\| (salida \<
valordesde \|\| salida \> valorHasta))
{

if (limpiarPantalla == true)
{
Console.Clear();
}

Console.WriteLine(mensaje);
ingreso = Console.ReadLine();
}

return salida;
}
}

EXAMEN DE DICIEMBRE -- OPTIMIZADO 2 (CON RESIZE DE ARRAYS PARA AGREGAR PRODUCTOS)
---------------------------------------------------------------------------------

### Program

class Program

{
static void Main(string\[\] args)

{
char salir = \'n\';
int tamanioVector = 2;
decimal ganancia = 0.15m;
decimal iva = 0.21m;
string\[\] productos = new string\[tamanioVector\];
decimal\[\] precioCosto = new decimal\[tamanioVector\];
decimal\[\] precioVenta = new decimal\[tamanioVector\];
decimal\[\] montoIva = new decimal\[tamanioVector\];
decimal\[\] precioFinal = new decimal\[tamanioVector\];
int cont = 0;

do
{
Console.Clear();
int ancho = 90;
string titulo = \"LISTA DE PRECIOS\";
string guiones = new string(\'-\', ancho);
string dobleLinea = new string(\'=\', ancho);
string cabecera1 = Helpers.Cabecera(\"Producto\", 38, \'d\');
string cabecera2 = Helpers.Cabecera(\"Precio Venta\", 22);
string cabecera3 = Helpers.Cabecera(\"IVA\", 12);
string cabecera4 = Helpers.Cabecera(\"Precio Final\", 18);

for (int i = cont; i \< tamanioVector; i++)
{
var ingresoNombre = Helpers.IngresoString(\"Ingrese el nombre del
producto\");
productos\[i\] = ingresoNombre;
var ingresoCosto = Helpers.IngresoDecimal(0, decimal.MaxValue, \"Ingrese
el precio de costo\", true);
precioCosto\[i\] = ingresoCosto;
Console.Clear();
}

for (int i =cont; i \< tamanioVector; i++)
{
precioVenta\[i\] = precioCosto\[i\] \* (1 + ganancia);
montoIva\[i\] = precioVenta\[i\] \* iva;
precioFinal\[i\] = Math.Round(precioVenta\[i\] + montoIva\[i\], 2);
}

Console.WriteLine(dobleLinea);
Console.WriteLine((titulo.PadLeft((ancho + Math.Abs(titulo.Length)) /
2).PadRight(ancho)));
Console.WriteLine(dobleLinea);
Console.WriteLine(cabecera1 + cabecera2 + cabecera3 + cabecera4);
Console.WriteLine((guiones));

for (int i = 0; i \< tamanioVector; i++)
{
Console.Write(Helpers.Cabecera(productos\[i\], 39, \'d\'));
Console.Write(Helpers.Cabecera(\$\"{ precioVenta\[i\]:c2}\", 19));
Console.Write(Helpers.Cabecera(\$\"{ montoIva\[i\]:c2}\", 15));
Console.WriteLine(Helpers.Cabecera(\$\"{ precioFinal\[i\]:c2}\", 17));
}

Console.WriteLine(guiones);
Console.WriteLine(\$\"Cantidad de productos: {productos.Length}\");
Console.WriteLine(\"Presione s para salir, u otra tecla para agregar un
producto\");

salir = Console.ReadKey().KeyChar;
salir = char.ToUpper(salir);
Array.Resize\<string\>(ref productos, tamanioVector + 1);
Array.Resize\<decimal\>(ref precioCosto, tamanioVector + 1);
Array.Resize\<decimal\>(ref precioVenta, tamanioVector + 1);
Array.Resize\<decimal\>(ref montoIva, tamanioVector + 1);
Array.Resize\<decimal\>(ref precioFinal, tamanioVector + 1);

cont = tamanioVector;
tamanioVector++;

} while (salir != \'S\');
//Console.ReadLine();
}
}

### Helpers 

class Helpers

{
public static string Cabecera(string mensaje, int posicion, char lado)

{
//string Cabe = (lado == \'d\') ? mensaje.PadRight(posicion) :
mensaje.PadLeft (posicion);
string Cabe = mensaje.PadRight(posicion);
return Cabe;
}

public static string Cabecera(string mensaje, int posicion)
{
string Cabe = mensaje.PadLeft(posicion); //Cabecera(mensaje,
posicion,\'l\');
return Cabe;
}

public static string IngresoString(string mensaje)
{
string ingreso = null;

while (string.IsNullOrWhiteSpace(ingreso))
{
Console.WriteLine(mensaje);
ingreso = Console.ReadLine();
Console.Clear();
}
return ingreso;
}

public static decimal IngresoDecimal()
{
decimal salida;
salida = IngresoDecimal(\"Ingrese un número\");
return salida;
}

public static decimal IngresoDecimal(string mensaje)
{
decimal salida;
salida = IngresoDecimal(decimal.MinValue, decimal.MaxValue, mensaje);
return salida;
}

public static decimal IngresoDecimal(decimal valordesde, decimal
valorHasta)
{
decimal salida;
salida = IngresoDecimal(valordesde, valordesde, \$\"Ingrese un valor
entre {valordesde} y {valorHasta}\");
return salida;
}

public static decimal IngresoDecimal(decimal valordesde, decimal
valorHasta, string mensaje)
{
decimal salida;
salida = IngresoDecimal(valordesde, valorHasta, mensaje, false);
return salida;
}

public static decimal IngresoDecimal(decimal valordesde, decimal
valorHasta, string mensaje, bool limpiarPantalla)
{
decimal salida;

if (limpiarPantalla == true)
{
Console.Clear();
}

Console.WriteLine(mensaje);
string ingreso = Console.ReadLine();

while (decimal.TryParse(ingreso, out salida) == false \|\| (salida \<
valordesde \|\| salida \> valorHasta))
{
if (limpiarPantalla == true)
{
Console.Clear();
}

Console.WriteLine(mensaje);
ingreso = Console.ReadLine();
}
return salida;
}
}
