decimal precio=0;

Console.WriteLine("Ingrese el Precio del Producto");
try
{
    precio = Convert.ToDecimal(Console.ReadLine());
}
catch (Exception)
{
    Console.WriteLine("Ingreso de Datos Invalido");
}
if (precio >= 100)
{
    Console.WriteLine("Felicidades, Este producto recibira un descuento del 10%");
    precio = precio - (precio/10);
}
else
{
    Console.WriteLine("Su compra NO califica para ningun descuento");
}
Console.WriteLine("El total a pagar es de: " + precio);