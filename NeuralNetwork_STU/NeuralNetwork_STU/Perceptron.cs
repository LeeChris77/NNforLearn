using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    class Perceptron
    {
        private double[] x;
        private double[] w;
        private int Contenum;
        private double s;
        private double y;
        private readonly FunctionEnum Function;
        public Perceptron(int shape)
        {
            x = new double[shape];
            w = new double[shape];
        }
        public Perceptron(int shape,FunctionEnum functionGet)
        {
            x = new double[shape];
            w = new double[shape];
            Function = functionGet;
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
            switch (Function)
            {
                case FunctionEnum.Sigmoid:
                    y = Activation.SigmoidFunction(s);
                    break;
                case FunctionEnum.Identity:
                    y = Activation.IdentityFunction(s);
                    break;
                case FunctionEnum.ReLU:
                    y = Activation.ReLUFunction(s);
                    break;
                case FunctionEnum.BinaryStep:
                    y = Activation.BinaryStepFunction(s);
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }

        //寫入
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
                w[i] = rnd.Next(-5,6);
            }
        }
    }
}
