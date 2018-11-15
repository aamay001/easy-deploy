using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

static public class Settings
{
    static public String LOCAL_UPDATE_DIR = "";
    static public String LOGGING_DIR = "\\\\%computername%\\C$\\EasyDeploy";

    static public int MAX_NUMBER_PING_THREADS = 256;
    static public bool AUTO_UPDATE_AD_ON_STARTUP = true;
}

