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
    }
}
