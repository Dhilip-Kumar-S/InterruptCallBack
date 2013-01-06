using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using msexcel = Microsoft.Office.Interop.Excel;




namespace TaskPriority
{
    
    public partial class TaskPriority : Form
    {
        public struct ConfigStruct
        {
            public string ConfigFile;
            public bool PopUp;
            public int RFrequency;
            public int Urgent_Hrs, Urgent_Mins;
            public string task1, task2, task3, task4;
        };

        public ConfigStruct config_data;
        public msexcel.Application xlApp;
        public msexcel.Workbook xlWorkBook;
        public msexcel.Worksheet xlWorkSheet;
        public object missing;
        private bool re_load_flag;
        private bool time_wasting;

        public TaskPriority()
        {
            InitializeComponent();
            missing = System.Reflection.Missing.Value;
            config_data.ConfigFile = Environment.GetEnvironmentVariable("USERPROFILE")+"\\IntCallBack.xls";
            xlApp = new msexcel.Application();
            time_wasting = false;

            if (File.Exists(config_data.ConfigFile))
            {
                xlWorkBook = xlApp.Workbooks.Open(config_data.ConfigFile, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing, missing);
                xlWorkSheet = (msexcel.Worksheet) xlWorkBook.Worksheets.get_Item(1);

                double dummy = (double) (xlWorkSheet.Cells[1, 2] as msexcel.Range ).Value ;
                config_data.PopUp = ((int)dummy == 1) ? true : false;
                config_data.RFrequency = (int)(xlWorkSheet.Cells[2, 2] as msexcel.Range).Value;
                config_data.Urgent_Hrs = (int)(xlWorkSheet.Cells[3, 2] as msexcel.Range).Value;
                config_data.Urgent_Mins = (int)(xlWorkSheet.Cells[4, 2] as msexcel.Range).Value;
                config_data.task1 = (string) (xlWorkSheet.Cells[5, 2] as msexcel.Range).Value;
                config_data.task2 = (string)(xlWorkSheet.Cells[6, 2] as msexcel.Range).Value;
                config_data.task3 = (string)(xlWorkSheet.Cells[7, 2] as msexcel.Range).Value;
                config_data.task4 = (string)(xlWorkSheet.Cells[8, 2] as msexcel.Range).Value;
                re_load_flag = true;

            }
            else
            {
                
                xlWorkBook = xlApp.Workbooks.Add(missing);
                xlWorkSheet = xlWorkBook.Worksheets.get_Item(1);
                

                config_data.PopUp = true;
                config_data.RFrequency = 3;
                config_data.Urgent_Hrs = 8;
                config_data.Urgent_Mins = 0;
                config_data.task1 = config_data.task2 = config_data.task3 = config_data.task4 = "";

                xlWorkSheet.Cells[1, 1] = "PopUP";
                xlWorkSheet.Cells[2, 1] = "Frequency";
                xlWorkSheet.Cells[3, 1] = "Urgent Hrs";
                xlWorkSheet.Cells[4, 1] = "Urgent Mins";
                xlWorkSheet.Cells[5,1] = "Task 1";
                xlWorkSheet.Cells[6,1] = "Task 2";
                xlWorkSheet.Cells[7,1] = "Task 3";
                xlWorkSheet.Cells[8,1] = "Task 4";

                xlWorkSheet.Cells[1, 2] = (config_data.PopUp == true) ? "1" : "2";
                xlWorkSheet.Cells[2, 2] = config_data.RFrequency.ToString();
                xlWorkSheet.Cells[3, 2] = config_data.Urgent_Hrs.ToString();
                xlWorkSheet.Cells[4, 2] = config_data.Urgent_Mins.ToString();
                xlWorkSheet.Cells[5, 2] = config_data.task1;
                xlWorkSheet.Cells[6, 2] = config_data.task1;
                xlWorkSheet.Cells[7, 2] = config_data.task1;
                xlWorkSheet.Cells[8, 2] = config_data.task1;

                xlWorkBook.SaveAs(config_data.ConfigFile, msexcel.XlFileFormat.xlWorkbookNormal, missing, missing, missing, missing, msexcel.XlSaveAsAccessMode.xlShared, missing, missing, missing, missing, missing);
                //xlWorkBook.Close();
                re_load_flag = false;
            }
            

            
        }

        private void TaskPriority_Load(object sender, EventArgs e)
        {
            if (re_load_flag)
            {
               
                string temp_string;
                textBox1.Visible = textBox2.Visible = textBox3.Visible = textBox4.Visible = false;
                button1.Text = config_data.task1;
                button2.Text = config_data.task2;
                button3.Text = config_data.task3;
                button4.Text = config_data.task4;
                TimeLeft.Maximum = (config_data.Urgent_Hrs * 60) + config_data.Urgent_Mins;
                TimeLeft.Minimum = 0;
                TimeLeft.Value = TimeLeft.Maximum;
                temp_string = config_data.RFrequency.ToString();
                Frequency.SelectedIndex = Frequency.Items.IndexOf(temp_string);
                temp_string = config_data.Urgent_Hrs.ToString();
                Urgent_Hrs.SelectedIndex = Urgent_Hrs.Items.IndexOf(temp_string);
                temp_string = config_data.Urgent_Mins.ToString();
                Urgent_Mins.SelectedIndex = Urgent_Mins.Items.IndexOf(temp_string);

            }
            else
            {
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                this.MinimizeBox = true;
                TimeLeft.Maximum = (config_data.Urgent_Hrs * 60) + config_data.Urgent_Mins;
                TimeLeft.Minimum = 0;
                TimeLeft.Value = TimeLeft.Minimum;
            }

            //TipTimeLeft.SetToolTip(TimeLeft, TimeLeft.Value.ToString() + " Mins");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            BringFocusTimer.Stop();
            BringFocusTimer.Enabled = false;
            time_wasting = false;
        }

        [DllImport("user32.dll")]
        public static extern bool FlashWindow(IntPtr hwnd, bool bInvert);

        public void blink_task_bar()
        {
            if (config_data.PopUp)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                IntPtr f_handle = this.Handle;
                FlashWindow(f_handle, false);
            }
            button1.Size = new Size(281, 247);
            button1.BringToFront();
            update_conf_file();
            if (time_wasting == false)
            {
                if ((TimeLeft.Value - config_data.RFrequency) <= 0)
                {
                    time_wasting = true;
                    TimeLeft.Value = 0;
                    TimeLeft.ForeColor = Color.Red;
                    TipTimeLeft.ToolTipTitle = "Wasted";
                }
                else
                {
                    TimeLeft.Value = TimeLeft.Value - config_data.RFrequency;
                }
            }
            else
            {
                TimeLeft.Maximum = TimeLeft.Value + config_data.RFrequency + 10;
                TimeLeft.Value = TimeLeft.Value + config_data.RFrequency;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
            {
                button1.Text = config_data.task1 = textBox1.Text;
                textBox1.Visible = false;
                button1.Visible = true;
                BringFocusTimer.Interval = (config_data.RFrequency * 60 * 1000);
                BringFocusTimer.Enabled = true;
                BringFocusTimer.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            blink_task_bar();
        }

      

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button2.Text = config_data.task2 = textBox2.Text;
                textBox2.Visible = false;
                button2.Visible = true;
             
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3.Text = config_data.task3 = textBox3.Text;
                textBox3.Visible = false;
                button3.Visible = true;

            }

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.Text = config_data.task4 = textBox4.Text;
                textBox4.Visible = false;
                button4.Visible = true;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Visible = true;
        }

        private void update_conf_file()
        {
            xlWorkSheet.Cells[1, 2] = (config_data.PopUp == true) ? "1" : "2";
            xlWorkSheet.Cells[2, 2] = config_data.RFrequency.ToString();
            xlWorkSheet.Cells[3, 2] = config_data.Urgent_Hrs.ToString();
            xlWorkSheet.Cells[4, 2] = config_data.Urgent_Mins.ToString();
            xlWorkSheet.Cells[5, 2] = config_data.task1;
            xlWorkSheet.Cells[6, 2] = config_data.task2;
            xlWorkSheet.Cells[7, 2] = config_data.task3;
            xlWorkSheet.Cells[8, 2] = config_data.task4;
            xlWorkBook.Save();
        }

        private void PopUP_CheckedChanged(object sender, EventArgs e)
        {
            config_data.PopUp = true;
        }

        private void Blink_CheckedChanged(object sender, EventArgs e)
        {
            config_data.PopUp = false;
        }

       
        private void Frequency_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            config_data.RFrequency = int.Parse(Frequency.SelectedItem.ToString());
            BringFocusTimer.Stop();
            BringFocusTimer.Enabled = false;
            BringFocusTimer.Interval = (config_data.RFrequency * 60 * 1000);
            BringFocusTimer.Enabled = true;
            BringFocusTimer.Start();
       
        }

        private void Urgent_Hrs_SelectedIndexChanged(object sender, EventArgs e)
        {
            config_data.Urgent_Hrs  = int.Parse(Urgent_Hrs.SelectedItem.ToString ());
            TimeLeft.Maximum = (config_data.Urgent_Hrs * 60) + config_data.Urgent_Mins;
            TimeLeft.Minimum = 0;
            TimeLeft.Value = TimeLeft.Maximum;
            time_wasting = false;
            
        }

        private void Urgent_Mins_SelectedIndexChanged(object sender, EventArgs e)
        {
            config_data.Urgent_Mins = int.Parse(Urgent_Mins.SelectedItem.ToString());
            TimeLeft.Maximum = (config_data.Urgent_Hrs * 60) + config_data.Urgent_Mins;
            TimeLeft.Minimum = 0;
            TimeLeft.Value = TimeLeft.Maximum;
            time_wasting = false;
        }

        private void TaskPriority_FormClosing(object sender, FormClosingEventArgs e)
        {
            xlWorkBook.Close();
            xlApp.Quit();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Size = new Size(118, 113);
            button1.SendToBack();
        }

        private void TimeLeft_MouseHover(object sender, EventArgs e)
        {
            if (time_wasting == false)
            {
                TipTimeLeft.SetToolTip(TimeLeft, TimeLeft.Value.ToString() + " Mins");
            }
            else
            {
                TipTimeLeft.SetToolTip(TimeLeft, "-" + TimeLeft.Value.ToString() + " Mins");
            }
        }
                       
    }
}
