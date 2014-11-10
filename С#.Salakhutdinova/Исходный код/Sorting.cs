using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TestTaskSalakhutdinova
{
    class Sorting
    {


        public string[] SortDic()
        {
            Form1 place = new Form1();
            string[] readText = File.ReadAllLines(DataPlfce.Default.dicplace, Encoding.UTF8);
            return readText;
           
        }
               
        public void SravnenieForHtml(string txtplace)
        {
            try
            {
                string text = "";
                string str = "";
                Form1 formka = new Form1();
                SaveFileDialog OFP = new SaveFileDialog(); 
                OFP.ShowDialog();
                OFP.InitialDirectory = "c:\\";
                DataPlfce.Default.htmlplace = OFP.FileName;
                StreamReader sr = new StreamReader(DataPlfce.Default.txtplace);
                StreamWriter writer = new StreamWriter(new FileStream(DataPlfce.Default.htmlplace, FileMode.Create), Encoding.UTF8);
                writer.WriteLine("<html><head><body>");


                for (int i = 0; i < 4; i++)
                {
                    text = sr.ReadLine() + " " + "<br/>" + " ";

                    string[] textmas = text.Split(new Char[] { ' ' });
                    string[] dicmas = SortDic();
                    for (int k = 0; k < textmas.Length; k++)
                    {
                        for (int j = 0; j < dicmas.Length; j++)
                        {
                            if (textmas[k] == dicmas[j])
                            {
                                textmas[k] = "<b><i>" + textmas[k] + "</b></i>";

                            }
                        }

                    }
                    for (int o = 0; o < textmas.Length; o++)
                    {

                        str = str + textmas[o] + " ";
                        text = str;

                    }


                }

                writer.Write(text);
                writer.WriteLine(" </html></head></body>");
                writer.Close();
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Файлы не выбраны и не могут быть обработаны");
            }
        }
    
    }
}
