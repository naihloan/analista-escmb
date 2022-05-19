# Primer Seguimiento Sistemas de Datos II

Como parte de la acreditación de la Asignatura te pedimos que respondas las siguientes preguntas:

#### ¿Qué estados posibles tiene un Vehículo ? Explica cada uno de esos estados 
Disponible/Agotado/Reparable

Un auto puede esta disponible para la venta. O que ese modelo ya no esté más. También puede haber un auto que no esté en condiciones apta para la venta y hagan falta reparaciones.

#### ¿Qué estados posibles tiene una Venta? Explica cada uno de esos estados 
Terminada/SinDato

Una venta se hizo o no se hizo. Si se hizo está terminada. Sino, no tiene ningún valor.

#### Describe la estructura de la tabla Vehículos 
(clavePrimaria)id_Vehiculo(int),
Usado(tinyint),
Marca(varchar50),
Modelo(varchar50),
Motor(tinyint),
Color(varchar50),
Chasis(varchar30),
Precio(decimal18)

#### Describe la estructura de la tabla Ventas 
(clavePrimaria)id_Venta(int),
id_Empleado(int),
id_Producto(varchar50),
id_Mecanico(int),
id_Forma_de_pago(int),
id_Cod_Cliente(int),
Fecha(date),
Garantia(varchar50),
Condicion(varchar50),
Total(int)

#### Describe la estructura de la tabla Clientes. Relaciona las tablas Clientes con la tabla Sucursales. Explica la relación. 
(clavePrimaria)id_Cod_Cliente(int),
Documento(int),
Nombre(varchar50),
Direccion(varchar50),
Ciudad(varchar50),
Telefono(int),

La relación entre Clientes y Sucursales es una relación de muchos a muchos (N,M).  Para conectar ambas entidades hay que tomar en cuenta las ventas y los vendedores que hicieron las ventas. En cada venta se identifica cuál es el cliente, cuál es el vendedor y a qué sucursal corresponde.

#### Escribe en SQL la siguiente consulta:  \n "Lista los Vehículos vendidos incluyendo Marca y Modelo" . | 20 puntos

SELECT ID_Producto  
FROM Venta  
WHERE Condicion = 'vendido'  
AND (  
    Marca FROM Vehiculo AND  
    Modelo FROM Vehiculo  
)

#### Escribe en SQL la siguiente consulta:  \n "Lista los vehículos incluyendo Marca y Modelo" | 20 puntos

SELECT  
(Marca AND Modelo)  
FROM Vehiculo

#### Escribe en SQL la siguiente consulta:  \n "Designaciones de empleados en cargos" 

Nota: Los empleados aparecían en la tabla original sin cargos. Acá se toma ese campo para hacer consulta. A futuro puede crearse este atributo.

SELECT Nombre, Apellido  
FROM Empleado  
WHERE Cargo IS NOT NULL;

