using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    public enum FunctionName { Sigmoid, Identity, ReLU };
    public class Activation
    {
        public static double FunctionChoose(FunctionName function,double x)
        {
            double tmp = 0.0;
            switch (function)
            {
                case FunctionName.Sigmoid:
                    tmp = 1 / (1 + Math.Exp(-x));
                    break;
            }
            return tmp;
        }

    }
}
