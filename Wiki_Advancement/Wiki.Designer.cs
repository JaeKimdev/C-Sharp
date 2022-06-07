namespace Wiki_Advancement
{
    partial class Wiki
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDel = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelCat = new System.Windows.Forms.Label();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.groupBoxStr = new System.Windows.Forms.GroupBox();
            this.radioButtonNonLinear = new System.Windows.Forms.RadioButton();
            this.radioButtonLinear = new System.Windows.Forms.RadioButton();
            this.textBoxDef = new System.Windows.Forms.TextBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelDef = new System.Windows.Forms.Label();
            this.textBoxSerch = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listViewWiki = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.groupBoxStr.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 24);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(52, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDel
            // 
            this.buttonDel.Location = new System.Drawing.Point(142, 24);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(52, 23);
            this.buttonDel.TabIndex = 1;
            this.buttonDel.Text = "DEL";
            this.buttonDel.UseVisualStyleBackColor = true;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(77, 24);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(52, 23);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "EDIT";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(73, 58);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(121, 23);
            this.textBoxName.TabIndex = 3;
            this.textBoxName.DoubleClick += new System.EventHandler(this.textBoxName_DoubleClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 62);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(39, 15);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelCat
            // 
            this.labelCat.AutoSize = true;
            this.labelCat.Location = new System.Drawing.Point(12, 90);
            this.labelCat.Name = "labelCat";
            this.labelCat.Size = new System.Drawing.Size(55, 15);
            this.labelCat.TabIndex = 5;
            this.labelCat.Text = "Category";
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(73, 87);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCat.TabIndex = 6;
            // 
            // groupBoxStr
            // 
            this.groupBoxStr.Controls.Add(this.radioButtonNonLinear);
            this.groupBoxStr.Controls.Add(this.radioButtonLinear);
            this.groupBoxStr.Location = new System.Drawing.Point(12, 126);
            this.groupBoxStr.Name = "groupBoxStr";
            this.groupBoxStr.Size = new System.Drawing.Size(182, 72);
            this.groupBoxStr.TabIndex = 7;
            this.groupBoxStr.TabStop = false;
            this.groupBoxStr.Text = "Structure";
            // 
            // radioButtonNonLinear
            // 
            this.radioButtonNonLinear.AutoSize = true;
            this.radioButtonNonLinear.Location = new System.Drawing.Point(80, 32);
            this.radioButtonNonLinear.Name = "radioButtonNonLinear";
            this.radioButtonNonLinear.Size = new System.Drawing.Size(85, 19);
            this.radioButtonNonLinear.TabIndex = 1;
            this.radioButtonNonLinear.TabStop = true;
            this.radioButtonNonLinear.Text = "Non-Linear";
            this.radioButtonNonLinear.UseVisualStyleBackColor = true;
            // 
            // radioButtonLinear
            // 
            this.radioButtonLinear.AutoSize = true;
            this.radioButtonLinear.Location = new System.Drawing.Point(17, 32);
            this.radioButtonLinear.Name = "radioButtonLinear";
            this.radioButtonLinear.Size = new System.Drawing.Size(57, 19);
            this.radioButtonLinear.TabIndex = 0;
            this.radioButtonLinear.TabStop = true;
            this.radioButtonLinear.Text = "Linear";
            this.radioButtonLinear.UseVisualStyleBackColor = true;
            // 
            // textBoxDef
            // 
            this.textBoxDef.Location = new System.Drawing.Point(12, 230);
            this.textBoxDef.Multiline = true;
            this.textBoxDef.Name = "textBoxDef";
            this.textBoxDef.Size = new System.Drawing.Size(182, 138);
            this.textBoxDef.TabIndex = 8;
            this.textBoxDef.DoubleClick += new System.EventHandler(this.textBoxDef_DoubleClick);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(21, 376);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(102, 376);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "SAVE";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelDef
            // 
            this.labelDef.AutoSize = true;
            this.labelDef.Location = new System.Drawing.Point(12, 209);
            this.labelDef.Name = "labelDef";
            this.labelDef.Size = new System.Drawing.Size(59, 15);
            this.labelDef.TabIndex = 11;
            this.labelDef.Text = "Definition";
            // 
            // textBoxSerch
            // 
            this.textBoxSerch.Location = new System.Drawing.Point(235, 25);
            this.textBoxSerch.Name = "textBoxSerch";
            this.textBoxSerch.Size = new System.Drawing.Size(112, 23);
            this.textBoxSerch.TabIndex = 12;
            this.textBoxSerch.DoubleClick += new System.EventHandler(this.textBoxSerch_DoubleClick);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 412);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(430, 22);
            this.statusStrip.TabIndex = 15;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(353, 25);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(51, 23);
            this.buttonSearch.TabIndex = 16;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listViewWiki
            // 
            this.listViewWiki.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewWiki.Location = new System.Drawing.Point(235, 58);
            this.listViewWiki.Name = "listViewWiki";
            this.listViewWiki.Size = new System.Drawing.Size(169, 341);
            this.listViewWiki.TabIndex = 17;
            this.listViewWiki.UseCompatibleStateImageBehavior = false;
            this.listViewWiki.View = System.Windows.Forms.View.Details;
            this.listViewWiki.Click += new System.EventHandler(this.listViewWiki_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Category";
            this.columnHeader2.Width = 90;
            // 
            // Wiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 434);
            this.Controls.Add(this.listViewWiki);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.textBoxSerch);
            this.Controls.Add(this.labelDef);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.textBoxDef);
            this.Controls.Add(this.groupBoxStr);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.labelCat);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Wiki";
            this.Text = "Wiki Application";
            this.Load += new System.EventHandler(this.Wiki_Load);
            this.groupBoxStr.ResumeLayout(false);
            this.groupBoxStr.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAdd;
        private Button buttonDel;
        private Button buttonEdit;
        private TextBox textBoxName;
        private Label labelName;
        private Label labelCat;
        private ComboBox comboBoxCat;
        private GroupBox groupBoxStr;
        private RadioButton radioButtonNonLinear;
        private RadioButton radioButtonLinear;
        private TextBox textBoxDef;
        private Button buttonOpen;
        private Button buttonSave;
        private Label labelDef;
        private TextBox textBoxSerch;
        private StatusStrip statusStrip;
        private Button buttonSearch;
        private ListView listViewWiki;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ToolStripStatusLabel toolStripStatusLabel;
    }
}