using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BotForTwitch {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void aboutBotForTwitchToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

		public void connect() {
			// Connect to IRC server for Twitch
		}

		public void disconnect() {
			// Disconnect from Twitch server
		}

		public void send(string channel, string message) {
			// Send message to IRC server
			channel = "#" + channel;
		}
    }
}
