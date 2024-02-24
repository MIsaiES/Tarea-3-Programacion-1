int edad;
decimal monto;

Console.WriteLine("Ingrese su Edad");
edad = Convert.ToUInt16(Console.ReadLine());

Console.WriteLine("Ingrese el Monto del Prestamo");
monto = Convert.ToDecimal(Console.ReadLine());

if (edad>60 && monto>0 || monto>0 && monto<5000)
{
    Console.WriteLine("Prestamo Garantizado");
}
else
{
    Console.WriteLine("Prestamo RECHAZADO");
}
