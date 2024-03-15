---
title: apuntes de c# 
author: Luciano Ghione, Benjamín Juárez, Píldoras Informáticas
date: septiembre 2021
---

Los métodos *no* terminan en `;`  
Las instrucciones terminan en `;`

`Console.WriteLine`  
INSTANCIA.METODO

* CLASES PROPIAS
* CLASES PREDEFINIDAS >> Bibliotecas de clases API

## TIPOS

* Por Referencia
* Por Valor
    * Enumerados
    * Estructuras
    * Primitivos
        * Booleanos
            * true
            * false
        * Reales
            * float
            * double: acepta números con coma
            * decimal
        * Enteros
            * con signo. Valores >> 0
                * sbyte
                * short
                * int
                * long
            * sin signo. Reconoce valores negativos
                * byte
                * ushort
                * uint
                * ulong

Variable: Espacio en la memoria RAM del ordenador donde se almacenará un valor que podrá cambiar durante la ejecución del programa.

## Buenas Prácticas

* Comenzar el nombre de la variable con letra minúscula
* Si el nombre de la variable está compuesta por más de una letra, comenzar la segunda con mayúscula: `edadAdulto [camelCase]`
* No usar notación húngara: `1edad [int como tipo de dato]`
* No comenzar el nombre de una variable con guión bajo: `_edad`
* No crear una variable más de una variable que se diferencien por sólo una letra

## Qué es declarar una variable?

* es crear, construir la variable
* en c#, para declarar se indica
    * el tipo de dato
    * el nombre de la variable
    * ejemplo: `int edad`

## Qué es iniciar una variable?

* es especificar qué valor almacenará la variable en su interior
    * `edad = 28;`
    * `int edad = 28;`

En c# no se puede usar una variable que no se ha iniciado.

## Operadores aritméticos

Suma            `+` Se usa con valores de texto. Concatenación de strings
Resta           `-`
Multiplicación  `*`
División        `/`
Residuo/Módulo  `%` Disuelve el resto de una división (no da un porcentaje)
Incremento      `++` edad = 19 / edad += 5 >> edad = 24 / edad += 5 >> incrementa a un valor 5
Decremento      `--` edad -= 9 >> decrementa a un valor 9
















`;`
* esto >> aquello
* `int edad = 28;`

