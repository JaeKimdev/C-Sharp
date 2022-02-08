using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        static int row = 10; // x
        static int col = 10; // y
        static int[,] myArray = new int [row,col];

        #region DisplayArray
        private void DisplayArray()
        {
            ListboxDisplay.Items.Clear();
            for (int x = 0; x < row; x++)
            // aligning x with a row
            {
                ListboxDisplay.Items.Add(" ");
                // This is only for displaying the array
                string oneLine = " ";
                for (int y = 0; y < col; y++)
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
            
            for (int x = 0; x < row; x++)
 
            // aligning x with a row
            {
                for (int y = 0; y < col; y++)
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
            for (int x = 0; x < row; x++)
            // aligning x with a row
            {
                for (int y = 0; y < col; y++)
                {
                    myArray[x, y] = r.Next(100, 1000);
                    //myArray[x, y] = x + 1;
                    // populating and then displaying the array
                }
            }
            DisplayArray();
        }
        #endregion
        #region Sort
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            for (int row_x = 0; row_x < row; row_x++)
            // row
            {
                for (int col_y = 0; col_y < col; col_y++)
                // column
                {
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
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
        #endregion
    }
}

