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


namespace WindowsFormsApp1
{
    public partial class info : Form
    {
        public info()
        {
            InitializeComponent();
        }

        private void info_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

           private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLab lb1 = new FormLab();
            lb1.Show();

        }

        private void infoBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
