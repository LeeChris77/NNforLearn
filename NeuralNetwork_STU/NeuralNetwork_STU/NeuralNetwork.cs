using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    class NeuralNetwork
    {
        private int size;
        private int cellsize;
        //Celltype celltype;
        //ActivationFunction function;
        public NeuralNetwork(int layer_size,double[]x)
        {
            size = layer_size;
            for (int i = 0; i < size; i++)
            {
                Layer ly = new Layer(Celltype.Perceptron , ActivationFunction.ReLU);
            }
        }
        
    }
}
