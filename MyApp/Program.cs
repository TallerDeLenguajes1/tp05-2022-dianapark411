// See https://aka.ms/new-console-template for more information

//EJERCICIOS 2, 3: CALCULADORA BASICA

int CalculadoraV1 (int opcion, int num1, int num2) {
    int result = 0;

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

    return result;
}

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


int flag = 1;
while (flag == 1){
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

    int resultado = CalculadoraV1(opcion, num1,num2);
    Console.WriteLine("El resultado es: " + resultado);
    Console.WriteLine("Desea realizar otra operacion?");
    Console.WriteLine("SI: 1, NO:0");
    flag = Convert.ToInt32(Console.ReadLine());
}

CalculadoraV2();


//EJERCICIO 4: CADENAS

Console.WriteLine("Ingrese una cadena: ");
string cadena1 = Console.ReadLine();


Console.WriteLine("Algunas letras de la cadena: " + cadena1[0] + cadena1[3]);

Console.WriteLine("Longitud de la cadena: " + cadena1.Length);
Console.WriteLine("Subcadena: " + cadena1.Substring(1,5));

cadena1 = cadena1.ToUpper();
Console.WriteLine("Cadena en mayusculas: " + cadena1);
cadena1 = cadena1.ToLower();
Console.WriteLine("Cadena en minusculas: " + cadena1);

Console.WriteLine("Cadena leida caracter por caracter:");
foreach (char c in cadena1){
    Console.WriteLine(c);
}

/*
● Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados (Revisar el comportamiento de split()) -> tampoco se a que se refiere con mostrar los resultados
*/

List<string> array = new List<string>();
array = cadena1.Split(' ').ToList();    //guardo cada palabra de la cadena en un array
	
//string[] array = cadena.Split(delimitador);

Console.WriteLine("Ingrese la palabra de la que quiere saber su ocurrencia: ");
string palabra = Console.ReadLine();
int cantOcurrencias = 0;

foreach (var l in array){
    if(l.CompareTo(palabra) == 0){
        cantOcurrencias ++;
    }
}
Console.WriteLine("Cantidad de veces que aparece " + palabra + " en " + cadena1 + ": " + cantOcurrencias);


Console.WriteLine("Ingrese otra cadena: ");
string cadena2 = Console.ReadLine();
Console.WriteLine("Cadena 1 y 2 unidas: " + cadena1 + " " + cadena2);

int valor = cadena1.CompareTo(cadena2);
if(valor == 0){
    Console.WriteLine("Las cadenas 1 y 2 son iguales");
}else{
    if(valor<0){
        Console.WriteLine("La cadena 1 es lexicograficamente menor que la cadena 2");
    }else{
        Console.WriteLine("La cadena 1 es lexicograficamente mayor que la cadena 2");
    }
}

/*
● Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado. Por ejemplo para la suma sería:
“la suma de “ num1 “ y de” num2 “ es igual a: ” resultado.
Donde num1, num2 y resultados son los sumandos y el resultado de la operación respectivamente.
Nota: Busque el comportamiento del Método ToString();
*/

Console.WriteLine("\nUtilizando la calculadora del ejercicio 2:");
Console.WriteLine("Que operacion desea realizar?");
Console.WriteLine("SUMAR-> 1  -  RESTAR-> 2  -  MULTIPLICAR-> 3  -  DIVIDIR-> 4 :  ");
int opcion1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese un numero:");
int num4 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese otro numero:");
int num5 = Convert.ToInt32(Console.ReadLine());
int resultado1 = CalculadoraV1(opcion1, num4,num5);

string operacion;
if(opcion1 == 1){
   operacion = "suma"; 
}else{
    if (opcion1 == 2){
        operacion = "resta"; 
    }else{
        if(opcion1 == 3){
            operacion = "multiplicacion"; 
        }else{
            operacion = "division"; 
        }
    }
}
Console.WriteLine("La {0} de {1} y de {2} es igual a: {3}", operacion, num4.ToString(), num5.ToString(), resultado1.ToString());


/* 
● Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva. Por ej. ingrese por pantalla “582+2” y que le devuelva la suma de 582 con 2
*/

Console.WriteLine("Ingrese una ecuacion (Simbolos: Suma-> +, Resta-> -, Multiplicacion-> x, Division-> / ): ");
string ecuacion = Console.ReadLine();
string[] ecuacionDividida ;
int opcion2 = 0;

if(ecuacion.Contains('+')){
    ecuacionDividida = ecuacion.Split('+');
    opcion2 = 1;
}else{
    if(ecuacion.Contains('-')){
        ecuacionDividida = ecuacion.Split('-');
        opcion2 = 2;
    }else{
        if(ecuacion.Contains('x')){
            ecuacionDividida = ecuacion.Split('x');
            opcion2 = 3;
        }else{
            ecuacionDividida = ecuacion.Split('/');
            opcion2 = 4;
        }
    }
}

int resultado2 = CalculadoraV1(opcion2, Convert.ToInt32(ecuacionDividida[0]), Convert.ToInt32(ecuacionDividida[1]));

Console.WriteLine("{0} = {1}", ecuacion, resultado2.ToString());


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
