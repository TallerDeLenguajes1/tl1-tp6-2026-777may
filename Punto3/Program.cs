// // Dada una cadena (un string) de texto ingresada por el usuario
// Console.WriteLine("Ingrese un texto: ");
// string Texto1 = Console.ReadLine();
// // Obtener la longitud de la cadena y muestre por pantalla
// Console.WriteLine($"""
//     La longitud de {Texto1} es de: {Texto1.Length}
// """);
// // A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas.
// // &Extraer una subcadena de la cadena ingresada.
// Console.WriteLine("Ingrese otro texto: ");
// string Texto2 = Console.ReadLine();
// Console.WriteLine($"""
//     La cadena {Texto1} con la cadena {Texto2} forman: {String.Concat(Texto1, Texto2)}
//     La subcadena es: {Texto1.Substring(Texto1.Length/2)}
// """);

// // Utilizando la calculadora creada anteriormente realizar las operaciones de dos números y mostrar por pantalla y mostrar en texto el resultado.

// int opcion = 1;
double num1 = 0, num2 = 0;
// while (opcion != 0)
// {
//     Console.WriteLine("Ingrese una opción:\n" +
//         "    1: para Sumar\n" +
//         "    2: para Restar\n" +
//         "    3: para Multiplicar\n" +
//         "    4: para Dividir\n" +
//         "    5: para Operaciones Varias\n" +
//         "    6: para Comparar mayor entre dos numeros\n\n" +
//         "0 para Salir");
//     if (int.TryParse(Console.ReadLine(), out opcion) && opcion > 0 && opcion < 7)
//     {
//         if (opcion != 5)
//         {
//             Console.WriteLine("Ingrese el primer num");
//             if (double.TryParse(Console.ReadLine(), out num1))
//             {
//                 Console.WriteLine("Ingrese el segundo num");
//                 if (double.TryParse(Console.ReadLine(), out num2))
//                 {
//                     switch (opcion)
//                     {
//                         case 1:
//                             Console.WriteLine("La suma es: " + (num1 + num2).ToString());
//                             break;
//                         case 2:
//                             Console.WriteLine("La resta es: " + (num1 - num2).ToString());
//                             break;
//                         case 3:
//                             Console.WriteLine("El producto es: " + (num1 * num2).ToString());
//                             break;
//                         case 4:
//                             if (num2 != 0) { Console.WriteLine("La division es: " + (num1 / num2).ToString()); } else { Console.WriteLine("No se ha ingresado un divisor válido\n"); };
//                             break;
//                         case 6:
//                             Console.WriteLine($"""
//                                 El maximo entre los dos numeros es: {(Math.Max(num1, num2)).ToString()}
//                                 El minimo entre los dos numeros es: {(Math.Min(num1, num2)).ToString()}
//                             """);
//                             break;
//                     }
//                     Console.WriteLine("\n¿Desea realizar otro cálculo?\n" +
//                         "1: Si, 0: No.");
//                     if (!int.TryParse(Console.ReadLine(), out opcion) || opcion != 0 && opcion != 1)
//                     {
//                         Console.WriteLine("No se ha ingresado una opción válida\n");
//                         opcion = 1;
//                     }
//                 }
//                 else
//                 {
//                     Console.WriteLine("No se ha ingresado un número válido\n");
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("No se ha ingresado un número válido\n");
//             }
//         }
//         else
//         {
//             Console.WriteLine("Ingrese el numero a operar");
//             if (double.TryParse(Console.ReadLine(), out num1))
//             {
//                 Console.WriteLine($"""
//                 Su valor absoluto es: {(Math.Abs(num1))} 
//                 Su cuadrado es: {(num1 * num1)}
//                 {(num1 >= 0 ? "Su raizcuadrada es: " + (Math.Sqrt(num1)).ToString() : ("Su raiz no pertenece a los reales"))}
//                 Su seno es: {(Math.Sin(num1))}
//                 Su coseno es: {(Math.Cos(num1))}
//                 Su parte entera es: {(Math.Truncate(num1))}
//                 """);
//                 Console.WriteLine("\n¿Desea realizar otro cálculo?\n" +
//                     "1: Si, 0: No.");
//                 if (!int.TryParse(Console.ReadLine(), out opcion) || opcion != 0 && opcion != 1)
//                 {
//                     Console.WriteLine("No se ha ingresado una opción válida\n");
//                     opcion = 1;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("No se ha ingresado un número válido\n");
//             }
//         }
//     }
//     else
//     {
//         if (opcion != 0)
//         {
//             Console.WriteLine("No se ha ingresado una opción válida\n");
//         }
//     }
// }


// // Recorrer la cadena de texto con un ciclo Foreach e ir mostrando elemento por elemento en pantalla
// foreach (char letra in Texto1){
//     Console.WriteLine(letra);
// }
// // Buscar la ocurrencia de una palabra determinada en la cadena ingresada
// int ocurrencia = Texto1.IndexOf("la", StringComparison.OrdinalIgnoreCase);
// if (ocurrencia >= 0)
// {
//     Console.WriteLine($"""La ocurrencia de "la" sucede en la letra {ocurrencia+1}""");
// }
// else
// {
//     Console.WriteLine("No hay ocurrencia alguna");
// }

// // Convierta la cadena a mayúsculas y luego a minúsculas.
// Console.WriteLine($"{Texto1} en mayusculas es {Texto1.ToUpper()} en minusculas es {Texto1.ToLower()}");

// // Ingrese una cadena separada por caracteres que usted determine y muestre por pantalla los resultados

// Console.WriteLine("""Ingrese una cadena con separador "." """);
// string Texto3 = Console.ReadLine();
// foreach(string oracion in Texto3.Split('.', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
// {
//     Console.WriteLine(oracion);
// }

// Siguiendo con el ejemplo de la calculadora (ejercicio 2) ingrese una ecuación simple como cadena de caracteres y que el sistema lo resuelva.  
string formula;
char operacion = 's';
string operadoresValidos = "+-*/m>s";

do
{
    Console.WriteLine ("Ingrese una operacion matematica con: \n"+
        "    m: para Operaciones Varias\n" +
        "    >: para Comparar mayor entre dos numeros\n\n" +
        "s: para Salir");
    formula = Console.ReadLine();
    if (formula != "s") operacion = BrindarOperacion(formula, out num1, out num2);
    if (operacion != 'x' && operacion != 's')
    {
        if (operacion != 'm')
        {
            switch (operacion)
            {
                case '+':
                    Console.WriteLine("La suma es: " + (num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("La resta es: " + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("El producto es: " + (num1 * num2));
                    break;
                case '/':
                    if (num2 != 0) { Console.WriteLine("La division es: " + (num1 / num2)); } else { Console.WriteLine("No se ha ingresado un divisor válido\n"); };
                    break;
                case '>':
                    Console.WriteLine($"""
                        El maximo entre los dos numeros es: {Math.Max(num1, num2)}
                        El minimo entre los dos numeros es: {Math.Min(num1, num2)}
                    """);
                    break;
            }
            Console.WriteLine("\n¿Desea realizar otro cálculo?\n" +
                "s: Si, n: No.");
            operacion = Console.ReadKey().KeyChar;
            if (!"sn".Contains(operacion))
            {
                Console.WriteLine("No se ha ingresado una opción válida\n");
            }
            else
            {
                if(operacion == 's')
                {
                    operacion = 'n';
                }else
                {
                    operacion = 's';
                }
            }

        }
        else
        {
            Console.WriteLine($"""
            Su valor absoluto es: {Math.Abs(num1)} 
            Su cuadrado es: {num1 * num1}
            {(num1 >= 0 ? "Su raizcuadrada es: " + Math.Sqrt(num1) : "Su raiz no pertenece a los reales")}
            Su seno es: {Math.Sin(num1)}
            Su coseno es: {Math.Cos(num1)}
            Su parte entera es: {Math.Truncate(num1)}
            """);
            Console.WriteLine("\n¿Desea realizar otro cálculo?\n" +
                "s: Si, n: No.");
            operacion = Console.ReadKey().KeyChar;
            if (!"sn".Contains(operacion))
            {
                Console.WriteLine("No se ha ingresado una opción válida\n");
            }
            else
            {
                if(operacion == 's')
                {
                    operacion = 'n';
                }else
                {
                    operacion = 's';
                }
            }
        }
    }
    else
    {
        if(operacion == 'x') Console.WriteLine("No se ha ingresado una opción válida\n");
    }
} while (operacion != 's');

// Busque en diferentes bibliografías que son y cómo funcionan las expresiones regulares.
// ● ¿Funcionan únicamente en C#?
// ● ¿En qué casos le parecen útiles? Enuncie al menos 3.
// ● ¿Cómo se hace uso de estas en C#?
// Resuelva las siguiente expresiones regulares
// Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido.

//* Funciones:
char ObtenerOperacion(String texto)
{
    foreach (var letra in operadoresValidos)
    {
        if (texto.Contains(letra))
        {
            return letra;
        }
    }
    return 'x';
}
char BrindarOperacion(string formula, out double n1, out double n2)
{
    char opcion = ObtenerOperacion(formula); //letra o X 
    if (opcion != 'x')
    {
        var partes = formula.Split(opcion, StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        int largo = partes.Length;
        if( largo == 1 || largo == 2)
        {
            if (double.TryParse(partes[0], out n1))
            {
                if (opcion == 'm')
                {
                    n2 = 0;
                    return opcion;
                }
                if(double.TryParse(partes[1], out n2)) return opcion;
            }
        }
    }
    n1 = 0;
    n2 = 0; 
    return 'x';
}