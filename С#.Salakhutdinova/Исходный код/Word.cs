using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace TestTaskSalakhutdinova
{
    class Word
    {
       
        public string OpenWord(string place)
        {
            FileStream txtfile = File.OpenRead(place);
            //строку из файла txtword.txt преобразую в байты
            byte[] massyb = new byte[txtfile.Length];
            // считываю полученные данные
            txtfile.Read(massyb, 0, massyb.Length);
            // заново преобразую в строку
            string textFromFile = System.Text.Encoding.UTF8.GetString(massyb);       
            return textFromFile;
           
        }
 
    }    
       
}
