using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    public class Activation
    {/// <summary>
    /// Sigmoid = 0
    /// Identity = 1
    /// ReLU = 2
    /// </summary>
    /// <param name="function">指定列舉引數</param>
    /// <param name="x">傳入Summtion總和</param>
    /// <returns>將函數運算結果(tmp)回傳</returns>
        public static double FunctionChoose(FunctionName function,double x)
        {
            double tmp = 0.0;
            switch (function)
            {
                case FunctionName.Sigmoid:
                    tmp = 1 / (1 + Math.Exp(-x));
                    break;
                case FunctionName.Identity:
                    tmp = x;
                    break;
                case FunctionName.ReLU:
                    if(x < 0)
                    {
                        tmp = 0;
                    }
                    else
                    {
                        tmp = x;
                    }
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
            return tmp;
        }

    }
}
