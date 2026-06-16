# Ejercicio 4

## ¿String es un tipo por valor o un tipo por referencia?

En C#, `string` es un **tipo por referencia**. Sin embargo, tiene un comportamiento especial: las cadenas son **inmutables**, es decir, una vez creada una cadena de texto, su contenido no puede modificarse. Cuando parece que se modifica un `string`, en realidad se crea una nueva cadena en memoria.

---

## ¿Qué secuencias de escape tiene el tipo string?

Las secuencias de escape más utilizadas en C# son:

* `\"` : Comillas dobles (`"`)
* `\'` : Comilla simple (`'`)
* `\\` : Barra invertida (`\`)
* `\n` : Salto de línea
* `\t` : Tabulación horizontal
* `\r` : Retorno de carro
* `\b` : Retroceso (backspace)
* `\0` : Carácter nulo
* `\a` : Alerta o sonido del sistema
* `\f` : Salto de página
* `\v` : Tabulación vertical

Ejemplo:

```csharp
Console.WriteLine("Hola\nMundo");
```

Salida:

```
Hola
Mundo
```

---

## ¿Qué sucede cuando se utiliza el carácter `@` y `$` antes de una cadena de texto?

### `@` (cadena textual o verbatim string)

El carácter `@` indica que la cadena se interpretará literalmente. Las barras invertidas (`\`) y los saltos de línea se toman como texto normal y no como secuencias de escape.

Ejemplo:

```csharp
string ruta = @"C:\Usuarios\Mica\Documentos";
```

Sin `@` habría que escribir:

```csharp
string ruta = "C:\\Usuarios\\Mica\\Documentos";
```

### `$` (interpolación de cadenas)

El carácter `$` permite insertar el valor de variables o expresiones directamente dentro de la cadena utilizando llaves `{}`.

Ejemplo:

```csharp
string nombre = "Mica";
int edad = 20;

Console.WriteLine($"Me llamo {nombre} y tengo {edad} años.");
```

Salida:

```
Me llamo Mica y tengo 20 años.
```

También pueden combinarse ambos caracteres:

```csharp
string nombre = "Mica";
string mensaje = $@"Hola {nombre}
Bienvenida a C#";
```
