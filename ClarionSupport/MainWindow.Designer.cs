namespace ClarionSupport
{
    partial class ClarionSupportMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClarionSupportMain));
            this.dataBox = new System.Windows.Forms.ListBox();
            this.propBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxSelf = new System.Windows.Forms.CheckBox();
            this.propsValueEntry = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.addControlButton = new System.Windows.Forms.Button();
            this.controlNameEntry = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.functionRadio = new System.Windows.Forms.RadioButton();
            this.propertiesRadio = new System.Windows.Forms.RadioButton();
            this.autoAddCheck = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.resultRTFBox = new System.Windows.Forms.RichTextBox();
            this.Resoult = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clearAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.valueReverserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableOCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.isReportCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataBox
            // 
            resources.ApplyResources(this.dataBox, "dataBox");
            this.dataBox.FormattingEnabled = true;
            this.dataBox.Name = "dataBox";
            this.dataBox.SelectedIndexChanged += new System.EventHandler(this.dataBox_SelectedIndexChanged);
            this.dataBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataBox_keyUp);
            // 
            // propBox
            // 
            resources.ApplyResources(this.propBox, "propBox");
            this.propBox.FormattingEnabled = true;
            this.propBox.Name = "propBox";
            this.propBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPropBox);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.checkBoxSelf);
            this.groupBox1.Controls.Add(this.propsValueEntry);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // checkBoxSelf
            // 
            resources.ApplyResources(this.checkBoxSelf, "checkBoxSelf");
            this.checkBoxSelf.Name = "checkBoxSelf";
            this.checkBoxSelf.UseVisualStyleBackColor = true;
            // 
            // propsValueEntry
            // 
            resources.ApplyResources(this.propsValueEntry, "propsValueEntry");
            this.propsValueEntry.Name = "propsValueEntry";
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addControlButton
            // 
            resources.ApplyResources(this.addControlButton, "addControlButton");
            this.addControlButton.Name = "addControlButton";
            this.addControlButton.UseVisualStyleBackColor = true;
            this.addControlButton.Click += new System.EventHandler(this.addControlButton_Click);
            // 
            // controlNameEntry
            // 
            resources.ApplyResources(this.controlNameEntry, "controlNameEntry");
            this.controlNameEntry.Name = "controlNameEntry";
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.functionRadio);
            this.groupBox2.Controls.Add(this.propertiesRadio);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // functionRadio
            // 
            resources.ApplyResources(this.functionRadio, "functionRadio");
            this.functionRadio.Name = "functionRadio";
            this.functionRadio.UseVisualStyleBackColor = true;
            // 
            // propertiesRadio
            // 
            resources.ApplyResources(this.propertiesRadio, "propertiesRadio");
            this.propertiesRadio.Checked = true;
            this.propertiesRadio.Name = "propertiesRadio";
            this.propertiesRadio.TabStop = true;
            this.propertiesRadio.UseVisualStyleBackColor = true;
            // 
            // autoAddCheck
            // 
            resources.ApplyResources(this.autoAddCheck, "autoAddCheck");
            this.autoAddCheck.Name = "autoAddCheck";
            this.autoAddCheck.UseVisualStyleBackColor = true;
            this.autoAddCheck.CheckedChanged += new System.EventHandler(this.autoAddCheck_CheckedChanged);
            // 
            // checkBox4
            // 
            resources.ApplyResources(this.checkBox4, "checkBox4");
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // resultRTFBox
            // 
            resources.ApplyResources(this.resultRTFBox, "resultRTFBox");
            this.resultRTFBox.Name = "resultRTFBox";
            this.resultRTFBox.TextChanged += new System.EventHandler(this.resultRTFBox_TextChanged);
            // 
            // Resoult
            // 
            resources.ApplyResources(this.Resoult, "Resoult");
            this.Resoult.Name = "Resoult";
            // 
            // copyButton
            // 
            resources.ApplyResources(this.copyButton, "copyButton");
            this.copyButton.Name = "copyButton";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.valueReverserToolStripMenuItem,
            this.tableOCToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            resources.ApplyResources(this.clearAllToolStripMenuItem, "clearAllToolStripMenuItem");
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // valueReverserToolStripMenuItem
            // 
            this.valueReverserToolStripMenuItem.Name = "valueReverserToolStripMenuItem";
            resources.ApplyResources(this.valueReverserToolStripMenuItem, "valueReverserToolStripMenuItem");
            this.valueReverserToolStripMenuItem.Click += new System.EventHandler(this.valueReverserToolStripMenuItem_Click);
            // 
            // tableOCToolStripMenuItem
            // 
            this.tableOCToolStripMenuItem.Name = "tableOCToolStripMenuItem";
            resources.ApplyResources(this.tableOCToolStripMenuItem, "tableOCToolStripMenuItem");
            this.tableOCToolStripMenuItem.Click += new System.EventHandler(this.tableOCToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            resources.ApplyResources(this.aboutToolStripMenuItem, "aboutToolStripMenuItem");
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // errorLabel
            // 
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_click);
            // 
            // generateButton
            // 
            resources.ApplyResources(this.generateButton, "generateButton");
            this.generateButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.generateButton.Name = "generateButton";
            this.generateButton.UseVisualStyleBackColor = false;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // isReportCheckBox
            // 
            resources.ApplyResources(this.isReportCheckBox, "isReportCheckBox");
            this.isReportCheckBox.Name = "isReportCheckBox";
            this.isReportCheckBox.UseVisualStyleBackColor = true;
            this.isReportCheckBox.CheckedChanged += new System.EventHandler(this.isReportCheckBox_CheckedChanged);
            // 
            // ClarionSupportMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.isReportCheckBox);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.Resoult);
            this.Controls.Add(this.resultRTFBox);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.autoAddCheck);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.controlNameEntry);
            this.Controls.Add(this.addControlButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.propBox);
            this.Controls.Add(this.dataBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "ClarionSupportMain";
            this.Load += new System.EventHandler(this.ClarionSupportMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox dataBox;
        private System.Windows.Forms.CheckedListBox propBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox propsValueEntry;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button addControlButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton functionRadio;
        private System.Windows.Forms.RadioButton propertiesRadio;
        private System.Windows.Forms.CheckBox autoAddCheck;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.RichTextBox resultRTFBox;
        private System.Windows.Forms.Label Resoult;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.TextBox controlNameEntry;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.ToolStripMenuItem valueReverserToolStripMenuItem;
        private System.Windows.Forms.CheckBox isReportCheckBox;
        private System.Windows.Forms.CheckBox checkBoxSelf;
        private System.Windows.Forms.ToolStripMenuItem tableOCToolStripMenuItem;
    }
}

