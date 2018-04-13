using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MumtaazHerbal
{
    class FileManager
    {

        private string fileName;

        //constructor untuk mengambil nama file database
        /// <param name="file"></param>
        /// 
        public FileManager(string file)
        {
            this.fileName = file;
        }

        /// <summary>
        /// Membuat file baru
        /// </summary>
        /// <param name="file"></param>
        public void CreateFile(string file)
        {
            File.Create(file);
        }

        /// <summary>
        /// Melakukan pengecekan tersedianya file database.
        /// </summary>
        /// <returns></returns>
        public bool isFileExists()
        {
            if (File.Exists(fileName))
            {
                return true;
            }

            return false;
        }
    }
}
