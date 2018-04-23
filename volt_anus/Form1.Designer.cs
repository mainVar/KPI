namespace volt_anus
{
    partial class VoltStandart
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Init = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.write = new System.Windows.Forms.Button();
            this.read = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Box_Device = new System.Windows.Forms.ComboBox();
            this.label_t = new System.Windows.Forms.Label();
            this.label_adr = new System.Windows.Forms.Label();
            this.textBox_initT = new System.Windows.Forms.TextBox();
            this.textBox_initNum = new System.Windows.Forms.TextBox();
            this.comboBox_comand = new System.Windows.Forms.ComboBox();
            this.button_STARTmeasur = new System.Windows.Forms.Button();
            this.button_STOPmeasur = new System.Windows.Forms.Button();
            this.cBox_A = new System.Windows.Forms.CheckBox();
            this.cBox_B = new System.Windows.Forms.CheckBox();
            this.textBox_Nmeasur = new System.Windows.Forms.TextBox();
            this.label_Nmeasur = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.textBox_Time = new System.Windows.Forms.TextBox();
            this.dataGridViewTable = new System.Windows.Forms.DataGridView();
            this.ColumNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumVa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Chanal2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_TimeM = new System.Windows.Forms.TextBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cBoxAB = new System.Windows.Forms.CheckBox();
            this.zedGrapH = new ZedGraph.ZedGraphControl();
            this.rebootAPI = new System.Windows.Forms.Button();
            this.ShortString = new System.Windows.Forms.CheckBox();
            this.Calibr = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.but_menuV1_29 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Init
            // 
            this.Init.Location = new System.Drawing.Point(6, 40);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(127, 56);
            this.Init.TabIndex = 0;
            this.Init.Text = "Инициализация ";
            this.Init.UseVisualStyleBackColor = true;
            this.Init.Click += new System.EventHandler(this.Init_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(435, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(288, 179);
            this.textBox1.TabIndex = 1;
            // 
            // write
            // 
            this.write.Location = new System.Drawing.Point(165, 67);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(75, 23);
            this.write.TabIndex = 2;
            this.write.Text = "write ";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.write_Click);
            // 
            // read
            // 
            this.read.Location = new System.Drawing.Point(246, 67);
            this.read.Name = "read";
            this.read.Size = new System.Drawing.Size(75, 23);
            this.read.TabIndex = 3;
            this.read.Text = "read";
            this.read.UseVisualStyleBackColor = true;
            this.read.Click += new System.EventHandler(this.read_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Устройство";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Box_Device);
            this.groupBox1.Controls.Add(this.label_t);
            this.groupBox1.Controls.Add(this.label_adr);
            this.groupBox1.Controls.Add(this.textBox_initT);
            this.groupBox1.Controls.Add(this.textBox_initNum);
            this.groupBox1.Controls.Add(this.Init);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Box_Device
            // 
            this.Box_Device.AutoCompleteCustomSource.AddRange(new string[] {
            "URV-5",
            "HP"});
            this.Box_Device.FormattingEnabled = true;
            this.Box_Device.Items.AddRange(new object[] {
            "HP34420A",
            "URV-5"});
            this.Box_Device.Location = new System.Drawing.Point(6, 13);
            this.Box_Device.Name = "Box_Device";
            this.Box_Device.Size = new System.Drawing.Size(127, 21);
            this.Box_Device.TabIndex = 20;
            // 
            // label_t
            // 
            this.label_t.AutoSize = true;
            this.label_t.Location = new System.Drawing.Point(10, 107);
            this.label_t.Name = "label_t";
            this.label_t.Size = new System.Drawing.Size(64, 13);
            this.label_t.TabIndex = 9;
            this.label_t.Text = "Задержка t";
            // 
            // label_adr
            // 
            this.label_adr.AutoSize = true;
            this.label_adr.Location = new System.Drawing.Point(10, 131);
            this.label_adr.Name = "label_adr";
            this.label_adr.Size = new System.Drawing.Size(47, 13);
            this.label_adr.TabIndex = 8;
            this.label_adr.Text = "№ adres";
            // 
            // textBox_initT
            // 
            this.textBox_initT.Location = new System.Drawing.Point(80, 102);
            this.textBox_initT.Name = "textBox_initT";
            this.textBox_initT.Size = new System.Drawing.Size(53, 20);
            this.textBox_initT.TabIndex = 6;
            this.textBox_initT.Text = "13";
            // 
            // textBox_initNum
            // 
            this.textBox_initNum.Location = new System.Drawing.Point(80, 128);
            this.textBox_initNum.Name = "textBox_initNum";
            this.textBox_initNum.Size = new System.Drawing.Size(53, 20);
            this.textBox_initNum.TabIndex = 7;
            this.textBox_initNum.Text = "11";
            // 
            // comboBox_comand
            // 
            this.comboBox_comand.FormattingEnabled = true;
            this.comboBox_comand.Items.AddRange(new object[] {
            "PA, F2, X1",
            "PB, F2, X1"});
            this.comboBox_comand.Location = new System.Drawing.Point(165, 40);
            this.comboBox_comand.Name = "comboBox_comand";
            this.comboBox_comand.Size = new System.Drawing.Size(156, 21);
            this.comboBox_comand.TabIndex = 7;
            // 
            // button_STARTmeasur
            // 
            this.button_STARTmeasur.Location = new System.Drawing.Point(623, 43);
            this.button_STARTmeasur.Name = "button_STARTmeasur";
            this.button_STARTmeasur.Size = new System.Drawing.Size(100, 45);
            this.button_STARTmeasur.TabIndex = 8;
            this.button_STARTmeasur.Text = "Начать измерение ";
            this.button_STARTmeasur.UseVisualStyleBackColor = true;
            this.button_STARTmeasur.Click += new System.EventHandler(this.button_STARTmeasur_Click);
            // 
            // button_STOPmeasur
            // 
            this.button_STOPmeasur.Location = new System.Drawing.Point(623, 98);
            this.button_STOPmeasur.Name = "button_STOPmeasur";
            this.button_STOPmeasur.Size = new System.Drawing.Size(100, 45);
            this.button_STOPmeasur.TabIndex = 9;
            this.button_STOPmeasur.Text = "Остановить измерение ";
            this.button_STOPmeasur.UseVisualStyleBackColor = true;
            this.button_STOPmeasur.Click += new System.EventHandler(this.button_STOPmeasur_Click);
            // 
            // cBox_A
            // 
            this.cBox_A.AutoSize = true;
            this.cBox_A.Location = new System.Drawing.Point(542, 124);
            this.cBox_A.Name = "cBox_A";
            this.cBox_A.Size = new System.Drawing.Size(75, 17);
            this.cBox_A.TabIndex = 10;
            this.cBox_A.Text = "Channel A";
            this.cBox_A.UseVisualStyleBackColor = true;
            // 
            // cBox_B
            // 
            this.cBox_B.AutoSize = true;
            this.cBox_B.Location = new System.Drawing.Point(542, 140);
            this.cBox_B.Name = "cBox_B";
            this.cBox_B.Size = new System.Drawing.Size(75, 17);
            this.cBox_B.TabIndex = 11;
            this.cBox_B.Text = "Channel B";
            this.cBox_B.UseVisualStyleBackColor = true;
            // 
            // textBox_Nmeasur
            // 
            this.textBox_Nmeasur.Location = new System.Drawing.Point(560, 43);
            this.textBox_Nmeasur.Name = "textBox_Nmeasur";
            this.textBox_Nmeasur.Size = new System.Drawing.Size(57, 20);
            this.textBox_Nmeasur.TabIndex = 12;
            this.textBox_Nmeasur.Text = "500";
            // 
            // label_Nmeasur
            // 
            this.label_Nmeasur.AutoSize = true;
            this.label_Nmeasur.Location = new System.Drawing.Point(426, 43);
            this.label_Nmeasur.Name = "label_Nmeasur";
            this.label_Nmeasur.Size = new System.Drawing.Size(128, 13);
            this.label_Nmeasur.TabIndex = 13;
            this.label_Nmeasur.Text = "Количество измерений ";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(383, 72);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(171, 13);
            this.label_Time.TabIndex = 14;
            this.label_Time.Text = "Период измерения прибора (ms)";
            // 
            // textBox_Time
            // 
            this.textBox_Time.Location = new System.Drawing.Point(560, 98);
            this.textBox_Time.Name = "textBox_Time";
            this.textBox_Time.Size = new System.Drawing.Size(57, 20);
            this.textBox_Time.TabIndex = 15;
            this.textBox_Time.Text = "1000";
            // 
            // dataGridViewTable
            // 
            this.dataGridViewTable.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumNum,
            this.ColumTime,
            this.ColumVa,
            this.Chanal2});
            this.dataGridViewTable.Location = new System.Drawing.Point(1, 191);
            this.dataGridViewTable.Name = "dataGridViewTable";
            this.dataGridViewTable.Size = new System.Drawing.Size(428, 179);
            this.dataGridViewTable.TabIndex = 16;
            // 
            // ColumNum
            // 
            this.ColumNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumNum.HeaderText = "№";
            this.ColumNum.Name = "ColumNum";
            this.ColumNum.Width = 43;
            // 
            // ColumTime
            // 
            this.ColumTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumTime.FillWeight = 400F;
            this.ColumTime.HeaderText = "Час";
            this.ColumTime.Name = "ColumTime";
            this.ColumTime.Width = 52;
            // 
            // ColumVa
            // 
            this.ColumVa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ColumVa.HeaderText = "Channel 1";
            this.ColumVa.Name = "ColumVa";
            this.ColumVa.Width = 80;
            // 
            // Chanal2
            // 
            this.Chanal2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Chanal2.HeaderText = "Channel 2";
            this.Chanal2.Name = "Chanal2";
            this.Chanal2.Width = 80;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // textBox_TimeM
            // 
            this.textBox_TimeM.Location = new System.Drawing.Point(560, 69);
            this.textBox_TimeM.Name = "textBox_TimeM";
            this.textBox_TimeM.Size = new System.Drawing.Size(57, 20);
            this.textBox_TimeM.TabIndex = 17;
            this.textBox_TimeM.Text = "2000";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Время на 1 измерения";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(56, 24);
            this.menuStrip.TabIndex = 19;
            this.menuStrip.Text = "menuStrip1";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem1});
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.открытьToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem1
            // 
            this.открытьToolStripMenuItem1.Name = "открытьToolStripMenuItem1";
            this.открытьToolStripMenuItem1.Size = new System.Drawing.Size(132, 22);
            this.открытьToolStripMenuItem1.Text = "Открыть ";
            this.открытьToolStripMenuItem1.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // cBoxAB
            // 
            this.cBoxAB.AutoSize = true;
            this.cBoxAB.Location = new System.Drawing.Point(542, 156);
            this.cBoxAB.Name = "cBoxAB";
            this.cBoxAB.Size = new System.Drawing.Size(88, 17);
            this.cBoxAB.TabIndex = 20;
            this.cBoxAB.Text = "Channel A+B";
            this.cBoxAB.UseVisualStyleBackColor = true;
            // 
            // zedGrapH
            // 
            this.zedGrapH.Location = new System.Drawing.Point(1, 376);
            this.zedGrapH.Name = "zedGrapH";
            this.zedGrapH.ScrollGrace = 0D;
            this.zedGrapH.ScrollMaxX = 0D;
            this.zedGrapH.ScrollMaxY = 0D;
            this.zedGrapH.ScrollMaxY2 = 0D;
            this.zedGrapH.ScrollMinX = 0D;
            this.zedGrapH.ScrollMinY = 0D;
            this.zedGrapH.ScrollMinY2 = 0D;
            this.zedGrapH.Size = new System.Drawing.Size(722, 230);
            this.zedGrapH.TabIndex = 21;
            this.zedGrapH.UseExtendedPrintDialog = true;
            // 
            // rebootAPI
            // 
            this.rebootAPI.Location = new System.Drawing.Point(649, 0);
            this.rebootAPI.Name = "rebootAPI";
            this.rebootAPI.Size = new System.Drawing.Size(46, 23);
            this.rebootAPI.TabIndex = 22;
            this.rebootAPI.Text = "reboot";
            this.rebootAPI.UseVisualStyleBackColor = true;
            this.rebootAPI.Click += new System.EventHandler(this.rebootAPI_Click);
            // 
            // ShortString
            // 
            this.ShortString.AutoSize = true;
            this.ShortString.Location = new System.Drawing.Point(165, 129);
            this.ShortString.Name = "ShortString";
            this.ShortString.Size = new System.Drawing.Size(96, 17);
            this.ShortString.TabIndex = 23;
            this.ShortString.Text = "OnliData(short)";
            this.ShortString.UseVisualStyleBackColor = true;
            // 
            // Calibr
            // 
            this.Calibr.Location = new System.Drawing.Point(165, 100);
            this.Calibr.Name = "Calibr";
            this.Calibr.Size = new System.Drawing.Size(75, 23);
            this.Calibr.TabIndex = 24;
            this.Calibr.Text = "Калибр.";
            this.Calibr.UseVisualStyleBackColor = true;
            this.Calibr.Click += new System.EventHandler(this.Calibr_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(701, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(22, 23);
            this.CloseButton.TabIndex = 25;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // but_menuV1_29
            // 
            this.but_menuV1_29.Location = new System.Drawing.Point(165, 11);
            this.but_menuV1_29.Name = "but_menuV1_29";
            this.but_menuV1_29.Size = new System.Drawing.Size(75, 23);
            this.but_menuV1_29.TabIndex = 26;
            this.but_menuV1_29.Text = "V1-29";
            this.but_menuV1_29.UseVisualStyleBackColor = true;
            this.but_menuV1_29.Click += new System.EventHandler(this.but_menuV1_29_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(246, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "N4-7";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VoltStandart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 618);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.but_menuV1_29);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.Calibr);
            this.Controls.Add(this.ShortString);
            this.Controls.Add(this.rebootAPI);
            this.Controls.Add(this.zedGrapH);
            this.Controls.Add(this.cBoxAB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_TimeM);
            this.Controls.Add(this.dataGridViewTable);
            this.Controls.Add(this.textBox_Time);
            this.Controls.Add(this.label_Time);
            this.Controls.Add(this.label_Nmeasur);
            this.Controls.Add(this.textBox_Nmeasur);
            this.Controls.Add(this.cBox_B);
            this.Controls.Add(this.cBox_A);
            this.Controls.Add(this.button_STOPmeasur);
            this.Controls.Add(this.button_STARTmeasur);
            this.Controls.Add(this.comboBox_comand);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.read);
            this.Controls.Add(this.write);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "VoltStandart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTable)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Init;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button read;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_initT;
        private System.Windows.Forms.TextBox textBox_initNum;
        private System.Windows.Forms.Label label_t;
        private System.Windows.Forms.Label label_adr;
        private System.Windows.Forms.ComboBox comboBox_comand;
        private System.Windows.Forms.Button button_STARTmeasur;
        private System.Windows.Forms.Button button_STOPmeasur;
        private System.Windows.Forms.CheckBox cBox_A;
        private System.Windows.Forms.CheckBox cBox_B;
        private System.Windows.Forms.TextBox textBox_Nmeasur;
        private System.Windows.Forms.Label label_Nmeasur;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.TextBox textBox_Time;
        private System.Windows.Forms.DataGridView dataGridViewTable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_TimeM;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem1;
        private System.Windows.Forms.ComboBox Box_Device;
        private System.Windows.Forms.CheckBox cBoxAB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumVa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Chanal2;
        private ZedGraph.ZedGraphControl zedGrapH;
        private System.Windows.Forms.Button rebootAPI;
        private System.Windows.Forms.CheckBox ShortString;
        private System.Windows.Forms.Button Calibr;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button but_menuV1_29;
        private System.Windows.Forms.Button button1;
    }
}

