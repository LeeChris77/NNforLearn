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
        private double y;
        ActivationFunction function;

        public Perceptron(int shape)
        {
            x = new double[shape];
            w = new double[shape];
        }
        public Perceptron(int shape,ActivationFunction functionName)
        {
            x = new double[shape];
            w = new double[shape];
            function = functionName;
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
        public double Y
        {
            get { return y; }
        }

        private void Summation()
        {
            s = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                s += x[i] * w[i];
            }
        }

        public void Transfer()
        {
            Summation();
            switch (function)
            {
                case ActivationFunction.Sigmoid:
                    y = Activation.SigmoidFunction(s);
                    break;
                case ActivationFunction.Identity:
                    y = Activation.IdentityFunction(s);
                    break;
                case ActivationFunction.ReLU:
                    y = Activation.ReLUFunction(s);
                    break;
                case ActivationFunction.BinaryStep:
                    y = Activation.BinaryStepFunction(s);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        public void ReadInput(double [] arr)
        {
            Array.Copy(arr, x, x.Length);
            //可以用不同寫法
        }
        public void ReadWeight(double[] arr)
        {
            Array.Copy(arr, w, w.Length);
            //可以用不同寫法
        }
        public void RandomWeight()
        {
            Random rnd = new Random();
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = rnd.Next(-5,6);
            }
        }
    }
}
