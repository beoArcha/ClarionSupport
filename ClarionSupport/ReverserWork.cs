using System;
using System.Linq;

namespace ClarionSupport
{
    internal class ReverserWork
    {
        private string rtfText;

        public ReverserWork(string rtfText)
        {
            this.rtfText = rtfText;
        }

        public string Result
        {
            get
            {
                MakingReverse();
                return rtfText;
            }
        }

        private void MakingReverse()
        {
            string[] lines = rtfText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            rtfText = "";
            foreach (string item in lines)
            {
                if (item.Contains("="))
                {
                    string[] substring = item.Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    string level = "";
                    foreach (string part in substring.Reverse())
                    {
                        level += part + "=";
                    }
                    level = level.Remove(level.Length - 1);
                    rtfText += level + "\r\n";
                }
                else
                {
                    rtfText += item + "\r\n";
                }
            }
        }
    }
}