namespace TestLocalizedEnum
{
    partial class TestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestForm));
            this._convertButton = new System.Windows.Forms.Button();
            this._enumListBox = new System.Windows.Forms.ListBox();
            this._textBox = new System.Windows.Forms.TextBox();
            this._cultureComboBox = new System.Windows.Forms.ComboBox();
            this._enumLabel = new System.Windows.Forms.Label();
            this._convertLabel = new System.Windows.Forms.Label();
            this._descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _convertButton
            // 
            resources.ApplyResources(this._convertButton, "_convertButton");
            this._convertButton.Name = "_convertButton";
            this._convertButton.UseVisualStyleBackColor = true;
            this._convertButton.Click += new System.EventHandler(this._convertButton_Click);
            // 
            // _enumListBox
            // 
            resources.ApplyResources(this._enumListBox, "_enumListBox");
            this._enumListBox.FormattingEnabled = true;
            this._enumListBox.Name = "_enumListBox";
            // 
            // _textBox
            // 
            resources.ApplyResources(this._textBox, "_textBox");
            this._textBox.Name = "_textBox";
            // 
            // _cultureComboBox
            // 
            resources.ApplyResources(this._cultureComboBox, "_cultureComboBox");
            this._cultureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._cultureComboBox.FormattingEnabled = true;
            this._cultureComboBox.Name = "_cultureComboBox";
            this._cultureComboBox.Sorted = true;
            // 
            // _enumLabel
            // 
            resources.ApplyResources(this._enumLabel, "_enumLabel");
            this._enumLabel.Name = "_enumLabel";
            // 
            // _convertLabel
            // 
            resources.ApplyResources(this._convertLabel, "_convertLabel");
            this._convertLabel.Name = "_convertLabel";
            // 
            // _descriptionLabel
            // 
            resources.ApplyResources(this._descriptionLabel, "_descriptionLabel");
            this._descriptionLabel.Name = "_descriptionLabel";
            // 
            // TestForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._descriptionLabel);
            this.Controls.Add(this._convertLabel);
            this.Controls.Add(this._enumLabel);
            this.Controls.Add(this._cultureComboBox);
            this.Controls.Add(this._textBox);
            this.Controls.Add(this._enumListBox);
            this.Controls.Add(this._convertButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _convertButton;
        private System.Windows.Forms.ListBox _enumListBox;
        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.ComboBox _cultureComboBox;
        private System.Windows.Forms.Label _enumLabel;
        private System.Windows.Forms.Label _convertLabel;
        private System.Windows.Forms.Label _descriptionLabel;
    }
}

