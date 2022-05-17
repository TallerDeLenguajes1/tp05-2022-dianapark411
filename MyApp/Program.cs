// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Ingrese texto:");
string texto = Console.ReadLine();
//readline devuelve un string

Console.WriteLine("Ingrese un numero:");
string numero1 = Console.ReadLine();
Console.WriteLine("Ingrese otro numero:");
string numero2 = Console.ReadLine();

int resultado = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);

// int resultado = Int32.Parse(numero1) + Int32.Parse(numero2);

Console.WriteLine("La suma de los numeros es: " + resultado);
