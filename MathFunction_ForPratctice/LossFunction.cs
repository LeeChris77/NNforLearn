using System;

namespace Loss
{
    class Losslib
    {
        public double MAE(double[] x, double[] y)
        {
            double temp = 0.00;
            if (x.Length > y.Length || x.Length < y.Length) { Console.Write("資料長度不相同,請確認長度後再執行!"); }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    temp += Math.Abs(x[i] - y[i]);
                }
                temp /= x.Length;
                return temp;
            }
            return 1;
        }
        public double MSE(double[] x, double[] y)
        {
            double temp = 0.00;
            if (x.Length > y.Length || x.Length < y.Length) { Console.Write("資料長度不相同,請確認長度後再執行!"); }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    temp += Math.Pow(x[i] - y[i], 2);
                }
                temp /= x.Length;
                return temp;
            }
            return 1;
        }
        public double RMSE(double[] x, double[] y)
        {
            double temp = 0.00;
            if (x.Length > y.Length || x.Length < y.Length) { Console.Write("資料長度不相同,請確認長度後再執行!"); }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    temp += Math.Pow(x[i] - y[i], 2);
                }
                temp /= x.Length;
                temp = Math.Sqrt(temp);
                return temp;
            }
            return 1;
        }
        public double MAPE(double[] x, double[] y)
        {
            double temp = 0.00;
            if (x.Length > y.Length || x.Length < y.Length) { Console.Write("資料長度不相同,請確認長度後再執行!"); }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    temp += Math.Abs((x[i] - y[i]) / x[i]);
                }
                temp = (temp * 100) / x.Length;
                return temp;
            }
            return 1;
        }
        public double SMAPE(double[] x, double[] y)
        {
            double temp = 0.00;
            if (x.Length > y.Length || x.Length < y.Length) { Console.Write("資料長度不相同,請確認長度後再執行!"); }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    temp += Math.Abs((x[i] - y[i]) / (Math.Abs(x[i]) + Math.Abs(y[i]) / 2));
                }
                temp = (temp * 100) / x.Length;
                return temp;
            }
            return 1;
        }
        public double Mean_huberloss(double[] x, double[] y, double delta)
        {
            double temp = 0;
            if (x.Length > y.Length || x.Length < y.Length) { Console.Write("資料長度不相同,請確認長度後再執行!"); }
            else
            {
                for (int i = 0; i < x.Length; i++)
                {
                    if (Math.Abs(x[i] - y[i]) <= delta)
                    {
                        temp += Math.Pow(x[i] - y[i], 2) / 2;
                        //Console.WriteLine("sum T[" + i + "]: " + temp);
                    }
                    else if (Math.Abs(x[i] - y[i]) > delta)
                    {
                        temp += (delta * Math.Abs(x[i] - y[i])) - (Math.Pow(delta, 2) / 2);
                        //Console.WriteLine("sum F[" + i + "]: " + temp);
                    }
                }
                temp /= x.Length;
                return temp;
            }
            return 1;
        }
        public double Cross_entropy(double[,] Fdata, double[,] encode)
        {
            double total_sum = 0;
            if (Fdata.Length > encode.Length || Fdata.Length < encode.Length) { Console.Write("資料長度不相同,請確認長度後再執行!"); }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    double contAns = 0;
                    for (int c = 0; c < 4; c++)
                    {
                        contAns += (-encode[c, i]) * Math.Log(Fdata[c, i], 2);
                    }
                    Console.WriteLine("One Trun in ForLoop Type[" + (i + 1) + "] Sum:" + contAns);
                    total_sum += contAns;
                }
                return total_sum;
            }
            return 1;
        }

    }
}
