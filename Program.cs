Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
b = a;

Console.WriteLine("Valor de a: " +a);
Console.WriteLine("Valor de b: "+b);

//Ejercicio 1. Construir un programa que permita invertir un número. Verifique que el texto ingresado es de hecho un número y, en caso afirmativo, realice la inversión del número sólo si éste es mayor a 0.

Console.WriteLine("Ingrese el numero a invertir: "); //(Write)muestra un mensaje y (Line)salto de línea

string texto = Console.ReadLine(); //(line)lee una línea de texto, read(lee un cararcter)
//Lo guardamos en una variable de tipo string porque todavia no sabemos si es un numero.

int numero;

//Comprueba si texto es un numero. Si lo es, guarda ese numero en la variable numero, si no, manda mensaje de error.
if (int.TryParse(texto, out numero))
{
    //Verificamos el numero ingresado sea mayor que cero
    if (numero > 0)
    {
        int invertido = 0;//variable donde se guardara el numero inverido
        //iteramos hasta que no queden numeros
        while (numero > 0)
        {
            //obtenemos el ultimo digito
            int digito = numero % 10;
            //agregamos al final del numero invertido
            invertido = invertido * 10 + digito;
            //eliminamos el ultimo digito
            numero = numero / 10;
        }

        Console.WriteLine("Numero Invertido: " + invertido);
    } else
    {
        Console.WriteLine("Error, el dato ingresado no es valido. Usted debe ingresar un numero entero mayor a cero.");
    }
} else
{
    Console.WriteLine("Error, el dato ingresado no es valido. Usted debe ingresar un numero entero.");
}


//Ejercicio 4
Console.WriteLine("Ingrese una cadena de texto: ");
string cadenaTexto = Console.ReadLine();

//Obtener la longitud de la cadena y muestre por pantalla.
Console.WriteLine("Longitud: " + cadenaTexto.Length); //(Length devuelve la cantidad de caracteres)

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
Console.WriteLine("Ingrese una segunda cadena de texto: ");
string cadenaTexto2 = Console.ReadLine();

Console.WriteLine($"{cadenaTexto}. {cadenaTexto2}");
//string cadenaConcatenada = cadenaTexto + ". " + cadenaTexto2;

//Extraer una subcadena de la cadena ingresada.
Console.WriteLine("Cuntos caracteres decea extraer de la primera cadena ingresada: ");
string caracteres = Console.ReadLine();

int cantCaracteres;

if (int.TryParse(caracteres, out cantCaracteres))
{
    if (cadenaTexto.Length >= cantCaracteres)
    {
        string subCadena = cadenaTexto.Substring(0, cantCaracteres); //Empieza en la posición 0, toma la cantidad especificada de caracteres.
        Console.WriteLine("SubCadena: " + subCadena);
    }
    else
    {
        Console.WriteLine("La cadena tiene menos caracteres que los solicitados");
    }
}
else
{
    Console.WriteLine("Debe ingresar un numero entero positivo");
}

//Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería: “la suma de “ num1 “ y de” num2 “ es igual a: ” resultado. Donde num1, num2 y resultados son los sumandos y el resultado de la operación respectivamente

bool continuar = true;

while (continuar)
{
    //mostramos menu de opciones
    Console.WriteLine("===== CALCULADORA =====");
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.Write("Seleccione una opción: ");

    //leemos y validamos el dato ingresado
    string textoOpcion = Console.ReadLine();
    int opcion;

    if (int.TryParse(textoOpcion, out opcion))
    {
        //validamos la opcion seleccionada primero
        if (opcion >= 1 && opcion <= 4)
        {
            //pedimos los dos numeros al usuario
            Console.Write("Ingrese el primer número: ");
            string texto1 = Console.ReadLine();
            Console.Write("Ingrese el segundo número: ");
            string texto2 = Console.ReadLine();

            int num1, num2, resultado; 
            //verificamos que ambos sean numeros para continuar la operacion
            if (int.TryParse(texto1, out num1) && int.TryParse(texto2, out num2))
            {
                switch (opcion)
                {
                    case 1:
                    resultado = num1 + num2;
                    //ToString(): Convierte un dato en texto
                    Console.WriteLine("La suma de " + num1.ToString() + "y de" + num2.ToString() + "es igual a" + resultado.ToString());
                    break;

                    case 2:
                    resultado = num1 - num2;
                    Console.WriteLine("La resta de " + num1.ToString() + "y de" + num2.ToString() + "es igual a" + resultado.ToString());
                    break;

                    case 3:
                    resultado = num1 * num2;
                    Console.WriteLine("La multiplicacion de " + num1.ToString() + "y de" + num2.ToString() + "es igual a" + resultado.ToString());
                    break;

                    case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("La divicion de " + num1.ToString() + "y de" + num2.ToString() + "es igual a" + resultado.ToString());
                    } else
                    {
                        Console.WriteLine("Error. No se puede dividir por cero");
                    }
                    break;

                    //default:
                    //Console.WriteLine("Opcion invalida");
                    //break;
                }
            }else
            {
                Console.WriteLine("Error, datos ingresados invalidos. Debe ingresar numeros validos");
            }
        } else
        {
            Console.WriteLine("Opcion invalida, debe seleccionar una opcion valida");
        }
    } else
    {
        Console.WriteLine("Error, dato ingresado invalido. Debe ingresar un numero.");
    }

    //preguntamos si se desea seguir realizando operaciones
    Console.WriteLine("¿Desea realizar otro calculo? (s/n): ");
    string respuesta = Console.ReadLine();

    if (respuesta != "s")
    {
        continuar = false;
        Console.WriteLine("Fin de la iteracion");
    }

}

//Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
foreach (char letra in cadenaTexto)//Para cada carácter de la cadena, guardalo en la variable letra y hace lo que está entre las llaves.
{
    Console.WriteLine(letra);
}

// Buscar la ocurrencia de una palabra determinada en la cadena ingresada
//Ver si una palabra aparece dentro de otra cadena de texto y, si aparece, en qué posición está.
Console.WriteLine("Ingrese la palabra a buscar: ");
string palabra = Console.ReadLine();

//buscamos la palabra
int posicion = cadenaTexto.IndexOf(palabra); //IndexOf(): Busca la primera vez que aparece el texto y devuelve la posición donde empieza, si la palabra no existe devuelve -1

if (posicion != -1)
{
    Console.WriteLine("La palabra se encuentra en el texto ingresado");
}
else
{
    Console.WriteLine("La palabra no se encontro en el texto ingresado");
}

//Convierta la cadena a mayúsculas y luego a minúsculas.
Console.WriteLine("Texto en Mayusculas:");
Console.WriteLine(cadenaTexto.ToUpper());

Console.WriteLine("Texto en Minusculas:");
Console.WriteLine(cadenaTexto.ToLower());

//Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split())
Console.WriteLine("Ingrese una cadana de caracteres separada por coma: ");
string caracterSep = Console.ReadLine();

string[] palabras = caracterSep.Split(","); //Split(): divide una cadena de texto en varias partes, usando un caracter indicado como separador
Console.WriteLine("Palabras ingresadas: ");

foreach (string p in palabras)
{
    Console.WriteLine(p);
}

//Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2
Console.Write("Ingrese una suma: ");
string suma = Console.ReadLine();

string[] numeros = suma.Split("+");

int numero1, numero2;

if (numeros.Length == 2 && int.TryParse(numeros[0], out numero1) &&
    int.TryParse(numeros[1], out numero2))
{
    int resultado = numero1 + numero2;
    Console.WriteLine("Resultado: " + resultado);
}
else
{
    Console.WriteLine("La operacion es invalida.");
}

//Ejercicio 5: Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido.
