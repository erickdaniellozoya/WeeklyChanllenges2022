﻿/*
 * Reto #3
 * ¿ES UN NÚMERO PRIMO?
 * Fecha publicación enunciado: 17/01/22
 * Fecha publicación resolución: 24/01/22
 * Dificultad: MEDIA
 *
 * Enunciado: Escribe un programa que se encargue de comprobar si un número es o no primo.
 * Hecho esto, imprime los números primos entre 1 y 100.
 *
 * Información adicional:
 * - Usa el canal de nuestro discord (https://mouredev.com/discord) "🔁reto-semanal" para preguntas, dudas o prestar ayuda la acomunidad.
 * - Puedes hacer un Fork del repo y una Pull Request al repo original para que veamos tu solución aportada.
 * - Revisaré el ejercicio en directo desde Twitch el lunes siguiente al de su publicación.
 * - Subiré una posible solución al ejercicio el lunes siguiente al de su publicación.
 *
 */

using WeeklyChanllenges2022.Interfaces;

namespace WeeklyChanllenges2022.Challenges
{
    public class Challenge3 : IChallenge
    {
        public void DoChallenge()
        {
            for (int i = 1; i <= 100; i++)
                if(IsPrimeNumber(i)) Console.WriteLine(i);
        }

        private static bool IsPrimeNumber(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i < number; i++)
                if (number % i == 0) return false;

            return true;
        }
    }
}
