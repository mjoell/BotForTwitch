using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;

namespace BotForTwitch {
	public partial class FirstTimeForm : Form {
		public FirstTimeForm() {
			InitializeComponent();
		}

		private void FirstTimeForm_Load(object sender, EventArgs e) {

		}

		private void saveButton_Click(object sender, EventArgs e) {
			string[] settings = new string[] { usernameBox.Text, passwordBox.Text };

			for (int i = 0; i < settings.Length; i++) {
				if (settings[i].Equals("")) {
					MessageBox.Show("You have not completed all fields.  Please complete all fields before continuing.");
					return;
				} else {
					string[] settingLabels = new string[] { "username", "password" };
					Program.confcol[settingLabels[i]].Value = settings[i];
					Program.cm.Save(ConfigurationSaveMode.Modified);
					ConfigurationManager.RefreshSection(Program.cm.AppSettings.SectionInformation.Name);
				}
			}

			MessageBox.Show("All settings have been saved, and the app will now start.  If you have any questions, please see Help -> About to see how to contact and get support.");
			Close();
		}

		private void exitButton_Click(object sender, EventArgs e) {
			Process.GetCurrentProcess().Kill();
		}
	}
}
