namespace _20182203010_李美霞
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Second = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Minute = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hour = new System.Windows.Forms.Label();
            this.Chinese = new System.Windows.Forms.Label();
            this.indexs = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.vocabulary = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vocabulary_num = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vocabulary_num)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Second);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Minute);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Hour);
            this.panel1.Controls.Add(this.Chinese);
            this.panel1.Controls.Add(this.indexs);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.start);
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.vocabulary);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.vocabulary_num);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 276);
            this.panel1.TabIndex = 0;
            // 
            // Second
            // 
            this.Second.AutoSize = true;
            this.Second.Location = new System.Drawing.Point(98, 14);
            this.Second.Name = "Second";
            this.Second.Size = new System.Drawing.Size(17, 12);
            this.Second.TabIndex = 15;
            this.Second.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = ":";
            // 
            // Minute
            // 
            this.Minute.AutoSize = true;
            this.Minute.Location = new System.Drawing.Point(58, 14);
            this.Minute.Name = "Minute";
            this.Minute.Size = new System.Drawing.Size(17, 12);
            this.Minute.TabIndex = 13;
            this.Minute.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = ":";
            // 
            // Hour
            // 
            this.Hour.AutoSize = true;
            this.Hour.Location = new System.Drawing.Point(18, 14);
            this.Hour.Name = "Hour";
            this.Hour.Size = new System.Drawing.Size(17, 12);
            this.Hour.TabIndex = 11;
            this.Hour.Text = "00";
            // 
            // Chinese
            // 
            this.Chinese.AutoSize = true;
            this.Chinese.Location = new System.Drawing.Point(46, 176);
            this.Chinese.Name = "Chinese";
            this.Chinese.Size = new System.Drawing.Size(0, 12);
            this.Chinese.TabIndex = 10;
            // 
            // indexs
            // 
            this.indexs.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.indexs.Location = new System.Drawing.Point(20, 128);
            this.indexs.Name = "indexs";
            this.indexs.Size = new System.Drawing.Size(23, 21);
            this.indexs.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(46, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "个";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "第";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(358, 79);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 6;
            this.start.Text = "Start!";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(358, 227);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(71, 23);
            this.next.TabIndex = 5;
            this.next.Text = "我不会啊";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // vocabulary
            // 
            this.vocabulary.Location = new System.Drawing.Point(283, 122);
            this.vocabulary.Name = "vocabulary";
            this.vocabulary.Size = new System.Drawing.Size(134, 21);
            this.vocabulary.TabIndex = 3;
            this.vocabulary.TextChanged += new System.EventHandler(this.vocabulary_TextChanged);
            this.vocabulary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vocabulary_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(60, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入以下中文对应的英文单词：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(39, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "请输入您想要背的单词数：";
            // 
            // vocabulary_num
            // 
            this.vocabulary_num.Location = new System.Drawing.Point(245, 50);
            this.vocabulary_num.Name = "vocabulary_num";
            this.vocabulary_num.Size = new System.Drawing.Size(81, 21);
            this.vocabulary_num.TabIndex = 0;
            this.vocabulary_num.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 300);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vocabulary_num)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox indexs;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox vocabulary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown vocabulary_num;
        private System.Windows.Forms.Label Chinese;
        private System.Windows.Forms.Label Second;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Minute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Hour;
        private System.Windows.Forms.Timer timer1;
    }
}

