using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProgrammersProjekt.modell;
using ProgrammersProjekt.repository;
using System.Diagnostics;

namespace ProgrammersProjekt.controller
{
    /// <summary>
    /// Feladata:
    ///  - az adattárban lévő adatok elérése, kezelése
    ///  - az outputra szánt adatok átalakítása a megfeleő formátumba
    ///  - input adatok ellenörzése
    ///  - hibaüzenetek megjelenítése a logba vagy a felhasználó felé (kivételdobás)
    /// </summary>
    class ProgrammersController
    {
        /// <summary>
        /// A vezérlő kezeli a repositoryban (adattárban) lévő adatokat
        /// (Elv: a felső réteg igénybe veszi az alsóbb rétegek szolgáltatásait
        /// </summary>
        private ProgrammersRepository programmerRepository;

        /// <summary>
        /// Konstruktor
        /// </summary>
        public ProgrammersController()
        {
            //A repository réteget képviselő osztály példányosítása
            programmerRepository = new ProgrammersRepository();
        }

        /// <summary>
        /// Output átalakítás:
        ///  - a programozók memóriában tárolt listájából stringek listáját készíti el
        /// </summary>
        /// <returns>Programozók listája</returns>
        public List<string> getProgrammersFromMemory()
        {
            //Kapcsolat az adattár tárolt adataihoz
            List<Programmer> programmersStoredInMemory = programmerRepository.getProgrammersStoredInMemory();
            List<string> programmersString = new List<string>();
            foreach (Programmer p in programmersStoredInMemory)
            {
                programmersString.Add(p.ToString());
            }
            return programmersString;
        }

        /// <summary>
        /// Output átalakítás:
        ///  - a programozók aktuális listájából stringek listáját készíti el
        /// </summary>
        /// <returns>Programozók listája</returns>
        public List<string> getProgrammers()
        {
            //Kapcsolat az adattár akutálisan tárolt adataihoz
            List<Programmer> programers = programmerRepository.getProgrammers();
            List<string> programmersString = new List<string>();
            foreach (Programmer p in programers)
            {
                programmersString.Add(p.ToString());
            }
            return programmersString;
        }

        /// <summary>
        /// Output átalakítás:
        /// - a programozók aktuális listájából városnevek listáját készíti el
        /// </summary>
        /// <returns>Városnevek listája</returns>
        public List<string> getCities()
        {
            SortedSet<string> cities = new SortedSet<string>();
            foreach (Programmer p in programmerRepository.getProgrammers())
            {
                cities.Add(p.getCity());
            }
            return cities.ToList();
        }

        /// <summary>
        /// Belső metódus, amelyet több másik metódus is használ
        /// A programozó id-jét string adatból int adattá konvertálja
        /// </summary>
        /// <param name="idString">Programozó id-je string formátumban</param>
        /// <returns>Programozó id-je int formátumban</returns>
        private int getProgrammerId(string idString)
        {
            int id = -1;
            try
            {
                id = Convert.ToInt32(idString);
            }
            catch (FormatException fe)
            {
                Debug.WriteLine(idString + " azonosító nem megfelelő formátumú...");
            }
            catch (OverflowException oe)
            {
                Debug.WriteLine(idString + " azonosító túl nagy vagy túl kicsi...");
            }
            return id;
        }

        /// <summary>
        /// Programozó egy adott id alapján
        /// </summary>
        /// <param name="idString">Programozó id-je string alakban</param>
        /// <returns>Programozó objektum</returns>
        public Programmer getProgrammerById(string idString)
        {
            int id = -1;
            try
            {
                id = getProgrammerId(idString);
            }
            catch (Exception e)
            {
                return null;
            }

            Programmer p = programmerRepository.getProgrammerById(id);
            if (p == null)
            {
                Debug.WriteLine(idString + " azonosító alapján a programozó meghatározhatatlan...");
                return null;
            }
            else
                return p;
        }

        /// <summary>
        /// Adott id-jú adat törlése id alapján a repository segítségével
        /// </summary>
        /// <param name="idOfProgrammerToDelete">Annak az elemnek a id-je amelyet törölni kell (string alakban)</param>
        public void deleteProgrammer(string idOfProgrammerToDelete)
        {

            int id = -1;
            try
            {
                id = getProgrammerId(idOfProgrammerToDelete);
            }
            catch (Exception e)
            {
                return;
            }

            try
            {
                programmerRepository.remove(id);
            }
            catch (RepositoryException re)
            {
                Debug.WriteLine(re.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Ismeretlen hiba történt...\n" + ex.Message);
            }
        }

    }
}
