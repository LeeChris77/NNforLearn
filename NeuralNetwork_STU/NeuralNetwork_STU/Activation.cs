using System;

namespace NeuralNetwork_STU
{
    public class Activation
    {
        public static double IdentityFunction(double x) //恆等函式
        {
            double y_cal = x;
            return y_cal;
        }
        public static double BinaryStepFunction(double x)//單位階躍函式
        {
            double y_cal;
            if (x <= 0.8)
            {
                y_cal = 0;
            }
            else
            {
                y_cal = 1;
            }
            return y_cal;
        }
        public static double SigmoidFunction(double x) //Sigmoid
        {
            double y_cal = 1 / (1 + Math.Exp(-x));
            return y_cal;
        }
        public static double TanhFunction(double x) //雙曲正切函式
        {
            double y_cal = (Math.Exp(x) - Math.Exp(-x)) / (Math.Exp(x) + Math.Exp(-x));
            return y_cal;

        }
        public static double ArcTanFunction(double x) //反正切函式*
        {
            double y_cal = Math.Atan(x);
            return y_cal;
        }
        public static double SoftsignFunction(double x)//Softsign
        {
            double y_cal = x / (1 + Math.Abs(x));
            return y_cal;
        }
        public static double ReLUFunction(double x) //線性整流函式
        {
            double y_cal;
            if (x < 0) { y_cal = 0; } else { y_cal = x; }
            return y_cal;
        }
        public static double LeakyReLUFunction(double x) //帶泄露線性整流函式
        {
            double y_cal;
            if (x < 0) { y_cal = 0.01 * x; } else { y_cal = x; }
            return y_cal;
        }
        public static double PReLUFunction(double x, double alpha) //PReLU  自己帶alpha參數
        {
            double y_cal;
            if (x < 0) { y_cal = alpha * x; } else { y_cal = x; }
            return y_cal;
        }
        public static double RReLUFunction(double x, double alpha) //RReLU  alpha請設定亂數
        {
            double y_cal;
            if (x < 0) { y_cal = alpha * x; } else { y_cal = x; }
            return y_cal;
        }
        public static double ELUFunction(double x, double alpha) //ELU
        {
            double y_cal;
            if (x < 0) { y_cal = alpha * (Math.Exp(x) - 1); } else { y_cal = x; }
            return y_cal;
        }
        public static double SELUFunction(double x) //SELU
        {
            double lambda = 1.05070;
            double alpha = 1.67326;
            double y_cal;
            if (x < 0) { y_cal = lambda * alpha * (Math.Exp(x) - 1); } else { y_cal = x; }
            return y_cal;
        }
        public static double SReLUFunction(double x, double al, double ar, double tl, double tr) //SReLU //1, 0.4, -1.0, 1.0
        {
            double y_cal;
            if (x <= tl) { y_cal = tl + al * (x - tl); }
            else if (x >= tr) { y_cal = tr + ar * (x - tr); }
            else { y_cal = x; }
            return y_cal;
        }
        public static double HardSigmoidFunction(double x) //HardSigmoid
        {
            double y_cal;
            if (x < -2.5) { y_cal = 0; }
            else if (x > 2.5) { y_cal = 1; }
            else { y_cal = 0.2 * x + 0.5; }
            return y_cal;
                
        }
        public static double HardTanhFunction(double x) //HardTanh
        {
            double y_cal;
            if (x < -1) { y_cal = -1; }
            else if (x > 1) { y_cal = 1; }
            else { y_cal = x; }
            return y_cal;
        }
        public static double LeCunTanhFunction(double x) //LeCunTanh
        {
            double y_cal = 1.7519 * (2 / (1 + Math.Exp(-2 * x * 2 / 3)) - 1);
            return y_cal;
        }
        public static double SoftPlusFunction(double x) //SoftPlus
        {
            double y_cal = Math.Log(1 + Math.Exp(x));
            return y_cal;
        }
        public static double SignumFunction(double x) //Signum
        {
            double y_cal;
            if (x > 0) { y_cal = 1; }
            else if (x < 0) { y_cal = -1; }
            else { y_cal = 0; }
            return y_cal;
        }
        public static double BentIdentityFunction(double x) //彎曲恆等函式
        {
            double y_cal = (Math.Sqrt(Math.Pow(x, 2) + 1) - 1) / 2 + x;
            return y_cal;
        }
        public static double SymmetricalSigmoidFunction(double x) //SymmetricalSigmoid
        {
            double y_cal = (1 - Math.Exp(-x)) / (1 + Math.Exp(-x));
            return y_cal;
        }
        public static double LogLogFunction(double x) //LogLog
        {
            double y_cal = 1 - Math.Exp(-Math.Exp(x));
            return y_cal;
        }
        public static double GaussianFunction(double x) //高斯函式
        {
            double y_cal = Math.Exp(-Math.Pow(x, 2));
            return y_cal;
        }
        public static double AbsoluteFunction(double x) //Absolute
        {
            double y_cal = Math.Abs(x);
            return y_cal;
        }
        public static double SinusoidFunction(double x) //正弦函式
        {
            double y_cal = Math.Sin(x);
            return y_cal;
        }
        public static double CosFunction(double x) //Cos
        {
            double y_cal = Math.Cos(x);
            return y_cal;
        }
        public static double SincFunction(double x) //Sinc函式
        {
            double y_cal;
            if (x == 0) { y_cal = 1; } else { y_cal = Math.Sin(x) / x; }
            return y_cal;
        }
        
    }
}
