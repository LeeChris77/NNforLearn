using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace NeuralNetwork_STU
{
    class Layer
    {
        private double[] L_yvalue; //所有cell的y結果儲存位置
        private int size;
        private Celltype celltype;
        private ActivationFunction function;
        //Layer(3, Celltype.Perceptron, ActivationFunction.Sigmoid)
        //temp the object.Y in L_arr[]
        //-----------------未解-----------------
        //還要做一個計數變數來告訴該層每個細胞的input長度,上一層的L_yvalue長度
        //是否應該在Neural Network告訴Layer內的每一個細胞"你有多少個input"
        //NN(LayerSize)
        Layer(int cell_size, Celltype cell_type, ActivationFunction cell_function)
        {
            L_yvalue = new double[cell_size]; //宣告該層需要用多大的陣列來保存y值
            size = cell_size; //僅用於計算迴圈該跑幾次
            celltype = cell_type;
            function = cell_function;
            Create_cell();
        }
        private void Create_cell()
        {
            switch (celltype)
            {
                case Celltype.Perceptron:
                    for (int i = 0; i < size; i++) //此處'3'value位置應由上一層L_yvalue.Length來告知該變數
                    {
                        Perceptron cell = new Perceptron(3, function);
                        L_yvalue[i] = cell.Y;
                    }
                    break;
            }
        }
    }
}
