using System;
using System.Collections.Generic;
using System.Text;
using Activation;
namespace Neuros
{/// <summary>
 ///{0.0 ,0.5,-1.0 } => 4
    ///{ 1, 2, 3 } => 0;
    ///Relu
    /// </summary>
    class Perceptron
    {
        private double [] x;
        private double [] w;
        /// <summary>
        /// ///////////////////
        /// </summary>
        private double s;
        public double y;

        public Perceptron(int num)
        {
            x = new double[num];
            w = new double[num];
        }



        private void Summation()
        {
            s = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                s += x[i] * w[i];
            }
        }

        public void Activation()
        {
            ActivationLib tmp = new ActivationLib();
            Summation();
            y = tmp.ReLUFunction(s);
        }

        public void ReadInput(double [] arr)
        {
            Array.Copy(arr, x, x.Length);
        }
        public void ReadWeights(double[] arr)
        {
            Array.Copy(arr, w, w.Length);
        }
    }
}
