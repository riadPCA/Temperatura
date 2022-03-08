using System;

class Program {
  public static void Main (string[] args) {
double Type, C, F,Resultado;
    Console.WriteLine("¿Que escala Termica desea convertir?" );
    Console.WriteLine("Para Celsius ingrese 1" );
    Console.WriteLine("Para fahrenheit ingrese 2");
    Type = Convert.ToDouble(Console.ReadLine());
    switch (Type)
    {
        case 1:
            Console.WriteLine("Ingrese Los Celsius que desea convertir a fahrenheit");
            C = Convert.ToDouble(Console.ReadLine());
            Resultado=C * 1.8 + 32;
            Console.WriteLine("El equivalente de "+C+"ºC a fahrenheit es:           "+Resultado+"ºF");
            break;

        case 2:
            Console.WriteLine("Ingrese Los fahrenheit que desea convertir a Celsius");
            F = Convert.ToDouble(Console.ReadLine());
            Resultado=(F-32) / 1.8;
            Console.WriteLine("El equivalente de "+F+"ºF a Celsius es: "+Resultado+"ºC");
            break;
       default:
            Console.WriteLine("Numero no valido");
            break;
      
    }
  }
}


