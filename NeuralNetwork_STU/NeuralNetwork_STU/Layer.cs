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
        public Layer(int cell_size, Celltype cell_type, ActivationFunction cell_function)
        {
            L_y = new double[cell_size];
            size = cell_size;
            celltype = cell_type;
            function = cell_function;
            Create_cell();
        }
        private void Create_cell()
        {
            switch (celltype)
            {
                case Celltype.Perceptron:
                    if(temp == 0)
                    {
                        //我是input層 請生成指定cellsize
                        //Perceptron cell = new Perceptron(NN.getCreate_CellSize, function);
                    }
                    else
                    {  
                        //我是hidden or Output layer 請生成指定cellsize
                        for (int i = 0; i < size; i++) 
                        {
                            Perceptron cell = new Perceptron(3, function);
                        }
                    }
                    break;
            }
        }
    }
}
