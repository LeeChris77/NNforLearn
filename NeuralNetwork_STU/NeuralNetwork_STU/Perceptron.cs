using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    class Perceptron
    {
        private double[] x;
        private double[] w;
        private double s;
        public double y;

        public Perceptron(int shape)
        {
            x = new double[shape];
            w = new double[shape];
        }
        public double[] X
        {
            get { return x; }
        }
        public double[] W
        {
            get { return w; }
        }
        public double S
        {
            get { return s; }
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
        }

        public void ReadInput(double [] arr)
        {
            Array.Copy(arr, x, x.Length);
        }
        public void ReadWeight(double[] arr)
        {
            Array.Copy(arr, w, w.Length);
        }
        public void RandomWeight()
        {
            Random rnd = new Random();
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = rnd.Next(-3,4);
            }
        }
    }
}
