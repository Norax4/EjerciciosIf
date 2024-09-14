using System;
using System.Text;
//1


Console.WriteLine("Ingrese su calificación: ");
string answer = Console.ReadLine();
int calif = int.Parse(answer);

/*if (int.Parse(answer) != null)
{
    calif = int.Parse(answer);
} else
{
    Console.WriteLine("Valor no válido");
}*/ //Intento de comprobación de ingreso de números

if (calif <= 12 && calif > 9)
{
    Console.WriteLine("Sobresaliente");
} else if (calif <= 9 && calif > 5)
{
    Console.WriteLine("Aceptable");
} else if (calif <= 5 && calif >= 1)
{
    Console.WriteLine("Reprobado");
} else
{
    Console.WriteLine("Valor no válido");
}

//2


Console.WriteLine("Ingrese su edad: ");
string answer2 = Console.ReadLine();
int age = int.Parse(answer2);

if (age <= 12 && age > 0)
{
    Console.WriteLine("Usted es un niño");
} else if (age <= 17 && age > 12)
{
    Console.WriteLine("Usted es un adolescente");
} else if (age > 18)
{
    Console.WriteLine("Usted es un adulto");
} else
{
    Console.WriteLine("Valor no válido");
}

//3

Console.WriteLine("Ingrese el precio de su compra: ");
string priceString = Console.ReadLine();
int price = int.Parse(priceString); 

Console.WriteLine("Ingrese el porcentaje de descuento: ");
string discountString = Console.ReadLine();
int discount = int.Parse(discountString);

if (discount <= 100 && discount >= 0)
{
    Console.WriteLine("El precio final de su compra es: $" + (price - (price * discount)/100));
} else
{
    Console.WriteLine("El valor insertado para el descuento es inválido.");
}

//4

Console.WriteLine("Ingrese un número: ");
string answer4 = Console.ReadLine();
int number = int.Parse(answer4);

if (number > 0)
{
    Console.WriteLine("El número es positivo.");
} else if (number < 0)
{
    Console.WriteLine("El número es negativo.");
} else {
    Console.WriteLine("El número es 0.");
}

//5

Console.WriteLine("Ingrese el número de mes: ");
string answer5 = Console.ReadLine();
int month = int.Parse(answer5);

if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
{
    Console.WriteLine("El mes tiene 31 días");
} else if (month == 4 || month == 6 || month == 9 || month == 11)
{
    Console.WriteLine("El mes tiene 30 días");
} else if (month == 2)
{
    Console.WriteLine("El mes tiene 28 días");
} else
{
    Console.WriteLine("El valor ingresado es inválido");
}

//6

Console.WriteLine("Ingrese un número: ");
string answer6 = Console.ReadLine();
int number2 = int.Parse(answer6);

string result = ((number2 % 2) == 0) ? "El número es par." : "El número es impar.";
Console.WriteLine(result);

//7

Console.WriteLine("Ingrese el primer número: ");
string firstNumString = Console.ReadLine();
int firstNum = int.Parse(firstNumString);

Console.WriteLine("Ingrese el segundo número: ");
string secondNumString = Console.ReadLine();
int secondNum = int.Parse(secondNumString);

string result7 = (firstNum == secondNum) ? "Ambos números son iguales" : (firstNum > secondNum) ? "El primer número es mayor" : "El segundo número es mayor";
Console.WriteLine(result7);
//8

Console.WriteLine("Ingrese el año elegido: ");
string answer8 = Console.ReadLine();
int year = int.Parse(answer8);

string result8 = ((year % 400) == 0) ? "El año es bisiesto." : "El año no es bisiesto.";
Console.WriteLine(result8);
//9

Console.WriteLine("Ingrese su calificación: ");
string answer9 = Console.ReadLine();
int number3 = int.Parse(answer9);

string result9 = (number3 == 0) ? "Cero" : (number3 > 0) ? "Positivo" : "Negativo";
Console.WriteLine(result9);

//10

Console.WriteLine("Ingrese el primer número: ");
string firstNumStr = Console.ReadLine();
int firstNumb = int.Parse(firstNumStr);

Console.WriteLine("Ingrese el segundo número: ");
string secondNumStr = Console.ReadLine();
int secondNumb = int.Parse(secondNumStr);

string result10 = ((firstNumb % secondNumb) == 0) ? "El primer número es múltiplo del segundo" : "El primer número no es múltiplo del segundo.";
Console.WriteLine(result10);