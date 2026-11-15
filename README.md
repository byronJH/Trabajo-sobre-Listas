# Ejercicio: Gestión de listas

## Datos del integrante

- **Nombre:** Byron Adner Jorge Herrera.
- **Número:** 10#

## Descripción de la tarea o proyecto

Este proyecto consiste en desarrollar un programa de consola en C# que permita administrar el inventario de una tienda lo que conlleva a permitir agregar productos y sus precios, mostrar el inventario, buscar, modificar y eliminar productos. También permite calcular estadísticas de los precios y permite ordenar los productos de menor a mayor precio.

## Entrada

El programa pide los siguientes datos al usuario:

- La opción que desea ejecutar en el menú.
- El nombre del producto que desea agregar.
- El precio del producto.
- El nombre del producto que desea buscar, modificar o eliminar.
- El nuevo nombre y el nuevo precio cuando se modifica un producto.

## Proceso

1. Se muestran las opciones del menú principal dentro del bucle, para que el programa continúe funcionando hasta que el usuario seleccione la opción 0.
2. Se utiliza una estructura `switch` para identificar la opción seleccionada y llamar al método correspondiente.
3. En `AgregarProducto()`, se solicita el nombre y el precio, y ambos datos se guardan en las listas `Productos` y `Precios`.
4. En `VerProductos()`, se comprueba que la lista no esté vacía y se recorren los productos con un ciclo `for` para mostrar sus nombres y precios.
5. En `IndiceProductos()`, se busca el producto utilizando `BuscarIndice()`. La búsqueda no distingue entre mayúsculas y minúsculas.
6. En `ModificarProductos()`, se busca el producto y, si existe, se reemplazan su nombre y su precio.
7. En `EliminacionProductos()`, se busca el producto y se eliminan su nombre y su precio de las listas.
8. En `VerEstadisticas()`, se recorre la lista de precios para calcular la cantidad de productos, el precio mayor, el precio menor y el promedio.
9. En `ListaOrdenada()`, se ordenan los precios de menor a mayor y se reorganizan los nombres para mantenerlos relacionados con sus precios.
10. `LeerPrecio()` valida que el precio introducido sea numérico y mayor que cero. `ListaVacia()` comprueba si existen productos antes de ejecutar varias operaciones.

## Salida

El programa puede mostrar:

- Una confirmación cuando se agrega, modifica o elimina un producto.
- La lista de productos con sus respectivos precios.
- El resultado de la búsqueda de un producto.
- Un mensaje cuando no hay productos registrados o cuando un producto no aparece en la búsqueda.
- Las estadísticas del inventario: cantidad de productos, precio mayor, precio menor y promedio.
- Una confirmación cuando la lista queda ordenada por precio.
- Un mensaje de salida cuando el usuario selecciona la opción `0`.

## Tecnologías utilizadas

- **Lenguaje de programación:** C#.
- **Entorno de desarrollo:** Visual Studio.
- **Plataforma:** .NET.
- **Estructuras utilizadas:** Listas, métodos, `if`, `switch`, `do-while`, `for` y `foreach`.

## Capturas de pantalla

### Escenario 1: Menú principal agregando un producto

<img width="260" height="329" alt="Captura de pantalla 2026-11-14 215645" src="https://github.com/user-attachments/assets/31bdbeee-dfa4-46c8-8044-079cb99089b6" />

### Escenario 2: Mostrar todos los productos agregados

<img width="274" height="224" alt="Captura de pantalla 2026-11-14 215844" src="https://github.com/user-attachments/assets/022d6119-a1cc-4774-bc2d-5f11e6366abf" />

### Escenario 3: Buscas un producto individualmente

<img width="260" height="194" alt="Captura de pantalla 2026-11-14 220038" src="https://github.com/user-attachments/assets/546deb98-1d5b-40f0-8af4-dacbbd3c4e40" />

### Escenario 4: Modificar un producto

<img width="270" height="215" alt="Captura de pantalla 2026-11-14 220425" src="https://github.com/user-attachments/assets/b5507d6f-3c16-4aed-8440-1892ba8a37a6" />


### Escenario 5: Eliminar producto

<img width="262" height="190" alt="Captura de pantalla 2026-11-14 224145" src="https://github.com/user-attachments/assets/d4a462e8-60d5-42ab-8f40-a3f0b3899da1" />

### Escenario 6: Estadisticas

<img width="266" height="209" alt="Captura de pantalla 2026-11-14 224251" src="https://github.com/user-attachments/assets/f9e70eab-8aa4-44a6-ac76-00da9f9aa5af" />

### Escenario 7: Ordenar lista por orden ascendente

<img width="255" height="196" alt="Captura de pantalla 2026-11-14 224405" src="https://github.com/user-attachments/assets/f4c8728d-0cc1-4559-9372-60b8bc758bae" />
<img width="266" height="161" alt="Captura de pantalla 2026-11-14 224356" src="https://github.com/user-attachments/assets/27a6b474-f5a2-446c-90f7-d8533eaf8bb3" />

### Escenario 7: Salir

<img width="262" height="161" alt="Captura de pantalla 2026-11-14 224540" src="https://github.com/user-attachments/assets/95288b87-a43b-4830-ae90-a7118f08d291" />
