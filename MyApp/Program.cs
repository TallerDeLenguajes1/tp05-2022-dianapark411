// See https://aka.ms/new-console-template for more information

//EJERCICIO 2: CALCULADORA BASICA

void CalculadoraV1 () {
    int result = 0;

    Console.WriteLine("Que operacion desea realizar?");
    Console.WriteLine("SUMAR-> 1  -  RESTAR-> 2  -  MULTIPLICAR-> 3  -  DIVIDIR-> 4 :  ");
    string opcionUsuario = Console.ReadLine();
    int opcion = Convert.ToInt32(opcionUsuario);

    Console.WriteLine("Ingrese un numero:");
    string numero1 = Console.ReadLine();
    int num1 = Convert.ToInt32(numero1);

    Console.WriteLine("Ingrese otro numero:");
    string numero2 = Console.ReadLine();
    int num2 = Convert.ToInt32(numero2);

    switch (opcion){
        case 1:
            result = num1+num2;
            break;
        case 2:
            result = num1-num2;
            break;
        case 3:
            result = num1*num2;
            break;
        case 4:
            if(num2!=0){
                result = num1/num2;
            }else{
                Console.WriteLine("ERROR! Para dividir dos numeros el segundo debe ser distinto de cero");
            }
            break;
        default:
            break;
    }

    Console.WriteLine("El resultado es: " + result);
    Console.WriteLine("Desea realizar otra operacion?");
    Console.WriteLine("SI: 1, NO:0");
    string opcionUsuario2 = Console.ReadLine();
    int opcion2 = Convert.ToInt32(opcionUsuario2);

    if(opcion2 == 1){
        CalculadoraV1();
    }
}

CalculadoraV1();

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
