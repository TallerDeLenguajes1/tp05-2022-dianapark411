// See https://aka.ms/new-console-template for more information

//EJERCICIO 1: INVERTIR NUMERO

int resultado = 0, resto;

Console.WriteLine("Ingrese un numero:");
string numero = Console.ReadLine();

int num = Convert.ToInt32(numero);

for (int i = numero.Length; i > 0; i--){
    if(num>0){
        resto = num%10;
        resultado = resultado + resto * (int)(Math.Pow(10, i-1)); //casteo el resultado de la funcion pow porque me devuelve un doble
        num = num/10;
    }
}

Console.WriteLine("El numero invertido es: " + resultado);

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
