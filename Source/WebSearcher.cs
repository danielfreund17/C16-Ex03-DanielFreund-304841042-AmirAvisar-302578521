using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C16_Ex03_Daniel_304841042_Amir_302578521
{
    public partial class WebSearcher : Form
    {
        public string Url { get; set; }

        public WebSearcher()
        {
            InitializeComponent();
        }

        private void WebSearcher_Load(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate(Url);
        }
    }
}
