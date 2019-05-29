using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ProgrammersProjekt.view
{
    public partial class NewProgrammerForm : Form
    {
        //Akuális városok listája
        List<string> cities;

        //Az új  programozó felviteli ablak fogadja a városok listáját
        public NewProgrammerForm(List<string> cities)
        {
            this.cities = cities;
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
    }
}
