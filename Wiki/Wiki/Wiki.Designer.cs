namespace Wiki
{
    partial class Wiki
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxStructure = new System.Windows.Forms.TextBox();
            this.textBoxDefinition = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(12, 15);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(93, 15);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(326, 13);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(233, 273);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonOpen.TabIndex = 3;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(314, 273);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxName
            // 
            this.textBoxName.AccessibleName = "";
            this.textBoxName.Location = new System.Drawing.Point(12, 55);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(156, 20);
            this.textBoxName.TabIndex = 5;
            this.textBoxName.Text = "Name";
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(12, 91);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.ReadOnly = true;
            this.textBoxCategory.Size = new System.Drawing.Size(156, 20);
            this.textBoxCategory.TabIndex = 6;
            this.textBoxCategory.Text = "Category";
            // 
            // textBoxStructure
            // 
            this.textBoxStructure.Location = new System.Drawing.Point(12, 126);
            this.textBoxStructure.Name = "textBoxStructure";
            this.textBoxStructure.ReadOnly = true;
            this.textBoxStructure.Size = new System.Drawing.Size(156, 20);
            this.textBoxStructure.TabIndex = 7;
            this.textBoxStructure.Text = "Structure";
            // 
            // textBoxDefinition
            // 
            this.textBoxDefinition.Location = new System.Drawing.Point(12, 168);
            this.textBoxDefinition.Multiline = true;
            this.textBoxDefinition.Name = "textBoxDefinition";
            this.textBoxDefinition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDefinition.Size = new System.Drawing.Size(156, 125);
            this.textBoxDefinition.TabIndex = 8;
            this.textBoxDefinition.Text = "Definition";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(220, 15);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 9;
            // 
            // listBoxOutput
            // 
            this.listBoxOutput.FormattingEnabled = true;
            this.listBoxOutput.Location = new System.Drawing.Point(220, 55);
            this.listBoxOutput.Name = "listBoxOutput";
            this.listBoxOutput.Size = new System.Drawing.Size(181, 212);
            this.listBoxOutput.TabIndex = 10;
            // 
            // Wiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 319);
            this.Controls.Add(this.listBoxOutput);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBoxDefinition);
            this.Controls.Add(this.textBoxStructure);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Wiki";
            this.Text = "Wiki";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxStructure;
        private System.Windows.Forms.TextBox textBoxDefinition;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListBox listBoxOutput;
    }
}

