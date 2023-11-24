using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GornovTA.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            StringBuilder SB = new StringBuilder();

            foreach (char c in path)
            {
                bool Ru = (c >= '\u0410' && c <= '\u044F') || c == '\u0401' || c == '\u0451';
                if (!Ru)
                {
                    SB.Append(c);
                }
            }

            return SB.ToString();
        }
    }
}
