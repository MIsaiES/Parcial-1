double num;

Console.WriteLine("Ingrese un Numero");
double.TryParse(Console.ReadLine(), out num);

if (num == 0)
{
    Console.WriteLine("DATO INVALIDO");
}
else
{
    Console.WriteLine("TABLA DE MULTIPICACIONES");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine("\t" + i + " * "+ num +" = " + num * i);
    }
}