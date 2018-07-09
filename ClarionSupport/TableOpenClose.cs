using System;
using System.Windows.Forms;

namespace ClarionSupport
{
    public partial class TableOpenClose : Form
    {
        public TableOpenClose()
        {
            InitializeComponent();
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            string text;
            string shortText;
            string opening;
            string closing;
            text = tableTextBox.Text;
            shortText = shortTextBox.Text;
            if (text.Length > 0)
            {
                opening = "IF " + text + "::Used = 0\r\n    CheckOpen(" + text + ", 1)\r\n END\r\n " + text + "::Used += 1";
                if (shortText.Length > 0)
                {
                    opening += "\r\n BIND(" + text + ":RECORD) ";
                }
                closing = text + "::Used -= 1\r\n IF " + text + "::Used = 0 THEN CLOSE(" + text + ") END";
                openTextBox.Text = opening;
                closeTextBox.Text = closing;
            }
            else
            {
                openTextBox.Text = "";
                closeTextBox.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            openTextBox.Text = "";
            closeTextBox.Text = "";
            tableTextBox.Text = "";
            shortTextBox.Text = "";
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openTextBox.Text != "")
                Clipboard.SetText(openTextBox.Text);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (closeTextBox.Text != "")
                Clipboard.SetText(closeTextBox.Text);
        }
    }
}