string usuario = "usuario", contraseña = "contraseña";
string IngresoUs, IngresoCÑ;

Console.WriteLine("Ingrese el nombre de Usuario");
IngresoUs =Console.ReadLine();

Console.WriteLine("Ingrese la Contraseña");
IngresoCÑ =Console.ReadLine();

if (IngresoUs ==usuario && IngresoCÑ == contraseña)
{
    Console.WriteLine("Sesion iniciada Exitosamente");
}
else
{
    Console.WriteLine("Usuario o Contraseña INCORRECTOS");
}
