using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PsTools_Easy_Deploy_Tool
{
    static public class MainFormAccess
    {
        static public Form1 mainForm;

        static public void Init(Form1 f)
        {
            mainForm = f;
        }
    }
}
