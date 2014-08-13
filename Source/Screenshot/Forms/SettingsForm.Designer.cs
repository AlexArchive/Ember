namespace Screenshot.Forms
{
    partial class SettingsForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageGeneral = new System.Windows.Forms.TabPage();
            this.checkBoxEnableSoundEffect = new System.Windows.Forms.CheckBox();
            this.tabPageShortcut = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.hotkeyTextBoxRegion = new Shortcut.Forms.HotkeyTextBox();
            this.tabPageHosting = new System.Windows.Forms.TabPage();
            this.radioButtonCopyLinkToClipboard = new System.Windows.Forms.RadioButton();
            this.checkBoxUploadAfterCapture = new System.Windows.Forms.CheckBox();
            this.radioButtonOpenImageInBrowser = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageGeneral.SuspendLayout();
            this.tabPageShortcut.SuspendLayout();
            this.tabPageHosting.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Screenshot.Properties.Resources.settings_banner;
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
            this.tabControl1.Location = new System.Drawing.Point(12, 94);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 256);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageGeneral
            // 
            this.tabPageGeneral.Controls.Add(this.checkBoxEnableSoundEffect);
            this.tabPageGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabPageGeneral.Name = "tabPageGeneral";
            this.tabPageGeneral.Size = new System.Drawing.Size(452, 230);
            this.tabPageGeneral.TabIndex = 0;
            this.tabPageGeneral.Text = "General";
            this.tabPageGeneral.UseVisualStyleBackColor = true;
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
            this.tabPageShortcut.Controls.Add(this.label1);
            this.tabPageShortcut.Controls.Add(this.hotkeyTextBoxRegion);
            this.tabPageShortcut.Location = new System.Drawing.Point(4, 22);
            this.tabPageShortcut.Name = "tabPageShortcut";
            this.tabPageShortcut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageShortcut.Size = new System.Drawing.Size(452, 230);
            this.tabPageShortcut.TabIndex = 1;
            this.tabPageShortcut.Text = "Shortcut";
            this.tabPageShortcut.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Region hotkey:";
            // 
            // hotkeyTextBoxRegion
            // 
            this.hotkeyTextBoxRegion.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.hotkeyTextBoxRegion.Hotkey = null;
            this.hotkeyTextBoxRegion.Location = new System.Drawing.Point(20, 31);
            this.hotkeyTextBoxRegion.Name = "hotkeyTextBoxRegion";
            this.hotkeyTextBoxRegion.Size = new System.Drawing.Size(199, 22);
            this.hotkeyTextBoxRegion.TabIndex = 0;
            this.hotkeyTextBoxRegion.Text = "None";
            // 
            // tabPageHosting
            // 
            this.tabPageHosting.Controls.Add(this.radioButtonOpenImageInBrowser);
            this.tabPageHosting.Controls.Add(this.radioButtonCopyLinkToClipboard);
            this.tabPageHosting.Controls.Add(this.checkBoxUploadAfterCapture);
            this.tabPageHosting.Location = new System.Drawing.Point(4, 22);
            this.tabPageHosting.Name = "tabPageHosting";
            this.tabPageHosting.Size = new System.Drawing.Size(452, 230);
            this.tabPageHosting.TabIndex = 2;
            this.tabPageHosting.Text = "Hosting";
            this.tabPageHosting.UseVisualStyleBackColor = true;
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
            // checkBoxUploadAfterCapture
            // 
            this.checkBoxUploadAfterCapture.AutoSize = true;
            this.checkBoxUploadAfterCapture.Location = new System.Drawing.Point(17, 15);
            this.checkBoxUploadAfterCapture.Name = "checkBoxUploadAfterCapture";
            this.checkBoxUploadAfterCapture.Size = new System.Drawing.Size(133, 17);
            this.checkBoxUploadAfterCapture.TabIndex = 3;
            this.checkBoxUploadAfterCapture.Text = "Upload after capture";
            this.checkBoxUploadAfterCapture.UseVisualStyleBackColor = true;
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
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 368);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageGeneral;
        private System.Windows.Forms.CheckBox checkBoxEnableSoundEffect;
        private System.Windows.Forms.TabPage tabPageShortcut;
        private System.Windows.Forms.Label label1;
        private Shortcut.Forms.HotkeyTextBox hotkeyTextBoxRegion;
        private System.Windows.Forms.TabPage tabPageHosting;
        private System.Windows.Forms.CheckBox checkBoxUploadAfterCapture;
        private System.Windows.Forms.RadioButton radioButtonCopyLinkToClipboard;
        private System.Windows.Forms.RadioButton radioButtonOpenImageInBrowser;
    }
}