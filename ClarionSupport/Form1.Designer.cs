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
            this.dataBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataBox.FormattingEnabled = true;
            this.dataBox.ItemHeight = 16;
            this.dataBox.Location = new System.Drawing.Point(16, 96);
            this.dataBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataBox.Name = "dataBox";
            this.dataBox.Size = new System.Drawing.Size(192, 340);
            this.dataBox.TabIndex = 3;
            this.dataBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dataBox_keyUp);
            // 
            // propBox
            // 
            this.propBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.propBox.FormattingEnabled = true;
            this.propBox.Location = new System.Drawing.Point(241, 96);
            this.propBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propBox.Name = "propBox";
            this.propBox.Size = new System.Drawing.Size(195, 327);
            this.propBox.TabIndex = 5;
            this.propBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyPropBox);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "List of Properties";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "List of Controls";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.checkBoxSelf);
            this.groupBox1.Controls.Add(this.propsValueEntry);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(448, 257);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(161, 180);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Props value";
            // 
            // checkBoxSelf
            // 
            this.checkBoxSelf.AutoSize = true;
            this.checkBoxSelf.Location = new System.Drawing.Point(27, 146);
            this.checkBoxSelf.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSelf.Name = "checkBoxSelf";
            this.checkBoxSelf.Size = new System.Drawing.Size(54, 21);
            this.checkBoxSelf.TabIndex = 4;
            this.checkBoxSelf.Text = "Self";
            this.checkBoxSelf.UseVisualStyleBackColor = true;
            // 
            // propsValueEntry
            // 
            this.propsValueEntry.Location = new System.Drawing.Point(27, 114);
            this.propsValueEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propsValueEntry.Name = "propsValueEntry";
            this.propsValueEntry.Size = new System.Drawing.Size(105, 22);
            this.propsValueEntry.TabIndex = 3;
            this.propsValueEntry.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(27, 86);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(115, 21);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Custom value";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(27, 58);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(38, 21);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "1";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(27, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(38, 21);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "0";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // addControlButton
            // 
            this.addControlButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addControlButton.Location = new System.Drawing.Point(13, 500);
            this.addControlButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addControlButton.Name = "addControlButton";
            this.addControlButton.Size = new System.Drawing.Size(100, 28);
            this.addControlButton.TabIndex = 8;
            this.addControlButton.Text = "Add Controls";
            this.addControlButton.UseVisualStyleBackColor = true;
            this.addControlButton.Click += new System.EventHandler(this.addControlButton_Click);
            // 
            // controlNameEntry
            // 
            this.controlNameEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.controlNameEntry.Location = new System.Drawing.Point(16, 468);
            this.controlNameEntry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.controlNameEntry.Name = "controlNameEntry";
            this.controlNameEntry.Size = new System.Drawing.Size(217, 22);
            this.controlNameEntry.TabIndex = 7;
            this.controlNameEntry.Text = "Control Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox2.Controls.Add(this.functionRadio);
            this.groupBox2.Controls.Add(this.propertiesRadio);
            this.groupBox2.Location = new System.Drawing.Point(445, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(161, 101);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Control handling";
            // 
            // functionRadio
            // 
            this.functionRadio.AutoSize = true;
            this.functionRadio.Location = new System.Drawing.Point(20, 60);
            this.functionRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.functionRadio.Name = "functionRadio";
            this.functionRadio.Size = new System.Drawing.Size(83, 21);
            this.functionRadio.TabIndex = 1;
            this.functionRadio.Text = "Function";
            this.functionRadio.UseVisualStyleBackColor = true;
            this.functionRadio.Visible = false;
            // 
            // propertiesRadio
            // 
            this.propertiesRadio.AutoSize = true;
            this.propertiesRadio.Checked = true;
            this.propertiesRadio.Location = new System.Drawing.Point(21, 32);
            this.propertiesRadio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertiesRadio.Name = "propertiesRadio";
            this.propertiesRadio.Size = new System.Drawing.Size(94, 21);
            this.propertiesRadio.TabIndex = 0;
            this.propertiesRadio.TabStop = true;
            this.propertiesRadio.Text = "Properties";
            this.propertiesRadio.UseVisualStyleBackColor = true;
            // 
            // autoAddCheck
            // 
            this.autoAddCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.autoAddCheck.AutoSize = true;
            this.autoAddCheck.Location = new System.Drawing.Point(16, 444);
            this.autoAddCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.autoAddCheck.Name = "autoAddCheck";
            this.autoAddCheck.Size = new System.Drawing.Size(106, 21);
            this.autoAddCheck.TabIndex = 6;
            this.autoAddCheck.Text = "Auto adding";
            this.autoAddCheck.UseVisualStyleBackColor = true;
            this.autoAddCheck.CheckedChanged += new System.EventHandler(this.autoAddCheck_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(445, 204);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(160, 21);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "if... elsif... else... end";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // resultRTFBox
            // 
            this.resultRTFBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultRTFBox.Location = new System.Drawing.Point(645, 96);
            this.resultRTFBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resultRTFBox.Name = "resultRTFBox";
            this.resultRTFBox.Size = new System.Drawing.Size(276, 340);
            this.resultRTFBox.TabIndex = 15;
            this.resultRTFBox.Text = "";
            // 
            // Resoult
            // 
            this.Resoult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Resoult.AutoSize = true;
            this.Resoult.Location = new System.Drawing.Point(645, 66);
            this.Resoult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resoult.Name = "Resoult";
            this.Resoult.Size = new System.Drawing.Size(48, 17);
            this.Resoult.TabIndex = 14;
            this.Resoult.Text = "Result";
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.Location = new System.Drawing.Point(645, 468);
            this.copyButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(100, 28);
            this.copyButton.TabIndex = 16;
            this.copyButton.Text = "Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(121, 500);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Delete control";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearAllToolStripMenuItem,
            this.valueReverserToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clearAllToolStripMenuItem
            // 
            this.clearAllToolStripMenuItem.Name = "clearAllToolStripMenuItem";
            this.clearAllToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.clearAllToolStripMenuItem.Text = "Default";
            this.clearAllToolStripMenuItem.Click += new System.EventHandler(this.clearAllToolStripMenuItem_Click);
            // 
            // valueReverserToolStripMenuItem
            // 
            this.valueReverserToolStripMenuItem.Name = "valueReverserToolStripMenuItem";
            this.valueReverserToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.valueReverserToolStripMenuItem.Text = "Value reverser";
            this.valueReverserToolStripMenuItem.Click += new System.EventHandler(this.valueReverserToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(19, 34);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.MaximumSize = new System.Drawing.Size(960, 0);
            this.errorLabel.MinimumSize = new System.Drawing.Size(720, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(720, 17);
            this.errorLabel.TabIndex = 1;
            this.errorLabel.Text = " ";
            this.errorLabel.Click += new System.EventHandler(this.errorLabel_click);
            // 
            // generateButton
            // 
            this.generateButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.generateButton.Location = new System.Drawing.Point(448, 468);
            this.generateButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(164, 69);
            this.generateButton.TabIndex = 13;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // isReportCheckBox
            // 
            this.isReportCheckBox.AutoSize = true;
            this.isReportCheckBox.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.isReportCheckBox.Location = new System.Drawing.Point(445, 233);
            this.isReportCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.isReportCheckBox.Name = "isReportCheckBox";
            this.isReportCheckBox.Size = new System.Drawing.Size(73, 21);
            this.isReportCheckBox.TabIndex = 17;
            this.isReportCheckBox.Text = "Report";
            this.isReportCheckBox.UseVisualStyleBackColor = true;
            this.isReportCheckBox.CheckedChanged += new System.EventHandler(this.isReportCheckBox_CheckedChanged);
            // 
            // ClarionSupportMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(936, 533);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximumSize = new System.Drawing.Size(954, 580);
            this.MinimumSize = new System.Drawing.Size(954, 580);
            this.Name = "ClarionSupportMain";
            this.Text = "C6Free Companion App";
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
    }
}

