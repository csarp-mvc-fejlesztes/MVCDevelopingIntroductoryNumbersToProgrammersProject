using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ProgrammersProjekt.modell;

namespace ProgrammersProjekt.view
{
    public partial class NewProgrammerForm : Form
    {
        //Akuális városok listája
        List<string> cities;
        ///
        ProgrammerWithoutId pwi;

        //Az új  programozó felviteli ablak fogadja a városok listáját
        public NewProgrammerForm(List<string> cities)
        {
            this.cities = cities;
            pwi = new ProgrammerWithoutId();
            InitializeComponent();
        }


        private void NewProgrammerForm_Load(object sender, EventArgs e)
        {
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            comboBoxCity.Text = string.Empty;
            radioButtonMan.Checked = true;
            radioButtonWoman.Checked = false;
            checkBoxDesktopProgrammer.Checked = false;
            checkBoxGameProgrammer.Checked = false;
            checkBoxWebProgrammer.Checked = false;
            comboBoxCity.DataSource = cities;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string ageString = textBoxAge.Text;
            string city = comboBoxCity.Text;
            bool man = radioButtonMan.Checked;
            bool destopProgrammerProperies = checkBoxDesktopProgrammer.Checked;
            bool gameProgrammerProperties = checkBoxGameProgrammer.Checked;
            bool webProgrammerProperties = checkBoxWebProgrammer.Checked;

            
            int age = Convert.ToInt32(ageString);
            
            pwi.setName(name);
            pwi.setAge(age);
            pwi.setCity(city);
            if (man)
                pwi.setMan();
            else
                pwi.setWoman();
            pwi.setDesktopProgrammerProperies(destopProgrammerProperies);
            pwi.setGameProgrammerProperties(gameProgrammerProperties);
            pwi.setWebProgrammerProperties(webProgrammerProperties);
        }
    }
}
