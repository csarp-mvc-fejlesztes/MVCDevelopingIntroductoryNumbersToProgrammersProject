using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProgrammersProjekt.repository;

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

    }
}
