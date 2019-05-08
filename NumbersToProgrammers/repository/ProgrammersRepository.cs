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

        /// <summary>
        /// Programozó hozzáadása a listához
        /// </summary>
        /// <param name="programmer">A programozó</param>
        public void add(Programmer programmer)
        {
            if (programmer == null)
                throw new RepositoryException("A programozó nem jött létre a memóriában, nem lehet hozzáadni a listához");
            programmers.Add(programmer);
        }

        /// <summary>
        /// Adott id-jű elem törlése a listában
        /// </summary>
        /// <param name="id">Az id</param>
        /// <exception cref="RepositoryException">Adott sorszámú elem nem létezik a listában</exception>
        public void remove(int id)
        {
            int index = searchProgrammerIndex(id);
            try
            {
                programmers.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new RepositoryException(id + " sorszámú elem nem törölhető.\n" + e.Message);
            }
        }

        /// <summary>
        /// Id alapján megkeres egy programozót
        /// </summary>
        /// <param name="programmerID"></param>
        /// <returns></returns>
        public Programmer getProgrammerById(int programmerID)
        {
            if (programmers.FindIndex(p => p.getId() == programmerID) < 0)
                return null;
            else
                return programmers.Find(d => d.getId() == programmerID);
        }

        /// <summary>
        /// Adott id-jű elem módosítása
        /// </summary>
        /// <param name="id">A módosítandó programozó id-je</param>
        /// <param name="toProgrammer">Erre az adatra módosul</param>
        /// <exception cref="RepositoryException">Adott id-jű elem nem létezik a listában</exception>
        public void modify(int id, Programmer toProgrammer)
        {
            if (toProgrammer == null)
                throw new RepositoryException("Null értékre nem lehet módosítani\n");
            Programmer programmerToModify = getProgrammerById(id);
            if (programmerToModify == null)
                throw new RepositoryException(id + " sorszámú elem nem módosítható\n");
            programmerToModify.modifyProgrammer(toProgrammer);
        }


    }
}
