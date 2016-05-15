namespace MO_4._1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.TextBox();
            this.iter1 = new System.Windows.Forms.TextBox();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.xmin_y1 = new System.Windows.Forms.TextBox();
            this.xmin_x1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.iter2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.TextBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.xmin_y2 = new System.Windows.Forms.TextBox();
            this.xmin_x2 = new System.Windows.Forms.TextBox();
            this.x0_x = new System.Windows.Forms.TextBox();
            this.x0_y = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.x1_y = new System.Windows.Forms.TextBox();
            this.x1_x = new System.Windows.Forms.TextBox();
            this.eps_x = new System.Windows.Forms.TextBox();
            this.eps_y = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.alpha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.m = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(119, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(565, 366);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.f1);
            this.tabPage1.Controls.Add(this.iter1);
            this.tabPage1.Controls.Add(this.pic1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.xmin_y1);
            this.tabPage1.Controls.Add(this.xmin_x1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(557, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Простой случайный поиск:";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(439, 293);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "f(x_min)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(468, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "iter";
            // 
            // f1
            // 
            this.f1.Location = new System.Drawing.Point(442, 309);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(109, 20);
            this.f1.TabIndex = 9;
            // 
            // iter1
            // 
            this.iter1.Location = new System.Drawing.Point(471, 101);
            this.iter1.Name = "iter1";
            this.iter1.Size = new System.Drawing.Size(80, 20);
            this.iter1.TabIndex = 8;
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(6, 3);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(420, 331);
            this.pic1.TabIndex = 7;
            this.pic1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(439, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "x_min";
            // 
            // xmin_y1
            // 
            this.xmin_y1.Location = new System.Drawing.Point(442, 264);
            this.xmin_y1.Name = "xmin_y1";
            this.xmin_y1.Size = new System.Drawing.Size(109, 20);
            this.xmin_y1.TabIndex = 5;
            // 
            // xmin_x1
            // 
            this.xmin_x1.Location = new System.Drawing.Point(442, 238);
            this.xmin_x1.Name = "xmin_x1";
            this.xmin_x1.Size = new System.Drawing.Size(109, 20);
            this.xmin_x1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.iter2);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.f2);
            this.tabPage2.Controls.Add(this.pic2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.xmin_y2);
            this.tabPage2.Controls.Add(this.xmin_x2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(557, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Алгоритм наилучшей пробы с направляющим гиперквадратом:";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(468, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "iter";
            // 
            // iter2
            // 
            this.iter2.Location = new System.Drawing.Point(471, 107);
            this.iter2.Name = "iter2";
            this.iter2.Size = new System.Drawing.Size(80, 20);
            this.iter2.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 291);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "f(x_min)";
            // 
            // f2
            // 
            this.f2.Location = new System.Drawing.Point(444, 307);
            this.f2.Name = "f2";
            this.f2.Size = new System.Drawing.Size(107, 20);
            this.f2.TabIndex = 12;
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(6, 6);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(420, 328);
            this.pic2.TabIndex = 7;
            this.pic2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "x_min";
            // 
            // xmin_y2
            // 
            this.xmin_y2.Location = new System.Drawing.Point(444, 264);
            this.xmin_y2.Name = "xmin_y2";
            this.xmin_y2.Size = new System.Drawing.Size(107, 20);
            this.xmin_y2.TabIndex = 5;
            // 
            // xmin_x2
            // 
            this.xmin_x2.Location = new System.Drawing.Point(444, 236);
            this.xmin_x2.Name = "xmin_x2";
            this.xmin_x2.Size = new System.Drawing.Size(107, 20);
            this.xmin_x2.TabIndex = 4;
            // 
            // x0_x
            // 
            this.x0_x.Location = new System.Drawing.Point(12, 25);
            this.x0_x.Name = "x0_x";
            this.x0_x.Size = new System.Drawing.Size(35, 20);
            this.x0_x.TabIndex = 1;
            // 
            // x0_y
            // 
            this.x0_y.Location = new System.Drawing.Point(53, 25);
            this.x0_y.Name = "x0_y";
            this.x0_y.Size = new System.Drawing.Size(35, 20);
            this.x0_y.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "x0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x1";
            // 
            // x1_y
            // 
            this.x1_y.Location = new System.Drawing.Point(53, 74);
            this.x1_y.Name = "x1_y";
            this.x1_y.Size = new System.Drawing.Size(35, 20);
            this.x1_y.TabIndex = 6;
            // 
            // x1_x
            // 
            this.x1_x.Location = new System.Drawing.Point(12, 74);
            this.x1_x.Name = "x1_x";
            this.x1_x.Size = new System.Drawing.Size(35, 20);
            this.x1_x.TabIndex = 5;
            // 
            // eps_x
            // 
            this.eps_x.Location = new System.Drawing.Point(12, 120);
            this.eps_x.Name = "eps_x";
            this.eps_x.Size = new System.Drawing.Size(35, 20);
            this.eps_x.TabIndex = 7;
            // 
            // eps_y
            // 
            this.eps_y.Location = new System.Drawing.Point(12, 160);
            this.eps_y.Name = "eps_y";
            this.eps_y.Size = new System.Drawing.Size(35, 20);
            this.eps_y.TabIndex = 8;
            // 
            // p
            // 
            this.p.Location = new System.Drawing.Point(12, 203);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(35, 20);
            this.p.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Точность по x:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Точность по y:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Вероятность:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Alpha:";
            // 
            // alpha
            // 
            this.alpha.Location = new System.Drawing.Point(12, 251);
            this.alpha.Name = "alpha";
            this.alpha.Size = new System.Drawing.Size(35, 20);
            this.alpha.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 48);
            this.button1.TabIndex = 15;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 187);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Количество точек:";
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(13, 203);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(35, 20);
            this.m.TabIndex = 16;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(12, 337);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(101, 47);
            this.clear.TabIndex = 18;
            this.clear.Text = "Очистить все";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 396);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.m);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alpha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.p);
            this.Controls.Add(this.eps_y);
            this.Controls.Add(this.eps_x);
            this.Controls.Add(this.x1_y);
            this.Controls.Add(this.x1_x);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.x0_y);
            this.Controls.Add(this.x0_x);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox xmin_y1;
        private System.Windows.Forms.TextBox xmin_x1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xmin_y2;
        private System.Windows.Forms.TextBox xmin_x2;
        private System.Windows.Forms.TextBox x0_x;
        private System.Windows.Forms.TextBox x0_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox x1_y;
        private System.Windows.Forms.TextBox x1_x;
        private System.Windows.Forms.TextBox eps_x;
        private System.Windows.Forms.TextBox eps_y;
        private System.Windows.Forms.TextBox p;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox alpha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox f1;
        private System.Windows.Forms.TextBox iter1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox iter2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox f2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.Button clear;
    }
}

