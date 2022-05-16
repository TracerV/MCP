namespace XPUDP
{
    partial class Settings_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_DefaultPort = new System.Windows.Forms.TextBox();
            this.textBoxIP = new XPUDP.TextBoxIP();
            this.Save_preferences = new System.Windows.Forms.Button();
            this.Cancel_Settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DefaultPort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "MulticastIP";
            // 
            // textBox_DefaultPort
            // 
            this.textBox_DefaultPort.Location = new System.Drawing.Point(116, 38);
            this.textBox_DefaultPort.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DefaultPort.MaxLength = 5;
            this.textBox_DefaultPort.Name = "textBox_DefaultPort";
            this.textBox_DefaultPort.Size = new System.Drawing.Size(132, 20);
            this.textBox_DefaultPort.TabIndex = 2;
            this.textBox_DefaultPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox1_KeyPress);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(116, 80);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(132, 20);
            this.textBoxIP.TabIndex = 3;
            this.textBoxIP.Text = "0.0.0.0";
            // 
            // Save_preferences
            // 
            this.Save_preferences.Location = new System.Drawing.Point(277, 228);
            this.Save_preferences.Margin = new System.Windows.Forms.Padding(4);
            this.Save_preferences.Name = "Save_preferences";
            this.Save_preferences.Size = new System.Drawing.Size(60, 28);
            this.Save_preferences.TabIndex = 4;
            this.Save_preferences.Text = "Save";
            this.Save_preferences.UseVisualStyleBackColor = true;
            this.Save_preferences.Click += new System.EventHandler(this.Save_preferences_Click);
            // 
            // Cancel_Settings
            // 
            this.Cancel_Settings.Location = new System.Drawing.Point(198, 228);
            this.Cancel_Settings.Margin = new System.Windows.Forms.Padding(4);
            this.Cancel_Settings.Name = "Cancel_Settings";
            this.Cancel_Settings.Size = new System.Drawing.Size(71, 28);
            this.Cancel_Settings.TabIndex = 5;
            this.Cancel_Settings.Text = "Cancel";
            this.Cancel_Settings.UseVisualStyleBackColor = true;
            this.Cancel_Settings.Click += new System.EventHandler(this.Cancel_Settings_Click);
            // 
            // Settings_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 271);
            this.Controls.Add(this.Cancel_Settings);
            this.Controls.Add(this.Save_preferences);
            this.Controls.Add(this.textBoxIP);
            this.Controls.Add(this.textBox_DefaultPort);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Settings_form";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_DefaultPort;
        private TextBoxIP textBoxIP;
        private System.Windows.Forms.Button Save_preferences;
        private System.Windows.Forms.Button Cancel_Settings;
    }
}