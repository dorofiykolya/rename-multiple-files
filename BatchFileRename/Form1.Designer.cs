namespace BatchFileRename
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.inputList = new System.Windows.Forms.ListBox();
            this.outputList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.extensionComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.outputComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.regexpComboBox = new System.Windows.Forms.ComboBox();
            this.regexpCheckBox = new System.Windows.Forms.CheckBox();
            this.caseSensCheckBox = new System.Windows.Forms.CheckBox();
            this.replaceOutTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.replaceInTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.extensionTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filenNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTextComboBox = new System.Windows.Forms.ComboBox();
            this.runButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.fileNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.inputList);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.outputList);
            // 
            // inputList
            // 
            resources.ApplyResources(this.inputList, "inputList");
            this.inputList.FormattingEnabled = true;
            this.inputList.Name = "inputList";
            // 
            // outputList
            // 
            resources.ApplyResources(this.outputList, "outputList");
            this.outputList.FormattingEnabled = true;
            this.outputList.Name = "outputList";
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.runButton);
            this.panel1.Name = "panel1";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.extensionComboBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.outputComboBox);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // extensionComboBox
            // 
            resources.ApplyResources(this.extensionComboBox, "extensionComboBox");
            this.extensionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.extensionComboBox.FormattingEnabled = true;
            this.extensionComboBox.Name = "extensionComboBox";
            this.extensionComboBox.SelectedIndexChanged += new System.EventHandler(this.extensionComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // outputComboBox
            // 
            resources.ApplyResources(this.outputComboBox, "outputComboBox");
            this.outputComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.outputComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.outputComboBox.FormattingEnabled = true;
            this.outputComboBox.Name = "outputComboBox";
            this.outputComboBox.SelectedIndexChanged += new System.EventHandler(this.outputComboBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.regexpComboBox);
            this.groupBox2.Controls.Add(this.regexpCheckBox);
            this.groupBox2.Controls.Add(this.caseSensCheckBox);
            this.groupBox2.Controls.Add(this.replaceOutTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.replaceInTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // regexpComboBox
            // 
            resources.ApplyResources(this.regexpComboBox, "regexpComboBox");
            this.regexpComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.regexpComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.regexpComboBox.FormattingEnabled = true;
            this.regexpComboBox.Name = "regexpComboBox";
            this.regexpComboBox.SelectedIndexChanged += new System.EventHandler(this.regexpComboBox_SelectedIndexChanged);
            // 
            // regexpCheckBox
            // 
            resources.ApplyResources(this.regexpCheckBox, "regexpCheckBox");
            this.regexpCheckBox.Name = "regexpCheckBox";
            this.regexpCheckBox.UseVisualStyleBackColor = true;
            this.regexpCheckBox.CheckedChanged += new System.EventHandler(this.regexpCheckBox_CheckedChanged);
            // 
            // caseSensCheckBox
            // 
            resources.ApplyResources(this.caseSensCheckBox, "caseSensCheckBox");
            this.caseSensCheckBox.Name = "caseSensCheckBox";
            this.caseSensCheckBox.UseVisualStyleBackColor = true;
            this.caseSensCheckBox.CheckedChanged += new System.EventHandler(this.caseSensCheckBox_CheckedChanged);
            // 
            // replaceOutTextBox
            // 
            resources.ApplyResources(this.replaceOutTextBox, "replaceOutTextBox");
            this.replaceOutTextBox.Name = "replaceOutTextBox";
            this.replaceOutTextBox.TextChanged += new System.EventHandler(this.replaceOutTextBox_TextChanged);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // replaceInTextBox
            // 
            resources.ApplyResources(this.replaceInTextBox, "replaceInTextBox");
            this.replaceInTextBox.Name = "replaceInTextBox";
            this.replaceInTextBox.TextChanged += new System.EventHandler(this.replaceInTextBox_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.extensionTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.filenNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputTextComboBox);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // extensionTextBox
            // 
            resources.ApplyResources(this.extensionTextBox, "extensionTextBox");
            this.extensionTextBox.Name = "extensionTextBox";
            this.extensionTextBox.TextChanged += new System.EventHandler(this.extensionTextBox_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // filenNameTextBox
            // 
            resources.ApplyResources(this.filenNameTextBox, "filenNameTextBox");
            this.filenNameTextBox.Name = "filenNameTextBox";
            this.filenNameTextBox.TextChanged += new System.EventHandler(this.filenNameTextBox_TextChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // inputTextComboBox
            // 
            resources.ApplyResources(this.inputTextComboBox, "inputTextComboBox");
            this.inputTextComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.inputTextComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputTextComboBox.FormattingEnabled = true;
            this.inputTextComboBox.Name = "inputTextComboBox";
            this.inputTextComboBox.SelectedIndexChanged += new System.EventHandler(this.inputTextComboBox_SelectedIndexChanged);
            // 
            // runButton
            // 
            resources.ApplyResources(this.runButton, "runButton");
            this.runButton.BackColor = System.Drawing.Color.SandyBrown;
            this.runButton.Name = "runButton";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // statusStrip1
            // 
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // fileNameBindingSource
            // 
            this.fileNameBindingSource.DataSource = typeof(BatchFileRename.FileName);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.DragDropHandler);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.DragEnterHandler);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileNameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.ListBox inputList;
        private System.Windows.Forms.ListBox outputList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox extensionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox filenNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox replaceOutTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox replaceInTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox regexpCheckBox;
        private System.Windows.Forms.CheckBox caseSensCheckBox;
        private System.Windows.Forms.ComboBox regexpComboBox;
        private System.Windows.Forms.BindingSource fileNameBindingSource;
        private System.Windows.Forms.ComboBox inputTextComboBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox outputComboBox;
        private System.Windows.Forms.ComboBox extensionComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

    }
}

