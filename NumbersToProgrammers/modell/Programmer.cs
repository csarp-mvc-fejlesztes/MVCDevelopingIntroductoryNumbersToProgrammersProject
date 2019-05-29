using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersProjekt.modell
{
    public enum Gender { MAN, WOMAN }

    public class Programmer
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

        public void setID(int id)
        {
            this.id = id;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public void setAge(int age)
        {
            this.age = age;
        }

        public void setMan()
        {
            gender = Gender.MAN;
        }

        public void setWoman()
        {
            gender = Gender.WOMAN;
        }

        public void changeDesktopProgrammerProperies()
        {
            desktopProgrammer = !desktopProgrammer;
        }

        public void changeWebProgrammerProperties()
        {
            webProgrammer = !webProgrammer;
        }

        public void changeGameProgrammerProperties()
        {
            gameProgrammer = !gameProgrammer;
        }

        public int getId()
        {
            return id;
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

        public override string ToString()
        {
            string programmerString =
                id + " " +
                name + " " +
                age + " " +
                city + " ";
            if (gender == Gender.MAN)
                programmerString += "férfi ";
            else
                programmerString += "nő ";
            if (desktopProgrammer)
                programmerString += "programozás ";
            if (webProgrammer)
                programmerString += "webfejlesztés ";
            if (gameProgrammer)
                programmerString += "játékprogramírás ";
            return programmerString;
        }        

        /// <summary>
        /// Statikus függvény
        /// Használata: Programmer.getIdFromProgrammerString(string)
        /// 
        /// Feltételezi, hogy a string elején, az első szóközig a programozó ID-je van
        /// Ezt az id-t adja vissza
        /// </summary>
        /// <param name="programmerText">Programozó id-je string formátumban</param>
        /// <returns></returns>
        public static string getIdFromProgrammerString(string programmerText)
        {
            string[] data = programmerText.Split(' ');
            if (data.Length > 0)
                return data[0];
            else
                return string.Empty;
        }

        public void modifyProgrammer(Programmer newDataOfProgrammer)
        {
            id = newDataOfProgrammer.getId();
            name = newDataOfProgrammer.getName();
            age = newDataOfProgrammer.getAge();
            city = newDataOfProgrammer.getCity();
            gender = newDataOfProgrammer.getGender();
            desktopProgrammer = newDataOfProgrammer.getDesktopProgrammerProperties();
            webProgrammer = newDataOfProgrammer.getWebProgrammerProperties();
            gameProgrammer = newDataOfProgrammer.getGameProgrammerProperties();
        }
    }
}
