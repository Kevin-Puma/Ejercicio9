 Console.WriteLine("Ingrese el primer número:");
int numero1 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número:");
int numero2 = int.Parse(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número:");
int numero3 = int.Parse(Console.ReadLine());

if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
{
int mayor = numero1;

if (numero2 > mayor)
{
mayor = numero2;
}

if (numero3 > mayor)
{
mayor = numero3;
}

Console.WriteLine("El mayor de los tres números es: " + mayor);
}
else
{
Console.WriteLine("Los números deben ser diferentes.");
}