/*
 * Reto #7
 * CONTANDO PALABRAS
 * Fecha publicación enunciado: 14/02/22
 * Fecha publicación resolución: 21/02/22
 * Dificultad: MEDIA
 *
 * Enunciado: Crea un programa que cuente cuantas veces se repite cada palabra y que muestre el recuento final de todas ellas.
 * - Los signos de puntuación no forman parte de la palabra.
 * - Una palabra es la misma aunque aparezca en mayúsculas y minúsculas.
 * - No se pueden utilizar funciones propias del lenguaje que lo resuelvan automáticamente.
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
    public class Challenge7 : IChallenge
    {
        public void DoChallenge()
        {
            WordsCounter("To begin to toboggan first buy a toboggan, but don't buy too big a toboggan. Too big a toboggan is too big a toboggan to buy to begin to toboggan.");
        }

        private static void WordsCounter(string phrase)
        {
            Dictionary<string, int> wordsDictionary = new();
            string formatedPhrase = phrase.ToLower().Replace(".", "").Replace("'", "").Trim();
            formatedPhrase.Split(' ').ToList().ForEach(word =>
            {
                if(wordsDictionary.ContainsKey(word)) wordsDictionary[word]++; else wordsDictionary.Add(word, 1);
            });

            Console.WriteLine(phrase);
            foreach (var wordDictionary in wordsDictionary)
            {
                Console.WriteLine($"{wordDictionary.Key} - {wordDictionary.Value} times");
            }
        }
    }
}
