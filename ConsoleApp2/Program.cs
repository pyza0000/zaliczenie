using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalkulator kalorii");

            Console.Write("Podaj płeć (M/K): ");
            string plec = Console.ReadLine();

            Console.Write("Podaj wiek: ");
            int wiek = int.Parse(Console.ReadLine());

            Console.Write("Podaj wagę (kg): ");
            double waga = double.Parse(Console.ReadLine());

            Console.Write("Podaj wzrost (cm): ");
            double wzrost = double.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz poziom aktywności:");
            Console.WriteLine("1. Brak aktywności (praca siedząca)");
            Console.WriteLine("2. Lekka aktywność (1-2 dni w tygodniu)");
            Console.WriteLine("3. Umiarkowana aktywność (3-5 dni w tygodniu)");
            Console.WriteLine("4. Wysoka aktywność (6-7 dni w tygodniu)");
            Console.WriteLine("5. Bardzo wysoka aktywność (zawodowi sportowcy, ciężka praca fizyczna)");
            Console.Write("Wybierz (1-5): ");
            int aktywnosc = int.Parse(Console.ReadLine());

            double bmr;

            if (plec.ToUpper() == "M")
            {
                bmr = 88.44 + (13.4 * waga) + (4.8 * wzrost) - (5.68 * wiek);
            }
            else
            {
                bmr = 447.6 + (9.25 * waga) + (3.10 * wzrost) - (4.330 * wiek);
            }

            switch (aktywnosc)
            {
                case 1:
                    bmr *= 1.2;
                    break;
                case 2:
                    bmr *= 1.375;
                    break;
                case 3:
                    bmr *= 1.55;
                    break;
                case 4:
                    bmr *= 1.725;
                    break;
                case 5:
                    bmr *= 1.9;
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór aktywności.");
                    return;
            }

            Console.WriteLine($"Twoje dzienne zapotrzebowanie kaloryczne wynosi: {Math.Round(bmr)} kcal");


            Console.ReadKey();
        }
    }
}
