using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskSalakhutdinova
{
    public partial class web : Form
    {
        public web()
        {
            InitializeComponent();
        }

        private void web_Load(object sender, EventArgs e)
        {

            webBrowser1.Navigate(DataPlfce.Default.htmlplace);
          //  webBrowser1.DocumentText = Encoding.Default.GetString(Encoding.UTF8.GetBytes(webBrowser1.DocumentText));
            
        }
    }
}
