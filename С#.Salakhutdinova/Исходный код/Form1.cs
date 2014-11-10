using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace TestTaskSalakhutdinova
{
    public partial class Form1 : Form
    {
        public string[] txtfilemas;
        public string[] dicfilemas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void open_Click(object sender, EventArgs e)
        {
            try
            {
                Word openword = new Word();

                OpenFileDialog OFP = new OpenFileDialog();
                OFP.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
              //  OFP.InitialDirectory = "c:\\";
                OFP.ShowDialog();
                DataPlfce.Default.txtplace = OFP.FileName;
                string textFromFile = openword.OpenWord(DataPlfce.Default.txtplace);

                MessageBox.Show("файл с текстом считан");
                MessageBox.Show(textFromFile);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Вы не выбрали файл!");
            }
        }
        public string dicfilesave = "";
        private void opendic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OFP = new OpenFileDialog();
                
                OFP.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
              //  OFP.InitialDirectory = "c:\\";
                OFP.ShowDialog();
                DataPlfce.Default.dicplace = OFP.FileName;
                Dictionary opendic = new Dictionary();
                Sorting sort = new Sorting();
                string textFromFile = opendic.DicOpen(DataPlfce.Default.dicplace);
                MessageBox.Show("файл-словарь считан");
                MessageBox.Show(textFromFile);
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Вы не выбрали файл!");
            }
                
        }

        private void create_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Открыть ли файл?", "Работа с файлом", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                   web perehod = new web();
                   perehod.Show();
                }
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Sorting sort = new Sorting();
                sort.SravnenieForHtml(DataPlfce.Default.txtplace);
                // MessageBox.Show("УСЁ");
                fileplace.Text = "Ваш файл сохранится в корневом каталоге:" + DataPlfce.Default.htmlplace;
            }
            catch (System.UnauthorizedAccessException)
            {
                MessageBox.Show("Отказано в доступе. Попробуйте сохранить в другое место.");
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("Файлы не выбраны и не могут быть обработаны");
            }
           
        }
        
    }
}
