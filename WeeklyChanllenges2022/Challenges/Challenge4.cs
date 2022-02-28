/*
 * Reto #4
 * ÁREA DE UN POLÍGONO
 * Fecha publicación enunciado: 24/01/22
 * Fecha publicación resolución: 31/01/22
 * Dificultad: FÁCIL
 *
 * Enunciado: Crea UNA ÚNICA FUNCIÓN (importante que sólo sea una) que sea capaz de calcular y retornar el área de un polígono.
 * - La función recibirá por parámetro sólo UN polígono a la vez.
 * - Los polígonos soportados serán Triángulo, Cuadrado y Rectángulo.
 * - Imprime el cálculo del área de un polígono de cada tipo.
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
    public class Challenge4 : IChallenge
    {
        public void DoChallenge()
        {
            IPolygon square = new Square
            {
                Height = 5,
                Width = 5
            };

            IPolygon rectangle = new Rectangle
            {
                Height = 10,
                Width = 6
            };

            IPolygon triangle = new Triangle
            {
                Height = 6,
                Width = 3
            };

            Console.WriteLine($"Area of a sqaure ({square.Width}, {square.Height}): {GetPoligonArea(square)}");
            Console.WriteLine($"Area of a rectangle ({rectangle.Width}, {rectangle.Height}): {GetPoligonArea(rectangle)}");
            Console.WriteLine($"Area of a triangle ({triangle.Width}, {triangle.Height}): {GetPoligonArea(triangle)}");
        }

        private static float GetPoligonArea(IPolygon poligon)
        {
            return poligon.GetType().Name switch
            {
                "Square" or "Rectangle" => poligon.Width * poligon.Height,
                "Triangle" => poligon.Width * poligon.Height / 2,
                _ => 0,
            };
        }
    }

    public class Square : IPolygon
    {
        public float Width { get; set; }
        public float Height { get; set; }
    }

    public class Rectangle : IPolygon
    {
        public float Width { get; set; }
        public float Height { get; set; }
    }

    public class Triangle : IPolygon
    {
        public float Width { get; set; }
        public float Height { get; set; }
    }

    public interface IPolygon
    {
        public float Width { get; set; }
        public float Height { get; set; }
    }
}
