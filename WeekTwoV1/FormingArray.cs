using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Jae Kim
// /Don't use code inside the initialize component anymore
// Date: 08/02/2022

namespace WeekTwoV1
{
    public partial class FormingArray : Form
    {
        public FormingArray()
        {
            InitializeComponent();
        }
        static int rowSize = 10; // x
        static int colSize = 10; // y
        static int[,] myArray = new int [rowSize, colSize];
        string fileName = "array.bin";

        #region DisplayArray
        private void DisplayArray()
        {
            ListboxDisplay.Items.Clear();
            for (int x = 0; x < rowSize; x++)
            // aligning x with a row
            {
                ListboxDisplay.Items.Add(" ");
                // This is only for displaying the array
                string oneLine = " ";
                for (int y = 0; y < colSize; y++)
                {
                    oneLine = oneLine + "    " + myArray[x, y];
                }
                // at this point you can change the x & y to i & k to avoid confusion
                // add up all little colunms and put them in a single string and print them out. 
                ListboxDisplay.Items.Add(oneLine);
            }

        }
        #endregion
        #region Initialize
        private void ButtonInitialize_Click(object sender, EventArgs e)
        {
            
            for (int y = 0; y < colSize; y++)
            {
                for (int x = 0; x < rowSize; x++)
                {
                    myArray[x, y] = x + 1;
                    // populating and then displaying the array
                }
            }
            DisplayArray();
        }
        #endregion
        #region Randomize
        private void ButtonRandomize_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            for (int x = 0; x < rowSize; x++)
            // aligning x with a row
            {
                for (int y = 0; y < colSize; y++)
                {
                    myArray[x, y] = r.Next(100, 1000);
                    //myArray[x, y] = x + 1;
                    // populating and then displaying the array

                    //add pause
                }
            }
            DisplayArray();
        }
        #endregion
        #region Sort
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            for (int row_x = 0; row_x < rowSize; row_x++)
            // row
            {
                for (int col_y = 0; col_y < colSize; col_y++)
                // column
                {
                    for (int i = 0; i < rowSize; i++)
                    {
                        for (int j = 0; j < colSize; j++)
                        {
                            if (myArray[i, j] > myArray[row_x, col_y])

                            {
                                int temp = myArray[row_x, col_y];
                                // two items you're swapping
                                myArray[row_x, col_y] = myArray[i, j];
                                myArray[i, j] = temp;

                            }
                        }
                    }

                }
            }
            DisplayArray();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            int target = int.Parse(TextBoxTarget.Text);
            int row = 0;
            int col = colSize - 1;
            while ((row <= rowSize -1) && (col >= 0))
            {
                if (myArray[row, col] < target)
                {
                   ListboxDisplay.Items.Add("[" + "matrix" + row + "," + col + "]" + myArray[row, col]);
                    row++;
                }
                else if (myArray[row, col] > target)
                {
                    ListboxDisplay.Items.Add("[" + "matrix" + row + "," + col + "]" + myArray[row, col]);
                    col--;
                }
                else
                {
                    ListboxDisplay.Items.Add("Found");
                    return;
                }

            }
            ListboxDisplay.Items.Add("Not Found");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int y =0; y < colSize; y++)
                    {
                        for (int x =0; x < rowSize; x++)
                            bin.Serialize(stream, myArray[x, y]);
                    }
                }

            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = File.Open(fileName, FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    for (int y = 0; y < colSize; y++)
                    {
                        for (int x = 0; x < rowSize; x++)
                        {
                            myArray[x,y] = (int)bin.Deserialize(stream);
                        }
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DisplayArray();
        }
    }
}
#endregion

