/*
 * Reto #8
 * DECIMAL A BINARIO
 * Fecha publicación enunciado: 18/02/22
 * Fecha publicación resolución: 02/03/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea un programa se encargue de transformar un número decimal a binario sin utilizar funciones propias del lenguaje que lo hagan directamente.
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
    public class Challenge8 : IChallenge
    {
        public void DoChallenge()
        {
            Console.WriteLine(DecimalToBinary(13.375m));
        }

        private static string DecimalToBinary(decimal number)
        {
            Stack<int> binaryStack = new();
            List<string> binaryList = new();
            string[] numberSplit = number.ToString().Split('.');
            int numberFormated = int.Parse(numberSplit[0]);
            decimal decimalFormated = decimal.Parse($"0.{numberSplit[1]}");
            string result = "";

            do
            {
                binaryStack.Push(numberFormated % 2);
                numberFormated /= 2;
            }while(numberFormated != 0);


            do
            {
                binaryList.Add((decimalFormated * 2.0m).ToString().Split('.')[0]);
                decimalFormated = decimal.Parse($"0.{(decimalFormated * 2.0m).ToString().Split('.')[1]}");
            } while (decimalFormated != 0 && binaryList.Count < 20);
            
            foreach (var item in binaryStack)
            {
                result += item;
            }

            result += ".";

            foreach(var item in binaryList)
            {
                result += item;
            }

            return result;
        }
    }
}
