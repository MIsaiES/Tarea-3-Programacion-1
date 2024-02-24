int op=0;

Console.WriteLine("Lenguaje / Language / Langage");
Console.WriteLine("1.Español\n2.English\n3Français.");

try
{
	op = Convert.ToUInt16(Console.ReadLine());
}
catch (Exception)
{
	Console.WriteLine("Ingreso de datos INVALIDO");
}

switch (op)
{
	case 0:
		break;
	case 1:
		Console.WriteLine("Bienvenido");
		break;
	case 2:
        Console.WriteLine("Accueillir");
        break;
	case 3:
        Console.WriteLine("Welcome");
        break;
    default:
        Console.WriteLine("OPCION INVALIDA");
        break;
}