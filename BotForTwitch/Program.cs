using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace BotForTwitch {
    static class Program {
        public static Configuration cm = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public static KeyValueConfigurationCollection confcol = cm.AppSettings.Settings;

        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			if (confcol["username"].Value.Equals("") || confcol["password"].Value.Equals("")) {
				// Open setup dialog box
				// SetupForm setupForm = new SetupForm();
				// setupForm.ShowDialog();
				FirstTimeForm firstTimeForm = new FirstTimeForm();
				firstTimeForm.ShowDialog();
			}

			Application.Run(new MainForm());
        }
    }
}
