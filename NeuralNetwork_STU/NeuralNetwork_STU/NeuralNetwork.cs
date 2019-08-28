using System;
using System.Collections.Generic;
using System.Text;

namespace NeuralNetwork_STU
{
    public class NeuralNetwork
    {
        private int size;
        private Layer[] layer;
        private double[] x;
        //Celltype celltype;
        //ActivationFunction function;
        public NeuralNetwork(double[] input)
        {
            x = input;
            Console.Write("Press the Layer Size:");
            size = Convert.ToInt32(Console.ReadLine());
            layer = new Layer[size];
            if (layer.Length >= 2)
            {
                layer[0] = new Layer(Celltype.Perceptron, ActivationFunction.Identity, 0, x);
                layer[0].Y = x;
                //choose TYPE here
                Create_layer();
                Show();
            }
            else
            {
                Console.WriteLine("Please Press the Layer size over than One!");
            }
        }
        public NeuralNetwork(int layer_size,double[] input)
        {
            x = input;
            size = layer_size;
            layer = new Layer[size];
            if(layer.Length >= 2)
            {
                layer[0] = new Layer(Celltype.Perceptron, ActivationFunction.Identity, 0, x);
                layer[0].Y = x;
                //choose TYPE here
                Create_layer();
                Show();
            }
            else
            {
                Console.WriteLine("Please Press the Layer size over than One!");
            }
        }
        private void Create_layer()
        {
            for (int i = 1; i < layer.Length; i++)
            {
                //Console.WriteLine($"Press Layer {i} Celltype:");
                //Console.WriteLine($"Press Layer {i} Activation:");
                layer[i] = new Layer(Celltype.Perceptron, ActivationFunction.ReLU, layer[i - 1].Y.Length, layer[i-1].Y);
                
            }
        }
        private void Show()
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Layer {i + 1} :");
                for (int j = 0; j < layer[i].Y.Length; j++)
                {
                    Console.WriteLine(layer[i].Y[j]);
                }
            }
        }
        
    }
}
