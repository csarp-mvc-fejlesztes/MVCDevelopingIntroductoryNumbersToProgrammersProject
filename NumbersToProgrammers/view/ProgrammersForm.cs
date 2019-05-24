using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using ProgrammersProjekt.controller;

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
    }
}
