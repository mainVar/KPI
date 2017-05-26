using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormLab : Form
    {

        private PowerSource powerSource;
        private Oscilloscope oscilloscope;

        public FormLab()
        {
            InitializeComponent();
        }

        private void FormLab_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 15; i++) {
                cbxVariant.Items.Add(i.ToString());
            }
            cbxVariant.SelectedIndex = 0;

            powerSource = new PowerSource();
            powerSource.voltage = 5;
            powerSource.enabled = true;
            powerSource.noiseEnabled = true;

            oscilloscope = new Oscilloscope();
        }

        private void buttonSelectVariant_Click(object sender, EventArgs e)
        {
            cbxVariant.Enabled = false;
            powerSource.voltage = (cbxVariant.SelectedIndex / 4) + (float)2.7;
            timerVoltmeter.Enabled = true;
            timerOscilloscope.Enabled = true;
            buttonSelectVariant.Enabled = false;
            
        }

        private void timerVoltmeter_Tick(object sender, EventArgs e)
        {
            labelVoltmeter.Text = Convert.ToString(powerSource.readVoltage());

        }

        private void timerOscilloscope_Tick(object sender, EventArgs e)
        {
            // Here we'll draw oscilloscope signal
            oscilloscope.newValue(powerSource.readVoltage());
            boxOscilloscope.Refresh();

            // clear boxOscilloscope
            
            // draw lines
        }

        private void boxOscilloscope_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            int xMax = boxOscilloscope.Width;
            int yMax = boxOscilloscope.Height;

            // grid code below
            
            Pen pen = new Pen(Color.Gray);
            pen.Width = 1;

            int gridLines = 10;
            Point start = new Point();
            Point end = new Point();
            for (int i = 0; i < gridLines; i++)
            {
                // vertical line
                start.X = (int)(((float)xMax / (float)gridLines) * (float)i); // i'm sorry
                end.X = start.X;
                start.Y = 0;
                end.Y = yMax;
                g.DrawLine(pen, start, end);

                // horizontal line
                start.X = 0;
                end.X = xMax;
                start.Y = (int)(((float)yMax / (float)gridLines) * (float)i);
                end.Y = start.Y;
                g.DrawLine(pen, start, end);
            }

            // graph code below
            pen = new Pen(Color.Green);

            Point[] points = new Point[oscilloscope.dots];

            for (int i = 0; i < oscilloscope.dots; i++) {
                points[i].X = (xMax / oscilloscope.dots) * i;
                points[i].Y = yMax / 2;
                points[i].Y -= (int)((oscilloscope.values[i] + oscilloscope.verticalShift) * oscilloscope.scale);
            }

            g.DrawLines(pen, points);

            

        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            oscilloscope.scale = trackBar1.Value;
        }

        private void boxOscilloscope_Click(object sender, EventArgs e)
        {

        }

        private void trackBar_Size_Scroll(object sender, EventArgs e)
        {
            powerSource.noiseCoefficient = trackBar_Size.Value;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trackBar_mu_Scroll(object sender, EventArgs e)
        {
            powerSource.maliciousShift = (float)trackBar_mu.Value / 200 ;
        }

        private void buttonLab2_Click(object sender, EventArgs e)
        {
            trackBar_mu.Enabled = true;
            buttonLab2.Enabled = false;
           // trackBar_Size.Value = trackBar_Size.Maximum;
            powerSource.noiseCoefficient = trackBar_Size.Value;
           // trackBar_Size.Enabled = false;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timerVoltmeter.Enabled = !timerVoltmeter.Enabled;
        }

        private void trackBar_VertShift_Scroll(object sender, EventArgs e)
        {
            oscilloscope.verticalShift = (float)trackBar_VertShift.Value / (float)15;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
