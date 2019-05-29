using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ProgrammersProjekt.controller;
using ProgrammersProjekt.modell;

namespace ProgrammersProjekt
{
    public partial class ProgrammerForm : Form
    {
        /// <summary>
        /// A view-n az adatokat a controller alakítja át megfelelő formátumba és 
        /// a controller ellenörzi az input adatokat
        /// </summary>
        ProgrammersController programmersController = new ProgrammersController();

        public ProgrammerForm()
        {
            programmersController = new ProgrammersController();
            InitializeComponent();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolStripMenuItemInformation_Click(object sender, EventArgs e)
        {
            AboutBoxProjektfeladat abp = new AboutBoxProjektfeladat();
            if (abp.ShowDialog() == DialogResult.OK)
                return;
        }

        /// <summary>
        /// Vezérlőkben lévő adatok törlése
        /// </summary>
        private void clearProgrammerController()
        {
            textBoxId.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            comboBoxCity.Text = string.Empty;
            radioButtonMan.Checked = true;
            radioButtonWoman.Checked = false;
            checkBoxDesktopProgrammer.Checked = false;
            checkBoxGameProgrammer.Checked = false;
            checkBoxWebProgrammer.Checked = false;
        }

        /// <summary>
        /// A programozó adatait tartalmazó vezérlők törlése
        /// </summary>
        private void buttonDeleteDataFromController_Click(object sender, EventArgs e)
        {
            clearProgrammerController();
        }

        /// <summary>
        /// Adatok frissítése a formon
        /// </summary>
        private void updateControlerWithData()
        {
            comboBoxCity.DataSource = null;
            listBoxProgrammersData.DataSource = null;
            clearProgrammerController();
            if (programmersController.getProgrammers().Count != 0)
            {
                comboBoxCity.DataSource = programmersController.getCities();
                listBoxProgrammersData.DataSource = programmersController.getProgrammers();
            }
            textBoxId.ReadOnly = true;
        }

        /// <summary>
        /// Tesztadatok betöltés és megjelenítése
        /// </summary>
        private void buttonReadDataFromMemory_Click(object sender, EventArgs e)
        {
            programmersController.getProgrammersFromMemory();
            updateControlerWithData();
        }

        /// <summary>
        /// Tesztadatok betöltés és megjelenítése
        /// </summary>
        private void ToolStripMenuItemDataFromMemory_Click(object sender, EventArgs e)
        {
            programmersController.getProgrammersFromMemory();
            updateControlerWithData();
        }

        /// <summary>
        /// A kijelölt programozót töröljük
        /// </summary>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxProgrammersData.SelectedIndex;
            if (index < 0)
                return;

            string idText = Programmer.getIdFromProgrammerString(listBoxProgrammersData.Text);
            if (idText == string.Empty)
                return;

            programmersController.deleteProgrammer(idText);
            updateControlerWithData();
        }

        /// <summary>
        /// Programozó adatainak megjelenítése a vezérlőkben
        /// </summary>
        /// <param name="p">Megjelenítendő programozó</param>
        private void showProgrammerInController(Programmer p)
        {
            if (p == null)
            {
                clearProgrammerController();
            }
            else
            {
                textBoxId.Text = p.getId().ToString();
                textBoxName.Text = p.getName();
                textBoxAge.Text = p.getAge().ToString();
                comboBoxCity.Text = p.getCity();
                if (p.getGender() == Gender.MAN)
                {
                    radioButtonMan.Checked = true;
                    radioButtonWoman.Checked = false;
                }
                else
                {
                    radioButtonMan.Checked = false;
                    radioButtonWoman.Checked = true;
                }
                if (p.getDesktopProgrammerProperties())
                    checkBoxDesktopProgrammer.Checked = true;
                else
                    checkBoxDesktopProgrammer.Checked = false;
                if (p.getGameProgrammerProperties())
                    checkBoxGameProgrammer.Checked = true;
                else
                    checkBoxGameProgrammer.Checked = false;
                if (p.getWebProgrammerProperties())
                    checkBoxWebProgrammer.Checked = true;
                else
                    checkBoxWebProgrammer.Checked = false;
            }
        }

        /// <summary>
        /// Másik programozóra kattintunk a listBox-ban akkor frissíteni kell az adatokat a vezérlőben
        /// </summary>
        private void listBoxProgrammersData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxProgrammersData.SelectedIndex;
            if (index < 0)
                return;

            string idText = Programmer.getIdFromProgrammerString(listBoxProgrammersData.Text);
            if (idText == string.Empty)
                return;

            Programmer p = programmersController.getProgrammerById(idText);
            if (p != null)
                showProgrammerInController(p);
        }

        /// <summary>
        /// A kijelölt programozó adatait módosítjuk a vezérlőkben megadott adatokkal
        /// </summary>
        private void buttonModify_Click(object sender, EventArgs e)
        {

        }
    }
}
