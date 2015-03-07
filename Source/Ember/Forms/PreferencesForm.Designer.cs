namespace Ember.Forms
{
    partial class PreferencesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.checkBoxStartWithWindows = new System.Windows.Forms.CheckBox();
            this.checkBoxEnableSoundEffect = new System.Windows.Forms.CheckBox();
            this.tabPageShortcut = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.hotkeyTextBoxCaptureActiveWindow = new Shortcut.Forms.HotkeyTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hotkeyTextBoxCaptureFullscreen = new Shortcut.Forms.HotkeyTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hotkeyTextBoxCaptureArea = new Shortcut.Forms.HotkeyTextBox();
            this.tabPageHosting = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxHost = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxUploadFormat = new System.Windows.Forms.ComboBox();
            this.radioButtonOpenImageInBrowser = new System.Windows.Forms.RadioButton();
            this.radioButtonCopyLinkToClipboard = new System.Windows.Forms.RadioButton();
            this.checkBoxUploadImage = new System.Windows.Forms.CheckBox();
            this.tabPageLocal = new System.Windows.Forms.TabPage();
            this.buttonOpenDirectory = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxSaveDirectory = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSaveFormat = new System.Windows.Forms.ComboBox();
            this.checkBoxSaveImage = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageShortcut.SuspendLayout();
            this.tabPageHosting.SuspendLayout();
            this.tabPageLocal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ember.Properties.Resources.settings_banner;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageGeneral);
            this.tabControl1.Controls.Add(this.tabPageShortcut);
            this.tabControl1.Controls.Add(this.tabPageHosting);
            this.tabControl1.Controls.Add(this.tabPageLocal);
            this.tabControl1.Location = new System.Drawing.Point(12, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 256);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.checkBoxStartWithWindows);
            this.tabPageGeneral.Controls.Add(this.checkBoxEnableSoundEffect);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Size = new System.Drawing.Size(452, 230);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "   GENERAL   ";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
            // 
            // checkBoxStartWithWindows
            // 
            this.checkBoxStartWithWindows.AutoSize = true;
            this.checkBoxStartWithWindows.Location = new System.Drawing.Point(17, 38);
            this.checkBoxStartWithWindows.Name = "checkBoxStartWithWindows";
            this.checkBoxStartWithWindows.Size = new System.Drawing.Size(128, 17);
            this.checkBoxStartWithWindows.TabIndex = 3;
            this.checkBoxStartWithWindows.Text = "Start with Windows";
            this.checkBoxStartWithWindows.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnableSoundEffect
            // 
            this.checkBoxEnableSoundEffect.AutoSize = true;
            this.checkBoxEnableSoundEffect.Location = new System.Drawing.Point(17, 15);
            this.checkBoxEnableSoundEffect.Name = "checkBoxEnableSoundEffect";
            this.checkBoxEnableSoundEffect.Size = new System.Drawing.Size(129, 17);
            this.checkBoxEnableSoundEffect.TabIndex = 2;
            this.checkBoxEnableSoundEffect.Text = "Enable sound effect";
            this.checkBoxEnableSoundEffect.UseVisualStyleBackColor = true;
            // 
            // tabPageShortcut
            // 
            this.tabPageShortcut.Controls.Add(this.label3);
            this.tabPageShortcut.Controls.Add(this.hotkeyTextBoxCaptureActiveWindow);
            this.tabPageShortcut.Controls.Add(this.label2);
            this.tabPageShortcut.Controls.Add(this.hotkeyTextBoxCaptureFullscreen);
            this.tabPageShortcut.Controls.Add(this.label1);
            this.tabPageShortcut.Controls.Add(this.hotkeyTextBoxCaptureArea);
            this.tabPageShortcut.Location = new System.Drawing.Point(4, 22);
            this.tabPageShortcut.Name = "tabPageShortcut";
            this.tabPageShortcut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShortcut.Size = new System.Drawing.Size(452, 230);
            this.tabPageShortcut.TabIndex = 1;
            this.tabPageShortcut.Text = "   HOTKEY   ";
            this.tabPageShortcut.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Capture active window:";
            // 
            // hotkeyTextBoxCaptureActiveWindow
            // 
            this.hotkeyTextBoxCaptureActiveWindow.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeyTextBoxCaptureActiveWindow.Hotkey = null;
            this.hotkeyTextBoxCaptureActiveWindow.Location = new System.Drawing.Point(20, 151);
            this.hotkeyTextBoxCaptureActiveWindow.Name = "hotkeyTextBoxCaptureActiveWindow";
            this.hotkeyTextBoxCaptureActiveWindow.Size = new System.Drawing.Size(199, 25);
            this.hotkeyTextBoxCaptureActiveWindow.TabIndex = 4;
            this.hotkeyTextBoxCaptureActiveWindow.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Capture Fullscreen:";
            // 
            // hotkeyTextBoxCaptureFullscreen
            // 
            this.hotkeyTextBoxCaptureFullscreen.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeyTextBoxCaptureFullscreen.Hotkey = null;
            this.hotkeyTextBoxCaptureFullscreen.Location = new System.Drawing.Point(20, 93);
            this.hotkeyTextBoxCaptureFullscreen.Name = "hotkeyTextBoxCaptureFullscreen";
            this.hotkeyTextBoxCaptureFullscreen.Size = new System.Drawing.Size(199, 25);
            this.hotkeyTextBoxCaptureFullscreen.TabIndex = 2;
            this.hotkeyTextBoxCaptureFullscreen.Text = "None";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Capture area:";
            // 
            // hotkeyTextBoxCaptureArea
            // 
            this.hotkeyTextBoxCaptureArea.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotkeyTextBoxCaptureArea.Hotkey = null;
            this.hotkeyTextBoxCaptureArea.Location = new System.Drawing.Point(20, 35);
            this.hotkeyTextBoxCaptureArea.Name = "hotkeyTextBoxCaptureArea";
            this.hotkeyTextBoxCaptureArea.Size = new System.Drawing.Size(199, 25);
            this.hotkeyTextBoxCaptureArea.TabIndex = 0;
            this.hotkeyTextBoxCaptureArea.Text = "None";
            // 
            // tabPageHosting
            // 
            this.tabPageHosting.Controls.Add(this.label7);
            this.tabPageHosting.Controls.Add(this.comboBoxHost);
            this.tabPageHosting.Controls.Add(this.label4);
            this.tabPageHosting.Controls.Add(this.comboBoxUploadFormat);
            this.tabPageHosting.Controls.Add(this.radioButtonOpenImageInBrowser);
            this.tabPageHosting.Controls.Add(this.radioButtonCopyLinkToClipboard);
            this.tabPageHosting.Controls.Add(this.checkBoxUploadImage);
            this.tabPageHosting.Location = new System.Drawing.Point(4, 22);
            this.tabPageHosting.Name = "tabPageHosting";
            this.tabPageHosting.Size = new System.Drawing.Size(452, 230);
            this.tabPageHosting.TabIndex = 2;
            this.tabPageHosting.Text = "   HOSTING    ";
            this.tabPageHosting.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Host:";
            // 
            // comboBoxHost
            // 
            this.comboBoxHost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHost.FormattingEnabled = true;
            this.comboBoxHost.Items.AddRange(new object[] {
            "Gif",
            "Jpeg",
            "Png"});
            this.comboBoxHost.Location = new System.Drawing.Point(64, 94);
            this.comboBoxHost.Name = "comboBoxHost";
            this.comboBoxHost.Size = new System.Drawing.Size(121, 21);
            this.comboBoxHost.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Format: ";
            // 
            // comboBoxUploadFormat
            // 
            this.comboBoxUploadFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUploadFormat.FormattingEnabled = true;
            this.comboBoxUploadFormat.Items.AddRange(new object[] {
            "Gif",
            "Jpeg",
            "Png"});
            this.comboBoxUploadFormat.Location = new System.Drawing.Point(64, 67);
            this.comboBoxUploadFormat.Name = "comboBoxUploadFormat";
            this.comboBoxUploadFormat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUploadFormat.TabIndex = 5;
            // 
            // radioButtonOpenImageInBrowser
            // 
            this.radioButtonOpenImageInBrowser.AutoSize = true;
            this.radioButtonOpenImageInBrowser.Location = new System.Drawing.Point(196, 38);
            this.radioButtonOpenImageInBrowser.Name = "radioButtonOpenImageInBrowser";
            this.radioButtonOpenImageInBrowser.Size = new System.Drawing.Size(146, 17);
            this.radioButtonOpenImageInBrowser.TabIndex = 4;
            this.radioButtonOpenImageInBrowser.TabStop = true;
            this.radioButtonOpenImageInBrowser.Text = "Open image in browser";
            this.radioButtonOpenImageInBrowser.UseVisualStyleBackColor = true;
            // 
            // radioButtonCopyLinkToClipboard
            // 
            this.radioButtonCopyLinkToClipboard.AutoSize = true;
            this.radioButtonCopyLinkToClipboard.Location = new System.Drawing.Point(17, 38);
            this.radioButtonCopyLinkToClipboard.Name = "radioButtonCopyLinkToClipboard";
            this.radioButtonCopyLinkToClipboard.Size = new System.Drawing.Size(173, 17);
            this.radioButtonCopyLinkToClipboard.TabIndex = 2;
            this.radioButtonCopyLinkToClipboard.TabStop = true;
            this.radioButtonCopyLinkToClipboard.Text = "Copy image link to clipboard";
            this.radioButtonCopyLinkToClipboard.UseVisualStyleBackColor = true;
            // 
            // checkBoxUploadImage
            // 
            this.checkBoxUploadImage.AutoSize = true;
            this.checkBoxUploadImage.Location = new System.Drawing.Point(17, 15);
            this.checkBoxUploadImage.Name = "checkBoxUploadImage";
            this.checkBoxUploadImage.Size = new System.Drawing.Size(98, 17);
            this.checkBoxUploadImage.TabIndex = 3;
            this.checkBoxUploadImage.Text = "Upload image";
            this.checkBoxUploadImage.UseVisualStyleBackColor = true;
            // 
            // tabPageLocal
            // 
            this.tabPageLocal.Controls.Add(this.buttonOpenDirectory);
            this.tabPageLocal.Controls.Add(this.label6);
            this.tabPageLocal.Controls.Add(this.textBoxSaveDirectory);
            this.tabPageLocal.Controls.Add(this.label5);
            this.tabPageLocal.Controls.Add(this.comboBoxSaveFormat);
            this.tabPageLocal.Controls.Add(this.checkBoxSaveImage);
            this.tabPageLocal.Location = new System.Drawing.Point(4, 22);
            this.tabPageLocal.Name = "tabPageLocal";
            this.tabPageLocal.Size = new System.Drawing.Size(452, 230);
            this.tabPageLocal.TabIndex = 3;
            this.tabPageLocal.Text = "   LOCAL   ";
            this.tabPageLocal.UseVisualStyleBackColor = true;
            // 
            // buttonOpenDirectory
            // 
            this.buttonOpenDirectory.Location = new System.Drawing.Point(307, 94);
            this.buttonOpenDirectory.Name = "buttonOpenDirectory";
            this.buttonOpenDirectory.Size = new System.Drawing.Size(75, 25);
            this.buttonOpenDirectory.TabIndex = 12;
            this.buttonOpenDirectory.Text = "...";
            this.buttonOpenDirectory.UseVisualStyleBackColor = true;
            this.buttonOpenDirectory.Click += new System.EventHandler(this.buttonOpenDirectory_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Save Directory: ";
            // 
            // textBoxSaveDirectory
            // 
            this.textBoxSaveDirectory.BackColor = System.Drawing.Color.White;
            this.textBoxSaveDirectory.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBoxSaveDirectory.Location = new System.Drawing.Point(17, 94);
            this.textBoxSaveDirectory.Name = "textBoxSaveDirectory";
            this.textBoxSaveDirectory.ReadOnly = true;
            this.textBoxSaveDirectory.Size = new System.Drawing.Size(284, 25);
            this.textBoxSaveDirectory.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Format: ";
            // 
            // comboBoxSaveFormat
            // 
            this.comboBoxSaveFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSaveFormat.FormattingEnabled = true;
            this.comboBoxSaveFormat.Items.AddRange(new object[] {
            "Gif",
            "Jpeg",
            "Png",
            "Bmp"});
            this.comboBoxSaveFormat.Location = new System.Drawing.Point(69, 32);
            this.comboBoxSaveFormat.Name = "comboBoxSaveFormat";
            this.comboBoxSaveFormat.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSaveFormat.TabIndex = 7;
            // 
            // checkBoxSaveImage
            // 
            this.checkBoxSaveImage.AutoSize = true;
            this.checkBoxSaveImage.Location = new System.Drawing.Point(17, 15);
            this.checkBoxSaveImage.Name = "checkBoxSaveImage";
            this.checkBoxSaveImage.Size = new System.Drawing.Size(83, 17);
            this.checkBoxSaveImage.TabIndex = 3;
            this.checkBoxSaveImage.Text = "Save image";
            this.checkBoxSaveImage.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PreferencesForm";
            this.Text = "Preferences";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SettingsForm_FormClosed);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageGeneral.ResumeLayout(false);
            this.tabPageGeneral.PerformLayout();
            this.tabPageShortcut.ResumeLayout(false);
            this.tabPageShortcut.PerformLayout();
            this.tabPageHosting.ResumeLayout(false);
            this.tabPageHosting.PerformLayout();
            this.tabPageLocal.ResumeLayout(false);
            this.tabPageLocal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.CheckBox checkBoxEnableSoundEffect;
        private System.Windows.Forms.TabPage tabPageShortcut;
        private System.Windows.Forms.Label label1;
        private Shortcut.Forms.HotkeyTextBox hotkeyTextBoxCaptureArea;
        private System.Windows.Forms.TabPage tabPageHosting;
        private System.Windows.Forms.CheckBox checkBoxUploadImage;
        private System.Windows.Forms.RadioButton radioButtonCopyLinkToClipboard;
        private System.Windows.Forms.RadioButton radioButtonOpenImageInBrowser;
        private System.Windows.Forms.Label label2;
        private Shortcut.Forms.HotkeyTextBox hotkeyTextBoxCaptureFullscreen;
        private System.Windows.Forms.Label label3;
        private Shortcut.Forms.HotkeyTextBox hotkeyTextBoxCaptureActiveWindow;
        private System.Windows.Forms.TabPage tabPageLocal;
        private System.Windows.Forms.CheckBox checkBoxSaveImage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxUploadFormat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSaveFormat;
        private System.Windows.Forms.CheckBox checkBoxStartWithWindows;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSaveDirectory;
        private System.Windows.Forms.Button buttonOpenDirectory;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxHost;
    }
}