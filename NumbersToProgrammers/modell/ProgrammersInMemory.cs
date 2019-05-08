using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjekt.modell
{
    /// <summary>
    /// Tesztadatok
    /// </summary>
    class ProgrammersInMemory
    {
        /// <summary>
        /// Tesztadatok listája
        /// </summary>
        private List<Programmer> programmers;

        /// <summary>
        /// A konstruktor előállítja a tesztadatokat
        /// </summary>
        public ProgrammersInMemory()
        {
            Programmer d1 = new Programmer(1, "Programozó Péter", 44, "Budapest", Gender.MAN, true, true, false);
            Programmer d2 = new Programmer(2, "Jétkfejlesztő János", 44, "Budapest", Gender.MAN, false, false, true);
            Programmer d3 = new Programmer(3, "Web Vica", 33, "Hódmezővásárhely", Gender.WOMAN, true, true, false);

            programmers = new List<Programmer>();
            programmers.Add(d1);
            programmers.Add(d2);
            programmers.Add(d3);
        }

        /// <summary>
        /// Tesztadatok getter
        /// </summary>
        /// <returns>Programozók listája a tesztadatokkal</returns>
        public List<Programmer> getProgrammersStoredInMemory()
        {
            return programmers;
        }
    }
}
