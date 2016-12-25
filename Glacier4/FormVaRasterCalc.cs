using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Glacier4
{
    public partial class FormVaRasterCalc : Form
    {
        public string exp;
        public FormVaRasterCalc()
        {
            InitializeComponent();
        }

        private void FormVaRasterCalc_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            exp = richTextBox1.Text;
        }
    }
}
