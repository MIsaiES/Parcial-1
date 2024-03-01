double n1=0, n2=0;
char oper='0';

do
{
	try
	{
		Console.WriteLine("Ingrese el Primer Numero");
		n1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el Segundo Numero");
        n2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese un Operador (+, -, *, /)");
        oper = (char)Console.Read();
		
		if (oper == '+' || oper == '-' || oper == '*' || oper == '*')
		{
			
		}
		else
		{
			Console.WriteLine("OPERADOR INVALIDO");
			oper = '0';
		}
    }
	catch (Exception)
	{
		Console.WriteLine("DATO INVALIDO");
		Console.ReadLine();
		Console.Clear();
		n1=0; n2=0;oper = '0';
	}
} while (n1==0 || n2==0 || oper=='0');

switch (oper)
{
	case '+':
		Console.WriteLine(n1 + " " + oper + " " + n2 + " = " + (n1+n2));
		break;
	case '-':
        Console.WriteLine(n1 + " " + oper + " " + n2 + " = " + (n1-n2));
        break;
	case '*':
        Console.WriteLine(n1 + " " + oper + " " + n2 + " = " + (n1*n2));
        break;
	case '/':
        Console.WriteLine(n1 + " "+ oper+ " " + n2 + " = " + (n1/n2));
        break;
    default:
		Console.WriteLine("Datos Ingresados Invalidos");
		break;
}