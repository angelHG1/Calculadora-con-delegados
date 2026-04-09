# Calculadora con delegados

## Explicacion del problema
Se solicitó un programa que utilizando delegados permita hacer operaciones con dos números, con la clausula de que no se deben usar
"if" o "switch" para que se realicen las operaciones.

## Que es un delegado
Un delegado en un tipo de dato que nos permite llamar y usar metodos de manera rapida dentro del código

## Por qué usar delegados en vez de llamar métodos directamente?
En este caso es porque hace el codigo mas escalable y flexible ante cambios. Tambien porque nos permite usar menos estructuras condicionales
haciendo el codigo mucho mas limpio.

## Como se usaron delegados en este proyecto
1. Se definió un delegado que recibe dos números y retorna un resultado.
2. Se crearon los métodos para las operaciones matemáticas: sumar, restar, multiplicar, dividir y potenciación.
3. Se solicitó al usuario ingresar dos números y la operacion a realizar.
4. Se asigna dinámicamente el método correspondiente al delegado según la opción elegida.
5. Se ejecuta la operación utilizando el delegado y se muestra el resultado en pantalla.

## Ejemplo de uso + capturas
### Datos de entrada
se ingresan dos números y mediante el menú se selecciona la operación

<img width="323" height="195" alt="image" src="https://github.com/user-attachments/assets/24244c19-f55a-4a32-afac-939520344e88" />

### Datos de salida
El programa asigna el metodo corresponiende a la operacion seleccionada en el delegado y se realiza el calculo.
<img width="275" height="70" alt="image" src="https://github.com/user-attachments/assets/c9e43de6-74f3-459c-b25c-63fb8f64e2a8" />

## Capturas del programa en ejecución en distintos escenarios.
#### Sumar 5 y 12 
<img width="379" height="220" alt="image" src="https://github.com/user-attachments/assets/27d9a96c-a17d-4294-8578-008810aed72a" />

#### Multiplicar 9 y 8
<img width="343" height="210" alt="image" src="https://github.com/user-attachments/assets/46a8c9d4-d0c0-42b5-9ac8-c93daa8068a5" />

#### Dividir cualquier numero entre 0
<img width="408" height="227" alt="image" src="https://github.com/user-attachments/assets/ec0c9170-2621-46fa-8980-b01ae3b18ada" />

#### 5 elevado a 3
<img width="307" height="189" alt="image" src="https://github.com/user-attachments/assets/65f9c90d-a418-4d6d-ac0c-911792fa2e40" />



