using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProgrammersProjekt.modell;

namespace ProgrammersProjekt.repository
{
    /// <summary>
    /// Repository == adattár osztály
    /// </summary>
    class ProgrammersRepository
    {
        /// <summary>
        /// Programozók listája
        /// </summary>
        private List<Programmer> programmers;

        /// <summary>
        /// Konstruktorban példányosítás
        /// </summary>
        public ProgrammersRepository()
        {
            programmers = new List<Programmer>();
        }

        /// <summary>
        /// Getter
        /// </summary>
        /// <returns>Programozók listája</returns>
        public List<Programmer> getProgrammers()
        {
            return programmers;
        }

        /// <summary>
        /// Feltöltés memóriában lévő tesztadatokkal
        /// </summary>
        /// <returns>Memóriában tárolt tesztadatok, programozók listája</returns>
        public List<Programmer> getProgrammersStoredInMemory()
        {
            ProgrammersInMemory pim = new ProgrammersInMemory();
            programmers = pim.getProgrammersStoredInMemory();
            return pim.getProgrammersStoredInMemory();
        }

        /// <summary>
        /// Id alapján megkeres egy programozó sorszámát a listában
        /// </summary>
        /// <param name="programmerID"></param>
        /// <returns></returns>
        private int searchProgrammerIndex(int programmerID)
        {
            return programmers.FindIndex(p => p.getId() == programmerID);
        }
    }
}
