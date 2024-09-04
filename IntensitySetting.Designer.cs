
namespace cmo
{
    partial class IntensitySetting
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxXmin = new System.Windows.Forms.TextBox();
            this.textBoxXmax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_K1 = new System.Windows.Forms.TextBox();
            this.textBox_K2 = new System.Windows.Forms.TextBox();
            this.textBox_K3 = new System.Windows.Forms.TextBox();
            this.textBox_M3 = new System.Windows.Forms.TextBox();
            this.textBox_M2 = new System.Windows.Forms.TextBox();
            this.textBox_M1 = new System.Windows.Forms.TextBox();
            this.textBox_O3 = new System.Windows.Forms.TextBox();
            this.textBox_O2 = new System.Windows.Forms.TextBox();
            this.textBox_O1 = new System.Windows.Forms.TextBox();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IntensitySettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(431, 111);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 3;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(952, 684);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            title1.Name = "Title1";
            title1.Text = "График функции интенсивности";
            this.chart1.Titles.Add(title1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(168, 743);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Вывести график";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxXmin
            // 
            this.textBoxXmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXmin.Location = new System.Drawing.Point(59, 740);
            this.textBoxXmin.Name = "textBoxXmin";
            this.textBoxXmin.Size = new System.Drawing.Size(42, 27);
            this.textBoxXmin.TabIndex = 2;
            this.textBoxXmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxXmin_KeyPress);
            // 
            // textBoxXmax
            // 
            this.textBoxXmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxXmax.Location = new System.Drawing.Point(59, 768);
            this.textBoxXmax.Name = "textBoxXmax";
            this.textBoxXmax.Size = new System.Drawing.Size(42, 27);
            this.textBoxXmax.TabIndex = 3;
            this.textBoxXmax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxXmax_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1191, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Функция интенсивности: λ(t) = α * (k1 * f(t, μ1, σ1) / F(a, b, μ1, σ1) + k2 * f(t" +
    ", μ2, σ2) / F(a, b, μ2, σ2) + k3 * f(t, μ3, σ3) / F(a, b, μ3, σ3)),";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "где f(t, μi, σi) / F(a, b, μi, σi) – интенсив-\nность i-го потока.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 50);
            this.label3.TabIndex = 6;
            this.label3.Text = "f(t, μi, σi) – функция плотности\nнормального распределения.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(382, 50);
            this.label4.TabIndex = 7;
            this.label4.Text = "F(a, b, μi, σi) - вероятность поступления\nзапроса в интервале времени [a; b].";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 50);
            this.label5.TabIndex = 8;
            this.label5.Text = "ki – доля запросов i-го потока в общем\nпотоке запросов,";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 50);
            this.label6.TabIndex = 9;
            this.label6.Text = "μi – время максимальной интенсив-\nности i-го потока запросов,";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(328, 75);
            this.label7.TabIndex = 10;
            this.label7.Text = "σi – показатель разброса времени\nпоступления запросов в систему\ni-го потока,";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 497);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(360, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "α - коэффициент масштабирования.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(12, 551);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Введите ki:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(12, 590);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Введите μi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(11, 634);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 25);
            this.label11.TabIndex = 14;
            this.label11.Text = "Введите σi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(11, 675);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 25);
            this.label12.TabIndex = 15;
            this.label12.Text = "Введите α:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(11, 715);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(310, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Введите время моделирования";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(12, 740);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 25);
            this.label14.TabIndex = 17;
            this.label14.Text = "от:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(12, 765);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 25);
            this.label15.TabIndex = 18;
            this.label15.Text = "до:";
            // 
            // textBox_K1
            // 
            this.textBox_K1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_K1.Location = new System.Drawing.Point(135, 551);
            this.textBox_K1.Name = "textBox_K1";
            this.textBox_K1.Size = new System.Drawing.Size(48, 27);
            this.textBox_K1.TabIndex = 19;
            this.textBox_K1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_K1_KeyPress);
            // 
            // textBox_K2
            // 
            this.textBox_K2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_K2.Location = new System.Drawing.Point(204, 551);
            this.textBox_K2.Name = "textBox_K2";
            this.textBox_K2.Size = new System.Drawing.Size(48, 27);
            this.textBox_K2.TabIndex = 20;
            this.textBox_K2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_K2_KeyPress);
            // 
            // textBox_K3
            // 
            this.textBox_K3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_K3.Location = new System.Drawing.Point(274, 551);
            this.textBox_K3.Name = "textBox_K3";
            this.textBox_K3.Size = new System.Drawing.Size(48, 27);
            this.textBox_K3.TabIndex = 21;
            this.textBox_K3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_K3_KeyPress);
            // 
            // textBox_M3
            // 
            this.textBox_M3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_M3.Location = new System.Drawing.Point(274, 591);
            this.textBox_M3.Name = "textBox_M3";
            this.textBox_M3.Size = new System.Drawing.Size(48, 27);
            this.textBox_M3.TabIndex = 24;
            this.textBox_M3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_M3_KeyPress);
            // 
            // textBox_M2
            // 
            this.textBox_M2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_M2.Location = new System.Drawing.Point(204, 591);
            this.textBox_M2.Name = "textBox_M2";
            this.textBox_M2.Size = new System.Drawing.Size(48, 27);
            this.textBox_M2.TabIndex = 23;
            this.textBox_M2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_M2_KeyPress);
            // 
            // textBox_M1
            // 
            this.textBox_M1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_M1.Location = new System.Drawing.Point(135, 591);
            this.textBox_M1.Name = "textBox_M1";
            this.textBox_M1.Size = new System.Drawing.Size(48, 27);
            this.textBox_M1.TabIndex = 22;
            this.textBox_M1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_M1_KeyPress);
            // 
            // textBox_O3
            // 
            this.textBox_O3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_O3.Location = new System.Drawing.Point(274, 634);
            this.textBox_O3.Name = "textBox_O3";
            this.textBox_O3.Size = new System.Drawing.Size(48, 27);
            this.textBox_O3.TabIndex = 27;
            this.textBox_O3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_O3_KeyPress);
            // 
            // textBox_O2
            // 
            this.textBox_O2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_O2.Location = new System.Drawing.Point(204, 634);
            this.textBox_O2.Name = "textBox_O2";
            this.textBox_O2.Size = new System.Drawing.Size(48, 27);
            this.textBox_O2.TabIndex = 26;
            this.textBox_O2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_O2_KeyPress);
            // 
            // textBox_O1
            // 
            this.textBox_O1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_O1.Location = new System.Drawing.Point(135, 634);
            this.textBox_O1.Name = "textBox_O1";
            this.textBox_O1.Size = new System.Drawing.Size(48, 27);
            this.textBox_O1.TabIndex = 25;
            this.textBox_O1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_O1_KeyPress);
            // 
            // textBox_A
            // 
            this.textBox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_A.Location = new System.Drawing.Point(135, 675);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(71, 27);
            this.textBox_A.TabIndex = 28;
            this.textBox_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_A_KeyPress);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntensitySettingToolStripMenuItem,
            this.ModelingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1405, 28);
            this.menuStrip1.TabIndex = 29;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IntensitySettingToolStripMenuItem
            // 
            this.IntensitySettingToolStripMenuItem.Name = "IntensitySettingToolStripMenuItem";
            this.IntensitySettingToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.IntensitySettingToolStripMenuItem.Text = "Настройка интенсивности";
            // 
            // ModelingToolStripMenuItem
            // 
            this.ModelingToolStripMenuItem.Name = "ModelingToolStripMenuItem";
            this.ModelingToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.ModelingToolStripMenuItem.Text = "Моделирование обработки запросов";
            this.ModelingToolStripMenuItem.Click += new System.EventHandler(this.ModelingToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 525);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 291);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // IntensitySetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1405, 831);
            this.Controls.Add(this.textBox_A);
            this.Controls.Add(this.textBox_O3);
            this.Controls.Add(this.textBox_O2);
            this.Controls.Add(this.textBox_O1);
            this.Controls.Add(this.textBox_M3);
            this.Controls.Add(this.textBox_M2);
            this.Controls.Add(this.textBox_M1);
            this.Controls.Add(this.textBox_K3);
            this.Controls.Add(this.textBox_K2);
            this.Controls.Add(this.textBox_K1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxXmax);
            this.Controls.Add(this.textBoxXmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "IntensitySetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройка интенсивности";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxXmin;
        private System.Windows.Forms.TextBox textBoxXmax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_K1;
        private System.Windows.Forms.TextBox textBox_K2;
        private System.Windows.Forms.TextBox textBox_K3;
        private System.Windows.Forms.TextBox textBox_M3;
        private System.Windows.Forms.TextBox textBox_M2;
        private System.Windows.Forms.TextBox textBox_M1;
        private System.Windows.Forms.TextBox textBox_O3;
        private System.Windows.Forms.TextBox textBox_O2;
        private System.Windows.Forms.TextBox textBox_O1;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IntensitySettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

