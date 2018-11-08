using ClipboardAssist;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClarionSupport
{
    public partial class ClarionSupportMain : Form
    {
        private ClipboardMonitor clipMonit = new ClipboardMonitor();

        public ClarionSupportMain()
        {
            InitializeComponent();
            PropsEnum property = new PropsEnum();
            try
            {
                string[] workingTable = property.PropsArray;
                foreach (string i in workingTable)
                {
                    propBox.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void ClarionSupportMain_Load(object sender, EventArgs e)
        {
        }

        private void errorLabel_click(object sender, EventArgs e)
        {
            errorLabel.Text = "";
        }

        private void addControlButton_Click(object sender, EventArgs e)
        {
            string tempStringEntry = controlNameEntry.Text;
            try
            {
                if (tempStringEntry.Length > 0)
                {
                    WorkingClass control = new WorkingClass(tempStringEntry);
                    control.ValueCheck();
                    if (!dataBox.Items.Contains(control.Name()))
                    {
                        dataBox.Items.Add(control.Name());
                    }
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch (Exception)
            {
                errorLabel.Text = "Exception caught.";
            }
            controlNameEntry.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch
            {
            }
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataBox.Items.Clear();
            for (int i = 0; i < propBox.Items.Count; i++)
            {
                propBox.SetItemCheckState(i, 0);
            }
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            autoAddCheck.Checked = false;
            controlNameEntry.Text = "Control Name";
            resultRTFBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataBox.SelectedItems.Count > 0)
                    dataBox.Items.RemoveAt(dataBox.SelectedIndex);
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                propsValueEntry.Enabled = true;
                propsValueEntry.Visible = true;
            }
            else
            {
                propsValueEntry.Clear();
                propsValueEntry.Enabled = false;
                propsValueEntry.Visible = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (autoAddCheck.Checked)
                {
                    autoAddCheck.Checked = false;
                    autoAddCheck.Update();
                }
                if (resultRTFBox.SelectedText != "")
                    Clipboard.SetDataObject(resultRTFBox.SelectedText);
                else if (resultRTFBox.Text != "")
                    Clipboard.SetDataObject(resultRTFBox.Text);
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataBox.Items.Count == 0)
                    throw new Exception("No controls added");
                if (propBox.CheckedItems.Count == 0)
                    throw new Exception("No properties chosen");
                if ((checkBox1.Checked == false) & (checkBox2.Checked == false) & (checkBox3.Checked == false))
                    throw new Exception("No values chosen");
                if (checkBox3.Checked == true & propsValueEntry.Text == "")
                    throw new Exception("No value entered");
                List<string> propert = new List<string>();
                foreach (string val in propBox.CheckedItems)
                {
                    propert.Add(val);
                }
                List<string> controlsList = new List<string>();
                foreach (string val in dataBox.Items)
                {
                    controlsList.Add(val);
                }
                GenerateResult result = new GenerateResult(checkBox1.Checked, checkBox2.Checked, checkBox4.Checked, isReportCheckBox.Checked, checkBoxSelf.Checked, propsValueEntry.Text, propert, controlsList);
                resultRTFBox.Clear();
                foreach (string val in result.Result)
                {
                    resultRTFBox.Text += val + "\n";
                }

                //result.Dispose();
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void valueReverserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reverser f2R = new Reverser();
            f2R.Show();
        }

        private void autoAddCheck_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (autoAddCheck.Checked == true)
                {
                    clipMonit.ClipboardChanged += autoAddCheck_EnabledClip;
                }
                else
                {
                    clipMonit.ClipboardChanged -= autoAddCheck_EnabledClip;
                }
            }
            catch (Exception ex)
            {
                errorLabel.Text = ex.Message;
            }
        }

        private void autoAddCheck_EnabledClip(object sender, EventArgs e)
        {
            if (!resultRTFBox.Focused)
            {
                try
                {
                    string tempStringEntry = Clipboard.GetText();

                    if (tempStringEntry.Length > 0)
                    {
                        WorkingClass control = new WorkingClass(tempStringEntry);
                        control.ValueCheck();
                        if (!dataBox.Items.Contains(control.Name()))
                        {
                            dataBox.Items.Add(control.Name());
                        }
                    }
                    else
                    {
                        throw new ArgumentNullException();
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
            else
            {
                autoAddCheck.Checked = false;
            }
        }

        //private void dataBox_keyDelete(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string tempStringEntry = Clipboard.GetText();

        //        if (tempStringEntry.Length > 0)
        //        {
        //            WorkingClass control = new WorkingClass(tempStringEntry);
        //            control.ValueCheck();
        //            dataBox.Items.Add(control.Name());
        //        }
        //        else
        //        {
        //            throw new ArgumentNullException();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        errorLabel.Text = "Exception caught.";
        //    }
        //}
        private void dataBox_keyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    if (dataBox.SelectedItems.Count == 1)
                        dataBox.Items.RemoveAt(dataBox.SelectedIndex);
                    //else if (dataBox.SelectedItems.Count > 1)
                    //{
                    //    foreach (var item in dataBox.SelectedIndices)
                    //    {
                    //    }
                    //}
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }

        private void isReportCheckBox_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void keyPropBox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    propBox.SetItemChecked(propBox.SelectedIndex, !propBox.GetItemChecked(propBox.SelectedIndex));
                }
                catch (Exception ex)
                {
                    errorLabel.Text = ex.Message;
                }
            }
        }

        private void resultRTFBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void tableOCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TableOpenClose TOC = new TableOpenClose();
            TOC.Show();
        }

        private void dataBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = dataBox.SelectedItem.ToString();
                controlNameEntry.Text = curItem;
            }
            catch
            { }

        }
    }
}