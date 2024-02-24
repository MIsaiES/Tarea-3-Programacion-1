int edad = 0;

try
{
    Console.WriteLine("Ingrese su Edad");
    edad = Convert.ToUInt16(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Ingreso de Datos INVALIDO");
}
if (edad >= 18)
{
    Console.WriteLine("Ingreso Permitido, BIENVENIDO");
}
else
{
    Console.WriteLine("INGRESO DENEGADO");
}
