using System;
using System.Collections.Generic;

namespace ClarionSupport
{
    internal class GenerateResult
    {
        private bool firstCheck;
        private bool secondCheck;
        private bool ifCheck;
        private bool ifReport;
        private bool ifSelf;
        private string value;
        private List<string> result = new List<string>();
        private List<string> properties;
        private List<string> controls;

        public GenerateResult(bool firstCheck, bool secondCheck, bool ifCheck, bool ifReport, bool ifSelf, string value, List<string> properties, List<string> controls)
        {
            this.firstCheck = firstCheck;
            this.secondCheck = secondCheck;
            this.ifCheck = ifCheck;
            this.ifReport = ifReport;
            this.ifSelf = ifSelf;
            this.value = value;
            this.properties = properties;
            this.controls = controls;
        }

        private void MakingResult()
        {
            if (ifCheck)
            {
                string text = "";
                for (int i = 0; i < 3; i++)
                {
                    switch (i)
                    {
                        case 0:
                            result.Add("if !@!");
                            text = "1";
                            break;

                        case 1:
                            result.Add("elsif !@!");
                            text = "0";
                            break;

                        case 2:
                            result.Add("else !@!");
                            text = value;
                            break;
                    }
                    for (int j = 0; j < controls.Count; j++)
                    {
                        for (int k = 0; k < properties.Count; k++)
                        {
                            result.Add(controls[j] + "{" + properties[k] + "}" + " = " + text);
                        }
                    }
                }
                result.Add("end");
            }
            else
            {
                for (int j = 0; j < controls.Count; j++)
                {
                    for (int k = 0; k < properties.Count; k++)
                    {
                        string prtProp = "{" + properties[k] + "}";
                        if (firstCheck)
                            result.Add(controls[j] + prtProp + " = 0");
                        if (secondCheck)
                            result.Add(controls[j] + prtProp + " = 1");
                        if (value != "")
                            result.Add(controls[j] + prtProp + " = " + value);
                    }
                }
            }
            if (ifReport)
            {
                doReport();
            }
            if (ifSelf)
            {
                doSelf();
            }
        }

        public List<string> Result
        {
            get
            {
                MakingResult();
                if (result.Count > 0)
                    return result;
                else
                    throw new Exception("Null reference");
            }
        }
        private void doReport ()
            {
                for (int i = 0; i < result.Count; i++)
                {
                if (!(result[i] == "if !@!" || result[i] == "elsif !@!" || result[i] == "else !@!" || result[i] == "end")) 
                    /*result[i].Substring(0,6) == "Report$")*/
                    {
                        result[i] = "Report$" + result[i];
                    }    
                }        
            }
        private void doSelf()
        {
            for (int i = 0; i<result.Count; i++)
            {
                if (!(result[i] == "if !@!" || result[i] == "elsif !@!" || result[i] == "else !@!" || result[i] == "end"))
                {
                    string[] substring = result[i].Split(new string[] { "=" }, StringSplitOptions.RemoveEmptyEntries);
                    result[i] = substring[0] + " = " + substring[0] + " + " + substring[1];
                }
            }
        }        

        public void Dispose()
        {
            Dispose();
        }
    }
}