using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace NeuralNetwork_STU
{
    public class Layer
    {
        private double[] y;
        private double[] x;
        private int size;
        private int input_length;
        private Celltype type;
        private ActivationFunction function;
       
        public Layer(Celltype cell_type, ActivationFunction cell_function, int y_length, double[]input)
        {
            Console.Write("Press This time Layer Cell Size:");
            size = Convert.ToInt32(Console.ReadLine());
            y = new double[size];
            x = input;
            type = cell_type;
            function = cell_function;
            input_length = y_length;
            Create_cell();
        }

        public double[] Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }

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
                        cell[i].ReadInput(x);   //*
                        cell[i].WeightFullOne();//*
                        cell[i].Transfer();
                        y[i] = cell[i].Y;
                    }
                    break;
            }
        }
    }
}
