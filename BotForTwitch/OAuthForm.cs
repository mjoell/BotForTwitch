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
			HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://botfortwitch.tv/oauth.php");
			webRequest.MaximumAutomaticRedirections = 1;
			webRequest.AllowAutoRedirect = true;
			string response1;

			using (var response = webRequest.GetResponse()) using (var content = response.GetResponseStream()) using (var reader = new StreamReader(content)) {
				response1 = response.ResponseUri.ToString();
				if (reader.ReadToEnd().Contains("Authorize Bot for Twitch")) {
					InitializeComponent();
				}
			}

			InitializeComponent();
		}
	}
}
