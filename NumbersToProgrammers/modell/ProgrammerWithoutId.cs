using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgrammersProjekt.modell
{
    public class ProgrammerWithoutId
    {
        private string name;
        private int age;
        private string city;
        private Gender gender;
        private bool desktopProgrammer;
        private bool webProgrammer;
        private bool gameProgrammer;

        public ProgrammerWithoutId()
        {
            name = string.Empty;
            age = 0;
            city = string.Empty;
            gender = Gender.MAN;
            desktopProgrammer = false;
            webProgrammer = false;
            gameProgrammer = false;
        }

        public ProgrammerWithoutId(string name, int age, string city, bool ferfi, bool desktopProgrammer, bool webProgrammer, bool gameProgrammer)
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.gender = Gender.MAN;
            this.desktopProgrammer = desktopProgrammer;
            this.webProgrammer = webProgrammer;
            this.gameProgrammer = gameProgrammer;
        }

        public void modifyProgrammer(Programmer newProgrammer)
        {
            name = newProgrammer.getName();
            age = newProgrammer.getAge();
            city = newProgrammer.getCity();
            gender = newProgrammer.getGender();
            desktopProgrammer = newProgrammer.getDesktopProgrammerProperties();
            webProgrammer = newProgrammer.getWebProgrammerProperties();
            gameProgrammer = newProgrammer.getGameProgrammerProperties();
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public void setMan()
        {
            gender = Gender.MAN;
        }

        public void setWoman()
        {
            gender = Gender.WOMAN;
        }

        public void setDesktopProgrammerProperies(bool desktopProgrammerProperies)
        {
            this.desktopProgrammer = desktopProgrammerProperies;
        }

        public void changeDesktopProgrammerProperies()
        {
            desktopProgrammer = !desktopProgrammer;
        }

        public void setWebProgrammerProperties(bool webProgrammerProperties)
        {
            this.webProgrammer= webProgrammerProperties;
        }

        public void changeWebProgrammerProperties()
        {
            webProgrammer = !webProgrammer;
        }

        public void setGameProgrammerProperties(bool gameProgrammerProperties)
        {
            this.gameProgrammer= gameProgrammerProperties;
        }

        public void changeGameProgrammerProperties()
        {
            gameProgrammer = !gameProgrammer;
        }

        public string getName()
        {
            return name;
        }
        public int getAge()
        {
            return age;
        }
        public string getCity()
        {
            return city;
        }
        public Gender getGender()
        {
            return gender;
        }
        public bool getDesktopProgrammerProperties()
        {
            return desktopProgrammer;
        }
        public bool getWebProgrammerProperties()
        {
            return webProgrammer;
        }
        public bool getGameProgrammerProperties()
        {
            return gameProgrammer;
        }
    }
}
