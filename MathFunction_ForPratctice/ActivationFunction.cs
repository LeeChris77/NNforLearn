using System;
using System.Collections.Generic;

namespace MathFunction_ForPratctice
{
    class Activation
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
        public List<double> Func_ArcTan(List<double> inputData) //反正切函式*
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                //double cal = ;
                //tmp.Add(cal);
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
        public List<double> Func_PReLU(List<double> inputData) //線性整流函式*
        {
            List<double> tmp = new List<double>();
            foreach (var item in inputData)
            {
                //double cal = ;
                //tmp.Add(cal);
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
    }
}
