
namespace Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.MusicListBox = new System.Windows.Forms.ListBox();
            this.ReviewButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.DirectoryCheckBox = new System.Windows.Forms.CheckBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.GameSettingsGroupBox = new System.Windows.Forms.GroupBox();
            this.RandomStartCheckBox = new System.Windows.Forms.CheckBox();
            this.TimeAnswerComboBox = new System.Windows.Forms.ComboBox();
            this.GameDurationComboBox = new System.Windows.Forms.ComboBox();
            this.TimeAnswerLabel = new System.Windows.Forms.Label();
            this.GameDurationLabel = new System.Windows.Forms.Label();
            this.GameSettingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MusicListBox
            // 
            this.MusicListBox.FormattingEnabled = true;
            this.MusicListBox.ItemHeight = 16;
            this.MusicListBox.Location = new System.Drawing.Point(13, 13);
            this.MusicListBox.Name = "MusicListBox";
            this.MusicListBox.Size = new System.Drawing.Size(775, 244);
            this.MusicListBox.TabIndex = 0;
            // 
            // ReviewButton
            // 
            this.ReviewButton.Location = new System.Drawing.Point(13, 264);
            this.ReviewButton.Name = "ReviewButton";
            this.ReviewButton.Size = new System.Drawing.Size(93, 35);
            this.ReviewButton.TabIndex = 1;
            this.ReviewButton.Text = "Обзор...";
            this.ReviewButton.UseVisualStyleBackColor = true;
            this.ReviewButton.Click += new System.EventHandler(this.ReviewButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Location = new System.Drawing.Point(112, 264);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(93, 35);
            this.ClearListButton.TabIndex = 2;
            this.ClearListButton.Text = "Очистить";
            this.ClearListButton.UseVisualStyleBackColor = true;
            // 
            // DirectoryCheckBox
            // 
            this.DirectoryCheckBox.AutoSize = true;
            this.DirectoryCheckBox.Location = new System.Drawing.Point(639, 263);
            this.DirectoryCheckBox.Name = "DirectoryCheckBox";
            this.DirectoryCheckBox.Size = new System.Drawing.Size(149, 21);
            this.DirectoryCheckBox.TabIndex = 3;
            this.DirectoryCheckBox.Text = "Вложенные папки";
            this.DirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(713, 409);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 29);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(613, 409);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(94, 29);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "Принять";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // GameSettingsGroupBox
            // 
            this.GameSettingsGroupBox.Controls.Add(this.RandomStartCheckBox);
            this.GameSettingsGroupBox.Controls.Add(this.TimeAnswerComboBox);
            this.GameSettingsGroupBox.Controls.Add(this.GameDurationComboBox);
            this.GameSettingsGroupBox.Controls.Add(this.TimeAnswerLabel);
            this.GameSettingsGroupBox.Controls.Add(this.GameDurationLabel);
            this.GameSettingsGroupBox.Location = new System.Drawing.Point(13, 306);
            this.GameSettingsGroupBox.Name = "GameSettingsGroupBox";
            this.GameSettingsGroupBox.Size = new System.Drawing.Size(594, 132);
            this.GameSettingsGroupBox.TabIndex = 6;
            this.GameSettingsGroupBox.TabStop = false;
            this.GameSettingsGroupBox.Text = "Настройки игры";
            // 
            // RandomStartCheckBox
            // 
            this.RandomStartCheckBox.AutoSize = true;
            this.RandomStartCheckBox.Location = new System.Drawing.Point(10, 92);
            this.RandomStartCheckBox.Name = "RandomStartCheckBox";
            this.RandomStartCheckBox.Size = new System.Drawing.Size(194, 21);
            this.RandomStartCheckBox.TabIndex = 7;
            this.RandomStartCheckBox.Text = "Случайное место старта";
            this.RandomStartCheckBox.UseVisualStyleBackColor = true;
            // 
            // TimeAnswerComboBox
            // 
            this.TimeAnswerComboBox.FormattingEnabled = true;
            this.TimeAnswerComboBox.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35"});
            this.TimeAnswerComboBox.Location = new System.Drawing.Point(191, 50);
            this.TimeAnswerComboBox.Name = "TimeAnswerComboBox";
            this.TimeAnswerComboBox.Size = new System.Drawing.Size(121, 24);
            this.TimeAnswerComboBox.TabIndex = 3;
            this.TimeAnswerComboBox.Text = "15";
            // 
            // GameDurationComboBox
            // 
            this.GameDurationComboBox.FormattingEnabled = true;
            this.GameDurationComboBox.Items.AddRange(new object[] {
            "30",
            "60",
            "90",
            "120",
            "150",
            "180"});
            this.GameDurationComboBox.Location = new System.Drawing.Point(191, 22);
            this.GameDurationComboBox.Name = "GameDurationComboBox";
            this.GameDurationComboBox.Size = new System.Drawing.Size(121, 24);
            this.GameDurationComboBox.TabIndex = 2;
            this.GameDurationComboBox.Text = "90";
            // 
            // TimeAnswerLabel
            // 
            this.TimeAnswerLabel.AutoSize = true;
            this.TimeAnswerLabel.Location = new System.Drawing.Point(7, 59);
            this.TimeAnswerLabel.Name = "TimeAnswerLabel";
            this.TimeAnswerLabel.Size = new System.Drawing.Size(111, 17);
            this.TimeAnswerLabel.TabIndex = 1;
            this.TimeAnswerLabel.Text = "Время на ответ";
            // 
            // GameDurationLabel
            // 
            this.GameDurationLabel.AutoSize = true;
            this.GameDurationLabel.Location = new System.Drawing.Point(7, 22);
            this.GameDurationLabel.Name = "GameDurationLabel";
            this.GameDurationLabel.Size = new System.Drawing.Size(177, 17);
            this.GameDurationLabel.TabIndex = 0;
            this.GameDurationLabel.Text = "Продолжительность игры";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GameSettingsGroupBox);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DirectoryCheckBox);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.ReviewButton);
            this.Controls.Add(this.MusicListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.GameSettingsGroupBox.ResumeLayout(false);
            this.GameSettingsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MusicListBox;
        private System.Windows.Forms.Button ReviewButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.CheckBox DirectoryCheckBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.GroupBox GameSettingsGroupBox;
        private System.Windows.Forms.ComboBox TimeAnswerComboBox;
        private System.Windows.Forms.ComboBox GameDurationComboBox;
        private System.Windows.Forms.Label TimeAnswerLabel;
        private System.Windows.Forms.Label GameDurationLabel;
        private System.Windows.Forms.CheckBox RandomStartCheckBox;
    }
}