using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    public class NeuralNetwork
    {
        private int size;
        private Layer[] ly;
        //Celltype celltype;
        //ActivationFunction function;
        public NeuralNetwork(int layer_size,double[] input)
        {
            size = layer_size;
            ly = new Layer[size];
            if(ly.Length > 1)
            {
                ly[0] = new Layer(Celltype.Perceptron, ActivationFunction.ReLU, 0);
                ly[0].y = input;
                Create_layer();
            }
            else
            {
                Console.WriteLine("Please Press the Layer size over than One!");
            }
        }
        public void Create_layer()
        {
            for (int i = 1; i < ly.Length; i++)
            {
                //Console.WriteLine($"Press Layer {i} Celltype:");
                //Console.WriteLine($"Press Layer {i} Activation:");
                ly[i] = new Layer(Celltype.Perceptron, ActivationFunction.ReLU, ly[i - 1].y.Length);
            }
        }
        public void Show()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Layer {i + 1} :");
                for (int j = 0; j < ly[i].y.Length; j++)
                {
                    Console.WriteLine(ly[i].y[j]);
                }
            }
        }
        
    }
}
