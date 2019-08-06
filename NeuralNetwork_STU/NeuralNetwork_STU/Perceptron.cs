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
            switch (function)
            {
                case FunctionName.Sigmoid:
                    y = Activation.SigmoidFunction(s);
                    break;
                case FunctionName.Identity:
                    y = Activation.IdentityFunction(s);
                    break;
                case FunctionName.ReLU:
                    y = Activation.ReLUFunction(s);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
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
