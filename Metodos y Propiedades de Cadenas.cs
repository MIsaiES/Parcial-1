string cadena, con_cadena , ocurr, reemplazo;
int op=0, cont=0, n;

Console.WriteLine("Ingrese un Cadena de Texto");
cadena = Console.ReadLine();

do
{
    op = 0;
    Console.WriteLine("¿Que desea hacer con esta Cadena de Texto?");
    Console.WriteLine("1.Obtener Longitud\n2.Convertir a Mayusculas\n3.Convertir a Minusculas\n4.Busqueda de Ocurrencias");
    Console.WriteLine("5.Extraer una Subcadena\n6.Reemplazar una Subcadena\n7.Eliminar Espacios\n8.Eliminar Vocales");
    Console.WriteLine("9.Concatenar con otra Cadena\n10.Ingresar la Cadena de nuevo\n11.SALIR");
    int.TryParse(Console.ReadLine(), out op );

    switch (op)
    {
        case 0:
            Console.WriteLine("OPCION INVALIDA");
            break;
        case 1:
            Console.WriteLine("La Longitud de la Cadena es: "+ cadena.Length);
            break;
        case 2:
            cadena = cadena.ToUpper();
            Console.WriteLine("Cadena en Mayusculas: " + cadena);
            break;
        case 3:
            cadena = cadena.ToLower();
            Console.WriteLine("Cadena en minusculas: " + cadena);
            break;
        case 4:
            Console.WriteLine("Ingrese la Ocurrencia que desea buscar en la cadena");
            ocurr = Console.ReadLine();

            Console.WriteLine("La Primera instancia se encuentra en la posicion: " + (cadena.IndexOf(ocurr)+1));
            Console.WriteLine("La Ultima instancia se encuentra en la posicion: "+ (cadena.LastIndexOf(ocurr)+1));
            break;
        case 5:
            Console.WriteLine("Ingrese la posicion de la Subcadena que desea Extraer (1 a " + cadena.Length + ")");
            int.TryParse (Console.ReadLine(), out n );

            Console.WriteLine("Subcadena: " + cadena.Substring(n-1));
            break;
        case 6:
            Console.WriteLine("Ingrese la Subcadena que desea Reemplazar");
            ocurr = Console.ReadLine ();

            Console.WriteLine("Ingrese la cadena con la que sera Reeplazada");
            reemplazo = Console.ReadLine();

            cadena = cadena.Replace(ocurr, reemplazo);
            Console.WriteLine("Cadena Reemplazada: " + cadena);
            break;
        case 7:
            cadena = cadena.Trim();
            Console.WriteLine("Cadena sin Vocales: " + cadena);
            break;
        case 8:
            cadena = cadena.Trim('a', 'e', 'i', 'o', 'u');
            Console.WriteLine("Cadena sin Vocales: " + cadena);
            break;
        case 9:
            Console.WriteLine("Ingrese la Cadena que desea concatenar con la Cadena Actual");
            con_cadena = Console.ReadLine();

            cadena= cadena + con_cadena;
            Console.WriteLine("Cadenas Concatenadas: " + cadena);
            break;
        case 10:
            Console.WriteLine("Ingrese un Cadena");
            cadena = Console.ReadLine();
            break;
        case 11:
            Console.WriteLine("CERRANDO EL PROGRAMA");
            cont++;
            break;
        default:
            Console.WriteLine("OPCION INVALIDA");
            break;
    }
    Console.ReadLine();
    Console.Clear();
} while (cont==0);