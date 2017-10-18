using ClipboardAssist;
using System;
using System.Windows.Forms;

namespace ClarionSupport
{
    public partial class Form2Reverser : Form
    {
        private ClipboardMonitor clipMonit = new ClipboardMonitor();

        public Form2Reverser()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void reverseButton_Click(object sender, EventArgs e)
        {
            ReverserWork rtfWork = new ReverserWork(rtfValue.Text);
            rtfValue.Text = rtfWork.Result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    checkBox1.Checked = false;
                    checkBox1.Update();
                }
                if (rtfValue.SelectedText != "")
                    Clipboard.SetDataObject(rtfValue.SelectedText);
                else if (rtfValue.Text != "")
                    Clipboard.SetDataObject(rtfValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked == true)
                {
                    clipMonit.ClipboardChanged += checkBox1_EnabledClip;
                }
                else
                {
                    clipMonit.ClipboardChanged -= checkBox1_EnabledClip;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_EnabledClip(object sender, EventArgs e)
        {
            try
            {
                string tempStringEntry = Clipboard.GetText();

                if (tempStringEntry.Length > 0)
                {
                    WorkingClass control = new WorkingClass(tempStringEntry);
                    control.ValueCheck();
                    rtfValue.Text += tempStringEntry += Environment.NewLine;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}