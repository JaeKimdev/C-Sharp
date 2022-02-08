namespace WeekTwoV1
{
    partial class FormingArray
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
            this.ButtonRandomize = new System.Windows.Forms.Button();
            this.ButtonInitialize = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ListboxDisplay = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ButtonRandomize
            // 
            this.ButtonRandomize.Location = new System.Drawing.Point(21, 12);
            this.ButtonRandomize.Name = "ButtonRandomize";
            this.ButtonRandomize.Size = new System.Drawing.Size(90, 34);
            this.ButtonRandomize.TabIndex = 0;
            this.ButtonRandomize.Text = "Randomize";
            this.ButtonRandomize.UseVisualStyleBackColor = true;
            this.ButtonRandomize.Click += new System.EventHandler(this.ButtonRandomize_Click);
            // 
            // ButtonInitialize
            // 
            this.ButtonInitialize.Location = new System.Drawing.Point(117, 12);
            this.ButtonInitialize.Name = "ButtonInitialize";
            this.ButtonInitialize.Size = new System.Drawing.Size(90, 34);
            this.ButtonInitialize.TabIndex = 1;
            this.ButtonInitialize.Text = "Initialize";
            this.ButtonInitialize.UseVisualStyleBackColor = true;
            this.ButtonInitialize.Click += new System.EventHandler(this.ButtonInitialize_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(213, 12);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(84, 34);
            this.ButtonSort.TabIndex = 2;
            this.ButtonSort.Text = "Sort";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ListboxDisplay
            // 
            this.ListboxDisplay.FormattingEnabled = true;
            this.ListboxDisplay.Location = new System.Drawing.Point(12, 64);
            this.ListboxDisplay.Name = "ListboxDisplay";
            this.ListboxDisplay.Size = new System.Drawing.Size(491, 368);
            this.ListboxDisplay.TabIndex = 3;
            // 
            // FormingArray
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 450);
            this.Controls.Add(this.ListboxDisplay);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonInitialize);
            this.Controls.Add(this.ButtonRandomize);
            this.Name = "FormingArray";
            this.Text = "2D Integer Array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonRandomize;
        private System.Windows.Forms.Button ButtonInitialize;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.ListBox ListboxDisplay;
    }
}

