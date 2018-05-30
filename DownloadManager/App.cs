using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadManager
{
    static class App
    {
        static FilesDB db;
        public static FilesDB DB
        {
            get
            {
                if (db == null)
                    db = new FilesDB();
                return db;
            }
        }
    }
}
