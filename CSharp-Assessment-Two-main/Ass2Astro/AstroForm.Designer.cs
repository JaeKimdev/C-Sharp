
namespace Ass2Astro
{
    partial class AstroForm
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
            this.ListBoxDisplay = new System.Windows.Forms.ListBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.TextBoxInput = new System.Windows.Forms.TextBox();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ToolStripStatus = new System.Windows.Forms.ToolStrip();
            this.StatusStripMessage = new System.Windows.Forms.ToolStripLabel();
            this.ButtonFillArray = new System.Windows.Forms.Button();
            this.ButtonSeqSearch = new System.Windows.Forms.Button();
            this.ButtonMid = new System.Windows.Forms.Button();
            this.ButtonAvg = new System.Windows.Forms.Button();
            this.ButtonRange = new System.Windows.Forms.Button();
            this.ButtonMode = new System.Windows.Forms.Button();
            this.textBoxMid = new System.Windows.Forms.TextBox();
            this.textBoxAvg = new System.Windows.Forms.TextBox();
            this.textBoxRange = new System.Windows.Forms.TextBox();
            this.textBoxMode = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ToolStripStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxDisplay
            // 
            this.ListBoxDisplay.FormattingEnabled = true;
            this.ListBoxDisplay.ItemHeight = 24;
            this.ListBoxDisplay.Location = new System.Drawing.Point(26, 22);
            this.ListBoxDisplay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ListBoxDisplay.Name = "ListBoxDisplay";
            this.ListBoxDisplay.Size = new System.Drawing.Size(336, 604);
            this.ListBoxDisplay.TabIndex = 0;
            this.ListBoxDisplay.Click += new System.EventHandler(this.ListBoxDisplay_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(399, 76);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(163, 42);
            this.ButtonAdd.TabIndex = 1;
            this.ButtonAdd.Text = "Add";
            this.toolTip1.SetToolTip(this.ButtonAdd, "Click to add a data point");
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // TextBoxInput
            // 
            this.TextBoxInput.Location = new System.Drawing.Point(399, 28);
            this.TextBoxInput.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.TextBoxInput.Name = "TextBoxInput";
            this.TextBoxInput.Size = new System.Drawing.Size(158, 35);
            this.TextBoxInput.TabIndex = 2;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(399, 129);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(163, 42);
            this.ButtonDelete.TabIndex = 3;
            this.ButtonDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.ButtonDelete, "Click to Delete the selected data point");
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Location = new System.Drawing.Point(574, 78);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(163, 42);
            this.ButtonEdit.TabIndex = 4;
            this.ButtonEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.ButtonEdit, "Click to edit the selected data point");
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(574, 131);
            this.ButtonSort.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(163, 42);
            this.ButtonSort.TabIndex = 5;
            this.ButtonSort.Text = "Sort";
            this.toolTip1.SetToolTip(this.ButtonSort, "Click to sort the array");
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(399, 207);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(163, 42);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.Text = "Bin.Search";
            this.toolTip1.SetToolTip(this.ButtonSearch, "Click to do a Binary Search");
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ToolStripStatus
            // 
            this.ToolStripStatus.AllowDrop = true;
            this.ToolStripStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStripStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ToolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripMessage});
            this.ToolStripStatus.Location = new System.Drawing.Point(0, 660);
            this.ToolStripStatus.Name = "ToolStripStatus";
            this.ToolStripStatus.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.ToolStripStatus.Size = new System.Drawing.Size(802, 38);
            this.ToolStripStatus.TabIndex = 7;
            this.ToolStripStatus.Text = "toolStrip1";
            // 
            // StatusStripMessage
            // 
            this.StatusStripMessage.Name = "StatusStripMessage";
            this.StatusStripMessage.Size = new System.Drawing.Size(25, 32);
            this.StatusStripMessage.Text = "-";
            // 
            // ButtonFillArray
            // 
            this.ButtonFillArray.Location = new System.Drawing.Point(574, 24);
            this.ButtonFillArray.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonFillArray.Name = "ButtonFillArray";
            this.ButtonFillArray.Size = new System.Drawing.Size(163, 42);
            this.ButtonFillArray.TabIndex = 8;
            this.ButtonFillArray.Text = "Fill Array";
            this.toolTip1.SetToolTip(this.ButtonFillArray, "Click to fill the array with random data");
            this.ButtonFillArray.UseVisualStyleBackColor = true;
            this.ButtonFillArray.Click += new System.EventHandler(this.ButtonFillArray_Click);
            // 
            // ButtonSeqSearch
            // 
            this.ButtonSeqSearch.Location = new System.Drawing.Point(574, 207);
            this.ButtonSeqSearch.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonSeqSearch.Name = "ButtonSeqSearch";
            this.ButtonSeqSearch.Size = new System.Drawing.Size(163, 42);
            this.ButtonSeqSearch.TabIndex = 9;
            this.ButtonSeqSearch.Text = "Seq.Search";
            this.toolTip1.SetToolTip(this.ButtonSeqSearch, "Click to do a Sequential Search");
            this.ButtonSeqSearch.UseVisualStyleBackColor = true;
            this.ButtonSeqSearch.Click += new System.EventHandler(this.ButtonSeqSearch_Click);
            // 
            // ButtonMid
            // 
            this.ButtonMid.Location = new System.Drawing.Point(399, 286);
            this.ButtonMid.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonMid.Name = "ButtonMid";
            this.ButtonMid.Size = new System.Drawing.Size(163, 42);
            this.ButtonMid.TabIndex = 10;
            this.ButtonMid.Text = "Mid-extreme";
            this.toolTip1.SetToolTip(this.ButtonMid, "Click to calculate the Mid-Extreme");
            this.ButtonMid.UseVisualStyleBackColor = true;
            this.ButtonMid.Click += new System.EventHandler(this.ButtonMid_Click);
            // 
            // ButtonAvg
            // 
            this.ButtonAvg.Location = new System.Drawing.Point(399, 340);
            this.ButtonAvg.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonAvg.Name = "ButtonAvg";
            this.ButtonAvg.Size = new System.Drawing.Size(163, 42);
            this.ButtonAvg.TabIndex = 11;
            this.ButtonAvg.Text = "Average";
            this.toolTip1.SetToolTip(this.ButtonAvg, "Click to calculate the Average");
            this.ButtonAvg.UseVisualStyleBackColor = true;
            this.ButtonAvg.Click += new System.EventHandler(this.ButtonAvg_Click);
            // 
            // ButtonRange
            // 
            this.ButtonRange.Location = new System.Drawing.Point(399, 393);
            this.ButtonRange.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonRange.Name = "ButtonRange";
            this.ButtonRange.Size = new System.Drawing.Size(163, 42);
            this.ButtonRange.TabIndex = 12;
            this.ButtonRange.Text = "Range";
            this.toolTip1.SetToolTip(this.ButtonRange, "Click to calculate the Range");
            this.ButtonRange.UseVisualStyleBackColor = true;
            this.ButtonRange.Click += new System.EventHandler(this.ButtonRange_Click);
            // 
            // ButtonMode
            // 
            this.ButtonMode.Location = new System.Drawing.Point(399, 447);
            this.ButtonMode.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.ButtonMode.Name = "ButtonMode";
            this.ButtonMode.Size = new System.Drawing.Size(163, 42);
            this.ButtonMode.TabIndex = 13;
            this.ButtonMode.Text = "Mode";
            this.toolTip1.SetToolTip(this.ButtonMode, "Click to calculate the Mode");
            this.ButtonMode.UseVisualStyleBackColor = true;
            this.ButtonMode.Click += new System.EventHandler(this.ButtonMode_Click);
            // 
            // textBoxMid
            // 
            this.textBoxMid.Location = new System.Drawing.Point(574, 290);
            this.textBoxMid.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxMid.Name = "textBoxMid";
            this.textBoxMid.ReadOnly = true;
            this.textBoxMid.Size = new System.Drawing.Size(158, 35);
            this.textBoxMid.TabIndex = 14;
            // 
            // textBoxAvg
            // 
            this.textBoxAvg.Location = new System.Drawing.Point(574, 345);
            this.textBoxAvg.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxAvg.Name = "textBoxAvg";
            this.textBoxAvg.ReadOnly = true;
            this.textBoxAvg.Size = new System.Drawing.Size(158, 35);
            this.textBoxAvg.TabIndex = 15;
            // 
            // textBoxRange
            // 
            this.textBoxRange.Location = new System.Drawing.Point(574, 393);
            this.textBoxRange.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxRange.Name = "textBoxRange";
            this.textBoxRange.ReadOnly = true;
            this.textBoxRange.Size = new System.Drawing.Size(158, 35);
            this.textBoxRange.TabIndex = 16;
            // 
            // textBoxMode
            // 
            this.textBoxMode.Location = new System.Drawing.Point(574, 450);
            this.textBoxMode.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.textBoxMode.Name = "textBoxMode";
            this.textBoxMode.ReadOnly = true;
            this.textBoxMode.Size = new System.Drawing.Size(158, 35);
            this.textBoxMode.TabIndex = 17;
            // 
            // AstroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 698);
            this.Controls.Add(this.textBoxMode);
            this.Controls.Add(this.textBoxRange);
            this.Controls.Add(this.textBoxAvg);
            this.Controls.Add(this.textBoxMid);
            this.Controls.Add(this.ButtonMode);
            this.Controls.Add(this.ButtonRange);
            this.Controls.Add(this.ButtonAvg);
            this.Controls.Add(this.ButtonMid);
            this.Controls.Add(this.ButtonSeqSearch);
            this.Controls.Add(this.ButtonFillArray);
            this.Controls.Add(this.ToolStripStatus);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.TextBoxInput);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ListBoxDisplay);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "AstroForm";
            this.Text = "Astronomical Processing";
            this.ToolStripStatus.ResumeLayout(false);
            this.ToolStripStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxDisplay;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.TextBox TextBoxInput;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.ToolStrip ToolStripStatus;
        private System.Windows.Forms.ToolStripLabel StatusStripMessage;
        private System.Windows.Forms.Button ButtonFillArray;
        private System.Windows.Forms.Button ButtonSeqSearch;
        private System.Windows.Forms.Button ButtonMid;
        private System.Windows.Forms.Button ButtonAvg;
        private System.Windows.Forms.Button ButtonRange;
        private System.Windows.Forms.Button ButtonMode;
        private System.Windows.Forms.TextBox textBoxMid;
        private System.Windows.Forms.TextBox textBoxAvg;
        private System.Windows.Forms.TextBox textBoxRange;
        private System.Windows.Forms.TextBox textBoxMode;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

