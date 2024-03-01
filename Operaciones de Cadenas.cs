string cadena1, cadena2, nom, apll;
int op, cont=0;

Console.WriteLine("Introduzca una Cadena de Texto");
cadena1 = Console.ReadLine();

do
{
    Console.WriteLine("¿Que desea Hacer con esta Cadena?");
    Console.WriteLine("1.Comparar Cadenas\n2)Concatenar Cadenas\n3)Empieza Con\n4)Formato de Cadenas\n5.SALIR");
    op = Convert.ToInt32(Console.ReadLine());
    switch (op)
    {
        case 1:
            Console.WriteLine("Introduzca una Cadena para Comparar con la Cadena existente");
            cadena2 = Console.ReadLine();

            if (cadena1.CompareTo(cadena2) == 0)
            {
                Console.WriteLine("Las Cadenas son Equivalentes");
            }

            else
            {
                Console.WriteLine("Las Cadenas NO son Equivalentes");
            }
            break;
        case 2:
            Console.WriteLine("Ingrese la Cadena que desea concatenar con la Cadena Actual");
            cadena2 = Console.ReadLine();

            cadena1 = cadena1 + cadena2;
            Console.WriteLine("Cadenas Concatenadas: " + cadena1);
            break;

        case 3:

            Console.WriteLine("¿Que Subcadena desea Revisar al Inicio?");
            cadena2 = Console.ReadLine();

            if (cadena1.StartsWith(cadena2) == true)
            {
                Console.WriteLine("La Cadena inicial Empieza con: " + cadena2);
            }
            else
            {
                Console.WriteLine("La Cadena inicial NO Empieza con: " + cadena2);
            }
            break;
        case 4:
            Console.WriteLine("ESTA ES UNA DEMOSTRACION SOBRE FORMATOS DE CADENAS");
            Console.WriteLine("Ingrese su Nombre");
            nom = Console.ReadLine();

            Console.WriteLine("Ingrese un Apellido");
            apll = Console.ReadLine();

            Console.WriteLine("Hola {0} {1}", nom, apll);

            break;
        case 5:
            Console.WriteLine("CERRANDO EL PROGRAMA");
            cont++;
            break;
    }
    Console.ReadLine();
    Console.Clear();
}while (cont==0);