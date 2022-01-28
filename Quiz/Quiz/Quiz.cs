using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Quiz
{
    static class Quiz
    {
        static public List<string> musicList = new List<string>();

        static public int gameDuration = 0; //Продолжительность игры
        static public int musicDuration = 0; //Время на одну песню
        static public bool randomStart = false; //Случайное место начала
        static public string lastFolder = ""; //Папка с музыкой
        static public bool allDirectories = false; //Обработка вложенных папок

        static public void ReadMusic()
        {
            try
            {
                string[] musicFiles = Directory.GetFiles(lastFolder, "*.mp3",
                    allDirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                musicList.Clear();
                musicList.AddRange(musicFiles);
            }
            catch
            {

            }
        }

        static string regKeyName = "Software\\QuizName\\Quiz";
        public static void WriteRegistry()
        {
            RegistryKey rk = null; //Класс для работы с ключами реестра
            try
            {
                rk = Registry.CurrentUser.CreateSubKey(regKeyName); //Обращаемся к redKeyName
                if (rk.Equals(null))
                {
                    return;
                }
                rk.SetValue("LastFolder", lastFolder); //Запись параметров...
                rk.SetValue("Random", randomStart);
                rk.SetValue("GameDuration", gameDuration);
                rk.SetValue("MusicDuration", musicDuration);
                rk.SetValue("allDirectories", allDirectories);
            }
            finally
            {
                if(rk != null)
                {
                    rk.Close();
                }
            }
        }

        public static void ReadRegistry()
        {
            RegistryKey rk = null; //Класс для работы с ключами реестра
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(regKeyName); //Обращаемся к redKeyName
                if (rk != null) //Если получили доступ, то считываем данные...
                {
                    //GetValue возвращает объект object
                    lastFolder = (string)rk.GetValue("LastFolder");
                    gameDuration = (int)rk.GetValue("GameDuration");
                    randomStart = Convert.ToBoolean(rk.GetValue("Random", false));
                    musicDuration = (int)rk.GetValue("MusicDuration");
                    allDirectories = Convert.ToBoolean(rk.GetValue("AllDirectories"));
                }
            }
            finally
            {
                if (rk != null)
                {
                    rk.Close();
                }
            }
        }
    }
}
