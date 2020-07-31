using System;


    class Program
{
    static void Main(string[] args)
    {
          {
            //Generador valores variantes en escala de 1 a 11
            Random aleatorio = new Random();
                 bool gameover = false;
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            int baraja = 0, total = (carta1 + carta2);;
            //Indicar al jugador culaes son sus 2 cartas iniciales y la suma incial
            Console.Write(" carta1: " + carta1);
            Console.Write(" carta2: " + carta2);
            Console.Write(" Total: " + total);
            //Ciclo para que el juego pueda continuar mientras el puntaje sea menor a 21
            while (21 > total && gameover != true)
                //Permitir tomar una carta adicional
                {   Console.WriteLine(" ¿Deseas una carta adicional? ");
                string si = Console.ReadLine();
                // Condiconada a que si escribe "s" se le sume una entre 1 y 11
                if (si == "s")
                {
                    baraja = aleatorio.Next(1, 11);
                    total += baraja;
                    Console.Write(" Carta= " + baraja);
                    Console.Write(" Total= " + total);
                }
                // Condiconada a que si escribe "n" pierda al no haber llegado al 21
                else if (si == "n")
                {
                    Console.Write(" (Perdiste) ");
                    gameover = true;
                }
            // Si logra 21 con un 10 y 11, ganara independiente del ciclo while o perdera si saca 22 al juntar 11 y 11
            }
            if (21 == total)
            {
                Console.WriteLine(" (ganaste) ");
            }
            else if (total > 21)
            {
                Console.WriteLine(" (perdiste) ");
            }

            Console.WriteLine(" total: " + total);
            Console.WriteLine(" Gracias por jugar ");
        }
    }
}
