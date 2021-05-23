using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Laboration_3
{
    public partial class formWindow : Form
    {
        public formWindow()
        {
            InitializeComponent();

            //Call method for clearing TextBox
            ClearTextBox();

            //Call method for show status bar
            StatusBar();
        }

        //Buttons Click
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            //If the file is changed ask user if he wants to save
            if (FileText.Equals(OpenFileTextBox.Text))
            {
                //Call method for clearing textBox
                ClearTextBox();
            }
            else
            {
                //Show dialog window to user with question
                var result = MessageBox.Show(
                                              "Vill du spara ändringarna i filen?",
                                              "Fråga",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:

                        //Call method for saving a file
                        SaveFile();

                        //Call method for clearing textBox
                        ClearTextBox();

                        break;

                    case DialogResult.No:

                        //Call method for clearing textBox
                        ClearTextBox();

                        break;

                }
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            //Call method for saving a file
            SaveFile();
        }
        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            //Declare and initiate a bool varibel to check if file is changed
            bool fileTextChanged = FileText.Equals(OpenFileTextBox.Text);

            //If the file is changed ask user if he wants to save
            if (fileTextChanged == false)
            {
                //Show dialog window to user with question
                var result = MessageBox.Show(
                                              "Vill du spara ändringarna i filen?",
                                              "Fråga",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:

                        //Call method for saving a file
                        SaveFile();

                        //Call method for opening a file
                        OpenFile();

                        break;

                    case DialogResult.No:

                        //Call method for opening a file
                        OpenFile();

                        break;

                }
            }
            else
            {
                //Call method for opening a file
                OpenFile();
            }

        }
        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
            //Open the explorer for the user to save file
            SaveFileDialog dialog = new SaveFileDialog();

            //filter for olny letting user save as txt files
            dialog.Filter = "Text Files (*.txt)|*.txt";

            //Save the resualt from dialog window
            var resualt = dialog.ShowDialog();

            //Check if user have saved the file or show error message
            if (resualt == DialogResult.OK)
            {
                //Find the position of the last \ in filepath
                int index = dialog.FileName.LastIndexOf("\\");

                //Get the find name from filepath name
                string namn = dialog.FileName.Substring(index + 1);

                //Set file name in windows bar
                this.Text = namn;

                //Call method for saving a file
                SaveFile();

            }
            else
            {
                //Show message that tells user it abort saving
                MessageBox.Show(
                                "Filen sparades inte",
                                "Avbruten",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            //Close the program
            System.Windows.Forms.Application.Exit();
        }

        //Events
        private void DragEnter(object sender, DragEventArgs e)
        {
            //Over all check if the file contains text
            if (DataFormats.Text == "Text")
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }
        private void DragDrop(object sender, DragEventArgs e)
        {
            //Save the text in textbox to a string varible
            string text = OpenFileTextBox.Text;

            //Create a string array with selected file path
            string[] filePaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //Check what key user is holding down
            switch (e.KeyState)
            {
                //ctrl pressed add the content after the existing textbox content
                case 8:
                    //Go through all selected files and add after the existing textbox content
                    foreach (var fileName in filePaths)
                    {
                        //Call method to check if file is .txt and save resualt
                        bool resualt = DroppFileType(fileName);

                        if (resualt == true)
                        {
                            //Load the file contetnt in textbox
                            OpenFileTextBox.Text = text + File.ReadAllText(fileName);
                        }

                        //Save the text in textbox
                        text = OpenFileTextBox.Text;
                    }
                    break;

                //shift pressed add the content at the marker position in existing textbox content
                case 4:
                    //Get position of marker to drop the text
                    int i = OpenFileTextBox.SelectionStart;

                    //Go through all selected files and add them to textbox content
                    foreach (var fileName in filePaths)
                    {
                        //Call method to check if file is .txt and save resualt
                        bool resualt = DroppFileType(fileName);

                        if (resualt == true)
                        {
                            //Load the file contetnt and incert it at marker positionx.  
                            OpenFileTextBox.Text = OpenFileTextBox.Text.Insert(i, File.ReadAllText(fileName));
                        }

                        //Save the text in textbox
                        text = OpenFileTextBox.Text;
                    }
                    break;

                default:
                    //Check that user only has selected one file
                    if (filePaths.Length == 1)
                    {
                        //Call method to check if file is .txt and save resualt
                        bool resualt = DroppFileType(filePaths[0]);

                        if (resualt == true)
                        {
                            //If the file is changed ask user if he wants to save
                            if (FileText != OpenFileTextBox.Text)
                            {
                                //Show dialog window to user with question
                                var result = MessageBox.Show(
                                                              "Vill du spara ändringarna i filen?",
                                                              "Fråga",
                                                              MessageBoxButtons.YesNoCancel,
                                                              MessageBoxIcon.Question);

                                switch (result)
                                {
                                    case DialogResult.Yes:

                                        //Call method for saving a file
                                        SaveFile();

                                        //Call method for opening a file
                                        LoadFile(filePaths[0]);

                                        break;

                                    case DialogResult.No:

                                        //Call method for opening a file
                                        LoadFile(filePaths[0]);

                                        break;
                                }
                            }
                            else if (FileText == OpenFileTextBox.Text)
                            {
                                //Call method for opening a file
                                LoadFile(filePaths[0]);
                            }
                        }
                    }
                    else
                    {
                        //Show message that tells user it can only open one file
                        MessageBox.Show(
                                        "Du kan bara öppna en fil",
                                        "Avbruten",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }

                    break;
            }
        }
        private void FormWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Declare and initiate a bool varibel to check if file is changed
            bool fileTextChanged = FileText.Equals(OpenFileTextBox.Text);

            //If the file is changed ask user if he wants to save
            if (FileText != OpenFileTextBox.Text)
            {
                //Show dialog window to user with question
                var result = MessageBox.Show(
                                              "Vill du spara ändringarna i filen?",
                                              "Fråga",
                                              MessageBoxButtons.YesNoCancel,
                                              MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:

                        //Call method for saving a file
                        SaveFile();

                        break;

                    case DialogResult.Cancel:

                        //Cancel the closing event of the program
                        e.Cancel = true;

                        break;

                }
            }
        }
        private void OpenFileTextBox_TextChanged(object sender, EventArgs e)
        {
            //Declare and initiate a bool varibel to check if filename starts with asterisk
            bool asterisk = this.Text.StartsWith("*");

            //Declare and initiate a bool varibel to check if file is changed
            bool fileTextChanged = FileText.Equals(OpenFileTextBox.Text);

            //When the file is changed show it in the form name
            if (asterisk == false && fileTextChanged == false)
            {
                //Set file name in windows bar
                this.Text = "*" + this.Text;
            }

            //Call method for uppdating status bar
            StatusBar();
        }

        //Method
        private void StatusBar()
        {
            //Count number of characters in textBox
            int amountWithSpace = OpenFileTextBox.Text.Length;

            //Create a string copy of texbox without spaces
            string withoutSpace = OpenFileTextBox.Text.Replace(" ", "");
            
            //Count number of characters without spaces in textBox
            int amountWithoutSpace = withoutSpace.Length;

            //Declare and initiate four int varibles
            int word = 0;
            int lastWord = 0;
            int amountWords = 0;
            int amountRows = 1;

            //Go through all text
            for (int i = 0; i < OpenFileTextBox.Text.Length; i++)
            {
                //Check if the current character is white space a new line
                if (OpenFileTextBox.Text[i] == ' ' || OpenFileTextBox.Text[i] == '\n')
                {
                    //Check that character before is not a white space
                    if (1 < i && OpenFileTextBox.Text[i - 1] != '\n' && OpenFileTextBox.Text[i - 1] != ' ')
                    {
                        //Add a word
                        word++;
                    }
                }
                if (OpenFileTextBox.Text[amountWithSpace - 1] != ' ' && OpenFileTextBox.Text[amountWithSpace - 1] != '\n')
                {
                    //Add a wod if the last leter is not a space or new row
                    lastWord = 1;
                }

                //Calculate amount of words
                amountWords = word + lastWord;

                //Check if the current character is a new line
                if (OpenFileTextBox.Text[i] == '\n')
                {
                    //Add a word
                    amountRows++;
                }
            }

            //Display status bar too user
            labWithSpace.Text = $"Antalet tecken med mellanslag: {amountWithSpace}";
            labWithoutSpace.Text = $"Antalet tecken utan mellanslag: {amountWithoutSpace}";
            labAmountWords.Text = $"Antalet ord: {amountWords}";
            labAmountRows.Text = $"Antalet rader: {amountRows}";
        }
        private void OpenFile()
        {
            //Open the explorer for the user to slect file
            OpenFileDialog dialog = new OpenFileDialog();

            //filter for olny letting user select txt files
            dialog.Filter = "Text Files (*.txt)|*.txt";

            //Save the resualt from dialog window
            var resualt = dialog.ShowDialog();

            //Check if user have selected a file or show error message
            if (resualt == DialogResult.OK)
            {
                //Call the method for loading a file
                LoadFile(dialog.FileName);
            }
            else
            {
                //Show message that tells user it abort opening file
                MessageBox.Show(
                                "Du valde inte någon fil",
                                "Avbruten",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }

        }
        private void LoadFile(string FilePath)
        {
            //Load the file contetnt in textbox
            OpenFileTextBox.Text = File.ReadAllText(FilePath);

            //Save the loded content
            FileText = OpenFileTextBox.Text;

            //Find the position of the last \ if filepath name
            int indexName = FilePath.LastIndexOf("\\");

            //Get the find name from filepath name
            string namn = FilePath.Substring(indexName + 1);

            //Set file name in windows bar
            this.Text = namn;
        }
        private bool DroppFileType(string FilePath)
        {
            //Find the position of the last . in filepath
            int indexTyp = FilePath.LastIndexOf(".");

            //Check if file patch have a .
            if (indexTyp > 0)
            {
                //Get the find name from filepath type
                string type = FilePath.Substring(indexTyp);

                if (type != ".txt")
                {
                    //Find the position of the last \ in filepath name
                    int indexName = FilePath.LastIndexOf("\\");

                    //Get the find name from filepath name
                    string namn = FilePath.Substring(indexName + 1);

                    MessageBox.Show(
                                     $"Kan inte läsa in filen {namn}! \nFilen behöver vara i text fomrat (.txt) inte {type}.",
                                     "Avbruten",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show(
                                     $"Kan inte läsa in filen! \nFilen behöver vara i text fomrat (.txt).",
                                     "Avbruten",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void SaveFile()
        {
            //Save text to varible
            FileText = OpenFileTextBox.Text;

            //if file has * in begining remove star
            if (this.Text.StartsWith("*"))
            {
                this.Text = this.Text.Substring(1);
            }

            try
            {
                //Save file 
                File.WriteAllText(this.Text, FileText);

                //Show message
                MessageBox.Show(
                                "Filen är sparad!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch
            {
                //Show message
                MessageBox.Show(
                                "Filen är inte sparad!",
                                "Avbruten",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void ClearTextBox()
        {
            //Clear contetnt in textbox
            OpenFileTextBox.Clear();

            //Set file name in windows bar
            FileText = "";

            //Set file name in windows bar
            this.Text = "namnlös.txt";

        }

        //Variabler
        private static string FileText { get; set; }
        
    }
}
