using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BotForTwitch {
    static class Program {
        Configuration cm = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        

        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());


        }
    }
}
