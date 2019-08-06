using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    class Perceptron
    {
        private double [] x;
        private double [] w;
        private double s;
        public double y;

        public Perceptron(int shape)
        {
            x = new double[shape];
            w = new double[shape];
        }

        private void Summation()
        {
            s = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                s += x[i] * w[i];
            }
        }

        public void Transfer(FunctionName function)
        {
            Summation();
            y = Activation.FunctionChoose(function,s);
            //y = Activation.FunctionOption(optNum, s);
        }
    }
}
