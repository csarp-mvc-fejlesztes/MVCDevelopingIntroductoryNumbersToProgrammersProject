using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjekt.modell
{
    public enum Gender { MAN, WOMAN }

    class Programmer
    {
        private int id;
        private string name;
        private int age;
        private string city;
        private Gender gender;
        private bool desktopProgrammer;
        private bool webProgrammer;
        private bool gameProgrammer;

        public Programmer()
        {
            id = -1;
            name = string.Empty;
            age = 0;
            city = string.Empty;
            gender = Gender.MAN;
            desktopProgrammer = false;
            webProgrammer = false;
            gameProgrammer = false;
        }

        public Programmer(int id, string name, int age, string city, Gender gender, bool desktopProgrammer, bool webProgrammer, bool gameProgrammer)
        {
            try
            {
                //validation
            }
            catch (Exception e)
            {
                throw new ModelException(e.Message);
            }
            this.id = id;
            this.name = name;
            this.age = age;
            this.city = city;
            this.gender = gender;
            this.desktopProgrammer = desktopProgrammer;
            this.webProgrammer = webProgrammer;
            this.gameProgrammer = gameProgrammer;
        }
    }
}
