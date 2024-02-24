int op=0;

try
{
    Console.WriteLine("¿Que Servicio desea Pagar?");
    Console.WriteLine("1.Lavado de Auto\n2.Cambio de Aceite\n3.Revision Mecanica");
    op = Convert.ToUInt16(Console.ReadLine());
}
catch(Exception)
{
    Console.WriteLine("Ingreso de datos INVALIDO");
}

switch (op)
{
    case 0:
        break;
    case 1:
        Console.WriteLine("Su Total a pagar es de : Q30");
        break;
    case 2:
        Console.WriteLine("Su Total a pagar es de : Q70");
        break;
    case 3:
        Console.WriteLine("Su Total a pagar es de : Q300");
        break;
    default:
        Console.WriteLine("OPCION INVALIDA");
        break;
}