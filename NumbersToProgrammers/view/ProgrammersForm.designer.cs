namespace ProgrammersProjekt
{
    partial class ProgrammerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelNev = new System.Windows.Forms.Label();
            this.labelEletkor = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDeleteDataFromController = new System.Windows.Forms.Button();
            this.listBoxProgrammersData = new System.Windows.Forms.ListBox();
            this.labelVaros = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.buttonSaveToTextFile = new System.Windows.Forms.Button();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.labelNem = new System.Windows.Forms.Label();
            this.labelHobi = new System.Windows.Forms.Label();
            this.checkBoxDesktopProgrammer = new System.Windows.Forms.CheckBox();
            this.checkBoxWebProgrammer = new System.Windows.Forms.CheckBox();
            this.checkBoxGameProgrammer = new System.Windows.Forms.CheckBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.groupBoxAdatfajlkezeles = new System.Windows.Forms.GroupBox();
            this.buttonReadDataFromMemory = new System.Windows.Forms.Button();
            this.buttonDataToDatabase = new System.Windows.Forms.Button();
            this.groupBoxAdatok = new System.Windows.Forms.GroupBox();
            this.buttonAddCity = new System.Windows.Forms.Button();
            this.labelAzonosito = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.groupBoxMűveletek = new System.Windows.Forms.GroupBox();
            this.buttonModify = new System.Windows.Forms.Button();
            this.groupBoxLista = new System.Windows.Forms.GroupBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemDataFromMemory = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDataFromDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.errorProviderModify = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxAdatfajlkezeles.SuspendLayout();
            this.groupBoxAdatok.SuspendLayout();
            this.groupBoxMűveletek.SuspendLayout();
            this.groupBoxLista.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNev
            // 
            this.labelNev.AutoSize = true;
            this.labelNev.Location = new System.Drawing.Point(6, 39);
            this.labelNev.Name = "labelNev";
            this.labelNev.Size = new System.Drawing.Size(27, 13);
            this.labelNev.TabIndex = 0;
            this.labelNev.Text = "Név";
            // 
            // labelEletkor
            // 
            this.labelEletkor.AutoSize = true;
            this.labelEletkor.Location = new System.Drawing.Point(7, 66);
            this.labelEletkor.Name = "labelEletkor";
            this.labelEletkor.Size = new System.Drawing.Size(40, 13);
            this.labelEletkor.TabIndex = 1;
            this.labelEletkor.Text = "Életkor";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(152, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(151, 66);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.ShortcutsEnabled = false;
            this.textBoxAge.Size = new System.Drawing.Size(70, 20);
            this.textBoxAge.TabIndex = 2;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(4, 19);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(225, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Hozzáadás";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDataFromController
            // 
            this.buttonDeleteDataFromController.Location = new System.Drawing.Point(4, 231);
            this.buttonDeleteDataFromController.Name = "buttonDeleteDataFromController";
            this.buttonDeleteDataFromController.Size = new System.Drawing.Size(225, 23);
            this.buttonDeleteDataFromController.TabIndex = 10;
            this.buttonDeleteDataFromController.Text = "Töröl adatokat";
            this.buttonDeleteDataFromController.UseVisualStyleBackColor = true;
            this.buttonDeleteDataFromController.Click += new System.EventHandler(this.buttonDeleteDataFromController_Click);
            // 
            // listBoxProgrammersData
            // 
            this.listBoxProgrammersData.FormattingEnabled = true;
            this.listBoxProgrammersData.Location = new System.Drawing.Point(6, 19);
            this.listBoxProgrammersData.Name = "listBoxProgrammersData";
            this.listBoxProgrammersData.Size = new System.Drawing.Size(717, 485);
            this.listBoxProgrammersData.TabIndex = 9;
            this.listBoxProgrammersData.SelectedIndexChanged += new System.EventHandler(this.listBoxProgrammersData_SelectedIndexChanged);
            // 
            // labelVaros
            // 
            this.labelVaros.AutoSize = true;
            this.labelVaros.Location = new System.Drawing.Point(6, 92);
            this.labelVaros.Name = "labelVaros";
            this.labelVaros.Size = new System.Drawing.Size(45, 13);
            this.labelVaros.TabIndex = 10;
            this.labelVaros.Text = "Helység";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(70, 92);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(151, 21);
            this.comboBoxCity.TabIndex = 3;
            // 
            // buttonSaveToTextFile
            // 
            this.buttonSaveToTextFile.Location = new System.Drawing.Point(6, 77);
            this.buttonSaveToTextFile.Name = "buttonSaveToTextFile";
            this.buttonSaveToTextFile.Size = new System.Drawing.Size(215, 23);
            this.buttonSaveToTextFile.TabIndex = 2;
            this.buttonSaveToTextFile.Text = "Mentés szövegfájlba";
            this.buttonSaveToTextFile.UseVisualStyleBackColor = true;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(79, 119);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(42, 17);
            this.radioButtonMan.TabIndex = 5;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "férfi";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(151, 119);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(37, 17);
            this.radioButtonWoman.TabIndex = 6;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "nő";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // labelNem
            // 
            this.labelNem.AutoSize = true;
            this.labelNem.Location = new System.Drawing.Point(6, 119);
            this.labelNem.Name = "labelNem";
            this.labelNem.Size = new System.Drawing.Size(29, 13);
            this.labelNem.TabIndex = 4;
            this.labelNem.Text = "Nem";
            // 
            // labelHobi
            // 
            this.labelHobi.AutoSize = true;
            this.labelHobi.Location = new System.Drawing.Point(7, 145);
            this.labelHobi.Name = "labelHobi";
            this.labelHobi.Size = new System.Drawing.Size(57, 13);
            this.labelHobi.TabIndex = 17;
            this.labelHobi.Text = "Szaktudás";
            // 
            // checkBoxDesktopProgrammer
            // 
            this.checkBoxDesktopProgrammer.AutoSize = true;
            this.checkBoxDesktopProgrammer.Location = new System.Drawing.Point(49, 161);
            this.checkBoxDesktopProgrammer.Name = "checkBoxDesktopProgrammer";
            this.checkBoxDesktopProgrammer.Size = new System.Drawing.Size(86, 17);
            this.checkBoxDesktopProgrammer.TabIndex = 7;
            this.checkBoxDesktopProgrammer.Text = "programozás";
            this.checkBoxDesktopProgrammer.UseVisualStyleBackColor = true;
            // 
            // checkBoxWebProgrammer
            // 
            this.checkBoxWebProgrammer.AutoSize = true;
            this.checkBoxWebProgrammer.Location = new System.Drawing.Point(49, 184);
            this.checkBoxWebProgrammer.Name = "checkBoxWebProgrammer";
            this.checkBoxWebProgrammer.Size = new System.Drawing.Size(89, 17);
            this.checkBoxWebProgrammer.TabIndex = 8;
            this.checkBoxWebProgrammer.Text = "webfejlesztés";
            this.checkBoxWebProgrammer.UseVisualStyleBackColor = true;
            // 
            // checkBoxGameProgrammer
            // 
            this.checkBoxGameProgrammer.AutoSize = true;
            this.checkBoxGameProgrammer.Location = new System.Drawing.Point(49, 207);
            this.checkBoxGameProgrammer.Name = "checkBoxGameProgrammer";
            this.checkBoxGameProgrammer.Size = new System.Drawing.Size(108, 17);
            this.checkBoxGameProgrammer.TabIndex = 9;
            this.checkBoxGameProgrammer.Text = "jatékprogram írás";
            this.checkBoxGameProgrammer.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(4, 48);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(225, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Törlés";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // groupBoxAdatfajlkezeles
            // 
            this.groupBoxAdatfajlkezeles.Controls.Add(this.buttonReadDataFromMemory);
            this.groupBoxAdatfajlkezeles.Controls.Add(this.buttonSaveToTextFile);
            this.groupBoxAdatfajlkezeles.Controls.Add(this.buttonDataToDatabase);
            this.groupBoxAdatfajlkezeles.Location = new System.Drawing.Point(16, 27);
            this.groupBoxAdatfajlkezeles.Name = "groupBoxAdatfajlkezeles";
            this.groupBoxAdatfajlkezeles.Size = new System.Drawing.Size(252, 114);
            this.groupBoxAdatfajlkezeles.TabIndex = 23;
            this.groupBoxAdatfajlkezeles.TabStop = false;
            this.groupBoxAdatfajlkezeles.Text = "Memóriában tárolt adatok kezelése";
            // 
            // buttonReadDataFromMemory
            // 
            this.buttonReadDataFromMemory.Location = new System.Drawing.Point(6, 19);
            this.buttonReadDataFromMemory.Name = "buttonReadDataFromMemory";
            this.buttonReadDataFromMemory.Size = new System.Drawing.Size(215, 23);
            this.buttonReadDataFromMemory.TabIndex = 0;
            this.buttonReadDataFromMemory.Text = "Beolvas memóriában tárolt adatokat";
            this.buttonReadDataFromMemory.UseVisualStyleBackColor = true;
            this.buttonReadDataFromMemory.Click += new System.EventHandler(this.buttonReadDataFromMemory_Click);
            // 
            // buttonDataToDatabase
            // 
            this.buttonDataToDatabase.Location = new System.Drawing.Point(6, 48);
            this.buttonDataToDatabase.Name = "buttonDataToDatabase";
            this.buttonDataToDatabase.Size = new System.Drawing.Size(215, 23);
            this.buttonDataToDatabase.TabIndex = 1;
            this.buttonDataToDatabase.Text = "Adatbazis keszítés adatokból";
            this.buttonDataToDatabase.UseVisualStyleBackColor = true;
            // 
            // groupBoxAdatok
            // 
            this.groupBoxAdatok.Controls.Add(this.buttonAddCity);
            this.groupBoxAdatok.Controls.Add(this.labelAzonosito);
            this.groupBoxAdatok.Controls.Add(this.textBoxId);
            this.groupBoxAdatok.Controls.Add(this.labelNev);
            this.groupBoxAdatok.Controls.Add(this.buttonDeleteDataFromController);
            this.groupBoxAdatok.Controls.Add(this.labelNem);
            this.groupBoxAdatok.Controls.Add(this.radioButtonWoman);
            this.groupBoxAdatok.Controls.Add(this.textBoxAge);
            this.groupBoxAdatok.Controls.Add(this.radioButtonMan);
            this.groupBoxAdatok.Controls.Add(this.checkBoxGameProgrammer);
            this.groupBoxAdatok.Controls.Add(this.labelHobi);
            this.groupBoxAdatok.Controls.Add(this.labelVaros);
            this.groupBoxAdatok.Controls.Add(this.textBoxName);
            this.groupBoxAdatok.Controls.Add(this.comboBoxCity);
            this.groupBoxAdatok.Controls.Add(this.checkBoxWebProgrammer);
            this.groupBoxAdatok.Controls.Add(this.checkBoxDesktopProgrammer);
            this.groupBoxAdatok.Controls.Add(this.labelEletkor);
            this.groupBoxAdatok.Location = new System.Drawing.Point(12, 156);
            this.groupBoxAdatok.Name = "groupBoxAdatok";
            this.groupBoxAdatok.Size = new System.Drawing.Size(251, 260);
            this.groupBoxAdatok.TabIndex = 25;
            this.groupBoxAdatok.TabStop = false;
            this.groupBoxAdatok.Text = "Adatok";
            // 
            // buttonAddCity
            // 
            this.buttonAddCity.Location = new System.Drawing.Point(227, 92);
            this.buttonAddCity.Name = "buttonAddCity";
            this.buttonAddCity.Size = new System.Drawing.Size(17, 23);
            this.buttonAddCity.TabIndex = 11;
            this.buttonAddCity.Text = "+";
            this.buttonAddCity.UseVisualStyleBackColor = true;
            // 
            // labelAzonosito
            // 
            this.labelAzonosito.AutoSize = true;
            this.labelAzonosito.Location = new System.Drawing.Point(6, 16);
            this.labelAzonosito.Name = "labelAzonosito";
            this.labelAzonosito.Size = new System.Drawing.Size(55, 13);
            this.labelAzonosito.TabIndex = 22;
            this.labelAzonosito.Text = "Azonosító";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(70, 14);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(151, 20);
            this.textBoxId.TabIndex = 0;
            // 
            // groupBoxMűveletek
            // 
            this.groupBoxMűveletek.Controls.Add(this.buttonModify);
            this.groupBoxMűveletek.Controls.Add(this.buttonAdd);
            this.groupBoxMűveletek.Controls.Add(this.buttonDelete);
            this.groupBoxMűveletek.Location = new System.Drawing.Point(12, 422);
            this.groupBoxMűveletek.Name = "groupBoxMűveletek";
            this.groupBoxMűveletek.Size = new System.Drawing.Size(251, 118);
            this.groupBoxMűveletek.TabIndex = 26;
            this.groupBoxMűveletek.TabStop = false;
            this.groupBoxMűveletek.Text = "Műveletek";
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(5, 77);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(224, 23);
            this.buttonModify.TabIndex = 2;
            this.buttonModify.Text = "Módosítás";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // groupBoxLista
            // 
            this.groupBoxLista.Controls.Add(this.listBoxProgrammersData);
            this.groupBoxLista.Location = new System.Drawing.Point(269, 27);
            this.groupBoxLista.Name = "groupBoxLista";
            this.groupBoxLista.Size = new System.Drawing.Size(727, 513);
            this.groupBoxLista.TabIndex = 27;
            this.groupBoxLista.TabStop = false;
            this.groupBoxLista.Text = "Adatbázisban lévő adatok...";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemDataFromMemory,
            this.ToolStripMenuItemDataFromDatabase,
            this.ToolStripMenuItemInformation,
            this.ToolStripMenuItemExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.TabIndex = 28;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemDataFromMemory
            // 
            this.ToolStripMenuItemDataFromMemory.Name = "ToolStripMenuItemDataFromMemory";
            this.ToolStripMenuItemDataFromMemory.Size = new System.Drawing.Size(157, 20);
            this.ToolStripMenuItemDataFromMemory.Text = "Memóriában tárolt adatok";
            this.ToolStripMenuItemDataFromMemory.Click += new System.EventHandler(this.ToolStripMenuItemDataFromMemory_Click);
            // 
            // ToolStripMenuItemDataFromDatabase
            // 
            this.ToolStripMenuItemDataFromDatabase.Name = "ToolStripMenuItemDataFromDatabase";
            this.ToolStripMenuItemDataFromDatabase.Size = new System.Drawing.Size(160, 20);
            this.ToolStripMenuItemDataFromDatabase.Text = "Adatbázisban tárolt adatok";
            // 
            // ToolStripMenuItemInformation
            // 
            this.ToolStripMenuItemInformation.Name = "ToolStripMenuItemInformation";
            this.ToolStripMenuItemInformation.Size = new System.Drawing.Size(149, 20);
            this.ToolStripMenuItemInformation.Text = "Információ a programról";
            this.ToolStripMenuItemInformation.Click += new System.EventHandler(this.ToolStripMenuItemInformation_Click);
            // 
            // ToolStripMenuItemExit
            // 
            this.ToolStripMenuItemExit.Name = "ToolStripMenuItemExit";
            this.ToolStripMenuItemExit.Size = new System.Drawing.Size(56, 20);
            this.ToolStripMenuItemExit.Text = "Kilépés";
            this.ToolStripMenuItemExit.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // errorProviderModify
            // 
            this.errorProviderModify.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ProgrammerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 573);
            this.Controls.Add(this.groupBoxLista);
            this.Controls.Add(this.groupBoxMűveletek);
            this.Controls.Add(this.groupBoxAdatok);
            this.Controls.Add(this.groupBoxAdatfajlkezeles);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ProgrammerForm";
            this.Text = "Memóriában tárolt adatok kezelése";
            this.groupBoxAdatfajlkezeles.ResumeLayout(false);
            this.groupBoxAdatok.ResumeLayout(false);
            this.groupBoxAdatok.PerformLayout();
            this.groupBoxMűveletek.ResumeLayout(false);
            this.groupBoxLista.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderModify)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNev;
        private System.Windows.Forms.Label labelEletkor;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDeleteDataFromController;
        private System.Windows.Forms.ListBox listBoxProgrammersData;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label labelVaros;
        private System.Windows.Forms.Button buttonSaveToTextFile;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.CheckBox checkBoxGameProgrammer;
        private System.Windows.Forms.CheckBox checkBoxWebProgrammer;
        private System.Windows.Forms.CheckBox checkBoxDesktopProgrammer;
        private System.Windows.Forms.Label labelHobi;
        private System.Windows.Forms.Label labelNem;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.GroupBox groupBoxAdatfajlkezeles;
        private System.Windows.Forms.GroupBox groupBoxAdatok;
        private System.Windows.Forms.GroupBox groupBoxLista;
        private System.Windows.Forms.GroupBox groupBoxMűveletek;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataFromMemory;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDataFromDatabase;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInformation;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemExit;
        private System.Windows.Forms.Button buttonDataToDatabase;
        private System.Windows.Forms.Button buttonReadDataFromMemory;
        private System.Windows.Forms.Label labelAzonosito;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Button buttonAddCity;
        private System.Windows.Forms.ErrorProvider errorProviderModify;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

