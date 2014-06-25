namespace BotForTwitch {
	partial class FirstTimeForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstTimeForm));
			this.label1 = new System.Windows.Forms.Label();
			this.usernameBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.passwordBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.saveButton = new System.Windows.Forms.Button();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(618, 32);
			this.label1.TabIndex = 0;
			this.label1.Text = "First time setup will allow you to set the required variables for the application" +
    ".  All of these \r\nsettings are changable later in the settings dialog.";
			// 
			// usernameBox
			// 
			this.usernameBox.Location = new System.Drawing.Point(15, 93);
			this.usernameBox.Name = "usernameBox";
			this.usernameBox.Size = new System.Drawing.Size(100, 20);
			this.usernameBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Username:";
			// 
			// passwordBox
			// 
			this.passwordBox.Location = new System.Drawing.Point(152, 92);
			this.passwordBox.Name = "passwordBox";
			this.passwordBox.PasswordChar = '*';
			this.passwordBox.Size = new System.Drawing.Size(100, 20);
			this.passwordBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(152, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Password:";
			// 
			// saveButton
			// 
			this.saveButton.Location = new System.Drawing.Point(536, 442);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(110, 23);
			this.saveButton.TabIndex = 5;
			this.saveButton.Text = "Save and Start";
			this.saveButton.UseVisualStyleBackColor = true;
			this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(396, 442);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(134, 23);
			this.exitButton.TabIndex = 6;
			this.exitButton.Text = "Exit, I\'ll come back later";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
			// 
			// FirstTimeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 477);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.passwordBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.usernameBox);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.ControlBox = false;
			this.Name = "FirstTimeForm";
			this.Text = "Bot For Twitch - First Time Setup";
			this.Load += new System.EventHandler(this.FirstTimeForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox usernameBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button saveButton;
		private System.Windows.Forms.Button exitButton;
	}
}