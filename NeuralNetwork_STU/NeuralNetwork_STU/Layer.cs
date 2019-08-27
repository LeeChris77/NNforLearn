using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace NeuralNetwork_STU
{
    public class Layer
    {
        public double[] y;
        private int size;
        private int input_length;
        private Celltype type;
        private ActivationFunction function;
       
        public Layer(Celltype cell_type, ActivationFunction cell_function,int y_length)
        {
            Console.Write("Press This time Layer Cell Size:");
            size = Convert.ToInt32(Console.ReadLine());
            y = new double[size];
            type = cell_type;
            function = cell_function;
            input_length = y_length;
            Create_cell();
        }
        private void Create_cell()
        {
            switch (type)
            {
                case Celltype.Perceptron:
                    Perceptron[] cell = new Perceptron[size];
                    for (int i = 0; i < size; i++)
                    {
                        cell[i] = new Perceptron(input_length, function);
                        cell[i].WeightFullOne();
                        cell[i].Transfer();
                        y[i] = cell[i].Y;
                    }
                    break;
            }
        }
    }
}
