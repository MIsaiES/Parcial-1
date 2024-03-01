int randnum, num;

Random rand = new Random();
randnum = rand.Next(1, 101);

Console.WriteLine("Adivina un Numero entre 1 y 100");
do
{
    int.TryParse(Console.ReadLine(), out num);
    if (num>randnum)
    {
        Console.WriteLine("El Numero es Menor a " +  num);
        Console.WriteLine("Intenta de nuevo");
    }
    else if (num < randnum)
    {
        Console.WriteLine("El Numero es Mayor a " + num);
        Console.WriteLine("Intenta de nuevo");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("************FELICIDADES************\n\tADIVINASTE EL NUMERO\n***********************************");
        Console.ReadLine();
    }
} while (num!=randnum);