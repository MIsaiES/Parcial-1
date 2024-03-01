int cont = 0;
uint op ,num=0;
double r;

do
{
    Console.WriteLine("Ingrese un Numero (Entero y Positivo)");
    uint.TryParse(Console.ReadLine(), out num);

    if (num == 0)
    {
        Console.WriteLine("Valor Ingresado INVALIDO");
    }
    else
    {
        Console.WriteLine("Ingrese la Operacion que desea Realizar");
        Console.WriteLine("1.Factorial\n2.Raiz Cuadrada\n3.Salir del Programa");
        uint.TryParse(Console.ReadLine(), out op);

        switch (op)
        {
            case 0:
                Console.WriteLine("Opcion Invalida");
                break;
            case 1:
                r = 1;
                for (int i = 1;i<=num; i++)
                {
                    r =r*i;
                }
                Console.WriteLine("El Factorial del Numero Ingresado es: " + r);
                break;
            case 2:
                r = Math.Sqrt(num);
                Console.WriteLine("La Raiz Cuadrada del numero Ingresado es : " + r);
                break;
            case 3:
                Console.WriteLine("Cerrando el Programa");
                cont++;
                break;
            default:
                Console.WriteLine("Opcion Invalida");
                break;
        }
    }
    Console.ReadLine();
    Console.Clear();
}while (cont==0);
