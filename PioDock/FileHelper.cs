using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace PioDock
{
    static class FileHelper
    {
        public static void WriteList(List<DockedModelScore> dockedRankList)
        {
            var path = Path.Combine(Form1.Input.DockedModelsFolderLocation, "RankedResult.txt");
            File.WriteAllText(path, ListToString(dockedRankList));
        }
        static string ListToString(List<DockedModelScore> list)
        {
            var str = "";
            foreach (var data in list)
            {
                str = str + data.ModelName + "," + data.RankedScore.ToString() + Environment.NewLine;
            }

            return str;
        }
    }
}
