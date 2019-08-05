using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    public class Activation
    {
        private double x = 0.0;
        private double cal = 0.0;
        enum ActivationName { Sigmoid, Identity, ReLU };
        public Activation()
        {
            int a = (int)ActivationName.Identity;
            Console.WriteLine(a);
        }
    }
}
