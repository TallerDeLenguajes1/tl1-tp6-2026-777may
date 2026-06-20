// Expresiones Regulares
// Busque en diferentes bibliografías que son y cómo funcionan las expresiones regulares.
Las clases expresiones regulares son un conjunto de caracteres que especifican el patrón que debería tener una expresión. Funcionan con simbolos que se interpretan según un estandar.
// ● ¿Funcionan únicamente en C#?
No, funciona en todos los lenguajes que puedan procesar este tipo de expresiones.
// ● ¿En qué casos le parecen útiles? Enuncie al menos 3.
Para corroborar que se cumpla un patrón de mail o contraseña, para buscar algo específico a modificar en un texto o para identificar patrones de enlaces o directorios.
// ● ¿Cómo se hace uso de estas en C#?
A través de la clase Regex que provee .NET.
Tiene reglas sobre cómo se escriben los patrones, por ejemplo:
\d n° 0-9
\w letra o n°
\W cualquier cosa que NO sea letra o n°
\s espacio vacio
. cualquier caractér
^   $ inician y terminan un patron de texto
+ indica que algo se deben repetir al menos una vez
* indica que se debe repetir 0, 1 o más veces
{n}  indica que se debe repetir n veces
[] crea grupos o rangos de búsqueda

EJ1: ^[A-Z]{3}\d{3}$
(Traducción: Comienza (^) con 3 letras mayúsculas, sigue con 3 dígitos (\d), y ahí termina el texto ($)).
Match: AAA123

EJ2:^.+@.+\..+$
(Traducción: Empieza (^) con algo de texto (.+), un @, más texto (.+), un punto real (\., se le pone la barra para avisar que es un punto de verdad y no el comodín), y termina ($) con más texto).
Match: alumno@facultad.com



EJ1:  bool esValido = Regex.IsMatch(texto, patronACumplir) 
EJ2:  string parteDeTexto = Regex.Match("El total a pagar es de $15450 pesos.", @"Total a pagar es de \$(\d+)", RegexOptions.IgnoreCase);
EJ3:  var multiplesCoincidencias = Regex.Matches(texto, patronBuscado, <Opcional>RegexOptions.IgnoreCase);
EJ4: string textoLimpio = Regex.Replace(textoALimpiar, patronLimpieza, conQueSeReemplaza);
string textoLimpio = Regex.Replace(Hola... ¿cómo estás? ¡Todo bien por acá, 100%!", @"[^\w\s]", ""); QUITA TODO LO QUE NO SEA LETRA O ESPACIO (Resultado: Hola cómo estás Todo bien por acá 100)


AYUDA: 
Ignorar Mayúsculas/Minúsculas fácilmente: En vez de volverte loco poniendo [a-zA-Z], podés pasarle un tercer parámetro a las funciones llamado RegexOptions.IgnoreCase.

Rendimiento (Si se usa muchas veces): Si vas a usar el mismo Regex adentro de un bucle while o foreach que da miles de vueltas, no uses el método estático. Conviene crear una instancia del objeto para que C# compile el autómata una sola vez en memoria:

EJ:
// Creás el objeto una sola vez afuera del bucle
Regex miValidador = new Regex(@"^\d+$", RegexOptions.Compiled);

while(quiereContinuar) {
    // Es mucho más rápido en ejecuciones masivas
    if (miValidador.IsMatch(Console.ReadLine())) { ... } 
}