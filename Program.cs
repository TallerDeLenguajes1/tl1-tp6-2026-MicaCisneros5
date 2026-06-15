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

