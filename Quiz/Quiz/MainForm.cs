using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class MainForm : Form
    {
        SettingsForm sf = new SettingsForm();
        GameForm gf = new GameForm();
        public MainForm()
        {
            InitializeComponent();
        }

        //Главное меню
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            sf.ShowDialog(); //Предыдущее окно некликабельно, пока не закроем текущее
        }
        private void PlayButton_Click(object sender, EventArgs e)
        {
            gf.ShowDialog();
        }

        //Загрузка параметров из реестра
        private void MainForm_Load(object sender, EventArgs e) //Load - событие
        {
            Quiz.ReadRegistry();
            Quiz.ReadMusic();
        }
    }
}
