using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quiz
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog().Equals(DialogResult.OK))
            {
                string[] musicList = Directory.GetFiles(fbd.SelectedPath, "*.mp3",
                    DirectoryCheckBox.Checked ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);

                Quiz.lastFolder = fbd.SelectedPath; //записываем в реестр ∨

                MusicListBox.Items.Clear();
                MusicListBox.Items.AddRange(musicList);

                Quiz.musicList.Clear();
                Quiz.musicList.AddRange(musicList);
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            //Выбранные нами параметры из настроек передаём в класс викторины и записываем в реестр...
            Quiz.allDirectories = DirectoryCheckBox.Checked;
            Quiz.gameDuration = Convert.ToInt32(GameDurationComboBox.Text);
            Quiz.musicDuration = Convert.ToInt32(TimeAnswerComboBox.Text);
            Quiz.randomStart = RandomStartCheckBox.Checked;
            Quiz.WriteRegistry();

            this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Set();
            this.Hide();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            //Аналогично отмене ∧
            Set();
            MusicListBox.Items.Clear();
            MusicListBox.Items.AddRange(Quiz.musicList.ToArray());
        }

        //Метод: использования дефолтных праметров из реестра
        void Set()
        {
            DirectoryCheckBox.Checked = Quiz.allDirectories;
            GameDurationComboBox.Text = Quiz.gameDuration.ToString();
            TimeAnswerComboBox.Text = Quiz.musicDuration.ToString();
            RandomStartCheckBox.Checked = Quiz.randomStart;
        }
    }
}
