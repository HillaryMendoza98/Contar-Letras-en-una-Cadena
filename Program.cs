
//contar letras en una cadena

using System;

class Program
{
    static void Main()
    {
        // Solicita al usuario que ingrese una cadena de texto
        Console.Write("Ingrese una cadena de texto: ");
        
        // Almacena la cadena ingresada por el usuario en la variable 'texto'
        string texto = Console.ReadLine();

        // Calcula la longitud (cantidad de caracteres) de la cadena ingresada
        int conteo = texto.Length;

        // Muestra la cantidad de caracteres que tiene la cadena ingresada
        Console.WriteLine($"La cadena '{texto}' tiene {conteo} caracteres.");
    }
}
