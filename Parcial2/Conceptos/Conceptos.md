# **ESTRUCTURA DE DATOS**
Las **estructura de datos** son formatos especializados que permiten organizar, almacenar y manipular la información de manera eficiente dentro de una computadora. Son fundamentales en informática y programación porque permiten que los algoritmos trabajen de forma óptima.

## **Las estructuras de datos más comúnes son:**
- Arreglos.
  - Unidimensionales.
  - Bidimensionales.
  - Multidimencionales.
- Listas.
  - Simples.
  - Dobles.
  - Circulares.
- Pilas.
- Colas.

### ***Arreglos***:
Los **arreglos** son una estructura de datos fundamental en la programación que permiten almacenar **múltiples valores del mismo tipo** en una sola variable, organizados de una forma ordena y que la manera de acceder a ellos es mediante índices.

#### **Unidimensionales**
Se trata de una colección lineal de elementos del mismo tipo, organizados en una sola dimensión, como un vector. **Ejemplo:**
```csharp
string[] unVector = {"Abelardo"};
```

#### **Bidimensionales**
Se trata de una colección que permite almacenar información en dos dimensiones: filas y columnas. Estás se les conocen como matrices. **Ejemplo:**
```csharp
int[,] unaMatriz = {
    {1,2,3},
    {4,5,6},
    {7,8,9}
    }
```
#### **Multidimensionales**
Se trata de una colección que permite almacenar información en tres dimensiones: bloques, filas y columnas. **Ejemplo:**
```csharp
int[,,] unCubo = {
    {
        {1, 2, 3, 4},
        {5, 6, 7, 8},
        {9, 10, 11, 12}
    },
    {
        {13, 14, 15, 16},
        {17, 18, 19, 20},
        {21, 22, 23, 24}
    }
}
```

### ***Listas***
Una **lista** es una estructura de datos que permite almacenar varios elementos en orden. Cada elemento tiene una posición (índice) y sus operaciones básicas son: agregar, eliminar, recorrer.

#### **Lista Simple**
Es una estructura de datos lineal que se compone de un conjunto de nodos en secuencia que están enlazados, cada nodo contiene un datos y un apuntador o referencia.

![Imagen](http://3.bp.blogspot.com/-6EUgwAAj1kU/ThZFDH5QJOI/AAAAAAAAAEM/Rae9N-EvcBo/s1600/enlace+simple.jpg)

#### **Lista Doble**
Es una estructura de datos lineal que se compone de un conjunto de nodos en secuencia enlazados, cada nodo tiene contiene un dato y dos apuntadores, uno que va hacia atrás y otro hacia adelante.

![Imagen](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEh5OgM-H4uFtQn1NoQwwiv2q8E2JjqijR4tnIC22Rgz40OQIOqP7bTfi2tbNmoyiNkAoMkJguzlrWn-khWJ1D2ptFAMZ51Dk1pdehc_3aCPq65c8F9CY-dfe8u9veTeXK_OXp10NmAJ7ag/s320/enlace+doble.jpg)

#### **Lista Circular**
Es una estructura de datos lineal que se compone de un conjunto de nodos en secuencia enlazados, cada nodo contiene un dato y un apuntador al siguiente nodo, y el último nodo se enlaza nuevamente al primero, formando un ciclo continuo sin un nodo terminal.

![Imagen](https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEi9yaRcrYnF8kTCvRyf8lw70jiCiS_3zIkwS3cS5hBdQbBCNMBkq9QWT7RRUh3WDBiyxKH7VJkAyJnbYqJ2x_SYqNXY6kLfI5QquvSA-qq4QlqYzBufc5KTP4P3al5p9LgSKycLTKpy6EU/s320/enlace+circular.jpg)

### ***Pilas***
Es una estructura de datos lineal que organiza los elementos siguiendo el principio **LIFO** (Last In, First Out), es decir, el último en entrar es el primero en salir. Sus operaciones básicas son: **Push**, que coloca el dato encima de otro, **Pop**, elimina y devuelve el dato que se encuentra en el tope, **Peek**, consulta el dato que está en el tope pero sin eliminarlo.

![Imagen](https://kevinnlg.wordpress.com/wp-content/uploads/2015/11/pila-de-datos-funciones.jpg?w=600)

### ***Colas***
Es una estructura de datos lineal que organiza los elemetnos siguiendo el principio **FIFO** (First In, First Out) es decir, el primero en entrar es el primero en salir. Sus operaciones básica son: **Enqueue**, agrega un elemento al final de la cola, **Dequeue**, elimina y devuelve el dato que está en el frente, **Front**, que devuelve el dato que está en el frente pero sin eliminarlo.

![Imagen](https://programacionpython80889555.wordpress.com/wp-content/uploads/2019/03/cola-3.png)