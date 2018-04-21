using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace volt_anus
{
    public partial class V1_29 : Form
    {
        public V1_29()
        {
            InitializeComponent();
        }

        public String s_Command;
        private void V1_29_Load(object sender, EventArgs e)
        {

        }
      
        private void but_setF_Click(object sender, EventArgs e)
        {
            switch (comboBoxFeriq.Text)
            {
                case "MHz":
                    s_Command = "FMHZ" + comboBoxFeriq.Text;
                    break;
                case "kHz":
                    s_Command = "FKHZ" + comboBoxFeriq.Text;
                    break;
                case "Hz":
                    s_Command = "FHZ" + comboBoxFeriq.Text;
                    break;
            }
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 50;
        }

        private void but_setV_Click(object sender, EventArgs e)
        {
            switch (comboBoxVoltage.Text)
            {
                case "mV":
                    s_Command = "UMV" + comboBoxVoltage.Text;
                    break;
                case "V":
                    s_Command = "UV" + comboBoxVoltage.Text;
                    break;
                case "uV":
                    s_Command = "UMKV" + comboBoxVoltage.Text;
                    break;
                case "dB":
                    s_Command = "UDB" + comboBoxVoltage.Text;
                    break;        
            }
            
        }

        private void but_setE_Click(object sender, EventArgs e)
        {
            switch (comboBox_Error.Text)
            {
                case "%":
                    s_Command = "J%" + comboBox_Error.Text;
                    break;
                case "dB":
                    s_Command = "JDB" + comboBox_Error.Text;
                    break;
            }
        }

        private void but_setC_Click(object sender, EventArgs e)
        {
            s_Command = "CPF" + textBox_LoadCap.Text;
        }

        private void but_setR_Click(object sender, EventArgs e)
        {
            s_Command = "RKOHM" + textBoxResistance.Text;
        }
    }
}
