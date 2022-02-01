
namespace Vehicle_Registration_Management
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBoxDisplay = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonBinSearch = new System.Windows.Forms.Button();
            this.buttonLinearSearch = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.toolStripStatus = new System.Windows.Forms.ToolStrip();
            this.StatusStripMessage = new System.Windows.Forms.ToolStripLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkTag = new System.Windows.Forms.CheckBox();
            this.toolStripStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxDisplay
            // 
            this.listBoxDisplay.FormattingEnabled = true;
            this.listBoxDisplay.Location = new System.Drawing.Point(25, 11);
            this.listBoxDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.listBoxDisplay.Name = "listBoxDisplay";
            this.listBoxDisplay.Size = new System.Drawing.Size(129, 277);
            this.listBoxDisplay.TabIndex = 0;
            this.listBoxDisplay.Click += new System.EventHandler(this.listBoxDisplay_Click);
            this.listBoxDisplay.DoubleClick += new System.EventHandler(this.listBoxDisplay_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(173, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Plate Details :";
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(175, 60);
            this.buttonEnter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(62, 21);
            this.buttonEnter.TabIndex = 2;
            this.buttonEnter.Text = "Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "Click to Add");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(175, 31);
            this.textBoxInput.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(116, 21);
            this.textBoxInput.TabIndex = 3;
            this.toolTip1.SetToolTip(this.textBoxInput, "Double click to Clear");
            this.textBoxInput.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.textBoxInput_MouseDoubleClick);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(240, 60);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(62, 21);
            this.buttonEdit.TabIndex = 4;
            this.buttonEdit.Text = "Edit";
            this.toolTip1.SetToolTip(this.buttonEdit, "Click to Edit");
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(175, 86);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(62, 20);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.toolTip1.SetToolTip(this.buttonDelete, "Click to Delete");
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonBinSearch
            // 
            this.buttonBinSearch.Location = new System.Drawing.Point(175, 126);
            this.buttonBinSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBinSearch.Name = "buttonBinSearch";
            this.buttonBinSearch.Size = new System.Drawing.Size(62, 20);
            this.buttonBinSearch.TabIndex = 7;
            this.buttonBinSearch.Text = "B.Search";
            this.toolTip1.SetToolTip(this.buttonBinSearch, "Binary Search");
            this.buttonBinSearch.UseVisualStyleBackColor = true;
            this.buttonBinSearch.Click += new System.EventHandler(this.buttonBinSearch_Click);
            // 
            // buttonLinearSearch
            // 
            this.buttonLinearSearch.Location = new System.Drawing.Point(240, 126);
            this.buttonLinearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLinearSearch.Name = "buttonLinearSearch";
            this.buttonLinearSearch.Size = new System.Drawing.Size(62, 20);
            this.buttonLinearSearch.TabIndex = 8;
            this.buttonLinearSearch.Text = "L.Search";
            this.toolTip1.SetToolTip(this.buttonLinearSearch, "Linear Search");
            this.buttonLinearSearch.UseVisualStyleBackColor = true;
            this.buttonLinearSearch.Click += new System.EventHandler(this.buttonLinearSearch_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(175, 172);
            this.buttonOpen.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(62, 20);
            this.buttonOpen.TabIndex = 9;
            this.buttonOpen.Text = "Open";
            this.toolTip1.SetToolTip(this.buttonOpen, "Open file");
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(240, 172);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(62, 20);
            this.buttonSave.TabIndex = 10;
            this.buttonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.buttonSave, "Save to file");
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(175, 204);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(62, 20);
            this.buttonReset.TabIndex = 11;
            this.buttonReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "Click to Reset");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripStatus.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusStripMessage});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 299);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripStatus.Size = new System.Drawing.Size(340, 25);
            this.toolStripStatus.TabIndex = 12;
            this.toolStripStatus.Text = "toolStrip1";
            // 
            // StatusStripMessage
            // 
            this.StatusStripMessage.Name = "StatusStripMessage";
            this.StatusStripMessage.Size = new System.Drawing.Size(12, 22);
            this.StatusStripMessage.Text = "-";
            // 
            // checkTag
            // 
            this.checkTag.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkTag.AutoSize = true;
            this.checkTag.Checked = true;
            this.checkTag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTag.Location = new System.Drawing.Point(240, 83);
            this.checkTag.Name = "checkTag";
            this.checkTag.Size = new System.Drawing.Size(63, 23);
            this.checkTag.TabIndex = 13;
            this.checkTag.Text = "     Tag    ";
            this.checkTag.UseVisualStyleBackColor = true;
            this.checkTag.CheckedChanged += new System.EventHandler(this.checkTag_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 324);
            this.Controls.Add(this.checkTag);
            this.Controls.Add(this.toolStripStatus);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonLinearSearch);
            this.Controls.Add(this.buttonBinSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Vehicle Registration Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonBinSearch;
        private System.Windows.Forms.Button buttonLinearSearch;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.ToolStrip toolStripStatus;
        private System.Windows.Forms.ToolStripLabel StatusStripMessage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkTag;
    }
}

