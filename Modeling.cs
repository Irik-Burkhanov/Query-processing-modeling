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

namespace cmo
{
    public partial class Modeling : Form
    {
        Model model;
        public Modeling()
        {
            InitializeComponent();
            model = new Model();
            TypeOfDistribution_CB.SelectedIndex = 0;
            model.observers += new System.EventHandler(this.UpdateFromModel);
            model.setA(Settings.Default.save_A);
            model.setlambda(Settings.Default.save_lambda);
            model.setX(Settings.Default.save_Xmin, Settings.Default.save_Xmax);
            model.setK(Settings.Default.save_K1, Settings.Default.save_K2, Settings.Default.save_K3);
            model.setM(Settings.Default.save_M1, Settings.Default.save_M2, Settings.Default.save_M3);
            model.setO(Settings.Default.save_O1, Settings.Default.save_O2, Settings.Default.save_O3);
            model.setTMMS(Settings.Default.save_TimeMin, Settings.Default.save_TimeMax, Settings.Default.save_CountSer);
            TypeOfDistribution_CB.KeyPress += (sender, e) => e.Handled = true;
        }
        private void UpdateFromModel(object sender, EventArgs e)
        {
            TimeMin_NUD.Text = model.getTimeMin().ToString();
            TimeMax_NUD.Text = model.getTimeMax().ToString();
            Lambda_NUD.Value = model.getlambda();
            CountOfServers_NUD.Value = model.getCountOfServers();
        }
        private void IntensitySettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            IntensitySetting Form_IntensitySetting = new IntensitySetting();
            Form_IntensitySetting.ShowDialog();
            Form_IntensitySetting.Close();
            //Show();
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (decimal.ToInt32(CountOfServers_NUD.Value) == 0 || decimal.ToInt32(Lambda_NUD.Value) == 0)
            {
                MessageBox.Show("Количество серверов и λ должны быть больше 0", "Ошибка при вводе данных!"); 
                return;
            }
            label7.Text = "Количество обработанных запросов: ";
            label8.Text = "Среднее время нахождения запроса в системе в ms: ";
            label9.Text = "Среднее время задержки запроса в очереди в ms: ";
            label10.Text = "Коэффициенты занятости устройств: ";
            label11.Text = "Средний коэффициент занятости устройств: ";
            label12.Text = "Время выполнения моделирования в реальном времени: ";
            label13.Text = "Время в тактах: ";

            int M = decimal.ToInt32(CountOfServers_NUD.Value);
            model.lambda = decimal.ToInt32(Lambda_NUD.Value);
            if (TimeMin_NUD.Text !="" && TimeMax_NUD.Text != "" && Lambda_NUD.Text != "" && CountOfServers_NUD.Text != "")
            {
                model.modeling(M, TypeOfDistribution_CB.SelectedIndex);
            }
            else { MessageBox.Show("Для работы ПО необходимо заполнить все поля", "Ошибка при вводе данных!"); return; }
            

            if(decimal.ToInt32(TimeMin_NUD.Value) < decimal.ToInt32(TimeMax_NUD.Value) && decimal.ToInt32(TimeMin_NUD.Value) >= 100 && decimal.ToInt32(TimeMax_NUD.Value) <= 1000)
            {
                model.setTMMS(decimal.ToInt32(TimeMin_NUD.Value), decimal.ToInt32(TimeMax_NUD.Value), M);
            }
            else { MessageBox.Show("Время ОТ не должно превышать время ДО", "Ошибка при вводе данных!"); return; }



            label7.Text = label7.Text + model.Na;
            label8.Text = label8.Text + Math.Round(model.ST, 2);
            label9.Text = label9.Text + Math.Round(model.STQ, 2);
            for (int i=1; i<=M; i++)
            {
                label10.Text = label10.Text + "  " + Math.Round(model.RI[i], 4)*100 + "%;";
                if (i == 9 || i == 23 || i == 45)
                {
                    label10.Text = label10.Text + "\n";
                }
            }
            label11.Text = label11.Text + Math.Round(model.CBC, 4) * 100 + "%";
            label12.Text = label12.Text + model.elapsedTime;
            label13.Text = label13.Text + model.tss;


            Settings.Default.save_CountSer = model.getCountOfServers();
            Settings.Default.save_TimeMin = model.getTimeMin();
            Settings.Default.save_TimeMax = model.getTimeMax();
            Settings.Default.save_lambda = model.getlambda();
            Settings.Default.Save();
        }
    }
}
