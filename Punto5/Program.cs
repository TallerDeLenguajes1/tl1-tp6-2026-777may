// Ejercicio 5. (optativo)
// Expresiones Regulares. Resuelva las siguiente expresiones regulares:
// Construir un programa que permita identificar de forma sencilla si la cadena ingresada es una dirección web y otro que una cadena ingresada sea un mail válido.

using System.Text.RegularExpressions;

string texto;
string patronWeb = @"^https?://www\..+\.(com|org|net|co|io)/?.*$";
do
{
    Console.WriteLine($""" Ingrese una dirección web: """);
    texto = Console.ReadLine();
} while (!Regex.IsMatch(texto, patronWeb));
//while (Regex.Match(texto, patronWeb).Success);

string patronMail = @"^([\w\.\-]+[._\-\+\*\!]+[\w\.\-]*|[._\-\+\*]+[\w\.\-]+)@([\w\-]+)\.(com|edu|gob|gov|net|org|mil|biz)(\.(ar|es|mx|co|cl|uk))?$";
// string patronImpecable = @"^([\w\.\-]+[._\-\+]+[\w\.\-]*|[._\-\+]+[\w\.\-]+)@([\w\-]+)\.(com|edu|gob|gov|net|org|mil|biz)(\.(ar|es|mx|co|cl|uk))?$"
// string patronLimpio = @"^(?=.*[._\-])[\w._\-]+@[\w\-]+\.(com|edu|gob|gov|net|org|mil|biz)(\.(ar|es|mx|co|cl|uk))?$";
// Usé una herramienta avanzada de Regex llamada Lookahead (Mirada hacia adelante), que se escribe (?= ... ).

//     (?=.*[._\-]): Esto es un inspector secreto. Antes de empezar a validar el mail, mira rápidamente hacia adelante en el texto y dice: "Che, me aseguro de que haya al menos un punto ., un guion bajo _ o un guion -" (los símbolos válidos de un mail). Si no encuentra ninguno, frena y da false.

//     [\w._\-]+: Si el inspector dio el OK, acá lee el nombre de usuario normal (letras, números y los símbolos).

//     @[\w\-]+\.: El @ obligatorio, el nombre del servidor (ahora con + para que acepte palabras largas como gmail o outlook), y el punto real.

//     El final: Tus bloques de dominios (.com, .edu) y países (.ar), que estaban perfectos.
do
{
    Console.WriteLine($""" Ingrese un mail: """);
    texto = Console.ReadLine();
} while (!Regex.IsMatch(texto, patronMail));

