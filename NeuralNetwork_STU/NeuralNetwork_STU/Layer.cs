using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace NeuralNetwork_STU
{
    class Layer
    {
        private double[] L_y;
        private int size;
        private Celltype celltype;
        private ActivationFunction function;
        int count=0;
       
        public Layer(Celltype cell_type, ActivationFunction cell_function)
        {
            Console.Write("Press This time Layer Cell Size:");
            size = Convert.ToInt32(Console.ReadLine());
            L_y = new double[size];
            celltype = cell_type;
            function = cell_function;
            Create_cell();
        }

        public double[] L_Y
        {
            get
            {
                return L_y;
            }
        }

        private void Create_cell()
        {
            switch (celltype)
            {
                case Celltype.Perceptron:
                    for (int i = 0; i < size; i++)
                    {
                        Perceptron cell = new Perceptron(3, function);
                        L_y[i] = cell.Y;
                    }
                    break;
            }
        }
    }
}
