using System;

namespace NeuralNetwork_STU
{/// <summary>
/// Layer => Perceptron(所有種類的神經元) => Activation, InputData, Weight
/// </summary>
    public enum ActivationFunction { Sigmoid, Identity, ReLU , BinaryStep };
    public enum Celltype {Perceptron, Recurrent };
    class Entry
    {
        static void Main(string[] args)
        {
            //Enum.Parse(typeof(enum),string values);
            //_ = new NeuralNetwork(2);
            //double[] x1 = { 0, 0 };
            //double[] x2 = { 0, 1 };
            //double[] x3 = { 1, 0 };
            //double[] x4 = { 1, 1 };
            //double[] w = new double[2];

            //Perceptron p1 = new Perceptron(2, ActivationFunction.BinaryStep);

            ////窮舉權重組合
            //for (double i = -5; i < 5; i+=0.01)
            //{
            //    w[0] = i;
            //    for (double j = -5; j < 5; j+=0.01)
            //    {
            //        w[1] = j;
            //        p1.ReadWeight(w);
            //        p1.ReadInput(x1);
            //        p1.Transfer();
            //        if (p1.Y == 0)
            //        {
            //            p1.ReadInput(x2);
            //            p1.Transfer();
            //            if(p1.Y == 0)
            //            {
            //                p1.ReadInput(x3);
            //                p1.Transfer();
            //                if(p1.Y == 0)
            //                {
            //                    p1.ReadInput(x4);
            //                    p1.Transfer();
            //                    if(p1.Y == 1)
            //                    {
            //                        Console.WriteLine("w0:" + w[0] + ",\tw1:" + w[1] + "\tCorrect!");
            //                    }
            //                }
            //                else
            //                {
            //                    //Console.WriteLine("w0:" + w[0] + ",\tw1:" + w[1] + "\tWRONG");
            //                }
            //            }
            //            else
            //            {
            //               // Console.WriteLine("w0:" + w[0] + ",\tw1:" + w[1] + "\tWRONG");
            //            }
            //        }
            //        else
            //        {
            //           // Console.WriteLine("w0:" + w[0] + ",\tw1:" + w[1] + "\tWRONG");
            //        }
            //    }
            //}
            //Console.WriteLine();

            //Perceptron p2 = new Perceptron(2);
            //for (int i = 0; i < 300; i++)
            //{
            //    p2.RandomWeight();
            //    p2.ReadInput(x1);
            //    p2.Transfer(ActivationFunction.ReLU);
            //    if (p2.y == 0)
            //    {
            //        p2.ReadInput(x2);
            //        p2.Transfer(ActivationFunction.ReLU);
            //        if (p2.y == 0)
            //        {
            //            p2.ReadInput(x3);
            //            p2.Transfer(ActivationFunction.ReLU);
            //            if (p2.y == 0)
            //            {
            //                p2.ReadInput(x4);
            //                p2.Transfer(ActivationFunction.ReLU);
            //                if (p2.y == 1)
            //                {
            //                    Console.WriteLine("w0:" + p2.W[0] + ",\tw1:" + p2.W[1] + "\tCorrect!");
            //                }
            //            }
            //            else
            //            {
            //                Console.WriteLine("w0:" + p2.W[0] + ",\tw1:" + p2.W[1] + "\tWRONG!");
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("w0:" + p2.W[0] + ",\tw1:" + p2.W[1] + "\tWRONG!");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("w0:" + p2.W[0] + ",\tw1:" + p2.W[1] + "\tWRONG!");
            //    }
            //}




        }
    }
}
