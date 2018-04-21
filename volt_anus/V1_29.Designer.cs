namespace volt_anus
{
    partial class V1_29
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
            this.but_setV = new System.Windows.Forms.Button();
            this.but_setF = new System.Windows.Forms.Button();
            this.label_V = new System.Windows.Forms.Label();
            this.label_F = new System.Windows.Forms.Label();
            this.textBox_Voltage = new System.Windows.Forms.TextBox();
            this.textBox_Frequency = new System.Windows.Forms.TextBox();
            this.comboBoxVoltage = new System.Windows.Forms.ComboBox();
            this.comboBoxFeriq = new System.Windows.Forms.ComboBox();
            this.textBoxError = new System.Windows.Forms.TextBox();
            this.textBox_LoadCap = new System.Windows.Forms.TextBox();
            this.textBoxResistance = new System.Windows.Forms.TextBox();
            this.comboBox_Error = new System.Windows.Forms.ComboBox();
            this.but_setE = new System.Windows.Forms.Button();
            this.but_setC = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.but_setR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_setV
            // 
            this.but_setV.Location = new System.Drawing.Point(334, 25);
            this.but_setV.Name = "but_setV";
            this.but_setV.Size = new System.Drawing.Size(75, 23);
            this.but_setV.TabIndex = 0;
            this.but_setV.Text = "Ok";
            this.but_setV.UseVisualStyleBackColor = true;
            this.but_setV.Click += new System.EventHandler(this.but_setV_Click);
            // 
            // but_setF
            // 
            this.but_setF.Location = new System.Drawing.Point(334, 71);
            this.but_setF.Name = "but_setF";
            this.but_setF.Size = new System.Drawing.Size(75, 23);
            this.but_setF.TabIndex = 1;
            this.but_setF.Text = "Ok";
            this.but_setF.UseVisualStyleBackColor = true;
            this.but_setF.Click += new System.EventHandler(this.but_setF_Click);
            // 
            // label_V
            // 
            this.label_V.AutoSize = true;
            this.label_V.Location = new System.Drawing.Point(12, 9);
            this.label_V.Name = "label_V";
            this.label_V.Size = new System.Drawing.Size(108, 13);
            this.label_V.TabIndex = 2;
            this.label_V.Text = "Задать напряжение";
            // 
            // label_F
            // 
            this.label_F.AutoSize = true;
            this.label_F.Location = new System.Drawing.Point(12, 55);
            this.label_F.Name = "label_F";
            this.label_F.Size = new System.Drawing.Size(84, 13);
            this.label_F.TabIndex = 3;
            this.label_F.Text = "Задать частоту";
            // 
            // textBox_Voltage
            // 
            this.textBox_Voltage.Location = new System.Drawing.Point(20, 25);
            this.textBox_Voltage.Name = "textBox_Voltage";
            this.textBox_Voltage.Size = new System.Drawing.Size(100, 20);
            this.textBox_Voltage.TabIndex = 4;
            // 
            // textBox_Frequency
            // 
            this.textBox_Frequency.Location = new System.Drawing.Point(20, 71);
            this.textBox_Frequency.Name = "textBox_Frequency";
            this.textBox_Frequency.Size = new System.Drawing.Size(100, 20);
            this.textBox_Frequency.TabIndex = 5;
            // 
            // comboBoxVoltage
            // 
            this.comboBoxVoltage.FormattingEnabled = true;
            this.comboBoxVoltage.Items.AddRange(new object[] {
            "mV",
            "V",
            "uV",
            "dB"});
            this.comboBoxVoltage.Location = new System.Drawing.Point(159, 24);
            this.comboBoxVoltage.Name = "comboBoxVoltage";
            this.comboBoxVoltage.Size = new System.Drawing.Size(60, 21);
            this.comboBoxVoltage.TabIndex = 6;
            // 
            // comboBoxFeriq
            // 
            this.comboBoxFeriq.FormattingEnabled = true;
            this.comboBoxFeriq.Items.AddRange(new object[] {
            "MHz",
            "KHz",
            "Hz"});
            this.comboBoxFeriq.Location = new System.Drawing.Point(159, 70);
            this.comboBoxFeriq.Name = "comboBoxFeriq";
            this.comboBoxFeriq.Size = new System.Drawing.Size(60, 21);
            this.comboBoxFeriq.TabIndex = 7;
            // 
            // textBoxError
            // 
            this.textBoxError.Location = new System.Drawing.Point(20, 113);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(100, 20);
            this.textBoxError.TabIndex = 8;
            // 
            // textBox_LoadCap
            // 
            this.textBox_LoadCap.Location = new System.Drawing.Point(20, 157);
            this.textBox_LoadCap.Name = "textBox_LoadCap";
            this.textBox_LoadCap.Size = new System.Drawing.Size(100, 20);
            this.textBox_LoadCap.TabIndex = 9;
            // 
            // textBoxResistance
            // 
            this.textBoxResistance.Location = new System.Drawing.Point(20, 196);
            this.textBoxResistance.Name = "textBoxResistance";
            this.textBoxResistance.Size = new System.Drawing.Size(100, 20);
            this.textBoxResistance.TabIndex = 10;
            // 
            // comboBox_Error
            // 
            this.comboBox_Error.FormattingEnabled = true;
            this.comboBox_Error.Items.AddRange(new object[] {
            "%",
            "dB"});
            this.comboBox_Error.Location = new System.Drawing.Point(159, 113);
            this.comboBox_Error.Name = "comboBox_Error";
            this.comboBox_Error.Size = new System.Drawing.Size(60, 21);
            this.comboBox_Error.TabIndex = 11;
            // 
            // but_setE
            // 
            this.but_setE.Location = new System.Drawing.Point(334, 110);
            this.but_setE.Name = "but_setE";
            this.but_setE.Size = new System.Drawing.Size(75, 23);
            this.but_setE.TabIndex = 12;
            this.but_setE.Text = "Ok";
            this.but_setE.UseVisualStyleBackColor = true;
            this.but_setE.Click += new System.EventHandler(this.but_setE_Click);
            // 
            // but_setC
            // 
            this.but_setC.Location = new System.Drawing.Point(334, 154);
            this.but_setC.Name = "but_setC";
            this.but_setC.Size = new System.Drawing.Size(75, 23);
            this.but_setC.TabIndex = 13;
            this.but_setC.Text = "Ok";
            this.but_setC.UseVisualStyleBackColor = true;
            this.but_setC.Click += new System.EventHandler(this.but_setC_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Допуск погрешности ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "ёмкость нагрузки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Сопротивление ";
            // 
            // but_setR
            // 
            this.but_setR.Location = new System.Drawing.Point(334, 193);
            this.but_setR.Name = "but_setR";
            this.but_setR.Size = new System.Drawing.Size(75, 23);
            this.but_setR.TabIndex = 17;
            this.but_setR.Text = "Ok";
            this.but_setR.UseVisualStyleBackColor = true;
            this.but_setR.Click += new System.EventHandler(this.but_setR_Click);
            // 
            // V1_29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 259);
            this.Controls.Add(this.but_setR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_setC);
            this.Controls.Add(this.but_setE);
            this.Controls.Add(this.comboBox_Error);
            this.Controls.Add(this.textBoxResistance);
            this.Controls.Add(this.textBox_LoadCap);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.comboBoxFeriq);
            this.Controls.Add(this.comboBoxVoltage);
            this.Controls.Add(this.textBox_Frequency);
            this.Controls.Add(this.textBox_Voltage);
            this.Controls.Add(this.label_F);
            this.Controls.Add(this.label_V);
            this.Controls.Add(this.but_setF);
            this.Controls.Add(this.but_setV);
            this.Name = "V1_29";
            this.Text = "V1_29";
            this.Load += new System.EventHandler(this.V1_29_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_setV;
        private System.Windows.Forms.Button but_setF;
        private System.Windows.Forms.Label label_V;
        private System.Windows.Forms.Label label_F;
        private System.Windows.Forms.TextBox textBox_Voltage;
        private System.Windows.Forms.TextBox textBox_Frequency;
        private System.Windows.Forms.ComboBox comboBoxVoltage;
        private System.Windows.Forms.ComboBox comboBoxFeriq;
        private System.Windows.Forms.TextBox textBoxError;
        private System.Windows.Forms.TextBox textBox_LoadCap;
        private System.Windows.Forms.TextBox textBoxResistance;
        private System.Windows.Forms.ComboBox comboBox_Error;
        private System.Windows.Forms.Button but_setE;
        private System.Windows.Forms.Button but_setC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button but_setR;
    }
}