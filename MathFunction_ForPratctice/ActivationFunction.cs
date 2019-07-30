using System;
using System.Collections.Generic;

namespace Activation
{
    public class ActivationLib
    {
        public List<double> Func_Identity(List<double> inputData) //恆等函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = item;
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_BinaryStep(List<double> inputData)//單位階躍函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < 0) { cal = 0; } else { cal = 1; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Sigmoid(List<double> inputData) //Sigmoid
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 1 / (1 + Math.Exp(-item));
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Tanh(List<double> inputData) //雙曲正切函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = (Math.Exp(item) - Math.Exp(-item)) / (Math.Exp(item) + Math.Exp(-item));
                tmp.Add(cal);
            }
            return tmp;
        }
        public double SingleTanh(double x) //臨時單一Tanh 修改參考185
        {
            double tmp = (Math.Exp(x) - Math.Exp(-x)) / (Math.Exp(x) + Math.Exp(-x));
            return tmp;
        }
        public List<double> Func_ArcTan(List<double> inputData) //反正切函式*
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = Math.Atan(item);
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Softsign(List<double> inputData)//Softsign
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = item / (1 + Math.Abs(item));
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_ReLU(List<double> inputData) //線性整流函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < 0) { cal = 0; } else { cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_LeakyReLU(List<double> inputData) //帶泄露線性整流函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < 0) { cal = 0.01 * item; } else { cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_PReLU(List<double> inputData ,double alpha) //PReLU
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < 0) { cal = alpha * item; } else { cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_RReLU(List<double> inputData, double alpha) //RReLU
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < 0) { cal = alpha * item; } else { cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_ELU(List<double> inputData, double alpha) //ELU
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < 0) { cal = alpha *(Math.Exp(item)-1); } else { cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_SELU(List<double> inputData) //SELU
        {
            List<double> tmp = new List<double>();
            double lambda = 1.05070;
            double alpha = 1.67326;
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < 0) { cal = lambda * alpha * (Math.Exp(item) - 1); } else { cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_SReLU(List<double> inputData) //SReLU
        {
            List<double> tmp = new List<double>();
            double al = 1;
            double ar = 0.4;
            double tl = -1.0;
            double tr = 1;
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item <= tl) { cal = tl + al*(item - tl); }
                else if (item >= tr){cal = tr + ar * (item - tr); }
                else{cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_HardSigmoid(List<double> inputData) //HardSigmoid
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < -2.5) { cal = 0; }
                else if (item > 2.5) { cal = 1; }
                else { cal = 0.2 * item + 0.5; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_HardTanh(List<double> inputData) //HardTanh
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item < -1) { cal = -1; }
                else if (item > 1) { cal = 1; }
                else { cal = item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_LeCunTanh(List<double> inputData) //LeCunTanh
        {
            List<double> tmp = new List<double>();
            ActivationLib toTanh = new ActivationLib();
            foreach (var item in inputData)
            {
                double cal = 1.7519 * toTanh.SingleTanh(((2 / 3) * item));
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_SoftPlus(List<double> inputData) //SoftPlus
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = Math.Log(1 + Math.Exp(item));
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Signum(List<double> inputData) //Signum
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if(item > 0) { cal = 1; }else if(item < 0) { cal = -1; } else { cal = 0; }
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_BentIdentity(List<double> inputData) //彎曲恆等函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = (Math.Sqrt(Math.Pow(item, 2) + 1) - 1) / 2 + item;
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_SymmetricalSigmoid(List<double> inputData) //LeCunTanh
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 1 - Math.Exp(-item) / 1 + Math.Exp(-item);
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_LogLog(List<double> inputData) //LogLog
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 1 -  Math.Exp(-Math.Exp(item));
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Gaussian(List<double> inputData) //高斯函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = Math.Exp((-Math.Pow(item, 2)));
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Absolute(List<double> inputData) //Absolute
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = Math.Abs(item);
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Sinusoid(List<double> inputData) //正弦函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = Math.Sin(item);
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Cos(List<double> inputData) //Cos
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = Math.Cos(item);
                tmp.Add(cal);
            }
            return tmp;
        }
        public List<double> Func_Sinc(List<double> inputData) //Sinc函式
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                double cal = 0;
                if (item == 0) { cal = 1; } else { cal = Math.Sin(item) / item; }
                tmp.Add(cal);
            }
            return tmp;
        }
        
    }
}
