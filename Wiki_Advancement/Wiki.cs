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


     
    }
}