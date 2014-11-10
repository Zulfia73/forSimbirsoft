using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TestTaskSalakhutdinova
{
    class Dictionary
    {
        public string DicOpen(string place)
        {
            FileStream dicfile = File.OpenRead(place);

            //строку из файла txtword.txt преобразую в байты
            byte[] massyb = new byte[dicfile.Length];
            // считываю полученные данные
            dicfile.Read(massyb, 0, massyb.Length);
            // заново преобразую в строку
            string textFromFile = System.Text.Encoding.UTF8.GetString(massyb);
            return textFromFile;
        }
      
    }
}
