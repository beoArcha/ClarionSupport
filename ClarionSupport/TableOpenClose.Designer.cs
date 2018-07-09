namespace ClarionSupport
{
    partial class TableOpenClose
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableOpenClose));
            this.tableTextBox = new System.Windows.Forms.TextBox();
            this.shortTextBox = new System.Windows.Forms.TextBox();
            this.openTextBox = new System.Windows.Forms.TextBox();
            this.closeTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.openButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tableTextBox
            // 
            this.tableTextBox.Location = new System.Drawing.Point(86, 32);
            this.tableTextBox.Name = "tableTextBox";
            this.tableTextBox.Size = new System.Drawing.Size(290, 20);
            this.tableTextBox.TabIndex = 0;
            // 
            // shortTextBox
            // 
            this.shortTextBox.Location = new System.Drawing.Point(86, 59);
            this.shortTextBox.Name = "shortTextBox";
            this.shortTextBox.Size = new System.Drawing.Size(100, 20);
            this.shortTextBox.TabIndex = 1;
            // 
            // openTextBox
            // 
            this.openTextBox.Location = new System.Drawing.Point(86, 115);
            this.openTextBox.Multiline = true;
            this.openTextBox.Name = "openTextBox";
            this.openTextBox.Size = new System.Drawing.Size(290, 100);
            this.openTextBox.TabIndex = 4;
            // 
            // closeTextBox
            // 
            this.closeTextBox.Location = new System.Drawing.Point(86, 250);
            this.closeTextBox.Multiline = true;
            this.closeTextBox.Name = "closeTextBox";
            this.closeTextBox.Size = new System.Drawing.Size(290, 100);
            this.closeTextBox.TabIndex = 6;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(86, 86);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "&Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(192, 86);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(276, 221);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(100, 23);
            this.openButton.TabIndex = 5;
            this.openButton.Text = "Copy open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(276, 356);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Copy close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Table:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Table short:";
            // 
            // TableOpenClose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 386);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.closeTextBox);
            this.Controls.Add(this.openTextBox);
            this.Controls.Add(this.shortTextBox);
            this.Controls.Add(this.tableTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TableOpenClose";
            this.Text = "Tabel Open Close Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tableTextBox;
        private System.Windows.Forms.TextBox shortTextBox;
        private System.Windows.Forms.TextBox openTextBox;
        private System.Windows.Forms.TextBox closeTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}