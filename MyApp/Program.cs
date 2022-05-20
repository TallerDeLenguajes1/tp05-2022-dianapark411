// See https://aka.ms/new-console-template for more information

//EJERCICIO 1: INVERTIR NUMERO

void CalculadoraV2 () {

    Console.WriteLine("Ingrese un numero:");
    string numero1 = Console.ReadLine();
    double num1 = Convert.ToDouble(numero1);

    Console.WriteLine("Valor absoluto:" + Math.Abs(num1));
    Console.WriteLine("Cuadrado:" + Math.Pow(num1, 2));
    if(num1>0){
        Console.WriteLine("Raiz cuadrada:" + Math.Sqrt(num1));
    }else{
        Console.WriteLine("ERROR! No puede calcular la raiz cuadrada de un negativo");
    }
    Console.WriteLine("Seno:" + Math.Sin(num1));
    Console.WriteLine("Coseno:" + Math.Cos(num1));
    Console.WriteLine("Parte entera:" + Math.Truncate(num1));

    Console.WriteLine("Ingrese un numero:");
    string numero2 = Console.ReadLine();
    double num2 = Convert.ToDouble(numero2);

    Console.WriteLine("Ingrese otro numero:");
    string numero3 = Console.ReadLine();
    double num3 = Convert.ToDouble(numero3);
    
    Console.WriteLine("El maximo de los numeros:" + Math.Max(num2, num3));
    Console.WriteLine("El minimo de los numeros:" + Math.Min(num2, num3));
}

CalculadoraV2();

/*
Console.WriteLine("Ingrese texto:");
string texto = Console.ReadLine();
//readline devuelve un string

Console.WriteLine("Ingrese un numero:");
string numero1 = Console.ReadLine();
Console.WriteLine("Ingrese otro numero:");
string numero2 = Console.ReadLine();

// Formas de convertir un string a un entero

int resultado = Convert.ToInt32(numero1) + Convert.ToInt32(numero2);
// int resultado = Int32.Parse(numero1) + Int32.Parse(numero2);

string resultado2 = numero1 + numero2;


Console.WriteLine("La suma de los numeros es: " + resultado2);
Console.WriteLine("La suma de los numeros es: " + resultado);

*/
