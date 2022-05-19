definir proyectos por cliente ADMINISTRADOR
definir equipos de trabajo ADMINISTRADOR
contemplar datos de proyecto  ADMINISTRADOR
definir proyecto ADMINISTRADOR
	definir actividades ADMINISTRADOR
	definir estimaciones ADMINISTRADOR
	definir empleados ADMINISTRADOR
	definir dependencias ADMINISTRADOR
registrar avances ADMINISTRADOR

realizar tarea no asignada EMPLEADO //
avisar al supervisor  EMPLEADO  //
asignar tarea no planificada SUPERVISOR **
declarar avance EMPLEADO //
solicitar informe CLIENTE --
consultar avance de proyecto SUPERVISOR **

 ******


# Los administradores, 
definen los proyectos de cada cliente, así como 
los equipos de trabajos (empleados que participan en cada proyecto con su respectivo rol afectado al proyecto).

contemplar datos por cada proyecto son, 
el cliente con nombre del contacto, teléfono, mail, 
una breve descripción del proyecto, 
y un estado de este.

3-    Para cada proyecto 
el administrador, 
define una serie de actividades, las cuales 
deben contemplar una estimación 
	de esfuerzo de desarrollo, 
	una fecha de inicio, 
	una fecha de fin, 
	y un grupo de empleados que participarán en dicha actividad, 
	así como una dependencia en caso de que existiera.

# 4-    Cada empleado 
participante del proyecto debe 
registrar el avance de cada actividad 
en la que está asignado.

5-    En caso de que 
un empleado tenga que 
realizar una tarea a la que no fue asignado, previo al inicio, debe 
avisar verbalmente al supervisor 
y es este quien debe 
asignar la tarea al empleado 
para que el mismo pueda 
declarar el avance.

# 6-    Los clientes 
pueden utilizando el sistema 
solicitar un informe 
de avance y estado de cada uno de sus proyectos.

# 7-    El Supervisor 
puede 
consultar el Status de cada proyecto, 
obteniendo información de avance del mismo.

 