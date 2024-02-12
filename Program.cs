// See https://aka.ms/new-console-template for more information
Console.WriteLine("Contraseña");
Console.WriteLine();

{
   
    string contraseñaCorrecta = "No me la sé";

   
    int intentos = 3;

    while (intentos > 0)
    {
        
        Console.WriteLine("Ingrese la contraseña:");
        string contraseñaIngresada = Console.ReadLine();

        if (contraseñaIngresada == contraseñaCorrecta)
        {
            Console.WriteLine("Contraseña correcta. ¡Acceso concedido!");
            break; 
        }
        else
        {
            intentos--;
            if (intentos > 0)
            {
                Console.WriteLine("Contraseña incorrecta. Le quedan " + intentos + " intentos.");
            }
            else
            {
                Console.WriteLine("Ha agotado el número de intentos. Acceso denegado.");
            }
        }
    }
}



