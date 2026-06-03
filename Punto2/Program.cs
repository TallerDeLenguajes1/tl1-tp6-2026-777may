// ! Seria bueno agregar Do While en vez de While

double numero1;
string solicitarNumero = "Ingrese un numero a operar:";
//como no hice el branch a partir de calculadoraV1 haré las cosas a media antes del merge
Console.WriteLine("Bienvenido. " + solicitarNumero);
double.TryParse(Console.ReadLine(), out numero1);
Console.WriteLine($"""
    Su valor absoluto es: {Math.Abs(numero1)} 
    Su cuadrado es: {numero1 * numero1}
    {(numero1 >=0 ? "Su raizcuadrada es: " + Math.Sqrt(numero1) : ("Su raiz no pertenece a los reales"))}
    Su seno es: {Math.Sin(numero1)}
    Su coseno es: {Math.Cos(numero1)}
    Su parte entera es: {Math.Truncate(numero1)}


""");
// a*a = 9   \|9 = 