using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Random;

namespace _20182203010_李美霞
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int num;
        public int index=0;
        public string word;
        public string meaning;
        public int correct = 0;

        private void vocabularies(string voca_path)
        {
            StreamReader sr = new StreamReader(voca_path, Encoding.Default);
            string str;
            while((str = sr.ReadLine()) != null)
            {
                
            }
            sr.Close();
        }
        private void next_vocabulary(object sender, EventArgs e)
        {
            vocabulary.Text = "";
            indexs.Text = (index+1).ToString();
            
            Random rd = new Random();
            int every = rd.Next(0, i);

            string[] temp = new string[3];
            temp = strl[every].Split(new Char[] { '\t', '\t', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            word = temp[0];
            meaning = temp[1];

            Chinese.Text = meaning;

            index++;

            next.Text = "我不会啊";
            
        }
        private void start_Click(object sender, EventArgs e)
        {
            next.Enabled = true;
            timer1.Start();
            Chinese.Text = "";
            num = (int)vocabulary_num.Value;

            this.next_vocabulary(sender, e);
            
        }
        string[] strl = new string[1409];
        public int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            next.Enabled = false;
            StreamReader sr = new StreamReader("College_Grade4.txt", Encoding.Default);
            string str;
            while ((str = sr.ReadLine()) != null)
            {      
                strl[i] = str;
                i++;
            }

            Chinese.Text = "目前本系统共有" + i.ToString() + "个单词";

            //Chinese.Text = strl[0];
            string[] temp = new string[3];
            temp = strl[0].Split(new Char[] { '\t', '\t', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        }

        private void next_Click(object sender, EventArgs e)
        {
            if(next.Text == "我不会啊")
            {
                vocabulary.Text = word;
                vocabulary.Enabled = false;
                if (index == num)
                {
                    timer1.Stop();
                    MessageBox.Show("本次背单词任务完成！你一共写出"+correct+"个单词哦~");
                    next.Enabled = false;
                }
                next.Text = "下一个";
            }
            else
            {
                vocabulary.Enabled = true;
                this.next_vocabulary(sender, e);
            }
        }


        
        private void vocabulary_TextChanged(object sender, EventArgs e)
        {
        }

        private void vocabulary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if(vocabulary.Text == word)
                {
                    correct++;
                    this.next_vocabulary(sender, e);
                }
                else
                {
                    MessageBox.Show("输得不对哦~");
                }
            }
        }

        int second = 0;
        int minute = 0;
        int hour = 0;

        string string_s;
        string string_m;
        string string_h;
        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;
            }
            if(minute == 60)
            {
                minute = 0;
                hour++;
            }

            if (second < 10)
            {
                string_s = "0" + second.ToString();
            }
            else
            {
                string_s = second.ToString();
            }
            if (minute < 10)
            {
                string_m = "0" + minute.ToString();
            }
            else
            {
                string_m = minute.ToString();
            }
            if (hour < 10)
            {
                string_h = "0" + hour.ToString();
            }
            else
            {
                string_h = hour.ToString();
            }
            Hour.Text = string_h;
            Minute.Text = string_m;
            Second.Text = string_s;
        }
    }
}