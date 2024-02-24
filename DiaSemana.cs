int dia=0;

Console.WriteLine("Ingrese El numero de Dia que desea ver (1 a 7)");
try
{
    dia = Convert.ToUInt16(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Ingreso de datos INVALIDO");
}

switch (dia)
{
    case 1:
        Console.WriteLine("El dia correspondiente es el: LUNES");
        break;
    case 2:
        Console.WriteLine("El dia correspondiente es el: MARTES");
        break;
    case 3:
        Console.WriteLine("El dia correspondiente es el: MIERCOLES");
        break;
    case 4:
        Console.WriteLine("El dia correspondiente es el: JUEVES");
        break; 
    case 5:
        Console.WriteLine("El dia correspondiente es el: VIERNES");
        break;
    case 6:
        Console.WriteLine("El dia correspondiente es el: SABADO");
        break;
    case 7:
        Console.WriteLine("El dia correspondiente es el: DOMINGO");
        break;
    default:
        Console.WriteLine("VALOR INVALIDO");
        break;
}