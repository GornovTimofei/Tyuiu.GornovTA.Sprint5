using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.GornovTA.Sprint5.Task7.V23.Lib;

namespace Tyuiu.GornovTA.Sprint5.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт №5 | Выполнил: Горнов Т. А. | АСОиУб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт №5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту.                *");
            Console.WriteLine("* Задание №7                                                              *");
            Console.WriteLine("* Вариант №23                                                             *");
            Console.WriteLine("* Выполнил: Горнов Тимофей Анатольевич | АСОиУб-23-2                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V23.txt";
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V23.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Находится в файле: ");
            string file = File.ReadAllText(path);
            string fileRes = ds.LoadDataAndSave(file);
            File.WriteAllText(pathSaveFile, fileRes);
            Console.WriteLine(pathSaveFile);
            Console.ReadKey();
        }
    }
}
