using System.Text;

namespace ClarionSupport
{
    internal class WorkingClass
    {
        private StringBuilder control = new StringBuilder();

        public WorkingClass(string name)
        {
            control.Append(name);
        }

        private void noForbidenChar(ref StringBuilder name)
        {
            char[] forbidenChar = { ' ', '?', '&', '*', '@', '"' };
            foreach (char ch in forbidenChar)
            {
                name = name.Replace(ch.ToString(), "");
            }
        }

        private StringBuilder firstSign(StringBuilder name)
        {
            StringBuilder newName = new StringBuilder("?");
            {
                newName.Append(name);
                return newName;
            }
        }

        public void ValueCheck()
        {
            noForbidenChar(ref control);
            control = firstSign(control);
        }

        public string Name()
        {
            string name = control.ToString();
            return name;
        }
    }
}