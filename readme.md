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
# Ejercicio 5 (Optativo) - Expresiones Regulares

## ¿Qué son las expresiones regulares?

Las expresiones regulares (Regular Expressions o Regex) son secuencias de caracteres que permiten definir patrones de búsqueda dentro de un texto. Se utilizan para buscar, validar, extraer o reemplazar información en cadenas de caracteres.

Por ejemplo, se pueden utilizar para verificar si un texto tiene el formato de un correo electrónico, encontrar números dentro de una oración o reemplazar determinadas palabras en un texto.

---

## ¿Cómo funcionan las expresiones regulares?

Las expresiones regulares funcionan mediante patrones formados por caracteres especiales y caracteres normales.

Algunos ejemplos:

- `\d` : representa cualquier dígito del 0 al 9.
- `[a-z]` : representa cualquier letra minúscula.
- `+` : indica una o más repeticiones del patrón anterior.
- `*` : indica cero o más repeticiones.
- `^` : indica el inicio de una cadena.
- `$` : indica el final de una cadena.

Ejemplos:

- `\d+` → uno o más números.
- `[A-Za-z]+` → una o más letras.
- `^\d+$` → una cadena formada únicamente por números.

---

## ¿Funcionan únicamente en C#?

No. Las expresiones regulares no son exclusivas de C#. Se utilizan en numerosos lenguajes y herramientas, entre ellos:

- C#
- Java
- JavaScript
- Python
- PHP
- C++
- SQL
- Editores de texto como Visual Studio Code y Notepad++

Aunque la sintaxis básica es muy similar entre lenguajes, algunas funciones avanzadas pueden variar según la implementación de cada uno.

---

## ¿En qué casos resultan útiles?

Algunos casos de uso son:

1. Validar correos electrónicos.
2. Verificar que un usuario ingrese solamente números.
3. Comprobar el formato de una fecha (por ejemplo, dd/mm/aaaa).
4. Buscar palabras específicas dentro de un texto.
5. Extraer información de una cadena de caracteres.
6. Reemplazar texto automáticamente.

---

## ¿Cómo se utilizan en C#?

En C# las expresiones regulares se utilizan mediante la clase `Regex`, que pertenece al espacio de nombres:

```csharp
using System.Text.RegularExpressions;
```

Algunos métodos de la clase `Regex` son:

- `Regex.IsMatch()` : verifica si un texto cumple un patrón.
- `Regex.Match()` : obtiene la primera coincidencia encontrada.
- `Regex.Matches()` : obtiene todas las coincidencias encontradas.
- `Regex.Replace()` : reemplaza partes del texto que coincidan con un patrón.

Ejemplo:

```csharp
using System.Text.RegularExpressions;

string texto = "12345";

if (Regex.IsMatch(texto, @"^\d+$"))
{
    Console.WriteLine("La cadena contiene solo números.");
}
```

En este ejemplo, el patrón `^\d+$` indica que la cadena debe estar compuesta únicamente por uno o más dígitos.