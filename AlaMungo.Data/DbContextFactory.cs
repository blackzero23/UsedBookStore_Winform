using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlaMungo.Data
{
    public class DbContextFactory
    {
        private const string FilePath = @"d:\EF.log";

        private static void Write(string log)
        {
            string contents;
            if (File.Exists(FilePath))
                contents = File.ReadAllText(FilePath);

            else
                contents = "";

            string time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
            string formattedLog = $"[{time}]\r\n{log}\r\n------------------------\r\n\r\n";

            contents = formattedLog + contents; // 성능 구림

            File.WriteAllText(FilePath, contents);


        }

        public static YesAlaMungoEntities Create()
        {
            YesAlaMungoEntities context = new YesAlaMungoEntities();

            context.Database.Log = Write;

            return context;
        }
    }
}
