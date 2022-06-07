using System.Diagnostics;
using System.Text;

namespace Wiki_Advancement
{
    public partial class Wiki : Form
    {
        public Wiki()
        {
            InitializeComponent();
            string[] categories = { "Array", "Tree", "Graphs", "List", "Hash", "Abstract" };
            comboBoxCat.DataSource = categories;

            Stream myTraceTestFile = File.Create("TestFile.txt");
            TextWriterTraceListener myTraceListner = new TextWriterTraceListener(myTraceTestFile);
            Trace.Listeners.Add(myTraceListner);
            Trace.AutoFlush = true;
            Trace.WriteLine("### Debug Data Log Start ###");
            Trace.WriteLine("");
        }

        // 6.2 Create a global List<T> of type Information called Wiki.
        List<Information> myWiki = new List<Information>();
        string defaultFileName = "information.dat";

        private void Wiki_Load(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogVG = new OpenFileDialog();
            openFileDialogVG.InitialDirectory = Application.StartupPath;
            openFileDialogVG.Filter = "DAT Files|*.dat";
            openFileDialogVG.Title = "Select a DAT File";
            if (openFileDialogVG.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(openFileDialogVG.FileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        myWiki.Clear();
                        while (stream.Position < stream.Length)
                        {
                            Information readInfo = new Information();
                            readInfo.setName(reader.ReadString());
                            readInfo.setCategory(reader.ReadString());
                            readInfo.setStructure(reader.ReadString());
                            readInfo.setDefinition(reader.ReadString());
                            myWiki.Add(readInfo);
                        }
                    }
                }
                Trace.WriteLine("Wiki Data Loaded");
                displayList();
            }
            else
            {
                Trace.WriteLine("Wiki Data Load canceled");
            }
        }
        // 6.3 Create a button method to ADD a new item to the list. Use a TextBox for the Name input, ComboBox for the Category,
        //Radio group for the Structure and Multiline TextBox for the Definition.
        #region Add, Edit, Deltete
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                !string.IsNullOrWhiteSpace(textBoxDef.Text)) {
                var result = MessageBox.Show("Proceed with new Record?", "Add New Record",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    if (ValidName(textBoxName.Text))
                    {
                        resetColor();
                        Information newInformation = new Information();
                        newInformation.setName(textBoxName.Text);
                        newInformation.setCategory(comboBoxCat.Text);
                        newInformation.setStructure(RadioBtnString());
                        newInformation.setDefinition(textBoxDef.Text);
                        myWiki.Add(newInformation);

                        clearTextbox();
                        displayList();
                        toolStripStatusLabel.Text = "Item successfully added.";
                    }
                    else { }
                }
                else
                {
                    toolStripStatusLabel.Text = "Data Not Added";
                }
            } else
            {
                toolStripStatusLabel.Text = "Please input every fields to Add data";
            }
        }

        // 6.8 Create a button method that will save the edited record of the currently selected item in the ListView.
        // All the changes in the input controls will be written back to the list.
        // Display an updated version of the sorted list at the end of this process.

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                resetColor();
                int currentRecord = listViewWiki.SelectedIndices[0];
                if (currentRecord >= 0)
                {
                    var result = MessageBox.Show("Proceed with update?", "Edit Record",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (result == DialogResult.OK)
                    {
                        if (ValidName(textBoxName.Text))
                        {
                            myWiki[currentRecord].setName(textBoxName.Text);
                            myWiki[currentRecord].setDefinition(textBoxDef.Text);
                            myWiki[currentRecord].setCategory(comboBoxCat.Text);
                            myWiki[currentRecord].setStructure(RadioBtnString());

                            clearTextbox();
                            displayList();
                            toolStripStatusLabel.Text = "Item successfully Edited.";
                        } else { }
                    }
                    else // If user click 'No', show messege
                    {
                        toolStripStatusLabel.Text = "Data NOT Edited";
                    }
                }
            }
            catch (Exception) // Prevent to click without select data
            {
                toolStripStatusLabel.Text = "Please select data to Edit!";
                clearTextbox();
            }
        }

        // 6.7 Create a button method that will delete the currently selected record in the ListView.
        // Ensure the user has the option to backout of this action by using a dialog box.
        // Display an updated version of the sorted list at the end of this process.
        private void buttonDel_Click(object sender, EventArgs e)
        {
            resetColor();
            try
            {
                int currentRecord = listViewWiki.SelectedIndices[0];
                Trace.WriteLine("Delete - currentRecord : " + currentRecord);
                if (currentRecord >= 0)
                {
                    DialogResult delName = MessageBox.Show("Do you wish to delete this Name?",
                     "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (delName == DialogResult.Yes)
                    {
                        myWiki.RemoveAt(currentRecord);

                        clearTextbox();
                        displayList();
                        toolStripStatusLabel.Text = "Item successfully Deleted.";
                    }
                    else // If user click 'No', show messege
                    {
                        toolStripStatusLabel.Text = "Data NOT Deleted";
                    }
                }

            }
            catch (Exception) // Prevent to click without select data
            {
                toolStripStatusLabel.Text = "Please select data to delete";
                clearTextbox();
            }
        }
        #endregion

        // 6.5 Create a custom ValidName method which will take a parameter string value from the Textbox Name and returns a Boolean after checking for duplicates.
        // Use the built in List<T> method “Exists” to answer this requirement.
        private bool ValidName(String a)
        {
            if (!myWiki.Exists(dup => dup.getName() == a))
            {
                Trace.WriteLine("Valid Name = true");
                return true;
            }
            else
            {
                Trace.WriteLine("Valid Name = false");
                toolStripStatusLabel.Text = "Invalid Name, Name Duplicated";
                return false;
            }
        }

        // 6.6 Create two methods to highlight and return the values from the Radio button GroupBox.
        // The first method must return a string value from the selected radio button (Linear or Non-Linear).
        // The second method must send an integer index which will highlight an appropriate radio button.
        #region Radio Button
        private string RadioBtnString()
        {
            if (radioButtonLinear.Checked)
            {
                Trace.WriteLine("radioButton - Linear");
                return "Linear";
            }
            else
            {
                Trace.WriteLine("radioButton - NoN Linear");
                return "Non-Linear";
            }
        }

        private void RadioBtnHighlight(int index)
        {
            if (index == 0)
            {
                Trace.WriteLine("radioButton - Checked");
                radioButtonLinear.Checked = true;
            }
            else
            {
                Trace.WriteLine("radioButton - Not Checked");
                radioButtonNonLinear.Checked = true;
            }
        }
        #endregion

        // 6.12 Create a custom method that will clear and reset the TextBboxes, ComboBox and Radio button
        #region Clear TextBox
        private void clearTextbox()
        {
            textBoxName.Clear();
            comboBoxCat.SelectedIndex = -1;
            radioButtonLinear.Checked = false;
            radioButtonNonLinear.Checked = false;
            textBoxDef.Clear();
            Trace.WriteLine("Text Box Cleared");
        }
        #endregion

        // 6.9 Create a single custom method that will sort and then display the Name and Category from the wiki information in the list.
        #region Display
        private void displayList()
        {
            myWiki.Sort();
            listViewWiki.Items.Clear();
            listViewWiki.ForeColor = Color.Black;
            foreach (var information in myWiki)
            {
               listViewWiki.Items.Add(information.displayInformation());
            }
            Trace.WriteLine("ListView Sorted");
        }
        #endregion

        private void resetColor()
        {
            for (int i = 0; i < myWiki.Count; i++)
            {
                listViewWiki.Items[i].ForeColor = Color.Black;
                listViewWiki.Items[i].BackColor = Color.White;
            }
            Trace.WriteLine("ListView Color Reset");
        }

        // 6.11 Create a ListView event so a user can select a Data Structure Name from the list of Names and the associated information
        // will be displayed in the related text boxes combo box and radio button.
        #region ListView Wiki
        private void listViewWiki_Click(object sender, EventArgs e)
        {
            int currentRecordIndex = listViewWiki.SelectedIndices[0];
            Trace.WriteLine("ListView index : " + currentRecordIndex + " Clicked");
            textBoxName.Text = myWiki[currentRecordIndex].getName();
            comboBoxCat.Text = myWiki[currentRecordIndex].getCategory();
            if (myWiki[currentRecordIndex].getStructure() == "Linear")
            {
                RadioBtnHighlight(0);
                Trace.WriteLine("ListView Click : Linear RadioBtn On");
            }

            else
            {
                RadioBtnHighlight(1);
                Trace.WriteLine("ListView Click : Non Linear RadioBtn On");
            }
            textBoxDef.Text = myWiki[currentRecordIndex].getDefinition();
        }
        #endregion

        // 6.10 Create a button method that will use the builtin binary search to find a Data Structure name.
        // If the record is found the associated details will populate the appropriate input controls and highlight the name in the ListView.
        // At the end of the search process the search input TextBox must be cleared.
        #region Search
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            resetColor();

            if (!string.IsNullOrEmpty(textBoxSerch.Text))
            {
                Information target = new Information();
                target.setName(textBoxSerch.Text);
                int search = myWiki.BinarySearch(target);

                if (search >= 0)
                {
                    listViewWiki.Focus();
                    listViewWiki.Items[search].BackColor = Color.Blue;
                    listViewWiki.Items[search].ForeColor = Color.White;
                    toolStripStatusLabel.Text = textBoxSerch.Text + " found !";
                }
                else
                    toolStripStatusLabel.Text = textBoxSerch.Text + " is not found !";

                textBoxSerch.Clear();
            }
            else
            {
                toolStripStatusLabel.Text = "Please input text to search";
            }
        }
        #endregion

        // 6.14 Create two buttons for the manual open and save option; this must use a dialog box to select a file or rename a saved file.
        // All Wiki data is stored/retrieved using a binary file format.
        #region Open, Save
        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialogVG = new OpenFileDialog();
            openFileDialogVG.InitialDirectory = Application.StartupPath;
            openFileDialogVG.Filter = "dat Files|*.dat";
            openFileDialogVG.Title = "Select a Dat File";
            if (openFileDialogVG.ShowDialog() == DialogResult.OK)
            {
                openRecord(openFileDialogVG.FileName);
            }
            Trace.WriteLine("Load Data file");
        }

        private void openRecord(string openFileName)
        {
            try
            {
                using (Stream stream = File.Open(openFileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        myWiki.Clear();
                        while (stream.Position < stream.Length)
                        {
                            Information readInfo = new Information();
                            readInfo.setName(reader.ReadString());
                            readInfo.setCategory(reader.ReadString());
                            readInfo.setStructure(reader.ReadString());
                            readInfo.setDefinition(reader.ReadString());
                            myWiki.Add(readInfo);
                        }
                    }
                }

            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            displayList();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogVG = new SaveFileDialog();
            saveFileDialogVG.Filter = "dat file|*.dat";
            saveFileDialogVG.Title = "Save a Dat File";
            saveFileDialogVG.InitialDirectory = Application.StartupPath;
            saveFileDialogVG.DefaultExt = "dat";
            saveFileDialogVG.ShowDialog();

            string fileName = saveFileDialogVG.FileName;
            if (saveFileDialogVG.FileName != "")
            {
                saveRecord(fileName);
            }
            else
            {
                saveRecord(defaultFileName);
            }
            Trace.WriteLine("Save Data File");
        }

        private void saveRecord(string saveFileName)
        {
            try
            {
                using (var stream = File.Open(saveFileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    foreach (var x in myWiki)
                    {
                        writer.Write(x.getName());
                        writer.Write(x.getCategory());
                        writer.Write(x.getStructure());
                        writer.Write(x.getDefinition());
                    }
                }
            }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion

        // 6.13 Create a double click event on the Name TextBox to clear the TextBboxes, ComboBox and Radio button.
        #region Doubble Click
        private void textBoxName_DoubleClick(object sender, EventArgs e)
        {
            clearTextbox();
        }

        private void textBoxDef_DoubleClick(object sender, EventArgs e)
        {
            clearTextbox();
        }

        private void textBoxSerch_DoubleClick(object sender, EventArgs e)
        {
            clearTextbox();
        }
        #endregion

        // 6.15 The Wiki application will save data when the form closes. 
        private void Wiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveRecord(defaultFileName);
        }

     
    }
}