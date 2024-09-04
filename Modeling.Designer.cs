
namespace cmo
{
    partial class Modeling
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.IntensitySettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModelingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeOfDistribution_CB = new System.Windows.Forms.ComboBox();
            this.CountOfServers_NUD = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TimeMin_NUD = new System.Windows.Forms.NumericUpDown();
            this.TimeMax_NUD = new System.Windows.Forms.NumericUpDown();
            this.Lambda_NUD = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfServers_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMin_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMax_NUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lambda_NUD)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IntensitySettingToolStripMenuItem,
            this.ModelingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1190, 28);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // IntensitySettingToolStripMenuItem
            // 
            this.IntensitySettingToolStripMenuItem.Name = "IntensitySettingToolStripMenuItem";
            this.IntensitySettingToolStripMenuItem.Size = new System.Drawing.Size(206, 24);
            this.IntensitySettingToolStripMenuItem.Text = "Настройка интенсивности";
            this.IntensitySettingToolStripMenuItem.Click += new System.EventHandler(this.IntensitySettingToolStripMenuItem_Click);
            // 
            // ModelingToolStripMenuItem
            // 
            this.ModelingToolStripMenuItem.Name = "ModelingToolStripMenuItem";
            this.ModelingToolStripMenuItem.Size = new System.Drawing.Size(287, 24);
            this.ModelingToolStripMenuItem.Text = "Моделирование обработки запросов";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Введите в ms время обработки запроса от:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(576, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "до:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(30, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(735, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Введите λ для генерации времени обработки и поступления новых запросов:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(30, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(490, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Выберите тип распределения запросов в системе:";
            // 
            // TypeOfDistribution_CB
            // 
            this.TypeOfDistribution_CB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeOfDistribution_CB.FormattingEnabled = true;
            this.TypeOfDistribution_CB.Items.AddRange(new object[] {
            "Случайным образом между серверами",
            "Запросы поступают на тот сервер, где меньше очередь"});
            this.TypeOfDistribution_CB.Location = new System.Drawing.Point(595, 139);
            this.TypeOfDistribution_CB.Name = "TypeOfDistribution_CB";
            this.TypeOfDistribution_CB.Size = new System.Drawing.Size(569, 28);
            this.TypeOfDistribution_CB.TabIndex = 37;
            // 
            // CountOfServers_NUD
            // 
            this.CountOfServers_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountOfServers_NUD.Location = new System.Drawing.Point(369, 184);
            this.CountOfServers_NUD.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.CountOfServers_NUD.Name = "CountOfServers_NUD";
            this.CountOfServers_NUD.Size = new System.Drawing.Size(64, 27);
            this.CountOfServers_NUD.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(30, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 25);
            this.label6.TabIndex = 39;
            this.label6.Text = "Введите количество серверов:";
            // 
            // TimeMin_NUD
            // 
            this.TimeMin_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeMin_NUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.TimeMin_NUD.Location = new System.Drawing.Point(485, 58);
            this.TimeMin_NUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimeMin_NUD.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TimeMin_NUD.Name = "TimeMin_NUD";
            this.TimeMin_NUD.Size = new System.Drawing.Size(60, 27);
            this.TimeMin_NUD.TabIndex = 40;
            this.TimeMin_NUD.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // TimeMax_NUD
            // 
            this.TimeMax_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeMax_NUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.TimeMax_NUD.Location = new System.Drawing.Point(636, 58);
            this.TimeMax_NUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TimeMax_NUD.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.TimeMax_NUD.Name = "TimeMax_NUD";
            this.TimeMax_NUD.Size = new System.Drawing.Size(60, 27);
            this.TimeMax_NUD.TabIndex = 41;
            this.TimeMax_NUD.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            // 
            // Lambda_NUD
            // 
            this.Lambda_NUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lambda_NUD.Location = new System.Drawing.Point(830, 99);
            this.Lambda_NUD.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Lambda_NUD.Name = "Lambda_NUD";
            this.Lambda_NUD.Size = new System.Drawing.Size(60, 27);
            this.Lambda_NUD.TabIndex = 43;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(155, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 57);
            this.button1.TabIndex = 44;
            this.button1.Text = "Расчет оценок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(40, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1124, 281);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(636, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 20);
            this.label13.TabIndex = 6;
            this.label13.Text = "Время в тактах: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(7, 227);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(498, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Время выполнения моделирования в реальном времени: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(7, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(403, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Средний коэффициент занятости устройств: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(7, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(338, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Коэффициенты занятости устройств: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(7, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(445, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Среднее время задержки запроса в очереди в ms: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(7, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(463, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "Среднее время нахождения запроса в системе в ms: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(327, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Количество обработанных запросов: ";
            // 
            // Modeling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1190, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lambda_NUD);
            this.Controls.Add(this.TimeMax_NUD);
            this.Controls.Add(this.TimeMin_NUD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CountOfServers_NUD);
            this.Controls.Add(this.TypeOfDistribution_CB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Modeling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Моделирование обработки запросов";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CountOfServers_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMin_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMax_NUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lambda_NUD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem IntensitySettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModelingToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TypeOfDistribution_CB;
        private System.Windows.Forms.NumericUpDown CountOfServers_NUD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown TimeMin_NUD;
        private System.Windows.Forms.NumericUpDown TimeMax_NUD;
        private System.Windows.Forms.NumericUpDown Lambda_NUD;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
    }
}