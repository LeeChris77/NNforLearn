using System;

namespace NeuralNetwork_STU
{
    public enum FunctionName { Sigmoid, Identity, ReLU };
    class Entry
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            double[] x = { 1, 1};//輸入
            double[] w = new double[2];
            int ans = 1; //y結果 (0,1)
            Perceptron p1 = new Perceptron(2);
            p1.ReadInput(x);
            Console.WriteLine("x0: "+x[0]+", x1: "+x[1]);

            //窮舉權重組合
            for (int i = -5; i < 6; i++)
            {
                w[0] = i;
                for (int j = -5; j < 6; j++)
                {
                    w[1] = j;
                    p1.ReadWeight(w);
                    p1.Transfer(FunctionName.ReLU);
                    if(p1.y == ans)  //line 13 結果對應(方便修正而已)
                    {
                        Console.WriteLine("w0:"+w[0]+", w1:"+w[1]+", y:"+p1.y+" Correct!");
                    }
                    else
                    {
                        Console.WriteLine("w0:" + w[0] + ", w1:" + w[1] + ", y:" + p1.y + " fail!");
                    }
                }
            }


        }
    }
}
