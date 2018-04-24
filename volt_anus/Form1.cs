//!*****************************************************************************
//! __Revisions:__
//!  Date       | Author              | Comments
//!  ---------- | ------------------- | ----------------
//!  15/07/2017 | Panchenko Vladislav | forms URV-5
//
//******************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoltStandard;
using System.Globalization;
using System.IO;
using ZedGraph;
//---------------------------------------------------------------------------------
namespace volt_anus
{
    public partial class VoltStandart : Form
    {
        private C_GPIBDevice V; // HP34420A
                                //   private C_GPIBDevice K;// B1-29
        private int counter = 1;//   counter in data Table
        private string counterZeroAdd = "";
        bool counterChanal = false;
        bool ActiveCalibr = false;
        double coefCalibr = 0;
        //false =1 chanal , true =2 chanal
        //counterChanal = false;
        bool writer = false;
        public VoltStandart()
        {
            InitializeComponent();
            _dataA = new List<double>();
            _dataB = new List<double>();
            DrawGraph();
        }

        private void Init_Click(object sender, EventArgs e)
        {
            //this.textBox1.AppendText("A");

            switch (((Button)sender).Name.ToString())
            {
                case "Init":

                    V = new C_GPIBDevice(0, int.Parse(textBox_initNum.Text), 0, int.Parse(textBox_initT.Text), 1, 0);

                    if (V.flag_DeviceIsReady == true)
                    {
                        textBox1.Clear();
                        this.textBox1.AppendText(" init compleet");
                    }

                    break;
                default:
                    return;
            }
        }

        //--------------------------------------------------------------------------------------------------------

        // The CheckBox control's Text property is changed each time the 
        // control is clicked, indicating a checked or unchecked state.

        //--------------------------------------------------------------------------------------------------------
        public string Comand() // checked chanal & (speed) time measurment
        {
            string chanal = "";//active chanal + time speed
            int speed;
            // device 
            switch (Box_Device.Text)
            {
                case "HP34420A":

                    if (cBox_A.Checked)
                    {
                        chanal = chanal + "ROUT:TERM FRON1";
                    }
                    if (cBox_B.Checked)
                    {
                        chanal = chanal + "ROUT:TERM FRON2";
                    }

                    // return chanal;
                    break;
                case "URV-5":
                    if (cBox_A.Checked)
                    {
                        chanal = chanal + "PA, IA,";
                    }

                    if (cBox_B.Checked)
                    {
                        chanal = chanal + "PB, IB,";
                    }

                    speed = int.Parse(textBox_Time.Text);
                    if (speed >= 1000)
                    {
                        chanal = chanal + " F2, X1";
                    }
                    break;
                    // return chanal;


            }
            return chanal;
        }
        //--------------------------------------------------------------------------------------------------------
        private int longB()
        {
            string lengt;
            int bit;
            lengt = Comand().Length.ToString(CultureInfo.InvariantCulture);
            //  textBox1.AppendText(lengt + '\r' + '\n') ;
            bit = int.Parse(lengt);
            return bit;

        }
      
        //---------------------------------------------------------------------------------------------------------
        // button  write 
        private void write_Click(object sender, EventArgs e)
        {

            switch (Box_Device.Text)
            {
                case "HP34420A":
                    C_GPIBDevice.ibwrt(V.i_DeviceID, "SENS:VOLT:DC:NPLC MAX", 21);
                    break;
                case "URV-5":

                    break;

            }
           //v1-29
            // C_GPIBDevice.ibwrt(V.i_DeviceID, "UV1.1\r\n"  , 7 );
           // V.fn_SendBoardCmd("\x0008");
          
           

            // C_GPIBDevice.ibwrt(V.i_DeviceID, "ROUT:TERM FRON1;*WAI", 20); 
        }
        private string readData()
        {
            StringBuilder sb_ReceivedData = new StringBuilder();
            unsafe
            {
                sbyte* psb_DeviceOutputBufferArray = stackalloc sbyte[V.i_MaximumExpectedReceivedMsgLenth];
                C_GPIBDevice.ibrd(V.i_DeviceID, psb_DeviceOutputBufferArray, 62);
                System.Int32 i_NumberOfBytesWaiting = C_GPIBDevice.ThreadIbcntl();

                if (i_NumberOfBytesWaiting > 0)
                {
                    for (int i = 0; i <= i_NumberOfBytesWaiting - 1; i++)
                    {
                        if (!((((char)(psb_DeviceOutputBufferArray[i])) == '\n') || (((char)(psb_DeviceOutputBufferArray[i])) == '\r')))
                        {
                            sb_ReceivedData.Append((char)psb_DeviceOutputBufferArray[i]);
                        } // of if
                        else break;
                    } // of for
                }
                else sb_ReceivedData.Append("нет данных в буфере прибора");
            } // of unsafe
            return sb_ReceivedData.ToString();
        }
        //button read
        private void read_Click(object sender, EventArgs e)
        {
          
            textBox1.Text = readData();
        }
        // button_STARTmeasur
        private void button_STARTmeasur_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("Команда \r\n");
            textBox1.AppendText(Comand()+ " \r\n");
         // label1.Text = textBox1.Text.Length.ToString(CultureInfo.InvariantCulture);
         
            int Nmeasur;
           
            Nmeasur = int.Parse(textBox_Nmeasur.Text);
     
                timer1.Start();
                timer1.Interval = 50;
            counterZeroAdd = Convert.ToString((Nmeasur));
            counterZeroAdd = counterZeroAdd.Length.ToString(CultureInfo.InvariantCulture);
            Nmeasur = Int32.Parse(counterZeroAdd);
            
            counterZeroAdd = ""; //cleaning
            for (int i = 1; i <= Nmeasur; i++)
            {
                counterZeroAdd = counterZeroAdd + " ";
            }
            textBox1.AppendText(counterZeroAdd.ToString() + '\r' + '\n');
        }
        private void Calibr_Click(object sender, EventArgs e)
        {
            textBox1.AppendText( "Калибровка начата \r\n");
            // label1.Text = textBox1.Text.Length.ToString(CultureInfo.InvariantCulture);
            ActiveCalibr = true;
            int Nmeasur;

            Nmeasur = int.Parse(textBox_Nmeasur.Text);

            timer1.Start();
            timer1.Interval = 50;
            counterZeroAdd = Convert.ToString((Nmeasur));
            counterZeroAdd = counterZeroAdd.Length.ToString(CultureInfo.InvariantCulture);
            Nmeasur = Int32.Parse(counterZeroAdd);

            counterZeroAdd = ""; //cleaning
            for (int i = 1; i <= Nmeasur; i++)
            {
                counterZeroAdd = counterZeroAdd + " ";
            }
            textBox1.AppendText(counterZeroAdd.ToString() + '\r' + '\n');
        }
       // button_STOPmeasur
        private void button_STOPmeasur_Click(object sender, EventArgs e)
        {
            timer2.Stop();

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // comand from measur + parametrs (Comand())
            //C_GPIBDevice.ibwrt(V.i_DeviceID, "READ?", 5);
           
          
            if (cBoxAB.Checked)
            {
               
                if (counterChanal == false)
                {
                    cBox_A.Checked = true;
                      C_GPIBDevice.ibwrt(V.i_DeviceID, Comand(), longB());
                      C_GPIBDevice.ibwrt(V.i_DeviceID, "READ?", 5);
                    //   textBox1.AppendText("a1"+ '\r' + '\n');

                   // counterChanal = true;
                }
                if (counterChanal == true)
                {
                    cBox_B.Checked = true;
                      C_GPIBDevice.ibwrt(V.i_DeviceID, Comand(), longB());
                      C_GPIBDevice.ibwrt(V.i_DeviceID, "READ?", 5);
                    //    textBox1.AppendText("b1" + '\r' + '\n');
                    // counterChanal = false;
                }
            }
            if (cBox_A.Checked)
            {
                
                C_GPIBDevice.ibwrt(V.i_DeviceID, Comand(), longB());
                C_GPIBDevice.ibwrt(V.i_DeviceID, "READ?", 5);
            }
            if (cBox_B.Checked)
            {
                
                C_GPIBDevice.ibwrt(V.i_DeviceID, Comand(), longB());
                C_GPIBDevice.ibwrt(V.i_DeviceID, "READ?", 5);
            }
                int measur_Time;
            measur_Time = int.Parse(textBox_TimeM.Text);
            timer2.Start();
            timer2.Interval = measur_Time;
            timer1.Stop();
        }
       
            string  dataA = "0";
            string  dataB = "0";

        private void timer2_Tick(object sender, EventArgs e)
        {
            int Nmeasur;
            
            Nmeasur = int.Parse(textBox_Nmeasur.Text);
            //char[] sym = readData().ToCharArray();
            
            if (cBox_A.Checked)
            {
                  //  dataA = "+3.07332080E+00";
                  dataA =  readData();
                    cBox_A.Checked = false;
                counterChanal = true;
            }

            if (cBox_B.Checked)
            {
                  //  dataB = "+3.27332080E+00";
                  dataB =  readData();
                    cBox_B.Checked = false;
                counterChanal = false;
                writer = true;
            }
            // костыляка шо я ебу!
           
            timer1.Start();
            
            if(writer==true)
            {
          
                string sum;
            

                sum = Convert.ToString((counter));
                if (ShortString.Checked)
                {
                    dataA = dataA.Substring(9);
                    dataB = dataB.Substring(9);
                    double newValueA = Double.Parse(dataA);
                    double newValueB = Double.Parse(dataB);
                    if (!ActiveCalibr && coefCalibr != 0)
                    {
                        
                            newValueB = newValueB * coefCalibr;

                    }
                    //newValueB = Math.Round(newValueB, 5);
                    string temp = newValueB.ToString("0.000E+00");
                    // rewrite it ~!!!!
                    dataGridViewTable.Rows.Add(counterZeroAdd + sum, DateTime.Now, dataA, temp);// write |number|date| measur value| 
                    dataGridViewTable.FirstDisplayedScrollingRowIndex = counter;//skroll 
                    counter++;

                }
                else
                {
                    dataGridViewTable.Rows.Add(counterZeroAdd + sum, DateTime.Now, dataA, dataB);// write |number|date| measur value| 
                    dataGridViewTable.FirstDisplayedScrollingRowIndex = counter;//skroll 
                    counter++;
                }
                if (ActiveCalibr)
                {
                    dataA = dataA.Substring(9);
                    dataB = dataB.Substring(9);
                    double ValueA = Double.Parse(dataA);
                    double ValueB = Double.Parse(dataB);
                    coefCalibr = ValueA / ValueB;
                    textBox1.AppendText(coefCalibr + "коефіцієнт калібровки \r\n");
                    timer2.Stop();
                    ActiveCalibr = false;
                    counter = Nmeasur;

                }

                // Вычислим новое значение
                //   double newValueOnChanaleA = _rnd.NextDouble() * (_ymax - _ymin) + _ymin;
                 dataA = dataA.Substring(9);
                //add cheking value it or not ;
                 double newValueOnChanaleA = Double.Parse(dataA);
                //double newValueOnChanaleA = 2.5;
                //Добавим его в конец списка
                _dataA.Add(newValueOnChanaleA);

                // Удалим первый элемент в списке данных, 
                // если заполнили максимальную емкость
                if (_dataA.Count > _capacity)
                {
                    _dataA.RemoveAt(0);
                }
                //------------------------------------------------------------------------
                    dataB = dataB.Substring(9);
                 double newValueOnChanaleB = Double.Parse(dataB);
               // double newValueOnChanaleB = 2.2;
                // Добавим его в конец списка
                _dataB.Add(newValueOnChanaleB);
                // Удалим первый элемент в списке данных, 
                // если заполнили максимальную емкость
                if (_dataB.Count > _capacity)
                {
                    _dataB.RemoveAt(0);
                }
                DrawGraph();
                writer = false;
            }

            if (counter >= Nmeasur)
            {
                timer2.Stop();
                timer1.Stop();
                counter = 1;
            }

            
        }
        /// <summary>
        /// Максимальный размер очереди
        /// </summary>
        int _capacity = 1500;
        /// <summary>
        /// Здесь храним данные
        /// </summary>
        List<double> _dataA;
        List<double> _dataB;

        /// <summary>
        /// Для генерации слуайных данные по таймеру
        /// </summary>
        //Random _rnd = new Random();
        
        // Интервал изменения данных по вертикали
        double _ymin = -1.0;
        double _ymax = 10.0;
      
        private void DrawGraph()
        {
            // int _capacity = 15000;
            int _capacity = int.Parse(textBox_Nmeasur.Text);
            // Получим панель для рисования
            GraphPane pane = zedGrapH.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();

            // Создадим список точек
            PointPairList list1 = new PointPairList();
           
            PointPairList list2 = new PointPairList();

            // Интервал, где есть данные
            double xmin = 0;
            double xmax = _capacity;

            // Расстояние между соседними точками по горизонтали
            double dx = 1.0;

            double curr_x1 = 0;
            double curr_x2 = 0;

            // Заполняем список точек
            //for (double x = 0; x <= xmax; x += 0.5)
            //{
            //    list1.Add(x,  );
            //}
            foreach (double ChannalA in _dataA)
            {
                list1.Add(curr_x1, ChannalA);

                curr_x1 += dx;
            }
            foreach (double ChannalB in _dataB)
            {
                list2.Add(curr_x2, ChannalB);

                curr_x2 += dx;
            }
                // Очистим список кривых от прошлых рисунков (кадров)
            //    pane.CurveList.Clear();
            //Generate a red curve with diamond
            // symbols, and "ChannalA" in the legend
            LineItem CurveA = pane.AddCurve("ChannalA",
                list1, Color.Red, SymbolType.Diamond);

            //Generate a blue curve with circle
            // symbols, and "ChannalB" in the legendw
             LineItem CurveB = pane.AddCurve("ChannalB",
                list2, Color.Blue, SymbolType.Circle);
            //LineItem CurveA = pane.AddCurve("Random Value", list1, Color.Blue, SymbolType.None);
            // LineItem CurveB = pane.AddCurve("Random Value", list2, Color.Red, SymbolType.None);

            // Устанавливаем интересующий нас интервал по оси X
            pane.XAxis.Scale.Min = xmin;
            pane.XAxis.Scale.Max = xmax;

            // Устанавливаем интересующий нас интервал по оси Y
            pane.YAxis.Scale.Min = _ymin;
            pane.YAxis.Scale.Max = _ymax;

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            // В противном случае на рисунке будет показана только часть графика, 
            // которая умещается в интервалы по осям, установленные по умолчанию
            zedGrapH.AxisChange();

            // Обновляем график
            zedGrapH.Invalidate();
        }
        // SetSize() is separate from Resize() so we can 
        // call it independently from the Form1_Load() method
        // This leaves a 10 px margin around the outside of the control
        // Customize this to fit your needs
        // user menu -------------------------------------------------------------------------------
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    StreamWriter myWritet = new StreamWriter(myStream);
                    try
                    {
                        for (int i = 0; i < dataGridViewTable.RowCount - 1; i++)
                        {
                            for (int j = 0; j < dataGridViewTable.ColumnCount; j++)
                            {
                                string data = dataGridViewTable.Rows[i].Cells[j].Value.ToString().Replace("\t", "[etot_simvol]");
                                myWritet.Write(data + "\t");
                            }
                            myWritet.WriteLine();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myWritet.Close();
                    }
                    myStream.Close();
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream mystr = null;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((mystr = openFileDialog.OpenFile()) != null)
                {
                    StreamReader myread = new StreamReader(mystr);
                    string[] str;
                    int num = 0;
                    try
                    {
                        string[] str1 = myread.ReadToEnd().Split('\n');
                        num = str1.Count();
                        dataGridViewTable.RowCount = num;
                        for (int i = 0; i < num; i++)
                        {
                            str = str1[i].Split('\t');
                            for (int j = 0; j < dataGridViewTable.ColumnCount; j++)
                            {
                                try
                                {
                                    string data = str[j].Replace("[etot_simvol]", "\t");
                                    dataGridViewTable.Rows[i].Cells[j].Value = data;
                                }
                                catch { }
                             }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        myread.Close();
                    }
                }
            }
        }
        // end user menu -----------------------------------------------------------------------------
        private void rebootAPI_Click(object sender, EventArgs e)
        {
            //  Hide();
            Application.Restart();
           // VoltStandart lb1 = new VoltStandart();
           //lb1.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void but_menuV1_29_Click(object sender, EventArgs e)
        {
            V1_29 menuV1_29 = new V1_29();
                menuV1_29.Show();
        }
    }

}
