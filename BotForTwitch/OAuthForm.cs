using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotForTwitch {
	public partial class OAuthForm : Form {
		public OAuthForm() {
			string url = "";
			Boolean open = true;

			BackgroundWorker backgroundWorker = new BackgroundWorker();
			backgroundWorker.DoWork += (DoWorkEventHandler)((o, args) => {
				while (open == true) {
					if (this.webBrowser1.Url == null) {
					} else {
						url = this.webBrowser1.Url.ToString();
					}

					if (url.Contains("code=")) {
						open = false;

						string password = this.webBrowser1.DocumentTitle;

						Clipboard.SetText(password);

						MessageBox.Show("Password coppied to clipboard.  Please insert it into the password field.");

						this.Close();
					}

					MessageBox.Show("dfdfd");
				}
			});
			backgroundWorker.RunWorkerAsync();

			InitializeComponent();

			MessageBox.Show(this.webBrowser1.DocumentTitle);
		}
	}
}
