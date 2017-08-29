using System;

namespace Botellas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int Bottles = 12;

            Console.WriteLine ("¿Cuantos minutos tardas en bañarte?");
            string Minutes = Console.ReadLine ();
            var Minutes0 = int.Parse (Minutes);
            int Total = Bottles * Minutes0;
            Console.WriteLine ("¿Cuando es tu próximo cumpleaños? (Orden: YYYY, MM, DD)");
            string BirthDay = Console.ReadLine ();
            var BirthDay0 = DateTime.Parse (BirthDay);
            DateTime Now = DateTime.Now;
            if (Now > BirthDay0)
            {
                var NextBirthDay = new DateTime (Now.Year, BirthDay0.Month, BirthDay0.Day);
                if (Now > NextBirthDay)
                {
                    DateTime NextBirthDay0 = NextBirthDay.AddYears (1);
                    TimeSpan ForBirth = NextBirthDay0 - Now;
                    int ForBirth0 = ForBirth.Days;
                    int Total2 = ForBirth0 * Total;
                    Console.WriteLine ($"El total de botellas que gastas al bañarte por día son: {Total}");
                    Console.WriteLine ($"La cantidad de botellas que gastarás hasta el día de tu cumpleaños mientras te bañes diario será de: {Total2}.");
                    int ExcludeSunday = Total2 / 7;
                    int Total3 = Total2 - ExcludeSunday;
                    Console.WriteLine ($"Sí excluyeramos los Domingos, serían: {Total3}, o en su defecto serían {ExcludeSunday} menos.");
                }
                else
                {
                    TimeSpan ForBirth = NextBirthDay - Now;
                    int ForBirth0 = ForBirth.Days;
                    int Total2 = ForBirth0 * Total;
                    Console.WriteLine ($"El total de botellas que gastas al bañarte por día son: {Total}");
                    Console.WriteLine ($"La cantidad de botellas que gastarás hasta el día de tu cumpleaños mientras te bañes diario será de: {Total2}.");
                    int ExcludeSunday = Total2 / 7;
                    int Total3 = Total2 - ExcludeSunday;
                    Console.WriteLine ($"Sí excluyeramos los Domingos, serían: {Total3}, o en su defecto serían {ExcludeSunday} menos.");
                }
            }
            else
            {
                TimeSpan ToBirth = BirthDay0 - Now;
                int ToBirth0 = ToBirth.Days;
                int Total0 = ToBirth0 * Total;
                Console.WriteLine ($"El total de botellas que gastas al bañarte por día son: {Total}");
                Console.WriteLine ($"La cantidad de botellas que gastarás hasta el día de tu cumpleaños mientras te bañes diario será de: {Total0}.");
                int ExcludeSunday = Total0 / 7;
                int Total1 = Total0 - ExcludeSunday;
                Console.WriteLine ($"Sí excluyeramos los Domingos, serían: {Total1}, o en su defecto serían {ExcludeSunday} menos.");
            }
        }
    }
}
