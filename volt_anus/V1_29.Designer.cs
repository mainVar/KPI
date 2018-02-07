namespace volt_URV
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
            this.but_setV.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_setF
            // 
            this.but_setF.Location = new System.Drawing.Point(334, 71);
            this.but_setF.Name = "but_setF";
            this.but_setF.Size = new System.Drawing.Size(75, 23);
            this.but_setF.TabIndex = 1;
            this.but_setF.Text = "Ok";
            this.but_setF.UseVisualStyleBackColor = true;
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
            // V1_29
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 259);
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
    }
}