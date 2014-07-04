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
		public static string prefix;
		public static string username;
		public static string password;

		[STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

			if (confcol["username"].Value.Equals("") || confcol["password"].Value.Equals("")) {
				FirstTimeForm firstTimeForm = new FirstTimeForm();
				firstTimeForm.ShowDialog();

				username = confcol["username"].Value;
				password = confcol["password"].Value;
				prefix = confcol["prefix"].Value;
			}

			Application.Run(new MainForm());
        }
    }
}
