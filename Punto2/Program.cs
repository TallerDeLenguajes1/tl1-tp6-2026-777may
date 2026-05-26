using System.Security.Cryptography.X509Certificates;

int opcion = 1;
double num1, num2;
while (opcion != 0)
{
    Console.WriteLine("Ingrese una opción:\n" + 
        "    1: para Sumar\n" + 
        "    2: para Restar\n" + 
        "    3: para Multiplicar\n" + 
        "    4: para Dividir\n\n" + 
        "0 para Salir");
    if (int.TryParse(Console.ReadLine(), out opcion) && opcion > 0 && opcion < 5)
    {
        Console.WriteLine("Ingrese el primer numero");
        if (double.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Ingrese el segundo numero");
            if (double.TryParse(Console.ReadLine(), out num2))
            {
                switch (opcion)
                {
                    case 1: Console.WriteLine ("La suma es: " + (num1+num2));
                        break;
                    case 2: Console.WriteLine ("La resta es: " + (num1-num2));
                        break;
                    case 3: Console.WriteLine ("El producto es: " + (num1*num2));
                        break;
                    case 4: if (num2 != 0) {Console.WriteLine ("La division es: " + (num1/num2));} else {Console.WriteLine("No se ha ingresado un divisor válido\n");};
                        break;
                }
                Console.WriteLine("\n¿Desea realizar otro cálculo?\n" + 
                    "1: Si, 0: No.");
                if (!int.TryParse(Console.ReadLine(), out opcion)  || opcion < 0 || opcion > 400)
                {
                    Console.WriteLine("No se ha ingresado una opción válida\n");
                    opcion = 1;
                }       
            }else{   
            Console.WriteLine("No se ha ingresado un número válido\n");
            }
            
        }else{   
            Console.WriteLine("No se ha ingresado un número válido\n");
        }

    }else{
        if(opcion != 0)
        {
            Console.WriteLine("No se ha ingresado una opción válida\n");
        }
    }
}
