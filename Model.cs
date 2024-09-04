using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmo
{
    class Model
    {
        Random rnd = new Random(1);
        public System.EventHandler observers;
        public double K1, K2, K3;
        public double M1, M2, M3;
        public double O1, O2, O3;
        public double Xmin, Xmax;
        public double alpha;
        public int lambda;

        public TimeSpan Elapsed{ get; }
        public string elapsedTime;
        public double tss;

        public double ST, STQ, CBC, Y, TimeMin, TimeMax;
        public double[] RI = new double[100];
        double[] A = new double[100000];
        double[] D = new double[100000];
        double[] ServiceTime = new double[100000];
        double[] GAT = new double[100000];
        double[] GATIO = new double[100000]; 
        public int Na = 0, Nd = 0, CountSer;
        /*public double[] mi = new double[3] { 9.5, 13, 18 };
        public double[] ci = new double[3] { 2.3, 1, 4 };
        public double[] ki = new double[3] { 0.37, 0.13, 0.5 };*/
        public double f_x_(double t, double mi, double ci)
        {
            double st = -Math.Pow(t - mi, 2) / (2 * Math.Pow(ci, 2));
            return Math.Exp(st) / (2 * Math.Pow(Math.PI * ci, 0.5));
        }

        public double F_x(double a, double b, double mi, double ci)
        {
            return f_x_((b - mi) / ci, 0, 1) - f_x_((a - mi) / ci, 0, 1);
        }

        public double lambda_Func(double time)
        {
            double F1 = F_x(0, 12, M1, O1);
            double F2 = F_x(0, 12, M2, O2);
            double F3 = F_x(0, 12, M3, O3);

            double f1 = K1 * f_x_(time, M1, O1) / F1;
            double f2 = K2 * f_x_(time, M2, O2) / F2;
            double f3 = K3 * f_x_(time, M3, O3) / F3;

            return (f1 + f2 + f3) * alpha;
        }
        public double GetServiceTime()
        {
            while (true)
            {
                double value = rnd.NextDouble();
                double gst = -Math.Log(value) / lambda;
                if (TimeMin <= gst && gst <= TimeMax)
                    return gst;
            }
        }

        public double GetArrivalTime(double t)
        { 
            while (true)
            {
                double u1 = rnd.NextDouble();
                t -= Math.Log(u1) / lambda;
                double u2 = rnd.NextDouble();
                if (u2 <= lambda_Func(t) / lambda)
                    return t;
            }
        }
        public double minEL(double[] E, int m, int q)
        {
            double min_ = E[q];
            for (int i = q; i <= m; i++)
            {
                if (E[i] < min_)
                    min_ = E[i];
            }
            return min_;
        }
        public int minSS(int[,] ss, int m)
        {
            int min_ = ss[1, 0];
            for (int i = 1; i <= m; i++)
            {
                if (ss[i, 0] < min_)
                    min_ = ss[i, 0];
            }
            return min_;
        }
        public int maxSS(int[,] ss, int m)
        {
            int max_ = ss[1, 1];
            for (int i = 1; i <= m; i++)
            {
                if (ss[i, 1] > max_)
                    max_ = ss[i, 1];
            }
            return max_;
        }
        public double GetAverageTime()
        {
            double sum = 0;
            for (int i = 0; i <= Na; i++)
            {
                GAT[i] = D[i] - A[i];
                sum += GAT[i];
            }
            return sum / Na;
        }
        public double GetAverageTimeInQueue()
        {
            double sum = 0;
            for (int i = 0; i <= Na; i++)
            {
                GATIO[i] = D[i] - (A[i] + ServiceTime[i]);
                sum += GATIO[i];
            }
            sum = sum / Na;
            return sum;
        }
        public void modeling(int M, int j)
        {
            Stopwatch stopwatch = new Stopwatch();
            int m = M;
            int[,] SS = new int[m+1, 2];
            double[] EL = new double[m + 1];
            double[] CashierBusyTime = new double[m+1];
            double t = Xmin;
            double Ta = GetArrivalTime(t);
            double Td = 1000000;

            alpha *= 3600;
            lambda *= 3600;
            Na = Nd = 0;

            SetInitialValues();
            EL[0] = Ta;
            stopwatch.Start();
            switch (j)
            {
                case 0:
                    while (true)
                    {
                        if (Math.Min(Ta, Td) > Xmax && SS[0, 0] == 0)
                            break;
                        else
                            leaving();

                        if (EL[0] == minEL(EL, m, 0))
                            add();
                        else
                            leaving();
                    }
                    break;
                case 1:
                    while (true)
                    {
                        if (Math.Min(Ta, Td) > Xmax && SS[0, 0] == 0)
                            break;
                        else
                            leaving();

                        if (EL[0] == minEL(EL, m, 0))
                            add1();
                        else
                            leaving();
                    }
                    break;
            }
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            tss = stopwatch.ElapsedTicks;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
    ts.Hours, ts.Minutes, ts.Seconds,
    ts.Milliseconds / 100);

            alpha /= 3600;
            lambda /= 3600;

            ST = GetAverageTime() * 3600000;
            STQ = GetAverageTimeInQueue() * 3600000;
            for(int i = 1; i <= m; i++)
            {
                RI[i] = GetCashBusyCoefficient(i);
            }
            CBC = GetAverageCashBusyCoefficient();

            void add()
            {
                t = EL[0];
                Ta = t;

                double NextArrival = GetArrivalTime(t);
                EL[0] = NextArrival;
                A[Na] = t;
                SS[0, 0] = SS[0, 0] + 1;
                int k = rnd.Next(1, m+1);
                if (SS[k, 0] == 0)
                {
                    SS[k, 0] = SS[k, 0] + 1;
                    SS[k, 1] = Na;
                    Y = GetServiceTime();
                    EL[k] = t + Y;
                    ServiceTime[Na] = Y;
                    CashierBusyTime[k] = CashierBusyTime[k] + Y;
                }
                else
                {
                    SS[k, 0] = SS[k, 0] + 1;
                }

                Na++;
                if (Na + 1 == A.Length)
                {
                    Array.Resize(ref A, Na * 2);
                    Array.Resize(ref D, Na * 2);
                    Array.Resize(ref ServiceTime, Na * 2);
                    Array.Resize(ref GAT, Na * 2);
                    Array.Resize(ref GATIO, Na * 2);
                }
            }

            void add1()
            {
                t = EL[0];
                Ta = t;
                double NextArrival = GetArrivalTime(t);
                EL[0] = NextArrival;
                A[Na] = t;
                SS[0, 0] = SS[0, 0] + 1;
                int min_ = minSS(SS, m);

                for (int i = 1; i <= m; i++)
                {
                    if(SS[i, 0] == 0)
                    {
                        SS[i, 0] = SS[i, 0] + 1;
                        SS[i, 1] = Na;
                        Y = GetServiceTime();
                        EL[i] = t + Y;
                        ServiceTime[Na] = Y;
                        CashierBusyTime[i] = CashierBusyTime[i] + Y;
                        break;
                    }
                    else
                    {
                        if (SS[i, 0] == min_)
                        {
                            SS[i, 0] = SS[i, 0] + 1;
                            break;
                        }
                    }
                }
                Na++;
                if (Na + 1 == A.Length)
                {
                    Array.Resize(ref A, Na * 2);
                    Array.Resize(ref D, Na * 2);
                    Array.Resize(ref ServiceTime, Na * 2);
                    Array.Resize(ref GAT, Na * 2);
                    Array.Resize(ref GATIO, Na * 2);
                }
            }

            void leaving()
            {
                for (int i = 1; i <= m; i++)
                {
                    if(EL[i] == minEL(EL, m, 0))
                    {
                        t = EL[i];
                        Td = t;
                        D[Nd] = t;
                        Nd++;
                        SS[0, 0] = SS[0, 0] - 1;

                        if (SS[i, 0] == 1)
                        {
                            SS[i, 0] = 0;
                            SS[i, 1] = 0;
                            EL[i] = 1000000;
                        }
                        else
                        {
                            int NextBuer = maxSS(SS, m) + 1;
                            SS[i, 0] = SS[i, 0] - 1;
                            SS[i, 1] = NextBuer;
                            Y = GetServiceTime();
                            EL[i] = t + Y;
                            if (NextBuer + 1 == ServiceTime.Length)
                            {
                                Array.Resize(ref ServiceTime, NextBuer * 2);
                            }
                            ServiceTime[NextBuer] = Y;
                            CashierBusyTime[i] = CashierBusyTime[i] + Y;
                        }
                        break;
                    }
                }
            }
            void SetInitialValues()
            {
                for (int i = 0; i <= m; i++)
                {
                    SS[i, 0] = 0;
                    SS[i, 1] = 0;
                    EL[i] = 1000000;
                }
            }
            double GetCashBusyCoefficient(int g)
            {
                return CashierBusyTime[g] / (Xmax - Xmin);
            }
            double GetAverageCashBusyCoefficient()
            {
                double sum = 0;
                for (int i = 1; i <= m; i++)
                {
                    sum += RI[i];
                }
                return sum / m;
            }
        }

        public void setTMMS(double value1, double value2, int value3)
        {
            TimeMin = value1 / 3600000;
            TimeMax = value2 / 3600000;
            CountSer = value3;
            observers.Invoke(this, null);
        }
        public void setK(double value1, double value2, double value3)
        {
            K1 = value1;
            K2 = value2;
            K3 = value3;
            observers.Invoke(this, null);
        }
        public void setM(double value1, double value2, double value3)
        {
            M1 = value1;
            M2 = value2;
            M3 = value3;
            observers.Invoke(this, null);
        }
        public void setO(double value1, double value2, double value3)
        {
            O1 = value1;
            O2 = value2;
            O3 = value3;
            observers.Invoke(this, null);
        }
        public void setA(double value)
        {
            alpha = value;
            observers.Invoke(this, null);
        }
        public void setlambda(int value)
        {
            lambda = value;
        }
        public void setX(double value1, double value2)
        {
            Xmin = value1;
            Xmax = value2;
            observers.Invoke(this, null);
        }
        public double getK1()
        {
            return K1;
        }
        public double getK2()
        {
            return K2;
        }
        public double getK3()
        {
            return K3;
        }
        public double getA()
        {
            return alpha;
        }
        public double getO1()
        {
            return O1;
        }
        public double getO2()
        {
            return O2;
        }
        public double getO3()
        {
            return O3;
        }
        public double getM1()
        {
            return M1;
        }
        public double getM2()
        {
            return M2;
        }
        public double getM3()
        {
            return M3;
        }
        public double getXmin()
        {
            return Xmin;
        }
        public double getXmax()
        {
            return Xmax;
        }
        public int getlambda()
        {
            return lambda;
        }
        public double getTimeMin()
        {
            return TimeMin * 3600000;
        }
        public double getTimeMax()
        {
            return TimeMax * 3600000;
        }
        public int getCountOfServers()
        {
            return CountSer;
        }
    }
}
