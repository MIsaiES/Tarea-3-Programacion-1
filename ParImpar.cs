int n;

Console.WriteLine("Ingrese un Numero");
n = Convert.ToInt16(Console.ReadLine());

if (n==0)
{
    Console.WriteLine("Ingreso el Numero 0 (Numero Neutro)");
}
else if (n%2==0)
{
    Console.WriteLine("El numero es Par");
}
else
{
    Console.WriteLine("El numero es Impar");
}
