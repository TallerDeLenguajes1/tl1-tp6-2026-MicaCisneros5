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


//Ejercicio 2. Ingrese al branch CalculadoraV1 y construya un programa que sea una calculadora que permita al usuario realizar las 4 operaciones básicas (Sumar, Restar, Multiplicar y Dividir) a partir de un menú para seleccionar la opción a elegir y que luego pida dos números y que devuelva el resultado de la operación seleccionada. Además una vez que termine de realizar la operación le pregunte si desea realizar otro cálculo.

//creamos una variable de control inicializada en "TRUE" para que el programa entre al bucle while
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

            int num1, num2; 
            //verificamos que ambos sean numeros para continuar la operacion
            if (int.TryParse(texto1, out num1) && int.TryParse(texto2, out num2))
            {
                switch (opcion)
                {
                    case 1:
                    Console.WriteLine("Resultado: " + (num1 + num2));
                    break;

                    case 2:
                    Console.WriteLine("Resultado: " + (num1 - num2));
                    break;

                    case 3:
                    Console.WriteLine("Resultado: " + (num1 * num2));
                    break;

                    case 4:
                    if (num2 != 0)
                    {
                        Console.WriteLine("Resultado: " + (num1 / num2));
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

//Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la calculadora.. Solicite al usuario un número y muestre por pantalla:
//● El valor absoluto de un número
//● El cuadrado
//● La raíz cuadrada
//● El seno
//● El Coseno
//● La parte entera de un tipo float.
//Luego de esto, solicite dos números al usuario y determine:
//● El Máximo entre los dos números
//● El Mínimo entre los dos números
//Para TODOS los casos, no olvide contemplar siempre el caso de que el usuario no ingrese un número válido.

//solisitamos al usuario un numero 
Console.WriteLine("Ingrese un numero: ");
string texto3 = Console.ReadLine();

float numero3;

//validamos que sea un numero
if (float.TryParse (texto3, out numero3))
{
    //mostraremos los resultados utilizando la clase Math
    //valor absoluto
    Console.WriteLine("Valor absoluto: " + Math.Abs(numero3));

    //el cuadrado
    Console.WriteLine("Cuadrado: " + Math.Pow(numero3, 2));//(base, exponente)

    //raiz cuadrada, tenemos en cuenta que la raiz existe solamente para numero mayores o iguales a 0
    if (numero3 >= 0)
    {
        Console.WriteLine("Raiz cuadrada: " + Math.Sqrt(numero3));
    } else
    {
        Console.WriteLine("No existe raiz cuadrada para numeros negativos");
    }

    //seno
    Console.WriteLine("Seno: " + Math.Sin(numero3));

    //coseno
    Console.WriteLine("Coseno: " + Math.Cos(numero3));

    //parte entera
    Console.WriteLine("Parte entera: " + Math.Truncate(numero3));
    
}else
{
    Console.WriteLine("Error. Debe ingresar un numero valido.");
}

//solisitamos al usuario que ingrese dos numeros
Console.WriteLine("Ingrese el primer numero: ");
string texto4 = Console.ReadLine();
Console.WriteLine("Ingrese el segundo numero: ");
string texto5 = Console.ReadLine();

float num3, num4;

//validamos ambos numeros
if (float.TryParse(texto4, out num3) && float.TryParse(texto4, out num4))
{
    //determinamos maximo y minimo
    if (num3 > num4)
    {
        Console.WriteLine("Maximo: " + num3);
        Console.WriteLine("Minimo: " + num4);
    } else
    {
        Console.WriteLine("Maximo: " + num4);
        Console.WriteLine("Minimo: " + num3);
    }
} else
{
    Console.WriteLine("Error. Debe ingresar numeros validos");
}