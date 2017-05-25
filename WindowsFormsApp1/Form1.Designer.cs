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
            this.label6 = new System.Windows.Forms.Label();
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
            this.trackBar1.Location = new System.Drawing.Point(150, 25);
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
            this.trackBar_mu.Location = new System.Drawing.Point(12, 379);
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
            this.label2.Location = new System.Drawing.Point(130, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Маштаб осцилографа";
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
            this.label5.Location = new System.Drawing.Point(519, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "500 µ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "5 000 µ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormLab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 436);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
    }
}

