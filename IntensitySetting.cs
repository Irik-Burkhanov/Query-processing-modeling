using cmo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace cmo
{
    public partial class IntensitySetting : Form
    {
        Model model;

        public IntensitySetting()
        {
            InitializeComponent();

            model = new Model();
            model.observers += new System.EventHandler(this.UpdateFromModel);
            model.setA(Settings.Default.save_A);
            model.setX(Settings.Default.save_Xmin, Settings.Default.save_Xmax);
            model.setK(Settings.Default.save_K1, Settings.Default.save_K2, Settings.Default.save_K3);
            model.setM(Settings.Default.save_M1, Settings.Default.save_M2, Settings.Default.save_M3);
            model.setO(Settings.Default.save_O1, Settings.Default.save_O2, Settings.Default.save_O3);
        }

        private void UpdateFromModel(object sender, EventArgs e)
        {
            textBoxXmin.Text = model.getXmin().ToString();
            textBoxXmax.Text = model.getXmax().ToString();
            textBox_A.Text = model.getA().ToString();

            textBox_K1.Text = model.getK1().ToString();
            textBox_K2.Text = model.getK2().ToString();
            textBox_K3.Text = model.getK3().ToString();

            textBox_O1.Text = model.getO1().ToString();
            textBox_O2.Text = model.getO2().ToString();
            textBox_O3.Text = model.getO3().ToString();

            textBox_M1.Text = model.getM1().ToString();
            textBox_M2.Text = model.getM2().ToString();
            textBox_M3.Text = model.getM3().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_K1.Text == "" || textBox_K2.Text == "" || textBox_K3.Text == "" ||
                textBox_M1.Text == "" || textBox_M2.Text == "" || textBox_M3.Text == "" ||
                textBox_O1.Text == "" || textBox_O2.Text == "" || textBox_O3.Text == "" ||
                textBox_A.Text == "" || textBoxXmin.Text == "" || textBoxXmax.Text == "")
            {
                MessageBox.Show("Для работы ПО необходимо заполнить все поля.", "Ошибка при вводе данных!"); return;
            }
            else
            {
                double Xmin = double.Parse(textBoxXmin.Text);
                double Xmax = double.Parse(textBoxXmax.Text);

                double K1 = double.Parse(textBox_K1.Text);
                double K2 = double.Parse(textBox_K2.Text);
                double K3 = double.Parse(textBox_K3.Text);

                double M1 = double.Parse(textBox_M1.Text);
                double M2 = double.Parse(textBox_M2.Text);
                double M3 = double.Parse(textBox_M3.Text);

                double O1 = double.Parse(textBox_O1.Text);
                double O2 = double.Parse(textBox_O2.Text);
                double O3 = double.Parse(textBox_O3.Text);

                double A = double.Parse(textBox_A.Text);

                if (K1 + K2 + K3 == 1 && K1 >= 0 && K2 >= 0 && K3 >= 0)
                {
                    model.setK(K1, K2, K3);
                }
                else { MessageBox.Show("Сумма ki должна быть равна 1\nki не должен быть меньше 0.", "Ошибка при вводе данных!"); return; }

                if (M1 < M2 && M2 < M3 && M1 >= 7 && M3 <= 22)
                {
                    model.setM(M1, M2, M3);
                }
                else { MessageBox.Show("μ1 должен быть меньше μ2, а μ2 должен быть меньше μ3.\nУчитывайте время моделирования от 7 до 22", "Ошибка при вводе данных!"); return; }

                if (O1 > 0 && O2 > 0 && O3 > 0)
                {
                    model.setO(O1, O2, O3);
                }
                else { MessageBox.Show("σi не должны быть меньше или равны 0.", "Ошибка при вводе данных!"); return; }

                if (A > 0)
                {
                    model.setA(A);
                }
                else { MessageBox.Show("α не должна быть меньше или равна 0.", "Ошибка при вводе данных!"); return; }

                if (Xmin >= 7 && Xmax <= 22 && Xmin < Xmax)
                {
                    model.setX(Xmin, Xmax);
                }
                else { MessageBox.Show("Время моделирования не должно быть\nменьше 7 часов утра и больше 22 вечера", "Ошибка при вводе данных!"); return; }


                int cout = (int)Math.Ceiling((Xmax - Xmin) / 0.05);
                double[] x = new double[cout];
                double[] y = new double[cout];
                double Xmin1 = Xmin;
                for (int i = 0; i < cout; i++)
                {
                    Xmin1 += 0.05;
                    x[i] = Xmin1;
                    y[i] = model.lambda_Func(Xmin1);
                }
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisY.Interval = 2;
                chart1.ChartAreas[0].AxisX.Minimum = 7;
                chart1.ChartAreas[0].AxisX.Maximum = 22;
                chart1.Series[0].Points.DataBindXY(x, y);
                chart1.ChartAreas[0].AxisX.Title = "Время в часах";
                chart1.ChartAreas[0].AxisY.Title = "Интенсивность поступления запросов в секунду";

                Settings.Default.save_A = model.getA();
                Settings.Default.save_K1 = model.getK1();
                Settings.Default.save_K2 = model.getK2();
                Settings.Default.save_K3 = model.getK3();
                Settings.Default.save_M1 = model.getM1();
                Settings.Default.save_M2 = model.getM2();
                Settings.Default.save_M3 = model.getM3();
                Settings.Default.save_O1 = model.getO1();
                Settings.Default.save_O2 = model.getO2();
                Settings.Default.save_O3 = model.getO3();
                Settings.Default.save_Xmax = model.getXmax();
                Settings.Default.save_Xmin = model.getXmin();
                Settings.Default.Save();
            }

            /*chart1.ChartAreas[0].AxisX.LabelStyle.Format = "H:mm";
            chart1.Series[0].XValueType = ChartValueType.DateTime;
            chart1.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Minutes;
            chart1.ChartAreas[0].AxisX.Interval = 30;*/
        }

        private void ModelingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Modeling Form_Modeling = new Modeling();
            Form_Modeling.ShowDialog();
            Form_Modeling.Close();
            //Show();
            Close();
        }

        private void textBox_A_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_A.Text.Contains(',') && textBox_A.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_K1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_K1.Text.Contains(',') && textBox_K1.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_K2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_K2.Text.Contains(',') && textBox_K2.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_K3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_K3.Text.Contains(',') && textBox_K3.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_M1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_M1.Text.Contains(',') && textBox_M1.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_M2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_M2.Text.Contains(',') && textBox_M2.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_M3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_M3.Text.Contains(',') && textBox_M3.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_O1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_O1.Text.Contains(',') && textBox_O1.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_O2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_O2.Text.Contains(',') && textBox_O2.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox_O3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBox_O3.Text.Contains(',') && textBox_O3.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxXmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBoxXmin.Text.Contains(',') && textBoxXmin.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBoxXmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == ',' && (!textBoxXmax.Text.Contains(',') && textBoxXmax.Text.Length != 0) || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
