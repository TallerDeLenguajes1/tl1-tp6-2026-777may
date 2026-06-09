// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un texto: ");
String Texto1 = Console.ReadLine();
Console.WriteLine($"""
    La longitud de {Texto1} es de: {Texto1.Length}
""");
Console.WriteLine("Ingrese otro texto: ");
String Texto2 = Console.ReadLine();
Console.WriteLine($"""
    //*La cadena {Texto1} con la cadena {Texto2} forman: {Texto1.Concat(Texto2)}
""");
