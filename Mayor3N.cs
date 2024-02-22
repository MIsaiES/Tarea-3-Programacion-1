int n1, n2, n3;
Console.WriteLine("###### Mayor de tres Numeros ######");

try
{
    Console.WriteLine("Ingrese un Numero");
    n1 = Convert.ToInt16(Console.ReadLine());
}
catch (Exception) {
    Console.WriteLine("No se ingreso un Numero Valido"); 
    Console.WriteLine("Ingrese un Numero");
    n1 = Convert.ToInt16(Console.ReadLine());
}
try
{
    Console.WriteLine("Ingrese un Segundo Numero");
    n2 = Convert.ToInt16(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("No se ingreso un Numero Valido");
    Console.WriteLine("Ingrese un Segundo Numero");
    n2 = Convert.ToInt16(Console.ReadLine());
}
try
{
    Console.WriteLine("Ingrese un Tercer Numero");
    n3 = Convert.ToInt16(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("No se ingreso un Numero Valido");
    Console.WriteLine("Ingrese un  Tercer Numero");
    n3 = Convert.ToInt16(Console.ReadLine());
}

if (n1 >= n2 && n1 >= n3)
{
    Console.WriteLine("El mayor Numero ingresado fue: " + n1);
}
else if (n2 >= n3)
{
    Console.WriteLine("El mayor numero ingresado fue: " + n2);
}
else
{
    Console.WriteLine("El mayor numero ingresado fue: " +n3);
}
