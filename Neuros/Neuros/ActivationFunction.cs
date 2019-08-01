﻿using System;
using System.Collections.Generic;

namespace Activation
{
    public class ActivationLib
    {
        public double IdentityFunction(double x) //恆等函式
        {
            double y_cal = x;
            return y_cal;
        }
        public double BinaryStepFunction(double x)//單位階躍函式
        {
            double y_cal;
            if (x < 0) { y_cal = 0; } else { y_cal = 1; }
            return y_cal;
        }
        public double SigmoidFunction(double x) //Sigmoid
        {
            double y_cal = 1 / (1 + Math.Exp(-x));
            return y_cal;
        }
        public double TanhFunction(double x) //雙曲正切函式
        {
            double y_cal = (Math.Exp(x) - Math.Exp(-x)) / (Math.Exp(x) + Math.Exp(-x));
            return y_cal;

        }
        public double ArcTanFunction(double x) //反正切函式*
        {
            double y_cal = Math.Atan(x);
            return y_cal;
        }
        public double SoftsignFunction(double x)//Softsign
        {
            double y_cal = x / (1 + Math.Abs(x));
            return y_cal;
        }
        public double ReLUFunction(double x) //線性整流函式
        {
            double y_cal;
            if (x < 0) { y_cal = 0; } else { y_cal = x; }
            return y_cal;
        }
        public double LeakyReLUFunction(double x) //帶泄露線性整流函式
        {
            double y_cal;
            if (x < 0) { y_cal = 0.01 * x; } else { y_cal = x; }
            return y_cal;
        }
        public double PReLUFunction(double x, double alpha) //PReLU  自己帶alpha參數
        {
            double y_cal;
            if (x < 0) { y_cal = alpha * x; } else { y_cal = x; }
            return y_cal;
        }
        public double RReLUFunction(double x, double alpha) //RReLU  alpha請設定亂數
        {
            double y_cal;
            if (x < 0) { y_cal = alpha * x; } else { y_cal = x; }
            return y_cal;
        }
        public double ELUFunction(double x, double alpha) //ELU
        {
            double y_cal;
            if (x < 0) { y_cal = alpha * (Math.Exp(x) - 1); } else { y_cal = x; }
            return y_cal;
        }
        public double SELUFunction(double x) //SELU
        {
            double lambda = 1.05070;
            double alpha = 1.67326;
            double y_cal;
            if (x < 0) { y_cal = lambda * alpha * (Math.Exp(x) - 1); } else { y_cal = x; }
            return y_cal;
        }
        public double SReLUFunction(double x, double al, double ar, double tl, double tr) //SReLU //1, 0.4, -1.0, 1.0
        {
            double y_cal;
            if (x <= tl) { y_cal = tl + al * (x - tl); }
            else if (x >= tr) { y_cal = tr + ar * (x - tr); }
            else { y_cal = x; }
            return y_cal;
        }
        public double HardSigmoidFunction(double x) //HardSigmoid
        {
            double y_cal;
            if (x < -2.5) { y_cal = 0; }
            else if (x > 2.5) { y_cal = 1; }
            else { y_cal = 0.2 * x + 0.5; }
            return y_cal;
                
        }
        public double HardTanhFunction(double x) //HardTanh
        {
            double y_cal;
            if (x < -1) { y_cal = -1; }
            else if (x > 1) { y_cal = 1; }
            else { y_cal = x; }
            return y_cal;
        }
        public double LeCunTanhFunction(double x) //LeCunTanh
        {
            double y_cal = 1.7519 * (2 / (1 + Math.Exp(-2 * x * 2 / 3)) - 1);
            return y_cal;
        }
        public double SoftPlusFunction(double x) //SoftPlus
        {
            double y_cal = Math.Log(1 + Math.Exp(x));
            return y_cal;
        }
        public double SignumFunction(double x) //Signum
        {
            double y_cal;
            if (x > 0) { y_cal = 1; }
            else if (x < 0) { y_cal = -1; }
            else { y_cal = 0; }
            return y_cal;
        }
        public double BentIdentityFunction(double x) //彎曲恆等函式
        {
            double y_cal = (Math.Sqrt(Math.Pow(x, 2) + 1) - 1) / 2 + x;
            return y_cal;
        }
        public double SymmetricalSigmoidFunction(double x) //SymmetricalSigmoid
        {
            double y_cal = (1 - Math.Exp(-x)) / (1 + Math.Exp(-x));
            return y_cal;
        }
        public double LogLogFunction(double x) //LogLog
        {
            double y_cal = 1 - Math.Exp(-Math.Exp(x));
            return y_cal;
        }
        public double GaussianFunction(double x) //高斯函式
        {
            double y_cal = Math.Exp(-Math.Pow(x, 2));
            return y_cal;
        }
        public double AbsoluteFunction(double x) //Absolute
        {
            double y_cal = Math.Abs(x);
            return y_cal;
        }
        public double SinusoidFunction(double x) //正弦函式
        {
            double y_cal = Math.Sin(x);
            return y_cal;
        }
        public double CosFunction(double x) //Cos
        {
            double y_cal = Math.Cos(x);
            return y_cal;
        }
        public double SincFunction(double x) //Sinc函式
        {
            double y_cal;
            if (x == 0) { y_cal = 1; } else { y_cal = Math.Sin(x) / x; }
            return y_cal;
        }
        
    }
}