string texto;
double num;
bool exito;
Console.WriteLine("Ingrese un numero:");
texto = Console.ReadLine();
exito = double.TryParse(texto, out num);

if (exito)
{
    Console.WriteLine("El numero es: " + num);
    Console.WriteLine("Su inverso es: 1/" + num + " = " + 1/num);
    num = 1/num;
}else
{
    Console.WriteLine("Lo ingresado no era un numero");
}