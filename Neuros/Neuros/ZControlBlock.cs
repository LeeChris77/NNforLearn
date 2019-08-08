using System;
using System.IO;
using Neuros;
namespace NeurosMain
{
    class ControlBlock
    {
        static void Main(string[] args)
        {
            double[] inp =  {0.0 ,0.5,-1.0 };
            double[] inw = { 1, 2, 3 };
            Perceptron p = new Perceptron(3);
            p.ReadInput(inp);
            p.ReadWeights(inw);
            p.Activation();
            Console.WriteLine(p.y);
            Console.ReadKey();
        }
    }
}

/*
  //string[] ChosseFunctionName = { "Identity", "BinaryStep", "Sigmoid" };
            //StreamWriter sw = new StreamWriter(@"D:\Desktop\Activation_Data\" + ChosseFunctionName[0] + ".txt");
            //Console.WriteLine(@"D:\Desktop\Activation_Data\" + ChosseFunctionName[0]);
            //Random rnd = new Random();
            double bias = 1;
            double[] x = {1, 2, 3 };
            double[] w = {0.1, 0.2, 0.3 };
            NewNeuros neuro = new NewNeuros();
            Console.WriteLine(neuro.OneNeuro(x, w, "Sigmoid"));
            //CreateNeuros nur = new CreateNeuros(x, w, 0.8, "sigmoid");
 
     */
