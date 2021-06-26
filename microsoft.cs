/* 
12)Mostrar los nùmeros impares entre el 0 y el 100
13) Mostrar los números pares entre el 0 y el 100
14) Mostrar los números del 0 al 100
15) Mostrar los números del 100 al 0
16) Mostrar los multiplos de 3 del 0 al 100
17) Mostrar los multiplos de 3 y de 2 entre el 0 y 100
 */
 
using System;

class ejercicio
{
    static void Main()
    {
        int i, impar = 0, par = 0;

        for (i = 0; i < 100; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write("{0}|", i);
                impar++;
            }
        }

        Console.Write("\n\n");
        // EJERCICIO 13 ////////////////////////////////////
        for (i = 1; i < 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write("{0}|", i);
                par++;
            }
        }
        Console.Write("\n\nDel 0 al 100 hay {0} números pares y {1} impares\n\n", par, impar);
        // EJERCICIO 14 /////////////////////////////////////
        for(i= 0;i<101;i++)
               Console.Write("{0}|",i);
       
        Console.Write("\n\n");
        // EJERCICIO 15 ///////////////////////////////////////
        for (i = 100; i > -1; i--)
            Console.Write("{0}|", i);

        Console.Write("\n\n");
        // EJERCICIO 16 ////////////////////////////////////////
        for(i = 0; i < 100; i++)
            if(i % 3 == 0)
                Console.Write("{0}|",i);

        Console.Write("\n\n");
        // EJERCICIO 17 /////////////////////////////////////////
        for (i = 0; i < 100; i++)
            if (i % 3 == 0 || i % 2 == 0)
                Console.Write("{0}|", i);

        Console.Read();

    }
}