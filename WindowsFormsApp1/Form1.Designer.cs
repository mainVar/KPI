namespace WindowsFormsApp1
{
    partial class FormLab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLab));
            this.cbxVariant = new System.Windows.Forms.ComboBox();
            this.buttonSelectVariant = new System.Windows.Forms.Button();
            this.labelVoltmeter = new System.Windows.Forms.Label();
            this.timerVoltmeter = new System.Windows.Forms.Timer(this.components);
            this.timerOscilloscope = new System.Windows.Forms.Timer(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.trackBar_Size = new System.Windows.Forms.TrackBar();
            this.buttonExit = new System.Windows.Forms.Button();
            this.trackBar_mu = new System.Windows.Forms.TrackBar();
            this.boxOscilloscope = new System.Windows.Forms.PictureBox();
            this.buttonLab2 = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar_VertShift = new System.Windows.Forms.TrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOscilloscope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VertShift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxVariant
            // 
            this.cbxVariant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVariant.FormattingEnabled = true;
            this.cbxVariant.Location = new System.Drawing.Point(12, 12);
            this.cbxVariant.Name = "cbxVariant";
            this.cbxVariant.Size = new System.Drawing.Size(90, 21);
            this.cbxVariant.TabIndex = 0;
            this.cbxVariant.SelectedIndexChanged += new System.EventHandler(this.cbxVariant_SelectedIndexChanged);
            // 
            // buttonSelectVariant
            // 
            this.buttonSelectVariant.Location = new System.Drawing.Point(12, 39);
            this.buttonSelectVariant.Name = "buttonSelectVariant";
            this.buttonSelectVariant.Size = new System.Drawing.Size(90, 23);
            this.buttonSelectVariant.TabIndex = 1;
            this.buttonSelectVariant.Text = "Вибрати";
            this.buttonSelectVariant.UseVisualStyleBackColor = true;
            this.buttonSelectVariant.Click += new System.EventHandler(this.buttonSelectVariant_Click);
            // 
            // labelVoltmeter
            // 
            this.labelVoltmeter.Font = new System.Drawing.Font("Microsoft Tai Le", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVoltmeter.ForeColor = System.Drawing.Color.Black;
            this.labelVoltmeter.Image = global::WindowsFormsApp1.Properties.Resources.EK_SVAL0013PW_100V_I10A_B;
            this.labelVoltmeter.Location = new System.Drawing.Point(49, 183);
            this.labelVoltmeter.Name = "labelVoltmeter";
            this.labelVoltmeter.Size = new System.Drawing.Size(99, 32);
            this.labelVoltmeter.TabIndex = 2;
            this.labelVoltmeter.Text = "0.0";
            this.labelVoltmeter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerVoltmeter
            // 
            this.timerVoltmeter.Interval = 1000;
            this.timerVoltmeter.Tick += new System.EventHandler(this.timerVoltmeter_Tick);
            // 
            // timerOscilloscope
            // 
            this.timerOscilloscope.Tick += new System.EventHandler(this.timerOscilloscope_Tick);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(130, 25);
            this.trackBar1.Maximum = 50;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 108);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // trackBar_Size
            // 
            this.trackBar_Size.Location = new System.Drawing.Point(12, 305);
            this.trackBar_Size.Maximum = 15;
            this.trackBar_Size.Name = "trackBar_Size";
            this.trackBar_Size.Size = new System.Drawing.Size(547, 45);
            this.trackBar_Size.TabIndex = 6;
            this.trackBar_Size.Value = 1;
            this.trackBar_Size.Scroll += new System.EventHandler(this.trackBar_Size_Scroll);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 97);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(90, 23);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // trackBar_mu
            // 
            this.trackBar_mu.Enabled = false;
            this.trackBar_mu.Location = new System.Drawing.Point(15, 369);
            this.trackBar_mu.Maximum = 100;
            this.trackBar_mu.Minimum = -100;
            this.trackBar_mu.Name = "trackBar_mu";
            this.trackBar_mu.Size = new System.Drawing.Size(547, 45);
            this.trackBar_mu.TabIndex = 9;
            this.trackBar_mu.Scroll += new System.EventHandler(this.trackBar_mu_Scroll);
            // 
            // boxOscilloscope
            // 
            this.boxOscilloscope.BackColor = System.Drawing.Color.Black;
            this.boxOscilloscope.Location = new System.Drawing.Point(252, 12);
            this.boxOscilloscope.Name = "boxOscilloscope";
            this.boxOscilloscope.Size = new System.Drawing.Size(307, 261);
            this.boxOscilloscope.TabIndex = 4;
            this.boxOscilloscope.TabStop = false;
            this.boxOscilloscope.Click += new System.EventHandler(this.boxOscilloscope_Click);
            this.boxOscilloscope.Paint += new System.Windows.Forms.PaintEventHandler(this.boxOscilloscope_Paint);
            // 
            // buttonLab2
            // 
            this.buttonLab2.Location = new System.Drawing.Point(12, 68);
            this.buttonLab2.Name = "buttonLab2";
            this.buttonLab2.Size = new System.Drawing.Size(90, 23);
            this.buttonLab2.TabIndex = 10;
            this.buttonLab2.Text = "До досліду №2";
            this.buttonLab2.UseVisualStyleBackColor = true;
            this.buttonLab2.Click += new System.EventHandler(this.buttonLab2_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Location = new System.Drawing.Point(55, 250);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(90, 23);
            this.buttonPause.TabIndex = 11;
            this.buttonPause.Text = "Значення ";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Магнітна проникність µ";
            // 
            // trackBar_VertShift
            // 
            this.trackBar_VertShift.Location = new System.Drawing.Point(201, 25);
            this.trackBar_VertShift.Maximum = 100;
            this.trackBar_VertShift.Minimum = -100;
            this.trackBar_VertShift.Name = "trackBar_VertShift";
            this.trackBar_VertShift.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar_VertShift.Size = new System.Drawing.Size(45, 261);
            this.trackBar_VertShift.TabIndex = 13;
            this.trackBar_VertShift.Scroll += new System.EventHandler(this.trackBar_VertShift_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.EK_SVAL0013PW_100V_I10A_B;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 93);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Зміщення Y ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "B(r) Залишкова намагніченість";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Вольтметр ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "500 µ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(108, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(16, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "i";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 39);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(123, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Маштаб";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "4 500 µ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(73, 337);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "4 000 µ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "3 500 µ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "3 000 µ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 337);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "2 500 µ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(343, 337);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "2 000 µ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(401, 338);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "1 500 µ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(463, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "1 000 µ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(160, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(19, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "- 1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(159, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "- 10";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(160, 72);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(19, 13);
            this.label18.TabIndex = 32;
            this.label18.Text = "- 5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(25, 401);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(528, 13);
            this.label19.TabIndex = 33;
            this.label19.Text = "l                  I                  I                   I                  I   " +
    "               I                  I                  I                  I       " +
    "            I";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(83, 135);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(59, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Матеріал :";
            // 
            // FormLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(571, 436);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar_VertShift);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.buttonLab2);
            this.Controls.Add(this.trackBar_mu);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.trackBar_Size);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.boxOscilloscope);
            this.Controls.Add(this.labelVoltmeter);
            this.Controls.Add(this.buttonSelectVariant);
            this.Controls.Add(this.cbxVariant);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLab";
            this.ShowIcon = false;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormLab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Size)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_mu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxOscilloscope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_VertShift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxVariant;
        private System.Windows.Forms.Button buttonSelectVariant;
        private System.Windows.Forms.Label labelVoltmeter;
        private System.Windows.Forms.Timer timerVoltmeter;
        private System.Windows.Forms.Timer timerOscilloscope;
        private System.Windows.Forms.PictureBox boxOscilloscope;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar trackBar_Size;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TrackBar trackBar_mu;
        private System.Windows.Forms.Button buttonLab2;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar_VertShift;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

