namespace FrequentINT
{
 
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
    {
        public static int MestFrekventSiffra(int[] listaAvHeltal)
        {
            // Skapa en Dictionary för att lagra varje unikt tal och dess förekomster
            Dictionary<int, int> antalFörekomster = new Dictionary<int, int>();

            // Gå igenom hela listan av heltal
            foreach (int nummer in listaAvHeltal)
            {
                // Om numret redan finns i dictionary, öka dess räknare
                if (antalFörekomster.ContainsKey(nummer))
                {
                    antalFörekomster[nummer]++;
                }
                else
                {
                    // Om numret inte finns, lägg till det i dictionary med startvärdet 1
                    antalFörekomster[nummer] = 1;
                }
            }

            // Hitta det nummer som förekommer flest gånger
            // Om två nummer har samma antal förekomster, välj det minsta numret
            int mestFörekommandeNummer = antalFörekomster
                .OrderByDescending(par => par.Value)  // Sortera efter högsta antal förekomster
                .ThenBy(par => par.Key)              // Om lika, välj det minsta numret
                .First().Key;                        // Ta det första (mest frekventa) numret

            return mestFörekommandeNummer;
        }

        // Huvudmetod för att testa funktionen
        public static void Main()
        {
            Console.WriteLine(MestFrekventSiffra(new int[] { 1, 3, 2, 3, 4, 1, 3, 2, 2, 2, 5 })); // Förväntat resultat: 2
            Console.WriteLine(MestFrekventSiffra(new int[] { 7, 7, 5, 5, 1, 1, 1, 2, 2, 2 })); // Förväntat resultat: 1
        }
    }

}
