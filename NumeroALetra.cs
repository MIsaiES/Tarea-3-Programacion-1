int op, n;
string num;

Console.WriteLine("Ingrese un Numero del 1 al 5 como LETRAS (uno, dos, etc)");
num = Console.ReadLine().ToLower();

switch (num)
{
	case "uno":
		n = 1;
		Console.WriteLine("El numero ingresado es: " + n);
		break;
	case "dos":
		n = 2;
        Console.WriteLine("El numero ingresado es: " + n);
        break;
	case "tres":
		n = 3;
        Console.WriteLine("El numero ingresado es: " + n);
        break;
	case "cuatro":
		n = 4;
        Console.WriteLine("El numero ingresado es: " + n);
        break;
	case "cinco":
		n = 5;
        Console.WriteLine("El numero ingresado es: " + n);
        break;
	default:
		Console.WriteLine("Valor Invalido");
		break;
}