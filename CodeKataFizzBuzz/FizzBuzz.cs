/*
 Imagínate el siguiente escenario. Tienes 11 años y en los últimos 5 minutos del final de la lección, tu profesor de matemáticas 
 * decide hacer la clase mas divertida, introduciendo un juego. El explica que irá señalando a cada compañero de clase en orden
 * y preguntándole el siguiente número de la secuencia, comenzando por el número uno. La parte divertida es que, si el número
 * es divisible por 3, tienes que decir "Fizz" en vez del número. Y si es divisible por 5, debes decir "Buzz".

Las matemáticas no es tu fuerte y tienes miedo de que te llegue el turno y no sepas qué decir. Así que, con el fin de evitar
 * la vergüenza delante de toda la clase, tienes que obtener la lista completa impresa para saber qué decir. Tu clase tiene
 * unos 33 alumnos y se pueden llegar a hacer unas tres rondas antes de que suene el timbre para el recreo. La siguiente
 * clase de matemáticas es el jueves. ¡Codifícalo! :)
Enunciado
Escribe un programa que imprima los números del 1 al 100, pero aplicando las siguientes normas:

    Devuelve Fizz si el número es divisible por 3.
    Devuelve Buzz si el número es divisible por 5.
    Devuelve FizzBuzz si el número es divisible por 3 y por 5.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKataFizzBuzz
{
    static class FizzBuzz
    {
        public static void PioPio()
        {            
            for (int i = 1; i < 101; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        if (i % 3 == 0 )
                            Console.WriteLine("Fizz");
                        else
                            Console.WriteLine("Buzz");
                    }
                    else
                        Console.WriteLine(i.ToString());                    
                }                   
            }
        }
    }
}
