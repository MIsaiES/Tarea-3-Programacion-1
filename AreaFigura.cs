double x, y, r;
int op=0;

Console.WriteLine("¿Que Area desea Calcular?");
Console.WriteLine("1.Triangulo\n2.Cuadrado\n3.Circulo");
try
{
op = Convert.ToInt16(Console.ReadLine());
}
catch(Exception)
{
	Console.WriteLine("Ingreso de Datos INVALIDO");
}

switch (op)
{
	case 1:
		Console.WriteLine("Ingrese la Base del Triangulo");
		x= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la Altura del Triangulo");
		y= Convert.ToDouble(Console.ReadLine());
        r = (x * y) / 2;
		r= r*+1;
		Console.WriteLine("El Area del Triangulo es de: " +  r); 
		break;
	case 2:
        Console.WriteLine("Ingrese la Base del Cuadrado");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ingrese la Altura del Cuadrado");
        y = Convert.ToDouble(Console.ReadLine());
        r = x * y;
        r = r * +1;
		Console.WriteLine("El Area del Cuadrado es de: " + r);
        break;
	case 3:
		Console.WriteLine("Ingrese el Radio del Circulo");
		x = Convert.ToDouble(Console.ReadLine());
        r = (x * x)*3.1415926;
		Console.WriteLine("El Area del Circulo es de: " + r);
		break;
	default:
		Console.WriteLine("OPCION INVALIDA");
		break;
}
